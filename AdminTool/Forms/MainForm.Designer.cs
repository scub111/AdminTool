namespace AdminTool
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._dbForm1 = new RapidInterface.DBForm();
            this.barLayoutItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.baseNavBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.baseNavBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.TestViewNavBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.OPCItemViewNavBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.SettingViewNavBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.icons1 = new DevExpress.Utils.ImageCollection(this.components);
            this.baseControlContainer1 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.baseDockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.pbInfo = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.stInfo = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.baseDockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.baseDocumentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.baseTabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.baseLayoutControl1 = new RapidInterface.LayoutControlEx();
            this.filterClearButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.filterTextEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.baseLayoutGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.filterLayoutItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.filterClearLayoutItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.OPCItemView1 = new RapidInterface.DBFormItemView();
            this.SettingView1 = new RapidInterface.DBFormItemBase();
            this.TestView1 = new RapidInterface.DBFormItemView();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.dbConnection1 = new RapidInterface.DBConnection();
            this._dbForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barLayoutItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseNavBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icons1)).BeginInit();
            this.baseControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseDockManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            this.baseDockPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseDocumentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseTabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseLayoutControl1)).BeginInit();
            this.baseLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterTextEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseLayoutGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterLayoutItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterClearLayoutItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConnection1)).BeginInit();
            this.SuspendLayout();
            // 
            // _dbForm1
            // 
            this._dbForm1.BarLayoutItem = this.barLayoutItem1;
            this._dbForm1.BaseControlContainer = this.baseControlContainer1;
            this._dbForm1.BaseDockManager = this.baseDockManager1;
            this._dbForm1.BaseDockPanel = this.baseDockPanel1;
            this._dbForm1.BaseDocumentManager = this.baseDocumentManager1;
            this._dbForm1.BaseLayoutControl = this.baseLayoutControl1;
            this._dbForm1.BaseLayoutGroup = this.baseLayoutGroup1;
            this._dbForm1.BaseNavBarControl = this.baseNavBarControl1;
            this._dbForm1.BaseNavBarGroup = this.baseNavBarGroup1;
            this._dbForm1.BaseTabbedView = this.baseTabbedView1;
            this._dbForm1.Controls.Add(this.baseLayoutControl1);
            this._dbForm1.CountOpenDesigner = 26;
            this._dbForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dbForm1.FilterClearButton = this.filterClearButton1;
            this._dbForm1.FilterClearLayoutItem = this.filterClearLayoutItem1;
            this._dbForm1.FilterLayoutItem = this.filterLayoutItem1;
            this._dbForm1.FilterTextEdit = this.filterTextEdit1;
            this._dbForm1.Icons = this.icons1;
            this._dbForm1.ImagePath = "D:\\_Projects\\AdminTool\\AdminTool\\Images";
            this._dbForm1.Items.Add(this.OPCItemView1);
            this._dbForm1.Items.Add(this.SettingView1);
            this._dbForm1.Items.Add(this.TestView1);
            this._dbForm1.Location = new System.Drawing.Point(0, 0);
            this._dbForm1.Name = "_dbForm1";
            this._dbForm1.NotifyIcon = this.notifyIcon1;
            this._dbForm1.OwnerForm = this;
            this._dbForm1.Size = new System.Drawing.Size(141, 719);
            this._dbForm1.TabIndex = 0;
            // 
            // barLayoutItem1
            // 
            this.barLayoutItem1.Control = this.baseNavBarControl1;
            this.barLayoutItem1.CustomizationFormText = "Навигация";
            this.barLayoutItem1.Location = new System.Drawing.Point(0, 26);
            this.barLayoutItem1.Name = "barLayoutItem1";
            this.barLayoutItem1.Size = new System.Drawing.Size(141, 693);
            this.barLayoutItem1.TextSize = new System.Drawing.Size(0, 0);
            this.barLayoutItem1.TextVisible = false;
            // 
            // baseNavBarControl1
            // 
            this.baseNavBarControl1.ActiveGroup = this.baseNavBarGroup1;
            this.baseNavBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.baseNavBarGroup1,
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3});
            this.baseNavBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.OPCItemViewNavBarItem1,
            this.SettingViewNavBarItem1,
            this.TestViewNavBarItem1});
            this.baseNavBarControl1.LinkSelectionMode = DevExpress.XtraNavBar.LinkSelectionModeType.OneInControl;
            this.baseNavBarControl1.Location = new System.Drawing.Point(2, 28);
            this.baseNavBarControl1.Name = "baseNavBarControl1";
            this.baseNavBarControl1.OptionsNavPane.ExpandedWidth = 137;
            this.baseNavBarControl1.Size = new System.Drawing.Size(137, 689);
            this.baseNavBarControl1.SmallImages = this.icons1;
            this.baseNavBarControl1.TabIndex = 5;
            // 
            // baseNavBarGroup1
            // 
            this.baseNavBarGroup1.Caption = "Источники";
            this.baseNavBarGroup1.Expanded = true;
            this.baseNavBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.TestViewNavBarItem1)});
            this.baseNavBarGroup1.Name = "baseNavBarGroup1";
            // 
            // TestViewNavBarItem1
            // 
            this.TestViewNavBarItem1.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.TestViewNavBarItem1.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.TestViewNavBarItem1.AppearancePressed.Options.UseFont = true;
            this.TestViewNavBarItem1.AppearancePressed.Options.UseForeColor = true;
            this.TestViewNavBarItem1.Caption = "Test";
            this.TestViewNavBarItem1.Name = "TestViewNavBarItem1";
            this.TestViewNavBarItem1.Visible = false;
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Переменные";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.OPCItemViewNavBarItem1)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // OPCItemViewNavBarItem1
            // 
            this.OPCItemViewNavBarItem1.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.OPCItemViewNavBarItem1.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.OPCItemViewNavBarItem1.AppearancePressed.Options.UseFont = true;
            this.OPCItemViewNavBarItem1.AppearancePressed.Options.UseForeColor = true;
            this.OPCItemViewNavBarItem1.Caption = "Устройство";
            this.OPCItemViewNavBarItem1.Name = "OPCItemViewNavBarItem1";
            this.OPCItemViewNavBarItem1.SmallImageIndex = 3;
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Приемники";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "Разное";
            this.navBarGroup3.Expanded = true;
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.SettingViewNavBarItem1)});
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // SettingViewNavBarItem1
            // 
            this.SettingViewNavBarItem1.AppearancePressed.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.SettingViewNavBarItem1.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.SettingViewNavBarItem1.AppearancePressed.Options.UseFont = true;
            this.SettingViewNavBarItem1.AppearancePressed.Options.UseForeColor = true;
            this.SettingViewNavBarItem1.Caption = "Настройки";
            this.SettingViewNavBarItem1.Name = "SettingViewNavBarItem1";
            this.SettingViewNavBarItem1.SmallImageIndex = 1;
            // 
            // icons1
            // 
            this.icons1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("icons1.ImageStream")));
            this.icons1.Images.SetKeyName(0, "OPCItem.png");
            this.icons1.Images.SetKeyName(1, "Setting.png");
            this.icons1.Images.SetKeyName(2, "Item.png");
            this.icons1.Images.SetKeyName(3, "Device.png");
            // 
            // baseControlContainer1
            // 
            this.baseControlContainer1.Controls.Add(this._dbForm1);
            this.baseControlContainer1.Location = new System.Drawing.Point(4, 23);
            this.baseControlContainer1.Name = "baseControlContainer1";
            this.baseControlContainer1.Size = new System.Drawing.Size(141, 719);
            this.baseControlContainer1.TabIndex = 0;
            // 
            // baseDockManager1
            // 
            this.baseDockManager1.Form = this;
            this.baseDockManager1.MenuManager = this.barManager1;
            this.baseDockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.baseDockPanel1});
            this.baseDockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockManager = this.baseDockManager1;
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.stInfo,
            this.pbInfo});
            this.barManager1.MaxItemId = 2;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemProgressBar1});
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.pbInfo),
            new DevExpress.XtraBars.LinkPersistInfo(this.stInfo)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // pbInfo
            // 
            this.pbInfo.Caption = "barEditItem1";
            this.pbInfo.Edit = this.repositoryItemProgressBar1;
            this.pbInfo.EditWidth = 311;
            this.pbInfo.Id = 1;
            this.pbInfo.Name = "pbInfo";
            this.pbInfo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.pbInfo_ItemClick);
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.Maximum = 1000;
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            this.repositoryItemProgressBar1.Step = 1;
            // 
            // stInfo
            // 
            this.stInfo.Caption = "Запуск...";
            this.stInfo.Id = 0;
            this.stInfo.Name = "stInfo";
            this.stInfo.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1096, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 746);
            this.barDockControlBottom.Size = new System.Drawing.Size(1096, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 746);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1096, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 746);
            // 
            // baseDockPanel1
            // 
            this.baseDockPanel1.Controls.Add(this.baseControlContainer1);
            this.baseDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.baseDockPanel1.ID = new System.Guid("aa6262a3-a9c1-4dc8-8841-984b5a45c4f6");
            this.baseDockPanel1.Location = new System.Drawing.Point(0, 0);
            this.baseDockPanel1.Name = "baseDockPanel1";
            this.baseDockPanel1.OriginalSize = new System.Drawing.Size(149, 200);
            this.baseDockPanel1.Size = new System.Drawing.Size(149, 746);
            this.baseDockPanel1.Text = "Навигация";
            // 
            // baseDocumentManager1
            // 
            this.baseDocumentManager1.Images = this.icons1;
            this.baseDocumentManager1.MdiParent = this;
            this.baseDocumentManager1.View = this.baseTabbedView1;
            this.baseDocumentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.baseTabbedView1});
            // 
            // baseLayoutControl1
            // 
            this.baseLayoutControl1.Controls.Add(this.filterClearButton1);
            this.baseLayoutControl1.Controls.Add(this.baseNavBarControl1);
            this.baseLayoutControl1.Controls.Add(this.filterTextEdit1);
            this.baseLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.baseLayoutControl1.Name = "baseLayoutControl1";
            this.baseLayoutControl1.Root = this.baseLayoutGroup1;
            this.baseLayoutControl1.Size = new System.Drawing.Size(141, 719);
            this.baseLayoutControl1.TabIndex = 0;
            // 
            // filterClearButton1
            // 
            this.filterClearButton1.Image = ((System.Drawing.Image)(resources.GetObject("filterClearButton1.Image")));
            this.filterClearButton1.Location = new System.Drawing.Point(2, 2);
            this.filterClearButton1.Name = "filterClearButton1";
            this.filterClearButton1.Size = new System.Drawing.Size(26, 22);
            this.filterClearButton1.StyleController = this.baseLayoutControl1;
            this.filterClearButton1.TabIndex = 4;
            // 
            // filterTextEdit1
            // 
            this.filterTextEdit1.Location = new System.Drawing.Point(32, 2);
            this.filterTextEdit1.Name = "filterTextEdit1";
            this.filterTextEdit1.Size = new System.Drawing.Size(107, 20);
            this.filterTextEdit1.StyleController = this.baseLayoutControl1;
            this.filterTextEdit1.TabIndex = 6;
            // 
            // baseLayoutGroup1
            // 
            this.baseLayoutGroup1.CustomizationFormText = "Формы";
            this.baseLayoutGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.baseLayoutGroup1.GroupBordersVisible = false;
            this.baseLayoutGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.filterLayoutItem1,
            this.barLayoutItem1,
            this.filterClearLayoutItem1});
            this.baseLayoutGroup1.Location = new System.Drawing.Point(0, 0);
            this.baseLayoutGroup1.Name = "baseLayoutGroup1";
            this.baseLayoutGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.baseLayoutGroup1.Size = new System.Drawing.Size(141, 719);
            this.baseLayoutGroup1.TextVisible = false;
            // 
            // filterLayoutItem1
            // 
            this.filterLayoutItem1.Control = this.filterTextEdit1;
            this.filterLayoutItem1.CustomizationFormText = "Фильтр";
            this.filterLayoutItem1.Location = new System.Drawing.Point(30, 0);
            this.filterLayoutItem1.Name = "filterLayoutItem1";
            this.filterLayoutItem1.Size = new System.Drawing.Size(111, 26);
            this.filterLayoutItem1.TextSize = new System.Drawing.Size(0, 0);
            this.filterLayoutItem1.TextVisible = false;
            // 
            // filterClearLayoutItem1
            // 
            this.filterClearLayoutItem1.Control = this.filterClearButton1;
            this.filterClearLayoutItem1.CustomizationFormText = "Очистка фильтра";
            this.filterClearLayoutItem1.Location = new System.Drawing.Point(0, 0);
            this.filterClearLayoutItem1.Name = "filterClearLayoutItem1";
            this.filterClearLayoutItem1.Size = new System.Drawing.Size(30, 26);
            this.filterClearLayoutItem1.TextSize = new System.Drawing.Size(0, 0);
            this.filterClearLayoutItem1.TextVisible = false;
            // 
            // OPCItemView1
            // 
            this.OPCItemView1.BaseNavBarItem = this.OPCItemViewNavBarItem1;
            this.OPCItemView1.Caption = "Устройство";
            this.OPCItemView1.DBForm = this._dbForm1;
            this.OPCItemView1.ImageIndex = 3;
            this.OPCItemView1.ImageName = "OPCItem.png";
            this.OPCItemView1.Images = this.icons1;
            this.OPCItemView1.IsDocumentActivated = false;
            this.OPCItemView1.TableType = typeof(AdminTool.Device);
            this.OPCItemView1.View = null;
            this.OPCItemView1.ViewType = typeof(AdminTool.DeviceView);
            // 
            // SettingView1
            // 
            this.SettingView1.BaseNavBarItem = this.SettingViewNavBarItem1;
            this.SettingView1.Caption = "Настройки";
            this.SettingView1.DBForm = this._dbForm1;
            this.SettingView1.ImageIndex = 1;
            this.SettingView1.ImageName = "Setting.png";
            this.SettingView1.Images = this.icons1;
            this.SettingView1.IsDocumentActivated = false;
            this.SettingView1.View = null;
            this.SettingView1.ViewType = typeof(AdminTool.SettingView);
            // 
            // TestView1
            // 
            this.TestView1.BaseNavBarItem = this.TestViewNavBarItem1;
            this.TestView1.Caption = "Test";
            this.TestView1.DBForm = this._dbForm1;
            this.TestView1.ImageName = "TestView.png";
            this.TestView1.Images = this.icons1;
            this.TestView1.IsDocumentActivated = false;
            this.TestView1.TableType = null;
            this.TestView1.View = null;
            this.TestView1.ViewType = typeof(AdminTool.TestView);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipTitle = "Транспортер в SQL";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Административный инструмент";
            this.notifyIcon1.Visible = true;
            // 
            // dbConnection1
            // 
            this.dbConnection1.AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema;
            this.dbConnection1.DataBase = "KairDB";
            this.dbConnection1.DataBaseType = RapidInterface.DBConnection.SQLType.MSSql;
            this.dbConnection1.OwnerForm = this;
            this.dbConnection1.OwnerFormInited = false;
            this.dbConnection1.Password = "qwe+ASDFG";
            this.dbConnection1.PasswordNeed = true;
            this.dbConnection1.Server = "172.31.106.121,1444";
            this.dbConnection1.User = "sa";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 771);
            this.Controls.Add(this.baseDockPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Административный инструмент";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this._dbForm1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barLayoutItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseNavBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icons1)).EndInit();
            this.baseControlContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.baseDockManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            this.baseDockPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.baseDocumentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseTabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseLayoutControl1)).EndInit();
            this.baseLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filterTextEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseLayoutGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterLayoutItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterClearLayoutItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbConnection1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RapidInterface.DBForm _dbForm1;
        private DevExpress.XtraLayout.LayoutControlItem barLayoutItem1;
        private DevExpress.XtraNavBar.NavBarControl baseNavBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup baseNavBarGroup1;
        private DevExpress.Utils.ImageCollection icons1;
        private DevExpress.XtraBars.Docking.ControlContainer baseControlContainer1;
        private DevExpress.XtraBars.Docking.DockManager baseDockManager1;
        private DevExpress.XtraBars.Docking.DockPanel baseDockPanel1;
        private DevExpress.XtraBars.Docking2010.DocumentManager baseDocumentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView baseTabbedView1;
        private RapidInterface.LayoutControlEx baseLayoutControl1;
        private DevExpress.XtraEditors.SimpleButton filterClearButton1;
        private DevExpress.XtraEditors.TextEdit filterTextEdit1;
        private DevExpress.XtraLayout.LayoutControlGroup baseLayoutGroup1;
        private DevExpress.XtraLayout.LayoutControlItem filterLayoutItem1;
        private DevExpress.XtraLayout.LayoutControlItem filterClearLayoutItem1;
        private DevExpress.XtraNavBar.NavBarItem OPCItemViewNavBarItem1;
        private RapidInterface.DBFormItemView OPCItemView1;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarStaticItem stInfo;
        private DevExpress.XtraNavBar.NavBarItem SettingViewNavBarItem1;
        private RapidInterface.DBFormItemBase SettingView1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private RapidInterface.DBConnection dbConnection1;
        private DevExpress.XtraNavBar.NavBarItem TestViewNavBarItem1;
        private RapidInterface.DBFormItemView TestView1;
        private DevExpress.XtraBars.BarEditItem pbInfo;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
    }
}

