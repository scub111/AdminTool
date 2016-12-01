using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RapidInterface;
using System.Net.NetworkInformation;
using System.Threading;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Menu;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Columns;
using System.Drawing;
using Registy;
using System.IO;
using System.Management;
using System.Collections;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace AdminTool
{
    [DBAttribute(Caption = "Устройство", IconFile = "Device.png")]
    public partial class DeviceView : DBViewInterface
    {
        public DeviceView()
        {
            InitializeComponent();
            _dbInterface1.SetXPCollectionSmart(Global.Default.CollectionWithUnits);
            Global.Default.ThreadMain.InterfaceChanged += threadMain_InterfaceChanged;
        }

        void threadMain_InterfaceChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                tableGridControl1.RefreshDataSource();
                foreach (Device device in Global.Default.DeviceCollection)
                    device.GetDataFromReal();
            }
        }

        static void CopyFile(string pathSourse, string dirDestination)
        {
            string fileName = Path.GetFileName(pathSourse);
            string pathDestination = string.Format(@"{0}\{1}", dirDestination, fileName);
            if (File.Exists(pathDestination))
                File.Delete(pathDestination);
            File.Copy(pathSourse, pathDestination);
        }
        static void Exec(string ipAddress, string domain, string user, string password, string programPath)
        {
            try
            {
                object[] theProcessToRun = { programPath };
                ConnectionOptions theConnection = new ConnectionOptions() { Username = string.Format(@"{0}\{1}", domain, user), Password = password };
                ManagementScope theScope = new ManagementScope(string.Format(@"\\{0}\root\cimv2", ipAddress), theConnection);
                ManagementClass theClass = new ManagementClass(theScope, new ManagementPath("Win32_Process"), new ObjectGetOptions());
                theClass.InvokeMethod("Create", theProcessToRun);
            }
            catch
            {
            }
        }

        static void SaveWallpaparConfig(string path, string text)
        {
            try
            {
                if (File.Exists(path))
                    File.Delete(path);

                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter stream = new StreamWriter(path, true);

                //Write a line of text
                stream.WriteLine(text);

                //Close the file
                stream.Close();
            }
            catch
            {
            }
        }

        static void UpdateWallpaper(string remoteMachine, string windowsVersion = "")
        {
            const string domain = "npr";
            const string user = "KarnaushenkoSV";
            const string password = "qwert-+ZXCVB";

            PinvokeWindowsNetworking.ConnectToRemote(string.Format(@"\\{0}\C$\", remoteMachine), string.Format(@"{0}\{1}", domain, user), password);

            string dirDestination = string.Format(@"\\{0}\C$\_User", remoteMachine);
            if (!Directory.Exists(dirDestination))
                Directory.CreateDirectory(dirDestination);

            if (!string.IsNullOrEmpty(windowsVersion))
                SaveWallpaparConfig(string.Format(@"{0}\SetInfoWallpaper.ini", dirDestination), windowsVersion);

            const string dirSourse = @"D:\_Projects\ClientTool\SetInfoWallpaper\bin\Debug\";
            CopyFile(dirSourse + "SetInfoWallpaper.exe", dirDestination);
            CopyFile(dirSourse + "SetInfoWallpaperStartUp.bat", dirDestination);

            CopyFile(@"D:\_Projects\ClientTool\Notification\bin\Debug\Notification.exe", dirDestination);

            Exec(remoteMachine, domain, user, password, @"C:\_User\SetInfoWallpaperStartUp.bat");

            //Logoff nemote machine.
            //Process.Start(@"C:\PSTools\PsExec.exe", string.Format(@"\\{0} -u npr\karnaushenkosv -p qwert-+ZXCVB -d -i shutdown -l", remoteMachine));
            //Process.Start(@"C:\PSTools\PsExec.exe", string.Format(@"\\{0} -u npr\karnaushenkosv -p qwert-+ZXCVB -d -i C:\_User\Notification.exe", remoteMachine));
        }

        void TryDo(object device)
        {
            DeviceReal deviceReal = ((Device)device).DeviceReal;
            deviceReal.Error = "[no error]";
            deviceReal.Done = false;
            deviceReal.Finished = false;
            try
            {
                Ping PingSender = new Ping();
                PingOptions Options = new PingOptions();
                byte[] buffer = Encoding.ASCII.GetBytes("a");

                PingReply reply = PingSender.Send(deviceReal.IPAddress, 3000, buffer, Options);

                if (reply.Status == IPStatus.Success)
                {
                    deviceReal.Pinged = true;
                    deviceReal.ReplyTime = (int)reply.RoundtripTime;
                }
                else
                {
                    deviceReal.Pinged = false;
                    deviceReal.ReplyTime = -1;
                }

                if (deviceReal.Pinged)
                {
                    RegistryObject SysRegistry = new RegistryRemote("karnaushenkosv", "qwert-+ZXCVB", "npr", deviceReal.IPAddress);

                    deviceReal.WindowsVersion = SysRegistry.GetValue(baseKey.HKEY_LOCAL_MACHINE, @"SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductName", valueType.STRING);
                    ArrayList users = SysRegistry.EnumerateKeys(baseKey.HKEY_USERS, "");
                    Regex userReg = new Regex(@"\bS-\d{1,15}\-\d{1,15}\-\d{1,15}\-\d{1,15}-\d{1,15}-\d{1,15}-\d{1,15}\b");

                    ArrayList currentUsers = new ArrayList();
                    foreach (string user in users)
                    {
                        if (userReg.IsMatch(user))
                            currentUsers.Add(user);
                    }

                    if (currentUsers.Count > 0)
                    {
                        //deviceReal.UserName = SysRegistry.GetValue(baseKey.HKEY_USERS, string.Format(@"{0}\Volatile Environment", currentUser), "USERNAME", valueType.STRING);

                        deviceReal.UserName = "";

                        foreach (string currentUser in currentUsers)
                        {
                            ArrayList keys = SysRegistry.EnumerateKeys(baseKey.HKEY_USERS, currentUser);
                            if (keys.Contains("Volatile Environment"))
                            {
                                string temp = SysRegistry.GetValue(baseKey.HKEY_USERS, string.Format(@"{0}\Volatile Environment", currentUser), "HOMEPATH", valueType.STRING);
                                temp = Path.GetFileNameWithoutExtension(temp);
                                if (string.IsNullOrEmpty(deviceReal.UserName))
                                    deviceReal.UserName = temp;
                                else
                                    deviceReal.UserName += string.Format(" || {0}", temp);
                            }
                        }
                    }

                    UpdateWallpaper(deviceReal.IPAddress, deviceReal.WindowsVersion);
                    deviceReal.Done = true;
                }
            }
            catch (Exception ex)
            {
                deviceReal.Error = string.Format("{0} -> {1}", ex.Source, ex.Message);
            }

            deviceReal.Finished = true;
        }

        void ThreadTryDo(Device device)
        {
            Thread tread = new Thread(TryDo);
            tread.Start(device);
        }

        private void repAction_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Device device = tableGridView1.GetFocusedRow() as Device;
            if (device != null)
            {
                ThreadTryDo(device);
            }
        }

        private void DeviceView_FormUpdate(object sender, EventArgs e)
        {
            LinkXPObject.Transfer<DeviceReal>(Global.Default.DeviceCollection, Global.Default.DeviceRealCollection);

            foreach (DeviceReal opcItem in Global.Default.DeviceRealCollection)
                opcItem.SendDataToXPObject();

            tableGridControl1.RefreshDataSource();
        }

        private void tableGridView1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == GridMenuType.Column)
            {
                GridViewColumnMenu menu = e.Menu as GridViewColumnMenu;
                //Erasing the default menu items 
                //menu.Items.Clear();
                if (menu.Column != null)
                {
                    if (menu.Column.Caption == "Актив")
                    {
                        menu.Items.Add(CreateCheckItem("Автивировать все", menu.Column, null, ActivateAll));
                        menu.Items.Add(CreateCheckItem("Деактивировать все", menu.Column, null, DectivateAll));
                    }
                }
                else
                {
                    menu.Items.Add(CreateCheckItem("Сгенерировать IP-адреса", menu.Column, null, GenerateIPAddress));
                    menu.Items.Add(CreateCheckItem("Выполнить для всех", menu.Column, null, DoActionAll));
                }
            }
        }

        //Create a menu item 
        static DXMenuCheckItem CreateCheckItem(string caption, GridColumn column, Image image, EventHandler eventHandler)
        {
            DXMenuCheckItem item = new DXMenuCheckItem(caption, false, image, eventHandler) { Tag = column };
            return item;
        }

        void ActivateAll(object sender, EventArgs e)
        {
            DXMenuItem item = sender as DXMenuItem;
            GridColumn column = item.Tag as GridColumn;
            if (column == null) return;

            for (int i = 0; i < tableGridView1.RowCount; i++)
                tableGridView1.SetRowCellValue(i, column, true);
        }

        void DectivateAll(object sender, EventArgs e)
        {
            DXMenuItem item = sender as DXMenuItem;
            GridColumn column = item.Tag as GridColumn;
            if (column == null) return;

            for (int i = 0; i < tableGridView1.RowCount; i++)
                tableGridView1.SetRowCellValue(i, column, false);
        }

        static void GenerateIPAddress(string network, int from, int to)
        {
            for (int i = from; i <= to; i++)
            {
                Device device = new Device(Global.Default.DeviceCollection.Session) { IPAddress = string.Format("{0}.{1}", network, i) };
                Global.Default.DeviceCollection.Add(device);
            }
        }

        void GenerateIPAddress(object sender, EventArgs e)
        {
            // Рудоуправление.
            GenerateIPAddress("172.31.106", 1, 255);

            // Ангидрит.
            GenerateIPAddress("172.24.92", 1, 255);

            // Известняки.
            GenerateIPAddress("172.24.43", 193, 255);

            // Скальный.
            GenerateIPAddress("172.24.88", 65, 94);

            // Кайерканский.
            GenerateIPAddress("172.24.228", 1, 128);
        }

        void DoActionAllFunc()
        {
            foreach (Device device in Global.Default.DeviceCollection)
                if (device.Active)
                    ThreadTryDo(device);
        }

        void DoActionAll(object sender, EventArgs e)
        {
            Thread tread = new Thread(DoActionAllFunc);
            tread.Start();
        }
    }
}
