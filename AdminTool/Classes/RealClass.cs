using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading;
using System.Data.SqlClient;
using DevExpress.Xpo;
using System.Collections.ObjectModel;
using RapidInterface;
using System.Runtime.InteropServices;
using System.IO.Ports;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using Registy;

namespace AdminTool
{
    #region CollectionEx
    public class CollectionEx<T> : Collection<T>
    {
        /// <summary>
        /// Количество подключенных элементов.
        /// </summary>
        public int ConnectedCount { get; set; }

        /// <summary>
        /// Асинхронное чтение данных.
        /// </summary>
        public void ReadDataAsync()
        {
            /*
            if (typeof(T) == typeof(DataSourceReal) || TypeEx.IsSubclassOf(typeof(T), typeof(DataSourceReal)))
            {
                ConnectedCount = 0;
                foreach (T item in this)
                {
                    DataSourceReal dataSource = item as DataSourceReal;
                    dataSource.ReadDataAsync();
                    dataSource.SendDataToXPObject();
                    if (dataSource.IsConnected)
                        ConnectedCount++;
                }
            }
            */
        }

        /// <summary>
        /// Асинхронная отправка данных.
        /// </summary>
        public void SendDataAsync()
        {
            /*
            if (typeof(T) == typeof(SQLServerReal) || TypeEx.IsSubclassOf(typeof(T), typeof(SQLServerReal)))
            {
                ConnectedCount = 0;
                foreach (T item in this)
                {
                    SQLServerReal sqlServer = item as SQLServerReal;
                    sqlServer.SendDataAsync();
                    sqlServer.SendDataToXPObject();
                    if (sqlServer.IsSending)
                        ConnectedCount++;
                }
            }
            */
        }
    }
    #endregion
    
    /*
    #region LinkXPObject
    public class LinkXPObject
    {
        public LinkXPObject(XPObject xpObject)
        {
            XPObject = xpObject;
            Oid = xpObject.Oid;
        }

        public object XPObject { get; set; }
        public int Oid { get; set; }

        /// <summary>
        /// Поиск объекта сервера.
        /// </summary>
        public object FindXPOject(Collection<XPObject> collection)
        {
            foreach (XPObject record in collection)
                if (record.Oid == Oid)
                {
                    XPObject = record;
                    return XPObject;
                }
            return null;
        }

        /// <summary>
        /// Отправка данных.
        /// </summary>
        public virtual void SendDataToXPObject() {}

        public static void Transfer<TypeReal>(XPCollection xpCollection, Collection<TypeReal> collectionReal)
        {
            if (TypeEx.IsSubclassOf(typeof(TypeReal), typeof(LinkXPObject)))
            {
                Collection<XPObject> collection = new Collection<XPObject>();
                foreach (XPObject server in xpCollection)
                    collection.Add(server);

                foreach (TypeReal serverReal in collectionReal)
                {
                    LinkXPObject link = serverReal as LinkXPObject;
                    XPObject server = link.FindXPOject(collection) as XPObject;
                    if (server != null)
                        collection.Remove(server);
                }
            }
        }
    }
    #endregion

    #region LinkXPObjects
    public class LinkXPObjects : Collection<LinkXPObject>
    {
        public void SendData()
        {
            foreach (LinkXPObject item in this)
                item.SendDataToXPObject();
        }
    }
    #endregion
    */

    #region ItemReal
    /// <summary>
    /// Таблица "Элемент".
    /// </summary>
    public class DeviceReal : LinkXPObject
    {
        public DeviceReal(Device item)
            : base(item)
        {
            Active = false;
            Done = false;
            ReplyTime = -10;
            Error = "[inited]";
            Finished = false;
            GetData(item);
        }

        /// <summary>
        /// Актив.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// IP-адрес.
        /// </summary>
        public string IPAddress { get; set; }

        /// <summary>
        /// Пинг.
        /// </summary>
        public bool Pinged { get; set; }

        /// <summary>
        /// Время пинга.
        /// </summary>
        public int ReplyTime { get; set; }

        /// <summary>
        /// Ошибка.
        /// </summary>
        public string Error { get; set; }

        /// <summary>
        /// Версия операционной системы.
        /// </summary>
        public string WindowsVersion { get; set; }

        /// <summary>
        /// Имя пользователя.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Выполнен.
        /// </summary>
        public bool Done { get; set; }

        /// <summary>
        /// Завершен.
        /// </summary>
        public bool Finished { get; set; }

        /// <summary>
        /// Получение данных.
        /// </summary>
        public void GetData(Device item)
        {
            Active = item.Active;
            IPAddress = item.IPAddress;
        }

        public override void SendDataToXPObject()
        {
            base.SendDataToXPObject();
            if (XPObject != null)
            {
                ((Device)XPObject).DeviceReal = this;
            }
        }
    }
    #endregion

    public class RegEx
    {
        public string Connect()
        {
            RegistryObject SysRegistry = new RegistryRemote("karnaushenkosv", "qwert-+ZXCVB", "npr", "172.31.106.152");

            string registryKey = @"Control Panel\Desktop";
            return SysRegistry.GetValue(baseKey.HKEY_CURRENT_USER, registryKey, "Wallpaper", valueType.STRING);
            //string valueNeed = @"C:\Desert2.jpg";
            //SysRegistry.SetValue(baseKey.HKEY_CURRENT_USER, registryKey, "Wallpaper", valueNeed, valueType.STRING);
        }
    }
}
