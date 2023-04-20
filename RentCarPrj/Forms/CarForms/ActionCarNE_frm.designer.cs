namespace RentCarPrj
{
    partial class ActionCarNE_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActionCarNE_frm));
            this.ribbonBar_Cnclu = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem_OK = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem_Cancel = new DevComponents.DotNetBar.ButtonItem();
            this.groupPanel_Type = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.comboBoxActionType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_ActionDate = new System.Windows.Forms.Panel();
            this.label_Date2 = new System.Windows.Forms.Label();
            this.label_Date1 = new System.Windows.Forms.Label();
            this.comboBox_Year1 = new System.Windows.Forms.ComboBox();
            this.comboBox_day1 = new System.Windows.Forms.ComboBox();
            this.comboBox_Month1 = new System.Windows.Forms.ComboBox();
            this.label_Date = new System.Windows.Forms.Label();
            this.textBox_TelPlace = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label_LName = new System.Windows.Forms.Label();
            this.textBox_ActionDsc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label_LFamily = new System.Windows.Forms.Label();
            this.groupPanel_Full = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.ComboBox_ProductUse = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.ComboBox_ActionPlace = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.textBox_AlarmKM = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_NowKM = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label_CMelliCode = new System.Windows.Forms.Label();
            this.label_CFatherN = new System.Windows.Forms.Label();
            this.textBox_NextKM = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label_CName = new System.Windows.Forms.Label();
            this.label_CFamily = new System.Windows.Forms.Label();
            this.groupPanel_Type.SuspendLayout();
            this.panel_ActionDate.SuspendLayout();
            this.groupPanel_Full.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonBar_Cnclu
            // 
            this.ribbonBar_Cnclu.AutoOverflowEnabled = true;
            this.ribbonBar_Cnclu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ribbonBar_Cnclu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ribbonBar_Cnclu.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem_OK,
            this.buttonItem_Cancel});
            this.ribbonBar_Cnclu.Location = new System.Drawing.Point(0, 278);
            this.ribbonBar_Cnclu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonBar_Cnclu.Name = "ribbonBar_Cnclu";
            this.ribbonBar_Cnclu.Size = new System.Drawing.Size(694, 66);
            this.ribbonBar_Cnclu.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.ribbonBar_Cnclu.TabIndex = 5;
            this.ribbonBar_Cnclu.TitleVisible = false;
            // 
            // buttonItem_OK
            // 
            this.buttonItem_OK.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem_OK.FixedSize = new System.Drawing.Size(160, 60);
            this.buttonItem_OK.HotFontBold = true;
            this.buttonItem_OK.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem_OK.Image")));
            this.buttonItem_OK.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.NotSet;
            this.buttonItem_OK.ImagePaddingHorizontal = 20;
            this.buttonItem_OK.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem_OK.Name = "buttonItem_OK";
            this.buttonItem_OK.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F2);
            this.buttonItem_OK.SubItemsExpandWidth = 20;
            this.buttonItem_OK.Text = "تایید و بسته شدن";
            this.buttonItem_OK.Click += new System.EventHandler(this.buttonItem_OK_Click);
            // 
            // buttonItem_Cancel
            // 
            this.buttonItem_Cancel.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem_Cancel.FixedSize = new System.Drawing.Size(80, 60);
            this.buttonItem_Cancel.HotFontBold = true;
            this.buttonItem_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem_Cancel.Image")));
            this.buttonItem_Cancel.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.NotSet;
            this.buttonItem_Cancel.ImagePaddingHorizontal = 20;
            this.buttonItem_Cancel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem_Cancel.Name = "buttonItem_Cancel";
            this.buttonItem_Cancel.SubItemsExpandWidth = 14;
            this.buttonItem_Cancel.Text = "انصراف";
            this.buttonItem_Cancel.Click += new System.EventHandler(this.buttonItem_Cancel_Click);
            // 
            // groupPanel_Type
            // 
            this.groupPanel_Type.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel_Type.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel_Type.Controls.Add(this.comboBoxActionType);
            this.groupPanel_Type.Controls.Add(this.label5);
            this.groupPanel_Type.Controls.Add(this.panel_ActionDate);
            this.groupPanel_Type.Controls.Add(this.label_Date);
            this.groupPanel_Type.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel_Type.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupPanel_Type.IsShadowEnabled = true;
            this.groupPanel_Type.Location = new System.Drawing.Point(0, 0);
            this.groupPanel_Type.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPanel_Type.Name = "groupPanel_Type";
            this.groupPanel_Type.Size = new System.Drawing.Size(694, 53);
            // 
            // 
            // 
            this.groupPanel_Type.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel_Type.Style.BackColorGradientAngle = 90;
            this.groupPanel_Type.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel_Type.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_Type.Style.BorderBottomWidth = 1;
            this.groupPanel_Type.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel_Type.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_Type.Style.BorderLeftWidth = 1;
            this.groupPanel_Type.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_Type.Style.BorderRightWidth = 1;
            this.groupPanel_Type.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_Type.Style.BorderTopWidth = 1;
            this.groupPanel_Type.Style.CornerDiameter = 4;
            this.groupPanel_Type.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel_Type.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel_Type.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel_Type.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel_Type.TabIndex = 0;
            this.groupPanel_Type.Text = "نوع";
            // 
            // comboBoxActionType
            // 
            this.comboBoxActionType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxActionType.DisplayMember = "Text";
            this.comboBoxActionType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxActionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxActionType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBoxActionType.ItemHeight = 15;
            this.comboBoxActionType.Location = new System.Drawing.Point(389, 2);
            this.comboBoxActionType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxActionType.Name = "comboBoxActionType";
            this.comboBoxActionType.Size = new System.Drawing.Size(167, 21);
            this.comboBoxActionType.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(560, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "نوع سرویس / عملیات:";
            // 
            // panel_ActionDate
            // 
            this.panel_ActionDate.BackColor = System.Drawing.Color.Transparent;
            this.panel_ActionDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ActionDate.Controls.Add(this.label_Date2);
            this.panel_ActionDate.Controls.Add(this.label_Date1);
            this.panel_ActionDate.Controls.Add(this.comboBox_Year1);
            this.panel_ActionDate.Controls.Add(this.comboBox_day1);
            this.panel_ActionDate.Controls.Add(this.comboBox_Month1);
            this.panel_ActionDate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panel_ActionDate.Location = new System.Drawing.Point(17, 0);
            this.panel_ActionDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_ActionDate.Name = "panel_ActionDate";
            this.panel_ActionDate.Size = new System.Drawing.Size(170, 29);
            this.panel_ActionDate.TabIndex = 1;
            this.panel_ActionDate.Leave += new System.EventHandler(this.panel_ActionDate_Leave);
            // 
            // label_Date2
            // 
            this.label_Date2.AutoSize = true;
            this.label_Date2.Location = new System.Drawing.Point(64, 5);
            this.label_Date2.Name = "label_Date2";
            this.label_Date2.Size = new System.Drawing.Size(11, 13);
            this.label_Date2.TabIndex = 17;
            this.label_Date2.Text = "/";
            // 
            // label_Date1
            // 
            this.label_Date1.AutoSize = true;
            this.label_Date1.BackColor = System.Drawing.Color.Transparent;
            this.label_Date1.Location = new System.Drawing.Point(115, 5);
            this.label_Date1.Name = "label_Date1";
            this.label_Date1.Size = new System.Drawing.Size(11, 13);
            this.label_Date1.TabIndex = 16;
            this.label_Date1.Text = "/";
            // 
            // comboBox_Year1
            // 
            this.comboBox_Year1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Year1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Year1.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox_Year1.ForeColor = System.Drawing.Color.Black;
            this.comboBox_Year1.IntegralHeight = false;
            this.comboBox_Year1.Items.AddRange(new object[] {
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
            this.comboBox_Year1.Location = new System.Drawing.Point(3, 2);
            this.comboBox_Year1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboBox_Year1.Name = "comboBox_Year1";
            this.comboBox_Year1.Size = new System.Drawing.Size(60, 21);
            this.comboBox_Year1.TabIndex = 2;
            // 
            // comboBox_day1
            // 
            this.comboBox_day1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_day1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_day1.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox_day1.ForeColor = System.Drawing.Color.Black;
            this.comboBox_day1.IntegralHeight = false;
            this.comboBox_day1.Items.AddRange(new object[] {
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
            this.comboBox_day1.Location = new System.Drawing.Point(126, 2);
            this.comboBox_day1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboBox_day1.Name = "comboBox_day1";
            this.comboBox_day1.Size = new System.Drawing.Size(39, 21);
            this.comboBox_day1.TabIndex = 0;
            // 
            // comboBox_Month1
            // 
            this.comboBox_Month1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Month1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Month1.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox_Month1.ForeColor = System.Drawing.Color.Black;
            this.comboBox_Month1.IntegralHeight = false;
            this.comboBox_Month1.Items.AddRange(new object[] {
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
            this.comboBox_Month1.Location = new System.Drawing.Point(75, 2);
            this.comboBox_Month1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboBox_Month1.Name = "comboBox_Month1";
            this.comboBox_Month1.Size = new System.Drawing.Size(41, 21);
            this.comboBox_Month1.TabIndex = 1;
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.BackColor = System.Drawing.Color.Transparent;
            this.label_Date.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_Date.ForeColor = System.Drawing.Color.Black;
            this.label_Date.Location = new System.Drawing.Point(190, 9);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(58, 13);
            this.label_Date.TabIndex = 33;
            this.label_Date.Text = "تاریخ انجام:";
            // 
            // textBox_TelPlace
            // 
            // 
            // 
            // 
            this.textBox_TelPlace.Border.Class = "TextBoxBorder";
            this.textBox_TelPlace.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox_TelPlace.ForeColor = System.Drawing.Color.Black;
            this.textBox_TelPlace.Location = new System.Drawing.Point(17, 4);
            this.textBox_TelPlace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_TelPlace.MaxLength = 50;
            this.textBox_TelPlace.Name = "textBox_TelPlace";
            this.textBox_TelPlace.Size = new System.Drawing.Size(170, 21);
            this.textBox_TelPlace.TabIndex = 1;
            // 
            // label_LName
            // 
            this.label_LName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_LName.AutoSize = true;
            this.label_LName.BackColor = System.Drawing.Color.Transparent;
            this.label_LName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_LName.ForeColor = System.Drawing.Color.Black;
            this.label_LName.Location = new System.Drawing.Point(560, 101);
            this.label_LName.Name = "label_LName";
            this.label_LName.Size = new System.Drawing.Size(51, 13);
            this.label_LName.TabIndex = 35;
            this.label_LName.Text = "توضیحات:";
            // 
            // textBox_ActionDsc
            // 
            this.textBox_ActionDsc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBox_ActionDsc.Border.Class = "TextBoxBorder";
            this.textBox_ActionDsc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox_ActionDsc.ForeColor = System.Drawing.Color.Black;
            this.textBox_ActionDsc.Location = new System.Drawing.Point(17, 97);
            this.textBox_ActionDsc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_ActionDsc.MaxLength = 50;
            this.textBox_ActionDsc.Multiline = true;
            this.textBox_ActionDsc.Name = "textBox_ActionDsc";
            this.textBox_ActionDsc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_ActionDsc.Size = new System.Drawing.Size(539, 93);
            this.textBox_ActionDsc.TabIndex = 0;
            // 
            // label_LFamily
            // 
            this.label_LFamily.AutoSize = true;
            this.label_LFamily.BackColor = System.Drawing.Color.Transparent;
            this.label_LFamily.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_LFamily.ForeColor = System.Drawing.Color.Black;
            this.label_LFamily.Location = new System.Drawing.Point(191, 9);
            this.label_LFamily.Name = "label_LFamily";
            this.label_LFamily.Size = new System.Drawing.Size(56, 13);
            this.label_LFamily.TabIndex = 33;
            this.label_LFamily.Text = "تلفن محل:";
            // 
            // groupPanel_Full
            // 
            this.groupPanel_Full.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel_Full.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel_Full.Controls.Add(this.ComboBox_ProductUse);
            this.groupPanel_Full.Controls.Add(this.ComboBox_ActionPlace);
            this.groupPanel_Full.Controls.Add(this.textBox_AlarmKM);
            this.groupPanel_Full.Controls.Add(this.label1);
            this.groupPanel_Full.Controls.Add(this.textBox_NowKM);
            this.groupPanel_Full.Controls.Add(this.label_CMelliCode);
            this.groupPanel_Full.Controls.Add(this.label_CFatherN);
            this.groupPanel_Full.Controls.Add(this.textBox_TelPlace);
            this.groupPanel_Full.Controls.Add(this.textBox_NextKM);
            this.groupPanel_Full.Controls.Add(this.label_LFamily);
            this.groupPanel_Full.Controls.Add(this.label_LName);
            this.groupPanel_Full.Controls.Add(this.label_CName);
            this.groupPanel_Full.Controls.Add(this.textBox_ActionDsc);
            this.groupPanel_Full.Controls.Add(this.label_CFamily);
            this.groupPanel_Full.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel_Full.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel_Full.IsShadowEnabled = true;
            this.groupPanel_Full.Location = new System.Drawing.Point(0, 53);
            this.groupPanel_Full.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPanel_Full.Name = "groupPanel_Full";
            this.groupPanel_Full.Size = new System.Drawing.Size(694, 225);
            // 
            // 
            // 
            this.groupPanel_Full.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel_Full.Style.BackColorGradientAngle = 90;
            this.groupPanel_Full.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel_Full.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_Full.Style.BorderBottomWidth = 1;
            this.groupPanel_Full.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel_Full.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_Full.Style.BorderLeftWidth = 1;
            this.groupPanel_Full.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_Full.Style.BorderRightWidth = 1;
            this.groupPanel_Full.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_Full.Style.BorderTopWidth = 1;
            this.groupPanel_Full.Style.CornerDiameter = 4;
            this.groupPanel_Full.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel_Full.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel_Full.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel_Full.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel_Full.TabIndex = 1;
            this.groupPanel_Full.Text = "مشخصات کلی";
            // 
            // ComboBox_ProductUse
            // 
            this.ComboBox_ProductUse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_ProductUse.DisplayMember = "Text";
            this.ComboBox_ProductUse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_ProductUse.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ComboBox_ProductUse.ItemHeight = 15;
            this.ComboBox_ProductUse.Location = new System.Drawing.Point(282, 35);
            this.ComboBox_ProductUse.Name = "ComboBox_ProductUse";
            this.ComboBox_ProductUse.Size = new System.Drawing.Size(274, 21);
            this.ComboBox_ProductUse.TabIndex = 51;
            // 
            // ComboBox_ActionPlace
            // 
            this.ComboBox_ActionPlace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_ActionPlace.DisplayMember = "Text";
            this.ComboBox_ActionPlace.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_ActionPlace.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ComboBox_ActionPlace.ItemHeight = 15;
            this.ComboBox_ActionPlace.Location = new System.Drawing.Point(282, 4);
            this.ComboBox_ActionPlace.Name = "ComboBox_ActionPlace";
            this.ComboBox_ActionPlace.Size = new System.Drawing.Size(274, 21);
            this.ComboBox_ActionPlace.TabIndex = 50;
            this.ComboBox_ActionPlace.SelectedValueChanged += new System.EventHandler(this.ComboBox_ActionPlace_SelectedValueChanged);
            // 
            // textBox_AlarmKM
            // 
            // 
            // 
            // 
            this.textBox_AlarmKM.Border.Class = "TextBoxBorder";
            this.textBox_AlarmKM.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox_AlarmKM.ForeColor = System.Drawing.Color.Black;
            this.textBox_AlarmKM.Location = new System.Drawing.Point(17, 66);
            this.textBox_AlarmKM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_AlarmKM.MaxLength = 50;
            this.textBox_AlarmKM.Name = "textBox_AlarmKM";
            this.textBox_AlarmKM.Size = new System.Drawing.Size(170, 21);
            this.textBox_AlarmKM.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(191, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "کیلومتر هشدار:";
            // 
            // textBox_NowKM
            // 
            // 
            // 
            // 
            this.textBox_NowKM.Border.Class = "TextBoxBorder";
            this.textBox_NowKM.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox_NowKM.ForeColor = System.Drawing.Color.Black;
            this.textBox_NowKM.Location = new System.Drawing.Point(17, 35);
            this.textBox_NowKM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_NowKM.MaxLength = 10;
            this.textBox_NowKM.Name = "textBox_NowKM";
            this.textBox_NowKM.Size = new System.Drawing.Size(170, 21);
            this.textBox_NowKM.TabIndex = 2;
            this.textBox_NowKM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            // 
            // label_CMelliCode
            // 
            this.label_CMelliCode.AutoSize = true;
            this.label_CMelliCode.BackColor = System.Drawing.Color.Transparent;
            this.label_CMelliCode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_CMelliCode.ForeColor = System.Drawing.Color.Black;
            this.label_CMelliCode.Location = new System.Drawing.Point(191, 40);
            this.label_CMelliCode.Name = "label_CMelliCode";
            this.label_CMelliCode.Size = new System.Drawing.Size(73, 13);
            this.label_CMelliCode.TabIndex = 47;
            this.label_CMelliCode.Text = "کیلومتر فعلی:";
            // 
            // label_CFatherN
            // 
            this.label_CFatherN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_CFatherN.AutoSize = true;
            this.label_CFatherN.BackColor = System.Drawing.Color.Transparent;
            this.label_CFatherN.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_CFatherN.ForeColor = System.Drawing.Color.Black;
            this.label_CFatherN.Location = new System.Drawing.Point(560, 40);
            this.label_CFatherN.Name = "label_CFatherN";
            this.label_CFatherN.Size = new System.Drawing.Size(125, 13);
            this.label_CFatherN.TabIndex = 46;
            this.label_CFatherN.Text = "نوع محصول/مواد مصرفی:";
            // 
            // textBox_NextKM
            // 
            this.textBox_NextKM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBox_NextKM.Border.Class = "TextBoxBorder";
            this.textBox_NextKM.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox_NextKM.ForeColor = System.Drawing.Color.Black;
            this.textBox_NextKM.Location = new System.Drawing.Point(386, 66);
            this.textBox_NextKM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_NextKM.MaxLength = 50;
            this.textBox_NextKM.Name = "textBox_NextKM";
            this.textBox_NextKM.Size = new System.Drawing.Size(170, 21);
            this.textBox_NextKM.TabIndex = 3;
            this.textBox_NextKM.Leave += new System.EventHandler(this.textBox_NextKM_Leave);
            this.textBox_NextKM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            // 
            // label_CName
            // 
            this.label_CName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_CName.AutoSize = true;
            this.label_CName.BackColor = System.Drawing.Color.Transparent;
            this.label_CName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_CName.ForeColor = System.Drawing.Color.Black;
            this.label_CName.Location = new System.Drawing.Point(560, 9);
            this.label_CName.Name = "label_CName";
            this.label_CName.Size = new System.Drawing.Size(99, 13);
            this.label_CName.TabIndex = 44;
            this.label_CName.Text = "محل انجام سرویس:";
            // 
            // label_CFamily
            // 
            this.label_CFamily.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_CFamily.AutoSize = true;
            this.label_CFamily.BackColor = System.Drawing.Color.Transparent;
            this.label_CFamily.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_CFamily.ForeColor = System.Drawing.Color.Black;
            this.label_CFamily.Location = new System.Drawing.Point(560, 71);
            this.label_CFamily.Name = "label_CFamily";
            this.label_CFamily.Size = new System.Drawing.Size(72, 13);
            this.label_CFamily.TabIndex = 43;
            this.label_CFamily.Text = "کیلومتر بعدی:";
            // 
            // ActionCarNE_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 344);
            this.Controls.Add(this.groupPanel_Full);
            this.Controls.Add(this.groupPanel_Type);
            this.Controls.Add(this.ribbonBar_Cnclu);
            this.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(710, 380);
            this.Name = "ActionCarNE_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت سرویس";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ActionCarNE_frm_Load);
            this.groupPanel_Type.ResumeLayout(false);
            this.groupPanel_Type.PerformLayout();
            this.panel_ActionDate.ResumeLayout(false);
            this.panel_ActionDate.PerformLayout();
            this.groupPanel_Full.ResumeLayout(false);
            this.groupPanel_Full.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonBar ribbonBar_Cnclu;
        private DevComponents.DotNetBar.ButtonItem buttonItem_OK;
        private DevComponents.DotNetBar.ButtonItem buttonItem_Cancel;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel_Type;
        private System.Windows.Forms.Label label_Date;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_TelPlace;
        private System.Windows.Forms.Label label_LName;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_ActionDsc;
        private System.Windows.Forms.Label label_LFamily;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel_Full;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_NowKM;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_NextKM;
        private System.Windows.Forms.Label label_CMelliCode;
        private System.Windows.Forms.Label label_CFatherN;
        private System.Windows.Forms.Label label_CName;
        private System.Windows.Forms.Label label_CFamily;
        private System.Windows.Forms.Panel panel_ActionDate;
        public System.Windows.Forms.Label label_Date2;
        private System.Windows.Forms.Label label_Date1;
        private System.Windows.Forms.ComboBox comboBox_Year1;
        private System.Windows.Forms.ComboBox comboBox_day1;
        private System.Windows.Forms.ComboBox comboBox_Month1;
        private System.Windows.Forms.Label label5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxActionType;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_AlarmKM;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx ComboBox_ActionPlace;
        private DevComponents.DotNetBar.Controls.ComboBoxEx ComboBox_ProductUse;
    }
}