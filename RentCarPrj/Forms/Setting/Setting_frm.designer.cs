namespace RentCarPrj
{
    partial class Setting_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting_frm));
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("امانت دهنده");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("محدودیتها");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("تنظیمات اجاره اتومبیل", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("SMS");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("تنظیمات سیستمی", new System.Windows.Forms.TreeNode[] {
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("تنظیم آلارم ها");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("دیگر تنظیمات", new System.Windows.Forms.TreeNode[] {
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("پشتیبانی و بازیابی");
            this.ribbonBar_Setting = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem_OK = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem_Cancel = new DevComponents.DotNetBar.ButtonItem();
            this.treeView_Setting = new System.Windows.Forms.TreeView();
            this.imageList_Setting = new System.Windows.Forms.ImageList(this.components);
            this.tabControl_Setting = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel_SMS = new DevComponents.DotNetBar.TabControlPanel();
            this.radioButtonGSM = new System.Windows.Forms.RadioButton();
            this.radioButtonInternet = new System.Windows.Forms.RadioButton();
            this.groupBox_IntSMS = new System.Windows.Forms.GroupBox();
            this.buttonTestCredit = new DevComponents.DotNetBar.ButtonX();
            this.textBoxTelNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label29 = new System.Windows.Forms.Label();
            this.textBoxPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label27 = new System.Windows.Forms.Label();
            this.textBoxUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label26 = new System.Windows.Forms.Label();
            this.groupPanel_SMS = new System.Windows.Forms.GroupBox();
            this.chkDeliveryReport = new System.Windows.Forms.CheckBox();
            this.chkunicode = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbLongMsg = new System.Windows.Forms.ComboBox();
            this.label36 = new System.Windows.Forms.Label();
            this.cmbEncoding = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.cmbFlowControl = new System.Windows.Forms.ComboBox();
            this.cmbStopBits = new System.Windows.Forms.ComboBox();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.cmbDataBits = new System.Windows.Forms.ComboBox();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.cmbTimeOut = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tabItem_SMS = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel_SetAlarms = new DevComponents.DotNetBar.TabControlPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.nUpDownExpDayBodyInsu = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.nUpDownExpKMService = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.nUpDownExpDayThirdInsu = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.nUpDownExpDayCarDuty = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.nUpDownExpDayCarEnter = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nUpDownGetFinePeriod = new System.Windows.Forms.NumericUpDown();
            this.tabItem_SetAlarms = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel_SetBkpRst = new DevComponents.DotNetBar.TabControlPanel();
            this.groupBox_Set = new System.Windows.Forms.GroupBox();
            this.checkBox_BRDesignRep = new System.Windows.Forms.CheckBox();
            this.checkBox_BRPicFilm = new System.Windows.Forms.CheckBox();
            this.groupBox_Rst = new System.Windows.Forms.GroupBox();
            this.button_RstChangePass = new DevComponents.DotNetBar.ButtonX();
            this.groupBox_Bkp = new System.Windows.Forms.GroupBox();
            this.label_BkpAuto = new System.Windows.Forms.Label();
            this.button_BkpAuto = new DevComponents.DotNetBar.ButtonX();
            this.radioButton_BkpNo = new System.Windows.Forms.RadioButton();
            this.radioButton_BkpAuto = new System.Windows.Forms.RadioButton();
            this.radioButton_BkpNonAuto = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabItem_SetBkpRst = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel_SetPosDef = new DevComponents.DotNetBar.TabControlPanel();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.nUpDown_FreeKillometer = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_FineTime = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBox_FineDay = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label42 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label_Mny3 = new System.Windows.Forms.Label();
            this.textBox_FineKillometer = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_CityLimit = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label43 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabItem_SetPosDef = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel_SetUnits = new DevComponents.DotNetBar.TabControlPanel();
            this.groupPanel_HCLord = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.textBox_EMail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBox_mobile = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label_LMelliCode = new System.Windows.Forms.Label();
            this.label_LFatherN = new System.Windows.Forms.Label();
            this.textBox_Tel = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label_LName = new System.Windows.Forms.Label();
            this.textBox_Address = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label_LFamily = new System.Windows.Forms.Label();
            this.groupPanel_HCCustomer = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.button_DelPic = new DevComponents.DotNetBar.ButtonX();
            this.pictureBoxCarPic = new System.Windows.Forms.PictureBox();
            this.label23 = new System.Windows.Forms.Label();
            this.ComboBoxBrithCityName = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.panel_BrithDate = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_YearBD = new System.Windows.Forms.ComboBox();
            this.comboBox_DayBD = new System.Windows.Forms.ComboBox();
            this.comboBox_MonthBD = new System.Windows.Forms.ComboBox();
            this.textBox_CNationalCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBox_CParentN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label4 = new System.Windows.Forms.Label();
            this.label_CMelliCode = new System.Windows.Forms.Label();
            this.label_CFatherN = new System.Windows.Forms.Label();
            this.textBox_CIDNO = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label7 = new System.Windows.Forms.Label();
            this.label_CName = new System.Windows.Forms.Label();
            this.textBox_CName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBox_CoName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label6 = new System.Windows.Forms.Label();
            this.label_CFamily = new System.Windows.Forms.Label();
            this.tabItem_SetUnits = new DevComponents.DotNetBar.TabItem(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxInitSMSMessage = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label39 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl_Setting)).BeginInit();
            this.tabControl_Setting.SuspendLayout();
            this.tabControlPanel_SMS.SuspendLayout();
            this.groupBox_IntSMS.SuspendLayout();
            this.groupPanel_SMS.SuspendLayout();
            this.tabControlPanel_SetAlarms.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownExpDayBodyInsu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownExpKMService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownExpDayThirdInsu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownExpDayCarDuty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownExpDayCarEnter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownGetFinePeriod)).BeginInit();
            this.tabControlPanel_SetBkpRst.SuspendLayout();
            this.groupBox_Set.SuspendLayout();
            this.groupBox_Rst.SuspendLayout();
            this.groupBox_Bkp.SuspendLayout();
            this.tabControlPanel_SetPosDef.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown_FreeKillometer)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabControlPanel_SetUnits.SuspendLayout();
            this.groupPanel_HCLord.SuspendLayout();
            this.groupPanel_HCCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarPic)).BeginInit();
            this.panel_BrithDate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonBar_Setting
            // 
            this.ribbonBar_Setting.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar_Setting.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar_Setting.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar_Setting.ContainerControlProcessDialogKey = true;
            this.ribbonBar_Setting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ribbonBar_Setting.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonBar_Setting.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem_OK,
            this.buttonItem_Cancel});
            this.ribbonBar_Setting.Location = new System.Drawing.Point(0, 453);
            this.ribbonBar_Setting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonBar_Setting.Name = "ribbonBar_Setting";
            this.ribbonBar_Setting.Size = new System.Drawing.Size(823, 62);
            this.ribbonBar_Setting.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.ribbonBar_Setting.TabIndex = 2;
            // 
            // 
            // 
            this.ribbonBar_Setting.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar_Setting.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar_Setting.TitleVisible = false;
            // 
            // buttonItem_OK
            // 
            this.buttonItem_OK.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem_OK.FixedSize = new System.Drawing.Size(80, 58);
            this.buttonItem_OK.HotFontBold = true;
            this.buttonItem_OK.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem_OK.Image")));
            this.buttonItem_OK.ImagePaddingHorizontal = 20;
            this.buttonItem_OK.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem_OK.Name = "buttonItem_OK";
            this.buttonItem_OK.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F2);
            this.buttonItem_OK.SubItemsExpandWidth = 20;
            this.buttonItem_OK.Text = "تایید";
            this.buttonItem_OK.Tooltip = "F2";
            this.buttonItem_OK.Click += new System.EventHandler(this.buttonItem_OK_Click);
            // 
            // buttonItem_Cancel
            // 
            this.buttonItem_Cancel.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem_Cancel.FixedSize = new System.Drawing.Size(80, 55);
            this.buttonItem_Cancel.HotFontBold = true;
            this.buttonItem_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem_Cancel.Image")));
            this.buttonItem_Cancel.ImagePaddingHorizontal = 20;
            this.buttonItem_Cancel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem_Cancel.Name = "buttonItem_Cancel";
            this.buttonItem_Cancel.SubItemsExpandWidth = 14;
            this.buttonItem_Cancel.Text = "انصراف";
            this.buttonItem_Cancel.Tooltip = "Esc";
            this.buttonItem_Cancel.Click += new System.EventHandler(this.buttonItem_Cancel_Click);
            // 
            // treeView_Setting
            // 
            this.treeView_Setting.BackColor = System.Drawing.Color.White;
            this.treeView_Setting.Dock = System.Windows.Forms.DockStyle.Right;
            this.treeView_Setting.Font = new System.Drawing.Font("Tahoma", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.treeView_Setting.ForeColor = System.Drawing.Color.Black;
            this.treeView_Setting.Indent = 25;
            this.treeView_Setting.ItemHeight = 40;
            this.treeView_Setting.LineColor = System.Drawing.Color.MediumVioletRed;
            this.treeView_Setting.Location = new System.Drawing.Point(638, 0);
            this.treeView_Setting.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.treeView_Setting.Name = "treeView_Setting";
            treeNode9.Name = "Node_SetUnits";
            treeNode9.StateImageKey = "Utilities.png";
            treeNode9.Text = "امانت دهنده";
            treeNode10.Name = "Node_SetPosDef";
            treeNode10.StateImageKey = "go_kde.png";
            treeNode10.Text = "محدودیتها";
            treeNode11.Name = "Node_FSet";
            treeNode11.StateImageKey = "advancedsettings.png";
            treeNode11.Text = "تنظیمات اجاره اتومبیل";
            treeNode12.Name = "Node_Sms";
            treeNode12.StateImageKey = "sms.png";
            treeNode12.Text = "SMS";
            treeNode13.Name = "Node_SetSystem";
            treeNode13.StateImageKey = "systemsettings.png";
            treeNode13.Text = "تنظیمات سیستمی";
            treeNode14.Name = "Node_SetAlarms";
            treeNode14.StateImageKey = "bell.png";
            treeNode14.Text = "تنظیم آلارم ها";
            treeNode15.Name = "Node_SetOther";
            treeNode15.StateImageKey = "announcements.png";
            treeNode15.Text = "دیگر تنظیمات";
            treeNode16.Name = "Node_SetBkpRst";
            treeNode16.StateImageKey = "kcmdf.png";
            treeNode16.Text = "پشتیبانی و بازیابی";
            this.treeView_Setting.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode13,
            treeNode15,
            treeNode16});
            this.treeView_Setting.RightToLeftLayout = true;
            this.treeView_Setting.Size = new System.Drawing.Size(185, 453);
            this.treeView_Setting.StateImageList = this.imageList_Setting;
            this.treeView_Setting.TabIndex = 4;
            this.treeView_Setting.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_Setting_NodeMouseClick);
            // 
            // imageList_Setting
            // 
            this.imageList_Setting.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Setting.ImageStream")));
            this.imageList_Setting.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Setting.Images.SetKeyName(0, "home.png");
            this.imageList_Setting.Images.SetKeyName(1, "advancedsettings.png");
            this.imageList_Setting.Images.SetKeyName(2, "announcements.png");
            this.imageList_Setting.Images.SetKeyName(3, "artscontrol.png");
            this.imageList_Setting.Images.SetKeyName(4, "go_kde.png");
            this.imageList_Setting.Images.SetKeyName(5, "sms.png");
            this.imageList_Setting.Images.SetKeyName(6, "kfm_home.png");
            this.imageList_Setting.Images.SetKeyName(7, "Startup Wizard.png");
            this.imageList_Setting.Images.SetKeyName(8, "bell.png");
            this.imageList_Setting.Images.SetKeyName(9, "kcmdf.png");
            this.imageList_Setting.Images.SetKeyName(10, "knode.png");
            this.imageList_Setting.Images.SetKeyName(11, "blender.png");
            this.imageList_Setting.Images.SetKeyName(12, "navigator.png");
            this.imageList_Setting.Images.SetKeyName(13, "systemsettings.png");
            this.imageList_Setting.Images.SetKeyName(14, "Utilities.png");
            // 
            // tabControl_Setting
            // 
            this.tabControl_Setting.CanReorderTabs = true;
            this.tabControl_Setting.Controls.Add(this.tabControlPanel_SMS);
            this.tabControl_Setting.Controls.Add(this.tabControlPanel_SetAlarms);
            this.tabControl_Setting.Controls.Add(this.tabControlPanel_SetBkpRst);
            this.tabControl_Setting.Controls.Add(this.tabControlPanel_SetPosDef);
            this.tabControl_Setting.Controls.Add(this.tabControlPanel_SetUnits);
            this.tabControl_Setting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Setting.FixedTabSize = new System.Drawing.Size(1, 1);
            this.tabControl_Setting.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Setting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl_Setting.Name = "tabControl_Setting";
            this.tabControl_Setting.SelectedTabFont = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold);
            this.tabControl_Setting.SelectedTabIndex = 0;
            this.tabControl_Setting.Size = new System.Drawing.Size(638, 453);
            this.tabControl_Setting.Style = DevComponents.DotNetBar.eTabStripStyle.Office2007Document;
            this.tabControl_Setting.TabIndex = 5;
            this.tabControl_Setting.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.MultilineNoNavigationBox;
            this.tabControl_Setting.Tabs.Add(this.tabItem_SetUnits);
            this.tabControl_Setting.Tabs.Add(this.tabItem_SetPosDef);
            this.tabControl_Setting.Tabs.Add(this.tabItem_SetBkpRst);
            this.tabControl_Setting.Tabs.Add(this.tabItem_SetAlarms);
            this.tabControl_Setting.Tabs.Add(this.tabItem_SMS);
            // 
            // tabControlPanel_SMS
            // 
            this.tabControlPanel_SMS.Controls.Add(this.groupBox1);
            this.tabControlPanel_SMS.Controls.Add(this.radioButtonGSM);
            this.tabControlPanel_SMS.Controls.Add(this.radioButtonInternet);
            this.tabControlPanel_SMS.Controls.Add(this.groupBox_IntSMS);
            this.tabControlPanel_SMS.Controls.Add(this.groupPanel_SMS);
            this.tabControlPanel_SMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel_SMS.Location = new System.Drawing.Point(0, 4);
            this.tabControlPanel_SMS.Name = "tabControlPanel_SMS";
            this.tabControlPanel_SMS.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel_SMS.Size = new System.Drawing.Size(638, 449);
            this.tabControlPanel_SMS.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.tabControlPanel_SMS.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.tabControlPanel_SMS.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel_SMS.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.tabControlPanel_SMS.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel_SMS.Style.GradientAngle = 90;
            this.tabControlPanel_SMS.TabIndex = 8;
            this.tabControlPanel_SMS.TabItem = this.tabItem_SMS;
            // 
            // radioButtonGSM
            // 
            this.radioButtonGSM.AutoSize = true;
            this.radioButtonGSM.BackColor = System.Drawing.Color.LightBlue;
            this.radioButtonGSM.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonGSM.Location = new System.Drawing.Point(555, 99);
            this.radioButtonGSM.Name = "radioButtonGSM";
            this.radioButtonGSM.Size = new System.Drawing.Size(52, 18);
            this.radioButtonGSM.TabIndex = 6;
            this.radioButtonGSM.Text = "GSM";
            this.radioButtonGSM.UseVisualStyleBackColor = false;
            // 
            // radioButtonInternet
            // 
            this.radioButtonInternet.AutoSize = true;
            this.radioButtonInternet.BackColor = System.Drawing.Color.LightBlue;
            this.radioButtonInternet.Checked = true;
            this.radioButtonInternet.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonInternet.Location = new System.Drawing.Point(530, 3);
            this.radioButtonInternet.Name = "radioButtonInternet";
            this.radioButtonInternet.Size = new System.Drawing.Size(77, 18);
            this.radioButtonInternet.TabIndex = 5;
            this.radioButtonInternet.TabStop = true;
            this.radioButtonInternet.Text = "Internet";
            this.radioButtonInternet.UseVisualStyleBackColor = false;
            // 
            // groupBox_IntSMS
            // 
            this.groupBox_IntSMS.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_IntSMS.Controls.Add(this.buttonTestCredit);
            this.groupBox_IntSMS.Controls.Add(this.textBoxTelNumber);
            this.groupBox_IntSMS.Controls.Add(this.label29);
            this.groupBox_IntSMS.Controls.Add(this.textBoxPassword);
            this.groupBox_IntSMS.Controls.Add(this.label27);
            this.groupBox_IntSMS.Controls.Add(this.textBoxUserName);
            this.groupBox_IntSMS.Controls.Add(this.label26);
            this.groupBox_IntSMS.Location = new System.Drawing.Point(29, 14);
            this.groupBox_IntSMS.Name = "groupBox_IntSMS";
            this.groupBox_IntSMS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox_IntSMS.Size = new System.Drawing.Size(580, 78);
            this.groupBox_IntSMS.TabIndex = 4;
            this.groupBox_IntSMS.TabStop = false;
            this.groupBox_IntSMS.Text = "Internet Setting";
            // 
            // buttonTestCredit
            // 
            this.buttonTestCredit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonTestCredit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonTestCredit.Location = new System.Drawing.Point(369, 48);
            this.buttonTestCredit.Name = "buttonTestCredit";
            this.buttonTestCredit.Size = new System.Drawing.Size(168, 22);
            this.buttonTestCredit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonTestCredit.TabIndex = 30;
            this.buttonTestCredit.Text = "Test & Credit";
            this.buttonTestCredit.Click += new System.EventHandler(this.buttonTestCredit_Click);
            // 
            // textBoxTelNumber
            // 
            // 
            // 
            // 
            this.textBoxTelNumber.Border.Class = "TextBoxBorder";
            this.textBoxTelNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxTelNumber.Location = new System.Drawing.Point(119, 48);
            this.textBoxTelNumber.Name = "textBoxTelNumber";
            this.textBoxTelNumber.Size = new System.Drawing.Size(163, 22);
            this.textBoxTelNumber.TabIndex = 29;
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(39, 52);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(71, 14);
            this.label29.TabIndex = 28;
            this.label29.Text = "TelNumber:";
            // 
            // textBoxPassword
            // 
            // 
            // 
            // 
            this.textBoxPassword.Border.Class = "TextBoxBorder";
            this.textBoxPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxPassword.Location = new System.Drawing.Point(381, 18);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(163, 22);
            this.textBoxPassword.TabIndex = 27;
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(309, 26);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(62, 14);
            this.label27.TabIndex = 26;
            this.label27.Text = "Password:";
            // 
            // textBoxUserName
            // 
            // 
            // 
            // 
            this.textBoxUserName.Border.Class = "TextBoxBorder";
            this.textBoxUserName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxUserName.Location = new System.Drawing.Point(119, 20);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(163, 22);
            this.textBoxUserName.TabIndex = 25;
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(39, 24);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(66, 14);
            this.label26.TabIndex = 24;
            this.label26.Text = "UserName:";
            // 
            // groupPanel_SMS
            // 
            this.groupPanel_SMS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel_SMS.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel_SMS.Controls.Add(this.chkDeliveryReport);
            this.groupPanel_SMS.Controls.Add(this.chkunicode);
            this.groupPanel_SMS.Controls.Add(this.label8);
            this.groupPanel_SMS.Controls.Add(this.cmbLongMsg);
            this.groupPanel_SMS.Controls.Add(this.label36);
            this.groupPanel_SMS.Controls.Add(this.cmbEncoding);
            this.groupPanel_SMS.Controls.Add(this.label28);
            this.groupPanel_SMS.Controls.Add(this.label30);
            this.groupPanel_SMS.Controls.Add(this.label32);
            this.groupPanel_SMS.Controls.Add(this.label33);
            this.groupPanel_SMS.Controls.Add(this.label34);
            this.groupPanel_SMS.Controls.Add(this.label35);
            this.groupPanel_SMS.Controls.Add(this.cmbFlowControl);
            this.groupPanel_SMS.Controls.Add(this.cmbStopBits);
            this.groupPanel_SMS.Controls.Add(this.cmbParity);
            this.groupPanel_SMS.Controls.Add(this.cmbDataBits);
            this.groupPanel_SMS.Controls.Add(this.cmbBaudRate);
            this.groupPanel_SMS.Controls.Add(this.cmbPort);
            this.groupPanel_SMS.Controls.Add(this.cmbTimeOut);
            this.groupPanel_SMS.Controls.Add(this.label22);
            this.groupPanel_SMS.Location = new System.Drawing.Point(29, 110);
            this.groupPanel_SMS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPanel_SMS.Name = "groupPanel_SMS";
            this.groupPanel_SMS.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPanel_SMS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupPanel_SMS.Size = new System.Drawing.Size(580, 207);
            this.groupPanel_SMS.TabIndex = 3;
            this.groupPanel_SMS.TabStop = false;
            this.groupPanel_SMS.Text = "GSM Setting";
            // 
            // chkDeliveryReport
            // 
            this.chkDeliveryReport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkDeliveryReport.AutoSize = true;
            this.chkDeliveryReport.Location = new System.Drawing.Point(373, 136);
            this.chkDeliveryReport.Name = "chkDeliveryReport";
            this.chkDeliveryReport.Size = new System.Drawing.Size(159, 18);
            this.chkDeliveryReport.TabIndex = 33;
            this.chkDeliveryReport.Text = "Message Delivery Report";
            this.chkDeliveryReport.UseVisualStyleBackColor = true;
            // 
            // chkunicode
            // 
            this.chkunicode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkunicode.AutoSize = true;
            this.chkunicode.BackColor = System.Drawing.Color.Transparent;
            this.chkunicode.Checked = true;
            this.chkunicode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkunicode.Location = new System.Drawing.Point(376, 159);
            this.chkunicode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkunicode.Name = "chkunicode";
            this.chkunicode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkunicode.Size = new System.Drawing.Size(156, 18);
            this.chkunicode.TabIndex = 16;
            this.chkunicode.Text = "Send as Unicode(UCS2)";
            this.chkunicode.UseVisualStyleBackColor = false;
            this.chkunicode.Visible = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 14);
            this.label8.TabIndex = 32;
            this.label8.Text = "Long Messages:";
            // 
            // cmbLongMsg
            // 
            this.cmbLongMsg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbLongMsg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLongMsg.FormattingEnabled = true;
            this.cmbLongMsg.Location = new System.Drawing.Point(387, 97);
            this.cmbLongMsg.Name = "cmbLongMsg";
            this.cmbLongMsg.Size = new System.Drawing.Size(145, 22);
            this.cmbLongMsg.TabIndex = 31;
            // 
            // label36
            // 
            this.label36.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(321, 38);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(61, 14);
            this.label36.TabIndex = 30;
            this.label36.Text = "Encoding:";
            // 
            // cmbEncoding
            // 
            this.cmbEncoding.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEncoding.FormattingEnabled = true;
            this.cmbEncoding.Location = new System.Drawing.Point(387, 35);
            this.cmbEncoding.Name = "cmbEncoding";
            this.cmbEncoding.Size = new System.Drawing.Size(145, 22);
            this.cmbEncoding.TabIndex = 29;
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(49, 180);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(79, 14);
            this.label28.TabIndex = 28;
            this.label28.Text = "Flow Control:";
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(68, 149);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(60, 14);
            this.label30.TabIndex = 27;
            this.label30.Text = "Stop Bits:";
            // 
            // label32
            // 
            this.label32.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(87, 118);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(41, 14);
            this.label32.TabIndex = 26;
            this.label32.Text = "Parity:";
            // 
            // label33
            // 
            this.label33.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(69, 87);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(59, 14);
            this.label33.TabIndex = 25;
            this.label33.Text = "Data Bits:";
            // 
            // label34
            // 
            this.label34.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(61, 56);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(67, 14);
            this.label34.TabIndex = 24;
            this.label34.Text = "Baud Rate:";
            // 
            // label35
            // 
            this.label35.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(94, 25);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(34, 14);
            this.label35.TabIndex = 23;
            this.label35.Text = "Port:";
            // 
            // cmbFlowControl
            // 
            this.cmbFlowControl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbFlowControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFlowControl.FormattingEnabled = true;
            this.cmbFlowControl.Location = new System.Drawing.Point(132, 176);
            this.cmbFlowControl.Name = "cmbFlowControl";
            this.cmbFlowControl.Size = new System.Drawing.Size(121, 22);
            this.cmbFlowControl.TabIndex = 22;
            // 
            // cmbStopBits
            // 
            this.cmbStopBits.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStopBits.FormattingEnabled = true;
            this.cmbStopBits.Location = new System.Drawing.Point(132, 145);
            this.cmbStopBits.Name = "cmbStopBits";
            this.cmbStopBits.Size = new System.Drawing.Size(121, 22);
            this.cmbStopBits.TabIndex = 21;
            // 
            // cmbParity
            // 
            this.cmbParity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Location = new System.Drawing.Point(132, 114);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(121, 22);
            this.cmbParity.TabIndex = 20;
            // 
            // cmbDataBits
            // 
            this.cmbDataBits.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataBits.FormattingEnabled = true;
            this.cmbDataBits.Location = new System.Drawing.Point(132, 83);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Size = new System.Drawing.Size(121, 22);
            this.cmbDataBits.TabIndex = 19;
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Location = new System.Drawing.Point(132, 52);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(121, 22);
            this.cmbBaudRate.TabIndex = 18;
            // 
            // cmbPort
            // 
            this.cmbPort.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(132, 21);
            this.cmbPort.MaxDropDownItems = 16;
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(121, 22);
            this.cmbPort.TabIndex = 17;
            // 
            // cmbTimeOut
            // 
            this.cmbTimeOut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbTimeOut.AutoCompleteCustomSource.AddRange(new string[] {
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800"});
            this.cmbTimeOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimeOut.FormattingEnabled = true;
            this.cmbTimeOut.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800"});
            this.cmbTimeOut.Location = new System.Drawing.Point(387, 66);
            this.cmbTimeOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTimeOut.Name = "cmbTimeOut";
            this.cmbTimeOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbTimeOut.Size = new System.Drawing.Size(145, 22);
            this.cmbTimeOut.TabIndex = 15;
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(319, 69);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(63, 14);
            this.label22.TabIndex = 14;
            this.label22.Text = "Time Out:";
            // 
            // tabItem_SMS
            // 
            this.tabItem_SMS.AttachedControl = this.tabControlPanel_SMS;
            this.tabItem_SMS.Name = "tabItem_SMS";
            this.tabItem_SMS.Text = "tabItem1";
            // 
            // tabControlPanel_SetAlarms
            // 
            this.tabControlPanel_SetAlarms.AutoScroll = true;
            this.tabControlPanel_SetAlarms.AutoScrollMinSize = new System.Drawing.Size(600, 400);
            this.tabControlPanel_SetAlarms.Controls.Add(this.groupBox2);
            this.tabControlPanel_SetAlarms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel_SetAlarms.Location = new System.Drawing.Point(0, 4);
            this.tabControlPanel_SetAlarms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlPanel_SetAlarms.Name = "tabControlPanel_SetAlarms";
            this.tabControlPanel_SetAlarms.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel_SetAlarms.Size = new System.Drawing.Size(638, 449);
            this.tabControlPanel_SetAlarms.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.tabControlPanel_SetAlarms.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.tabControlPanel_SetAlarms.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel_SetAlarms.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.tabControlPanel_SetAlarms.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel_SetAlarms.Style.GradientAngle = 90;
            this.tabControlPanel_SetAlarms.TabIndex = 7;
            this.tabControlPanel_SetAlarms.TabItem = this.tabItem_SetAlarms;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.nUpDownExpDayBodyInsu);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.nUpDownExpKMService);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.nUpDownExpDayThirdInsu);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.nUpDownExpDayCarDuty);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.nUpDownExpDayCarEnter);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.nUpDownGetFinePeriod);
            this.groupBox2.Location = new System.Drawing.Point(43, 42);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(553, 364);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تنظیم آلارم ها";
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(223, 285);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(111, 14);
            this.label24.TabIndex = 26;
            this.label24.Text = "جهت اعمال سرویس";
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(113, 285);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(41, 14);
            this.label25.TabIndex = 25;
            this.label25.Text = "کیلومتر";
            // 
            // nUpDownExpDayBodyInsu
            // 
            this.nUpDownExpDayBodyInsu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nUpDownExpDayBodyInsu.ForeColor = System.Drawing.Color.Black;
            this.nUpDownExpDayBodyInsu.Location = new System.Drawing.Point(160, 237);
            this.nUpDownExpDayBodyInsu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nUpDownExpDayBodyInsu.Name = "nUpDownExpDayBodyInsu";
            this.nUpDownExpDayBodyInsu.Size = new System.Drawing.Size(59, 22);
            this.nUpDownExpDayBodyInsu.TabIndex = 22;
            this.nUpDownExpDayBodyInsu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUpDownExpDayBodyInsu.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nUpDownExpDayBodyInsu.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(223, 241);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(112, 14);
            this.label20.TabIndex = 21;
            this.label20.Text = "اتمام مهلت بیمه بدنه";
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(112, 241);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(42, 14);
            this.label21.TabIndex = 20;
            this.label21.Text = "روز قبل";
            // 
            // nUpDownExpKMService
            // 
            this.nUpDownExpKMService.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nUpDownExpKMService.ForeColor = System.Drawing.Color.Black;
            this.nUpDownExpKMService.Location = new System.Drawing.Point(160, 281);
            this.nUpDownExpKMService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nUpDownExpKMService.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nUpDownExpKMService.Name = "nUpDownExpKMService";
            this.nUpDownExpKMService.Size = new System.Drawing.Size(59, 22);
            this.nUpDownExpKMService.TabIndex = 19;
            this.nUpDownExpKMService.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUpDownExpKMService.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nUpDownExpKMService.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(223, 197);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(151, 14);
            this.label18.TabIndex = 18;
            this.label18.Text = "اتمام مهلت بیمه شخص ثالث";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(112, 197);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 14);
            this.label19.TabIndex = 17;
            this.label19.Text = "روز قبل";
            // 
            // nUpDownExpDayThirdInsu
            // 
            this.nUpDownExpDayThirdInsu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nUpDownExpDayThirdInsu.ForeColor = System.Drawing.Color.Black;
            this.nUpDownExpDayThirdInsu.Location = new System.Drawing.Point(160, 193);
            this.nUpDownExpDayThirdInsu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nUpDownExpDayThirdInsu.Name = "nUpDownExpDayThirdInsu";
            this.nUpDownExpDayThirdInsu.Size = new System.Drawing.Size(59, 22);
            this.nUpDownExpDayThirdInsu.TabIndex = 16;
            this.nUpDownExpDayThirdInsu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUpDownExpDayThirdInsu.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nUpDownExpDayThirdInsu.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(223, 153);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 14);
            this.label16.TabIndex = 15;
            this.label16.Text = "اتمام مهلت سرویس";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(112, 153);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 14);
            this.label17.TabIndex = 14;
            this.label17.Text = "روز قبل";
            // 
            // nUpDownExpDayCarDuty
            // 
            this.nUpDownExpDayCarDuty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nUpDownExpDayCarDuty.ForeColor = System.Drawing.Color.Black;
            this.nUpDownExpDayCarDuty.Location = new System.Drawing.Point(160, 149);
            this.nUpDownExpDayCarDuty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nUpDownExpDayCarDuty.Name = "nUpDownExpDayCarDuty";
            this.nUpDownExpDayCarDuty.Size = new System.Drawing.Size(59, 22);
            this.nUpDownExpDayCarDuty.TabIndex = 13;
            this.nUpDownExpDayCarDuty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUpDownExpDayCarDuty.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nUpDownExpDayCarDuty.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(223, 109);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 14);
            this.label14.TabIndex = 12;
            this.label14.Text = "اتمام مهلت قرارداد";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(112, 109);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 14);
            this.label15.TabIndex = 11;
            this.label15.Text = "روز قبل";
            // 
            // nUpDownExpDayCarEnter
            // 
            this.nUpDownExpDayCarEnter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nUpDownExpDayCarEnter.ForeColor = System.Drawing.Color.Black;
            this.nUpDownExpDayCarEnter.Location = new System.Drawing.Point(160, 105);
            this.nUpDownExpDayCarEnter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nUpDownExpDayCarEnter.Name = "nUpDownExpDayCarEnter";
            this.nUpDownExpDayCarEnter.Size = new System.Drawing.Size(59, 22);
            this.nUpDownExpDayCarEnter.TabIndex = 10;
            this.nUpDownExpDayCarEnter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUpDownExpDayCarEnter.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nUpDownExpDayCarEnter.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(223, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(276, 14);
            this.label13.TabIndex = 9;
            this.label13.Text = "تعداد روزهای بعد از سرویس جهت اخذ خلافی ماشین";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(134, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 14);
            this.label10.TabIndex = 8;
            this.label10.Text = "روز";
            // 
            // nUpDownGetFinePeriod
            // 
            this.nUpDownGetFinePeriod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nUpDownGetFinePeriod.ForeColor = System.Drawing.Color.Black;
            this.nUpDownGetFinePeriod.Location = new System.Drawing.Point(160, 61);
            this.nUpDownGetFinePeriod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nUpDownGetFinePeriod.Name = "nUpDownGetFinePeriod";
            this.nUpDownGetFinePeriod.Size = new System.Drawing.Size(59, 22);
            this.nUpDownGetFinePeriod.TabIndex = 7;
            this.nUpDownGetFinePeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUpDownGetFinePeriod.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nUpDownGetFinePeriod.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // tabItem_SetAlarms
            // 
            this.tabItem_SetAlarms.AttachedControl = this.tabControlPanel_SetAlarms;
            this.tabItem_SetAlarms.Name = "tabItem_SetAlarms";
            this.tabItem_SetAlarms.Text = "tabItem_SetAlarms";
            // 
            // tabControlPanel_SetBkpRst
            // 
            this.tabControlPanel_SetBkpRst.AutoScroll = true;
            this.tabControlPanel_SetBkpRst.AutoScrollMinSize = new System.Drawing.Size(600, 400);
            this.tabControlPanel_SetBkpRst.Controls.Add(this.groupBox_Set);
            this.tabControlPanel_SetBkpRst.Controls.Add(this.groupBox_Rst);
            this.tabControlPanel_SetBkpRst.Controls.Add(this.groupBox_Bkp);
            this.tabControlPanel_SetBkpRst.Controls.Add(this.panel4);
            this.tabControlPanel_SetBkpRst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel_SetBkpRst.Location = new System.Drawing.Point(0, 4);
            this.tabControlPanel_SetBkpRst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlPanel_SetBkpRst.Name = "tabControlPanel_SetBkpRst";
            this.tabControlPanel_SetBkpRst.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel_SetBkpRst.Size = new System.Drawing.Size(638, 449);
            this.tabControlPanel_SetBkpRst.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.tabControlPanel_SetBkpRst.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.tabControlPanel_SetBkpRst.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel_SetBkpRst.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.tabControlPanel_SetBkpRst.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel_SetBkpRst.Style.GradientAngle = 90;
            this.tabControlPanel_SetBkpRst.TabIndex = 6;
            this.tabControlPanel_SetBkpRst.TabItem = this.tabItem_SetBkpRst;
            // 
            // groupBox_Set
            // 
            this.groupBox_Set.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Set.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Set.Controls.Add(this.checkBox_BRDesignRep);
            this.groupBox_Set.Controls.Add(this.checkBox_BRPicFilm);
            this.groupBox_Set.Location = new System.Drawing.Point(21, 174);
            this.groupBox_Set.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Set.Name = "groupBox_Set";
            this.groupBox_Set.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Set.Size = new System.Drawing.Size(590, 54);
            this.groupBox_Set.TabIndex = 16;
            this.groupBox_Set.TabStop = false;
            this.groupBox_Set.Text = "تنظیمات";
            // 
            // checkBox_BRDesignRep
            // 
            this.checkBox_BRDesignRep.AutoSize = true;
            this.checkBox_BRDesignRep.Location = new System.Drawing.Point(44, 26);
            this.checkBox_BRDesignRep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_BRDesignRep.Name = "checkBox_BRDesignRep";
            this.checkBox_BRDesignRep.Size = new System.Drawing.Size(206, 17);
            this.checkBox_BRDesignRep.TabIndex = 1;
            this.checkBox_BRDesignRep.Text = "پشتیبانی و بازیابی با طراحی گزارشات";
            this.checkBox_BRDesignRep.UseVisualStyleBackColor = true;
            this.checkBox_BRDesignRep.Visible = false;
            // 
            // checkBox_BRPicFilm
            // 
            this.checkBox_BRPicFilm.AutoSize = true;
            this.checkBox_BRPicFilm.Location = new System.Drawing.Point(326, 26);
            this.checkBox_BRPicFilm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_BRPicFilm.Name = "checkBox_BRPicFilm";
            this.checkBox_BRPicFilm.Size = new System.Drawing.Size(202, 17);
            this.checkBox_BRPicFilm.TabIndex = 0;
            this.checkBox_BRPicFilm.Text = "پشتیبانی و بازیابی با تصاویر و فیلمها";
            this.checkBox_BRPicFilm.UseVisualStyleBackColor = true;
            // 
            // groupBox_Rst
            // 
            this.groupBox_Rst.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Rst.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Rst.Controls.Add(this.button_RstChangePass);
            this.groupBox_Rst.Location = new System.Drawing.Point(21, 285);
            this.groupBox_Rst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Rst.Name = "groupBox_Rst";
            this.groupBox_Rst.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Rst.Size = new System.Drawing.Size(590, 139);
            this.groupBox_Rst.TabIndex = 15;
            this.groupBox_Rst.TabStop = false;
            this.groupBox_Rst.Text = "بازیابی";
            // 
            // button_RstChangePass
            // 
            this.button_RstChangePass.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_RstChangePass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_RstChangePass.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_RstChangePass.Location = new System.Drawing.Point(178, 49);
            this.button_RstChangePass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_RstChangePass.Name = "button_RstChangePass";
            this.button_RstChangePass.Size = new System.Drawing.Size(235, 40);
            this.button_RstChangePass.TabIndex = 0;
            this.button_RstChangePass.Text = "تغییر رمز بازیابی";
            this.button_RstChangePass.Click += new System.EventHandler(this.button_RstChangePass_Click);
            // 
            // groupBox_Bkp
            // 
            this.groupBox_Bkp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Bkp.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Bkp.Controls.Add(this.label_BkpAuto);
            this.groupBox_Bkp.Controls.Add(this.button_BkpAuto);
            this.groupBox_Bkp.Controls.Add(this.radioButton_BkpNo);
            this.groupBox_Bkp.Controls.Add(this.radioButton_BkpAuto);
            this.groupBox_Bkp.Controls.Add(this.radioButton_BkpNonAuto);
            this.groupBox_Bkp.Location = new System.Drawing.Point(21, 27);
            this.groupBox_Bkp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Bkp.Name = "groupBox_Bkp";
            this.groupBox_Bkp.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Bkp.Size = new System.Drawing.Size(590, 143);
            this.groupBox_Bkp.TabIndex = 14;
            this.groupBox_Bkp.TabStop = false;
            this.groupBox_Bkp.Text = "پشتیبانی";
            // 
            // label_BkpAuto
            // 
            this.label_BkpAuto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_BkpAuto.Location = new System.Drawing.Point(5, 13);
            this.label_BkpAuto.Name = "label_BkpAuto";
            this.label_BkpAuto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_BkpAuto.Size = new System.Drawing.Size(252, 60);
            this.label_BkpAuto.TabIndex = 6;
            this.label_BkpAuto.Text = "D:\\BackUpData";
            this.label_BkpAuto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_BkpAuto
            // 
            this.button_BkpAuto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_BkpAuto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_BkpAuto.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_BkpAuto.Location = new System.Drawing.Point(263, 32);
            this.button_BkpAuto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_BkpAuto.Name = "button_BkpAuto";
            this.button_BkpAuto.Size = new System.Drawing.Size(29, 21);
            this.button_BkpAuto.TabIndex = 5;
            this.button_BkpAuto.Text = "...";
            this.button_BkpAuto.Click += new System.EventHandler(this.button_BkpAuto_Click);
            // 
            // radioButton_BkpNo
            // 
            this.radioButton_BkpNo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButton_BkpNo.AutoSize = true;
            this.radioButton_BkpNo.Location = new System.Drawing.Point(511, 112);
            this.radioButton_BkpNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_BkpNo.Name = "radioButton_BkpNo";
            this.radioButton_BkpNo.Size = new System.Drawing.Size(63, 17);
            this.radioButton_BkpNo.TabIndex = 4;
            this.radioButton_BkpNo.Text = "هیچکدام";
            this.radioButton_BkpNo.UseVisualStyleBackColor = true;
            // 
            // radioButton_BkpAuto
            // 
            this.radioButton_BkpAuto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButton_BkpAuto.AutoSize = true;
            this.radioButton_BkpAuto.Checked = true;
            this.radioButton_BkpAuto.Location = new System.Drawing.Point(357, 33);
            this.radioButton_BkpAuto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_BkpAuto.Name = "radioButton_BkpAuto";
            this.radioButton_BkpAuto.Size = new System.Drawing.Size(217, 17);
            this.radioButton_BkpAuto.TabIndex = 3;
            this.radioButton_BkpAuto.TabStop = true;
            this.radioButton_BkpAuto.Text = "به صورت اتوماتیک گرفته شود            مسیر";
            this.radioButton_BkpAuto.UseVisualStyleBackColor = true;
            // 
            // radioButton_BkpNonAuto
            // 
            this.radioButton_BkpNonAuto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButton_BkpNonAuto.AutoSize = true;
            this.radioButton_BkpNonAuto.Location = new System.Drawing.Point(403, 72);
            this.radioButton_BkpNonAuto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton_BkpNonAuto.Name = "radioButton_BkpNonAuto";
            this.radioButton_BkpNonAuto.Size = new System.Drawing.Size(171, 17);
            this.radioButton_BkpNonAuto.TabIndex = 2;
            this.radioButton_BkpNonAuto.Text = "در هنگام خروج مسیر سوال شود";
            this.radioButton_BkpNonAuto.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(12, 258);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(608, 4);
            this.panel4.TabIndex = 13;
            // 
            // tabItem_SetBkpRst
            // 
            this.tabItem_SetBkpRst.AttachedControl = this.tabControlPanel_SetBkpRst;
            this.tabItem_SetBkpRst.Name = "tabItem_SetBkpRst";
            this.tabItem_SetBkpRst.Text = "tabItem_SetBkpRst";
            // 
            // tabControlPanel_SetPosDef
            // 
            this.tabControlPanel_SetPosDef.AutoScroll = true;
            this.tabControlPanel_SetPosDef.AutoScrollMinSize = new System.Drawing.Size(600, 400);
            this.tabControlPanel_SetPosDef.Controls.Add(this.groupPanel1);
            this.tabControlPanel_SetPosDef.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel_SetPosDef.Location = new System.Drawing.Point(0, 4);
            this.tabControlPanel_SetPosDef.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlPanel_SetPosDef.Name = "tabControlPanel_SetPosDef";
            this.tabControlPanel_SetPosDef.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel_SetPosDef.Size = new System.Drawing.Size(638, 449);
            this.tabControlPanel_SetPosDef.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.tabControlPanel_SetPosDef.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.tabControlPanel_SetPosDef.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel_SetPosDef.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.tabControlPanel_SetPosDef.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel_SetPosDef.Style.GradientAngle = 90;
            this.tabControlPanel_SetPosDef.TabIndex = 4;
            this.tabControlPanel_SetPosDef.TabItem = this.tabItem_SetPosDef;
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.label9);
            this.groupPanel1.Controls.Add(this.nUpDown_FreeKillometer);
            this.groupPanel1.Controls.Add(this.groupBox4);
            this.groupPanel1.Controls.Add(this.comboBox_CityLimit);
            this.groupPanel1.Controls.Add(this.label43);
            this.groupPanel1.Controls.Add(this.label12);
            this.groupPanel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.IsShadowEnabled = true;
            this.groupPanel1.Location = new System.Drawing.Point(46, 88);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(546, 272);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(161, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 346;
            this.label9.Text = "کیلومتر";
            // 
            // nUpDown_FreeKillometer
            // 
            this.nUpDown_FreeKillometer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nUpDown_FreeKillometer.ForeColor = System.Drawing.Color.Black;
            this.nUpDown_FreeKillometer.Location = new System.Drawing.Point(207, 206);
            this.nUpDown_FreeKillometer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nUpDown_FreeKillometer.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nUpDown_FreeKillometer.Name = "nUpDown_FreeKillometer";
            this.nUpDown_FreeKillometer.Size = new System.Drawing.Size(59, 21);
            this.nUpDown_FreeKillometer.TabIndex = 345;
            this.nUpDown_FreeKillometer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUpDown_FreeKillometer.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nUpDown_FreeKillometer.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.textBox_FineTime);
            this.groupBox4.Controls.Add(this.textBox_FineDay);
            this.groupBox4.Controls.Add(this.label42);
            this.groupBox4.Controls.Add(this.label37);
            this.groupBox4.Controls.Add(this.label_Mny3);
            this.groupBox4.Controls.Add(this.textBox_FineKillometer);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(6, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(531, 124);
            this.groupBox4.TabIndex = 343;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "جریمه به ازای هر";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(144, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 326;
            this.label5.Text = "ریال";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 325;
            this.label2.Text = "ریال";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_FineTime
            // 
            this.textBox_FineTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.textBox_FineTime.Border.Class = "TextBoxBorder";
            this.textBox_FineTime.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBox_FineTime.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox_FineTime.ForeColor = System.Drawing.Color.Black;
            this.textBox_FineTime.Location = new System.Drawing.Point(174, 57);
            this.textBox_FineTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_FineTime.MaxLength = 20;
            this.textBox_FineTime.Name = "textBox_FineTime";
            this.textBox_FineTime.Size = new System.Drawing.Size(165, 21);
            this.textBox_FineTime.TabIndex = 10;
            this.textBox_FineTime.Text = "0";
            this.textBox_FineTime.TextChanged += new System.EventHandler(this.textBox_Price_TextChanged);
            this.textBox_FineTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Price_KeyPress);
            // 
            // textBox_FineDay
            // 
            this.textBox_FineDay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.textBox_FineDay.Border.Class = "TextBoxBorder";
            this.textBox_FineDay.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBox_FineDay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox_FineDay.ForeColor = System.Drawing.Color.Black;
            this.textBox_FineDay.Location = new System.Drawing.Point(174, 90);
            this.textBox_FineDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_FineDay.MaxLength = 20;
            this.textBox_FineDay.Name = "textBox_FineDay";
            this.textBox_FineDay.Size = new System.Drawing.Size(165, 21);
            this.textBox_FineDay.TabIndex = 11;
            this.textBox_FineDay.Text = "0";
            this.textBox_FineDay.TextChanged += new System.EventHandler(this.textBox_Price_TextChanged);
            this.textBox_FineDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Price_KeyPress);
            // 
            // label42
            // 
            this.label42.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label42.ForeColor = System.Drawing.Color.Black;
            this.label42.Location = new System.Drawing.Point(343, 28);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(44, 13);
            this.label42.TabIndex = 324;
            this.label42.Text = "کیلومتر:";
            // 
            // label37
            // 
            this.label37.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label37.ForeColor = System.Drawing.Color.Black;
            this.label37.Location = new System.Drawing.Point(343, 94);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(24, 13);
            this.label37.TabIndex = 322;
            this.label37.Text = "روز:";
            // 
            // label_Mny3
            // 
            this.label_Mny3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Mny3.AutoSize = true;
            this.label_Mny3.BackColor = System.Drawing.Color.Transparent;
            this.label_Mny3.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Mny3.Location = new System.Drawing.Point(144, 28);
            this.label_Mny3.Name = "label_Mny3";
            this.label_Mny3.Size = new System.Drawing.Size(24, 13);
            this.label_Mny3.TabIndex = 316;
            this.label_Mny3.Text = "ریال";
            this.label_Mny3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_FineKillometer
            // 
            this.textBox_FineKillometer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.textBox_FineKillometer.Border.Class = "TextBoxBorder";
            this.textBox_FineKillometer.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBox_FineKillometer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox_FineKillometer.ForeColor = System.Drawing.Color.Black;
            this.textBox_FineKillometer.Location = new System.Drawing.Point(174, 24);
            this.textBox_FineKillometer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_FineKillometer.MaxLength = 20;
            this.textBox_FineKillometer.Name = "textBox_FineKillometer";
            this.textBox_FineKillometer.Size = new System.Drawing.Size(165, 21);
            this.textBox_FineKillometer.TabIndex = 12;
            this.textBox_FineKillometer.Text = "0";
            this.textBox_FineKillometer.TextChanged += new System.EventHandler(this.textBox_Price_TextChanged);
            this.textBox_FineKillometer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Price_KeyPress);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(343, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 312;
            this.label11.Text = "ساعت:";
            // 
            // comboBox_CityLimit
            // 
            this.comboBox_CityLimit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBox_CityLimit.DisplayMember = "CityName_Fa";
            this.comboBox_CityLimit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox_CityLimit.DropDownHeight = 100;
            this.comboBox_CityLimit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CityLimit.DropDownWidth = 150;
            this.comboBox_CityLimit.FocusHighlightEnabled = true;
            this.comboBox_CityLimit.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox_CityLimit.ForeColor = System.Drawing.Color.Black;
            this.comboBox_CityLimit.IntegralHeight = false;
            this.comboBox_CityLimit.ItemHeight = 20;
            this.comboBox_CityLimit.Location = new System.Drawing.Point(150, 163);
            this.comboBox_CityLimit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_CityLimit.Name = "comboBox_CityLimit";
            this.comboBox_CityLimit.PreventEnterBeep = true;
            this.comboBox_CityLimit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_CityLimit.Size = new System.Drawing.Size(116, 26);
            this.comboBox_CityLimit.TabIndex = 329;
            this.comboBox_CityLimit.Tag = "0";
            this.comboBox_CityLimit.ValueMember = "CityID";
            // 
            // label43
            // 
            this.label43.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.Transparent;
            this.label43.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.Black;
            this.label43.Location = new System.Drawing.Point(272, 170);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(111, 14);
            this.label43.TabIndex = 328;
            this.label43.Text = "محدوده تردد شهری:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(272, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 14);
            this.label12.TabIndex = 317;
            this.label12.Text = "حداکثر مسافت روزانه:";
            // 
            // tabItem_SetPosDef
            // 
            this.tabItem_SetPosDef.AttachedControl = this.tabControlPanel_SetPosDef;
            this.tabItem_SetPosDef.Name = "tabItem_SetPosDef";
            this.tabItem_SetPosDef.Text = "tabItem_SetPosDef";
            // 
            // tabControlPanel_SetUnits
            // 
            this.tabControlPanel_SetUnits.AutoScroll = true;
            this.tabControlPanel_SetUnits.AutoScrollMinSize = new System.Drawing.Size(600, 400);
            this.tabControlPanel_SetUnits.Controls.Add(this.groupPanel_HCLord);
            this.tabControlPanel_SetUnits.Controls.Add(this.groupPanel_HCCustomer);
            this.tabControlPanel_SetUnits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel_SetUnits.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlPanel_SetUnits.Location = new System.Drawing.Point(0, 4);
            this.tabControlPanel_SetUnits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlPanel_SetUnits.Name = "tabControlPanel_SetUnits";
            this.tabControlPanel_SetUnits.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel_SetUnits.Size = new System.Drawing.Size(638, 449);
            this.tabControlPanel_SetUnits.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.tabControlPanel_SetUnits.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(188)))), ((int)(((byte)(227)))));
            this.tabControlPanel_SetUnits.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel_SetUnits.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(165)))), ((int)(((byte)(199)))));
            this.tabControlPanel_SetUnits.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel_SetUnits.Style.GradientAngle = 90;
            this.tabControlPanel_SetUnits.TabIndex = 1;
            this.tabControlPanel_SetUnits.TabItem = this.tabItem_SetUnits;
            // 
            // groupPanel_HCLord
            // 
            this.groupPanel_HCLord.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel_HCLord.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel_HCLord.Controls.Add(this.textBox_EMail);
            this.groupPanel_HCLord.Controls.Add(this.textBox_mobile);
            this.groupPanel_HCLord.Controls.Add(this.label_LMelliCode);
            this.groupPanel_HCLord.Controls.Add(this.label_LFatherN);
            this.groupPanel_HCLord.Controls.Add(this.textBox_Tel);
            this.groupPanel_HCLord.Controls.Add(this.label_LName);
            this.groupPanel_HCLord.Controls.Add(this.textBox_Address);
            this.groupPanel_HCLord.Controls.Add(this.label_LFamily);
            this.groupPanel_HCLord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel_HCLord.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel_HCLord.IsShadowEnabled = true;
            this.groupPanel_HCLord.Location = new System.Drawing.Point(1, 250);
            this.groupPanel_HCLord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPanel_HCLord.Name = "groupPanel_HCLord";
            this.groupPanel_HCLord.Size = new System.Drawing.Size(636, 198);
            // 
            // 
            // 
            this.groupPanel_HCLord.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel_HCLord.Style.BackColorGradientAngle = 90;
            this.groupPanel_HCLord.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel_HCLord.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_HCLord.Style.BorderBottomWidth = 1;
            this.groupPanel_HCLord.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel_HCLord.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_HCLord.Style.BorderLeftWidth = 1;
            this.groupPanel_HCLord.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_HCLord.Style.BorderRightWidth = 1;
            this.groupPanel_HCLord.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_HCLord.Style.BorderTopWidth = 1;
            this.groupPanel_HCLord.Style.CornerDiameter = 4;
            this.groupPanel_HCLord.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel_HCLord.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel_HCLord.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel_HCLord.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel_HCLord.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel_HCLord.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel_HCLord.TabIndex = 2;
            this.groupPanel_HCLord.Text = "سایر";
            // 
            // textBox_EMail
            // 
            this.textBox_EMail.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.textBox_EMail.Border.Class = "TextBoxBorder";
            this.textBox_EMail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBox_EMail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox_EMail.ForeColor = System.Drawing.Color.Black;
            this.textBox_EMail.Location = new System.Drawing.Point(309, 143);
            this.textBox_EMail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_EMail.MaxLength = 20;
            this.textBox_EMail.Name = "textBox_EMail";
            this.textBox_EMail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_EMail.Size = new System.Drawing.Size(253, 21);
            this.textBox_EMail.TabIndex = 3;
            // 
            // textBox_mobile
            // 
            this.textBox_mobile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.textBox_mobile.Border.Class = "TextBoxBorder";
            this.textBox_mobile.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBox_mobile.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox_mobile.ForeColor = System.Drawing.Color.Black;
            this.textBox_mobile.Location = new System.Drawing.Point(20, 111);
            this.textBox_mobile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_mobile.MaxLength = 20;
            this.textBox_mobile.Name = "textBox_mobile";
            this.textBox_mobile.Size = new System.Drawing.Size(211, 21);
            this.textBox_mobile.TabIndex = 2;
            // 
            // label_LMelliCode
            // 
            this.label_LMelliCode.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_LMelliCode.AutoSize = true;
            this.label_LMelliCode.BackColor = System.Drawing.Color.Transparent;
            this.label_LMelliCode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_LMelliCode.ForeColor = System.Drawing.Color.Black;
            this.label_LMelliCode.Location = new System.Drawing.Point(566, 149);
            this.label_LMelliCode.Name = "label_LMelliCode";
            this.label_LMelliCode.Size = new System.Drawing.Size(35, 13);
            this.label_LMelliCode.TabIndex = 39;
            this.label_LMelliCode.Text = "email:";
            // 
            // label_LFatherN
            // 
            this.label_LFatherN.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_LFatherN.AutoSize = true;
            this.label_LFatherN.BackColor = System.Drawing.Color.Transparent;
            this.label_LFatherN.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_LFatherN.ForeColor = System.Drawing.Color.Black;
            this.label_LFatherN.Location = new System.Drawing.Point(237, 116);
            this.label_LFatherN.Name = "label_LFatherN";
            this.label_LFatherN.Size = new System.Drawing.Size(45, 13);
            this.label_LFatherN.TabIndex = 37;
            this.label_LFatherN.Text = "*موبایل:";
            // 
            // textBox_Tel
            // 
            this.textBox_Tel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            // 
            // 
            // 
            this.textBox_Tel.Border.Class = "TextBoxBorder";
            this.textBox_Tel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBox_Tel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox_Tel.ForeColor = System.Drawing.Color.Black;
            this.textBox_Tel.Location = new System.Drawing.Point(309, 111);
            this.textBox_Tel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Tel.MaxLength = 20;
            this.textBox_Tel.Name = "textBox_Tel";
            this.textBox_Tel.Size = new System.Drawing.Size(253, 21);
            this.textBox_Tel.TabIndex = 1;
            // 
            // label_LName
            // 
            this.label_LName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_LName.AutoSize = true;
            this.label_LName.BackColor = System.Drawing.Color.Transparent;
            this.label_LName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_LName.ForeColor = System.Drawing.Color.Black;
            this.label_LName.Location = new System.Drawing.Point(566, 7);
            this.label_LName.Name = "label_LName";
            this.label_LName.Size = new System.Drawing.Size(36, 13);
            this.label_LName.TabIndex = 35;
            this.label_LName.Text = "آدرس:";
            // 
            // textBox_Address
            // 
            this.textBox_Address.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBox_Address.Border.Class = "TextBoxBorder";
            this.textBox_Address.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBox_Address.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox_Address.ForeColor = System.Drawing.Color.Black;
            this.textBox_Address.Location = new System.Drawing.Point(19, 4);
            this.textBox_Address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Address.MaxLength = 0;
            this.textBox_Address.Multiline = true;
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Address.Size = new System.Drawing.Size(543, 96);
            this.textBox_Address.TabIndex = 0;
            // 
            // label_LFamily
            // 
            this.label_LFamily.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_LFamily.AutoSize = true;
            this.label_LFamily.BackColor = System.Drawing.Color.Transparent;
            this.label_LFamily.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_LFamily.ForeColor = System.Drawing.Color.Black;
            this.label_LFamily.Location = new System.Drawing.Point(566, 116);
            this.label_LFamily.Name = "label_LFamily";
            this.label_LFamily.Size = new System.Drawing.Size(46, 13);
            this.label_LFamily.TabIndex = 33;
            this.label_LFamily.Text = "تلفن ها:";
            // 
            // groupPanel_HCCustomer
            // 
            this.groupPanel_HCCustomer.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel_HCCustomer.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel_HCCustomer.Controls.Add(this.button_DelPic);
            this.groupPanel_HCCustomer.Controls.Add(this.pictureBoxCarPic);
            this.groupPanel_HCCustomer.Controls.Add(this.label23);
            this.groupPanel_HCCustomer.Controls.Add(this.ComboBoxBrithCityName);
            this.groupPanel_HCCustomer.Controls.Add(this.panel_BrithDate);
            this.groupPanel_HCCustomer.Controls.Add(this.textBox_CNationalCode);
            this.groupPanel_HCCustomer.Controls.Add(this.textBox_CParentN);
            this.groupPanel_HCCustomer.Controls.Add(this.label4);
            this.groupPanel_HCCustomer.Controls.Add(this.label_CMelliCode);
            this.groupPanel_HCCustomer.Controls.Add(this.label_CFatherN);
            this.groupPanel_HCCustomer.Controls.Add(this.textBox_CIDNO);
            this.groupPanel_HCCustomer.Controls.Add(this.label7);
            this.groupPanel_HCCustomer.Controls.Add(this.label_CName);
            this.groupPanel_HCCustomer.Controls.Add(this.textBox_CName);
            this.groupPanel_HCCustomer.Controls.Add(this.textBox_CoName);
            this.groupPanel_HCCustomer.Controls.Add(this.label6);
            this.groupPanel_HCCustomer.Controls.Add(this.label_CFamily);
            this.groupPanel_HCCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel_HCCustomer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel_HCCustomer.IsShadowEnabled = true;
            this.groupPanel_HCCustomer.Location = new System.Drawing.Point(1, 1);
            this.groupPanel_HCCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPanel_HCCustomer.Name = "groupPanel_HCCustomer";
            this.groupPanel_HCCustomer.Size = new System.Drawing.Size(636, 249);
            // 
            // 
            // 
            this.groupPanel_HCCustomer.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel_HCCustomer.Style.BackColorGradientAngle = 90;
            this.groupPanel_HCCustomer.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel_HCCustomer.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_HCCustomer.Style.BorderBottomWidth = 1;
            this.groupPanel_HCCustomer.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel_HCCustomer.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_HCCustomer.Style.BorderLeftWidth = 1;
            this.groupPanel_HCCustomer.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_HCCustomer.Style.BorderRightWidth = 1;
            this.groupPanel_HCCustomer.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_HCCustomer.Style.BorderTopWidth = 1;
            this.groupPanel_HCCustomer.Style.CornerDiameter = 4;
            this.groupPanel_HCCustomer.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel_HCCustomer.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel_HCCustomer.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel_HCCustomer.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel_HCCustomer.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel_HCCustomer.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel_HCCustomer.TabIndex = 1;
            this.groupPanel_HCCustomer.Text = "مشخصات سجلی";
            // 
            // button_DelPic
            // 
            this.button_DelPic.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_DelPic.BackColor = System.Drawing.Color.RosyBrown;
            this.button_DelPic.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_DelPic.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button_DelPic.Image = ((System.Drawing.Image)(resources.GetObject("button_DelPic.Image")));
            this.button_DelPic.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.button_DelPic.Location = new System.Drawing.Point(151, 160);
            this.button_DelPic.Name = "button_DelPic";
            this.button_DelPic.Size = new System.Drawing.Size(23, 24);
            this.button_DelPic.TabIndex = 50;
            this.button_DelPic.Tooltip = "حذف";
            this.button_DelPic.Click += new System.EventHandler(this.button_DelPic_Click);
            // 
            // pictureBoxCarPic
            // 
            this.pictureBoxCarPic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBoxCarPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCarPic.ErrorImage = null;
            this.pictureBoxCarPic.InitialImage = null;
            this.pictureBoxCarPic.Location = new System.Drawing.Point(23, 126);
            this.pictureBoxCarPic.Name = "pictureBoxCarPic";
            this.pictureBoxCarPic.Size = new System.Drawing.Size(121, 63);
            this.pictureBoxCarPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCarPic.TabIndex = 49;
            this.pictureBoxCarPic.TabStop = false;
            this.pictureBoxCarPic.Click += new System.EventHandler(this.pictureBoxCarPic_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(151, 133);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(73, 13);
            this.label23.TabIndex = 48;
            this.label23.Text = "لوگوی شرکت:";
            // 
            // ComboBoxBrithCityName
            // 
            this.ComboBoxBrithCityName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ComboBoxBrithCityName.DisplayMember = "CityName_Fa";
            this.ComboBoxBrithCityName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxBrithCityName.DropDownWidth = 120;
            this.ComboBoxBrithCityName.FocusHighlightColor = System.Drawing.Color.Empty;
            this.ComboBoxBrithCityName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ComboBoxBrithCityName.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxBrithCityName.IntegralHeight = false;
            this.ComboBoxBrithCityName.ItemHeight = 15;
            this.ComboBoxBrithCityName.Location = new System.Drawing.Point(247, 194);
            this.ComboBoxBrithCityName.Name = "ComboBoxBrithCityName";
            this.ComboBoxBrithCityName.Size = new System.Drawing.Size(167, 21);
            this.ComboBoxBrithCityName.TabIndex = 6;
            this.ComboBoxBrithCityName.Tag = "0";
            this.ComboBoxBrithCityName.ValueMember = "CityID";
            // 
            // panel_BrithDate
            // 
            this.panel_BrithDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_BrithDate.BackColor = System.Drawing.Color.Transparent;
            this.panel_BrithDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_BrithDate.Controls.Add(this.label1);
            this.panel_BrithDate.Controls.Add(this.label3);
            this.panel_BrithDate.Controls.Add(this.comboBox_YearBD);
            this.panel_BrithDate.Controls.Add(this.comboBox_DayBD);
            this.panel_BrithDate.Controls.Add(this.comboBox_MonthBD);
            this.panel_BrithDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panel_BrithDate.Location = new System.Drawing.Point(244, 160);
            this.panel_BrithDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_BrithDate.Name = "panel_BrithDate";
            this.panel_BrithDate.Size = new System.Drawing.Size(170, 29);
            this.panel_BrithDate.TabIndex = 5;
            this.panel_BrithDate.Leave += new System.EventHandler(this.panel_BrithDate_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(115, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "/";
            // 
            // comboBox_YearBD
            // 
            this.comboBox_YearBD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_YearBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_YearBD.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox_YearBD.ForeColor = System.Drawing.Color.Black;
            this.comboBox_YearBD.IntegralHeight = false;
            this.comboBox_YearBD.Items.AddRange(new object[] {
            "1320",
            "1321",
            "1322",
            "1323",
            "1324",
            "1325",
            "1326",
            "1327",
            "1328",
            "1329",
            "1330",
            "1331",
            "1332",
            "1333",
            "1334",
            "1335",
            "1336",
            "1337",
            "1338",
            "1339",
            "1340",
            "1341",
            "1342",
            "1343",
            "1344",
            "1345",
            "1346",
            "1347",
            "1348",
            "1349",
            "1350",
            "1351",
            "1352",
            "1353",
            "1354",
            "1355",
            "1356",
            "1357",
            "1358",
            "1359",
            "1360",
            "1361",
            "1362",
            "1363",
            "1364",
            "1365",
            "1366",
            "1367",
            "1368",
            "1369",
            "1370",
            "1371",
            "1372",
            "1373",
            "1374",
            "1375",
            "1376",
            "1377",
            "1378",
            "1379",
            "1380",
            "1381",
            "1382",
            "1383",
            "1384",
            "1385",
            "1386",
            "1387",
            "1388",
            "1389",
            "1390",
            "1391",
            "1392",
            "1393",
            "1394",
            "1395",
            "1396",
            "1397",
            "1398",
            "1399",
            "1400"});
            this.comboBox_YearBD.Location = new System.Drawing.Point(3, 2);
            this.comboBox_YearBD.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboBox_YearBD.Name = "comboBox_YearBD";
            this.comboBox_YearBD.Size = new System.Drawing.Size(60, 21);
            this.comboBox_YearBD.TabIndex = 2;
            // 
            // comboBox_DayBD
            // 
            this.comboBox_DayBD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_DayBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_DayBD.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox_DayBD.ForeColor = System.Drawing.Color.Black;
            this.comboBox_DayBD.IntegralHeight = false;
            this.comboBox_DayBD.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBox_DayBD.Location = new System.Drawing.Point(127, 2);
            this.comboBox_DayBD.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboBox_DayBD.Name = "comboBox_DayBD";
            this.comboBox_DayBD.Size = new System.Drawing.Size(39, 21);
            this.comboBox_DayBD.TabIndex = 0;
            // 
            // comboBox_MonthBD
            // 
            this.comboBox_MonthBD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_MonthBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_MonthBD.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox_MonthBD.ForeColor = System.Drawing.Color.Black;
            this.comboBox_MonthBD.IntegralHeight = false;
            this.comboBox_MonthBD.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox_MonthBD.Location = new System.Drawing.Point(74, 2);
            this.comboBox_MonthBD.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboBox_MonthBD.Name = "comboBox_MonthBD";
            this.comboBox_MonthBD.Size = new System.Drawing.Size(41, 21);
            this.comboBox_MonthBD.TabIndex = 1;
            // 
            // textBox_CNationalCode
            // 
            this.textBox_CNationalCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.textBox_CNationalCode.Border.Class = "TextBoxBorder";
            this.textBox_CNationalCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBox_CNationalCode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox_CNationalCode.ForeColor = System.Drawing.Color.Black;
            this.textBox_CNationalCode.Location = new System.Drawing.Point(247, 38);
            this.textBox_CNationalCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_CNationalCode.MaxLength = 10;
            this.textBox_CNationalCode.Name = "textBox_CNationalCode";
            this.textBox_CNationalCode.Size = new System.Drawing.Size(167, 21);
            this.textBox_CNationalCode.TabIndex = 1;
            // 
            // textBox_CParentN
            // 
            this.textBox_CParentN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.textBox_CParentN.Border.Class = "TextBoxBorder";
            this.textBox_CParentN.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBox_CParentN.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox_CParentN.ForeColor = System.Drawing.Color.Black;
            this.textBox_CParentN.Location = new System.Drawing.Point(247, 131);
            this.textBox_CParentN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_CParentN.MaxLength = 50;
            this.textBox_CParentN.Name = "textBox_CParentN";
            this.textBox_CParentN.Size = new System.Drawing.Size(167, 21);
            this.textBox_CParentN.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(420, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "صادره از/محل فعالیت:";
            // 
            // label_CMelliCode
            // 
            this.label_CMelliCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_CMelliCode.AutoSize = true;
            this.label_CMelliCode.BackColor = System.Drawing.Color.Transparent;
            this.label_CMelliCode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_CMelliCode.ForeColor = System.Drawing.Color.Black;
            this.label_CMelliCode.Location = new System.Drawing.Point(420, 43);
            this.label_CMelliCode.Name = "label_CMelliCode";
            this.label_CMelliCode.Size = new System.Drawing.Size(67, 13);
            this.label_CMelliCode.TabIndex = 47;
            this.label_CMelliCode.Text = "*شماره ثبت:";
            // 
            // label_CFatherN
            // 
            this.label_CFatherN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_CFatherN.AutoSize = true;
            this.label_CFatherN.BackColor = System.Drawing.Color.Transparent;
            this.label_CFatherN.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_CFatherN.ForeColor = System.Drawing.Color.Black;
            this.label_CFatherN.Location = new System.Drawing.Point(420, 136);
            this.label_CFatherN.Name = "label_CFatherN";
            this.label_CFatherN.Size = new System.Drawing.Size(40, 13);
            this.label_CFatherN.TabIndex = 46;
            this.label_CFatherN.Text = "نام پدر:";
            // 
            // textBox_CIDNO
            // 
            this.textBox_CIDNO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.textBox_CIDNO.Border.Class = "TextBoxBorder";
            this.textBox_CIDNO.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBox_CIDNO.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox_CIDNO.ForeColor = System.Drawing.Color.Black;
            this.textBox_CIDNO.Location = new System.Drawing.Point(247, 102);
            this.textBox_CIDNO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_CIDNO.MaxLength = 20;
            this.textBox_CIDNO.Name = "textBox_CIDNO";
            this.textBox_CIDNO.Size = new System.Drawing.Size(167, 21);
            this.textBox_CIDNO.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(420, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "*نام و نام خانوادگی مدیریت:";
            // 
            // label_CName
            // 
            this.label_CName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_CName.AutoSize = true;
            this.label_CName.BackColor = System.Drawing.Color.Transparent;
            this.label_CName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_CName.ForeColor = System.Drawing.Color.Black;
            this.label_CName.Location = new System.Drawing.Point(420, 12);
            this.label_CName.Name = "label_CName";
            this.label_CName.Size = new System.Drawing.Size(67, 13);
            this.label_CName.TabIndex = 44;
            this.label_CName.Text = "*نام  شرکت:";
            // 
            // textBox_CName
            // 
            this.textBox_CName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.textBox_CName.Border.Class = "TextBoxBorder";
            this.textBox_CName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBox_CName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox_CName.ForeColor = System.Drawing.Color.Black;
            this.textBox_CName.Location = new System.Drawing.Point(58, 70);
            this.textBox_CName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_CName.MaxLength = 50;
            this.textBox_CName.Name = "textBox_CName";
            this.textBox_CName.Size = new System.Drawing.Size(356, 21);
            this.textBox_CName.TabIndex = 2;
            // 
            // textBox_CoName
            // 
            this.textBox_CoName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.textBox_CoName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBox_CoName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox_CoName.ForeColor = System.Drawing.Color.Black;
            this.textBox_CoName.Location = new System.Drawing.Point(58, 9);
            this.textBox_CoName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_CoName.MaxLength = 50;
            this.textBox_CoName.Name = "textBox_CoName";
            this.textBox_CoName.Size = new System.Drawing.Size(356, 21);
            this.textBox_CoName.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(420, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "تاریخ تولد/تاسیس:";
            // 
            // label_CFamily
            // 
            this.label_CFamily.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_CFamily.AutoSize = true;
            this.label_CFamily.BackColor = System.Drawing.Color.Transparent;
            this.label_CFamily.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_CFamily.ForeColor = System.Drawing.Color.Black;
            this.label_CFamily.Location = new System.Drawing.Point(420, 105);
            this.label_CFamily.Name = "label_CFamily";
            this.label_CFamily.Size = new System.Drawing.Size(137, 13);
            this.label_CFamily.TabIndex = 43;
            this.label_CFamily.Text = "کد ملی / شماره شناسنامه:";
            // 
            // tabItem_SetUnits
            // 
            this.tabItem_SetUnits.AttachedControl = this.tabControlPanel_SetUnits;
            this.tabItem_SetUnits.Name = "tabItem_SetUnits";
            this.tabItem_SetUnits.Text = "tabItem_SetUnits";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Controls.Add(this.textBoxInitSMSMessage);
            this.groupBox1.Controls.Add(this.label39);
            this.groupBox1.Location = new System.Drawing.Point(29, 341);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 94);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "متن اس ام اس";
            // 
            // textBoxInitSMSMessage
            // 
            // 
            // 
            // 
            this.textBoxInitSMSMessage.Border.Class = "TextBoxBorder";
            this.textBoxInitSMSMessage.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxInitSMSMessage.Location = new System.Drawing.Point(30, 20);
            this.textBoxInitSMSMessage.Multiline = true;
            this.textBoxInitSMSMessage.Name = "textBoxInitSMSMessage";
            this.textBoxInitSMSMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInitSMSMessage.Size = new System.Drawing.Size(474, 47);
            this.textBoxInitSMSMessage.TabIndex = 25;
            this.textBoxInitSMSMessage.Text = "قرارداد شماره {0} در تاریخ {2} ثبت گردید. با تشکر از شما. شرکت {1}";
            // 
            // label39
            // 
            this.label39.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(510, 22);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(30, 14);
            this.label39.TabIndex = 24;
            this.label39.Text = "متن:";
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(9, 73);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(565, 13);
            this.label31.TabIndex = 26;
            this.label31.Text = "توجه: به جای شماره قرارداد {0}، نام شرکت {1}، تاریخ شروع سرویس {2} و تاریخ عودت {" +
                "3} استفاده شود";
            // 
            // Setting_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 515);
            this.Controls.Add(this.tabControl_Setting);
            this.Controls.Add(this.treeView_Setting);
            this.Controls.Add(this.ribbonBar_Setting);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Setting_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تنظیمات";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Setting_frm_FormClosing);
            this.Load += new System.EventHandler(this.Setting_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl_Setting)).EndInit();
            this.tabControl_Setting.ResumeLayout(false);
            this.tabControlPanel_SMS.ResumeLayout(false);
            this.tabControlPanel_SMS.PerformLayout();
            this.groupBox_IntSMS.ResumeLayout(false);
            this.groupBox_IntSMS.PerformLayout();
            this.groupPanel_SMS.ResumeLayout(false);
            this.groupPanel_SMS.PerformLayout();
            this.tabControlPanel_SetAlarms.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownExpDayBodyInsu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownExpKMService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownExpDayThirdInsu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownExpDayCarDuty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownExpDayCarEnter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownGetFinePeriod)).EndInit();
            this.tabControlPanel_SetBkpRst.ResumeLayout(false);
            this.groupBox_Set.ResumeLayout(false);
            this.groupBox_Set.PerformLayout();
            this.groupBox_Rst.ResumeLayout(false);
            this.groupBox_Bkp.ResumeLayout(false);
            this.groupBox_Bkp.PerformLayout();
            this.tabControlPanel_SetPosDef.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDown_FreeKillometer)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControlPanel_SetUnits.ResumeLayout(false);
            this.groupPanel_HCLord.ResumeLayout(false);
            this.groupPanel_HCLord.PerformLayout();
            this.groupPanel_HCCustomer.ResumeLayout(false);
            this.groupPanel_HCCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarPic)).EndInit();
            this.panel_BrithDate.ResumeLayout(false);
            this.panel_BrithDate.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonBar ribbonBar_Setting;
        private DevComponents.DotNetBar.ButtonItem buttonItem_OK;
        private DevComponents.DotNetBar.ButtonItem buttonItem_Cancel;
        private System.Windows.Forms.ImageList imageList_Setting;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel_SetUnits;
        private DevComponents.DotNetBar.TabItem tabItem_SetUnits;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel_SetPosDef;
        private DevComponents.DotNetBar.TabItem tabItem_SetPosDef;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel_SetBkpRst;
        private DevComponents.DotNetBar.TabItem tabItem_SetBkpRst;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel_SetAlarms;
        private DevComponents.DotNetBar.TabItem tabItem_SetAlarms;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nUpDownGetFinePeriod;
        private System.Windows.Forms.GroupBox groupBox_Rst;
        private DevComponents.DotNetBar.ButtonX button_RstChangePass;
        private System.Windows.Forms.GroupBox groupBox_Bkp;
        private System.Windows.Forms.Label label_BkpAuto;
        private DevComponents.DotNetBar.ButtonX button_BkpAuto;
        private System.Windows.Forms.RadioButton radioButton_BkpNo;
        private System.Windows.Forms.RadioButton radioButton_BkpAuto;
        private System.Windows.Forms.RadioButton radioButton_BkpNonAuto;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TreeView treeView_Setting;
        private DevComponents.DotNetBar.TabControl tabControl_Setting;
        private System.Windows.Forms.GroupBox groupBox_Set;
        private System.Windows.Forms.CheckBox checkBox_BRPicFilm;
        private System.Windows.Forms.CheckBox checkBox_BRDesignRep;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label_Mny3;
        private System.Windows.Forms.Label label43;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_CityLimit;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown nUpDownExpKMService;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown nUpDownExpDayThirdInsu;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown nUpDownExpDayCarDuty;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nUpDownExpDayCarEnter;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.NumericUpDown nUpDownExpDayBodyInsu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_FineTime;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_FineDay;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label37;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_FineKillometer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nUpDown_FreeKillometer;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel_HCLord;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_EMail;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_mobile;
        private System.Windows.Forms.Label label_LMelliCode;
        private System.Windows.Forms.Label label_LFatherN;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_Tel;
        private System.Windows.Forms.Label label_LName;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_Address;
        private System.Windows.Forms.Label label_LFamily;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel_HCCustomer;
        private DevComponents.DotNetBar.Controls.ComboBoxEx ComboBoxBrithCityName;
        private System.Windows.Forms.Panel panel_BrithDate;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_YearBD;
        private System.Windows.Forms.ComboBox comboBox_DayBD;
        private System.Windows.Forms.ComboBox comboBox_MonthBD;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_CNationalCode;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_CParentN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_CMelliCode;
        private System.Windows.Forms.Label label_CFatherN;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_CIDNO;
        private System.Windows.Forms.Label label_CName;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_CoName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_CFamily;
        private System.Windows.Forms.Label label7;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_CName;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel_SMS;
        private DevComponents.DotNetBar.TabItem tabItem_SMS;
        private System.Windows.Forms.GroupBox groupPanel_SMS;
        private System.Windows.Forms.CheckBox chkDeliveryReport;
        private System.Windows.Forms.CheckBox chkunicode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbLongMsg;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.ComboBox cmbEncoding;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.ComboBox cmbFlowControl;
        private System.Windows.Forms.ComboBox cmbStopBits;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.ComboBox cmbDataBits;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.ComboBox cmbTimeOut;
        private System.Windows.Forms.Label label22;
        private DevComponents.DotNetBar.ButtonX button_DelPic;
        private System.Windows.Forms.PictureBox pictureBoxCarPic;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox_IntSMS;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxPassword;
        private System.Windows.Forms.Label label27;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxUserName;
        private System.Windows.Forms.Label label26;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxTelNumber;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.RadioButton radioButtonGSM;
        private System.Windows.Forms.RadioButton radioButtonInternet;
        private DevComponents.DotNetBar.ButtonX buttonTestCredit;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxInitSMSMessage;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label31;
    }
}