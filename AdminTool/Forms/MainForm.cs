using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace AdminTool
{
    public partial class MainForm : XtraForm
    {
        public MainForm()
        {
            InitializeComponent();

            //XpoDefault.DataLayer = new SimpleDataLayer(new InMemoryDataStore());
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Global.Default.Init();
            Global.Default.ThreadMain.InterfaceChanged += new EventHandler(ThreadMain_InterfaceChanged);
            Text += string.Format(" {0}", Global.Default.Version);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        void ThreadMain_InterfaceChanged(object sender, EventArgs e)
        {
            stInfo.Caption = Global.Default.GetStatusInfo();

            pbInfo.EditValue = Global.Default.FinishedCount / (double)Global.Default.ActiveCount * 1000;


            //if (Global.Default.ThreadMain.CountWork == 3)
            //    Thread.ResetAbort();

        }

        private void pbInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
