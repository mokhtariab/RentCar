namespace RentCarPrj
{
    partial class AccountPayNE_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountPayNE_frm));
            this.ribbonBar_Cnclu = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem_OK = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem_Cancel = new DevComponents.DotNetBar.ButtonItem();
            this.textBox_AccountCardNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label26 = new System.Windows.Forms.Label();
            this.comboBox_BankName = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem9 = new DevComponents.Editors.ComboItem();
            this.comboItem10 = new DevComponents.Editors.ComboItem();
            this.comboItem16 = new DevComponents.Editors.ComboItem();
            this.comboItem11 = new DevComponents.Editors.ComboItem();
            this.comboItem14 = new DevComponents.Editors.ComboItem();
            this.comboItem17 = new DevComponents.Editors.ComboItem();
            this.comboItem12 = new DevComponents.Editors.ComboItem();
            this.comboItem13 = new DevComponents.Editors.ComboItem();
            this.comboItem18 = new DevComponents.Editors.ComboItem();
            this.comboItem19 = new DevComponents.Editors.ComboItem();
            this.comboItem15 = new DevComponents.Editors.ComboItem();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox_IBANNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_AccountName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.groupPanel_Check = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_AccountNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel_Check.SuspendLayout();
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
            this.ribbonBar_Cnclu.Location = new System.Drawing.Point(0, 202);
            this.ribbonBar_Cnclu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonBar_Cnclu.Name = "ribbonBar_Cnclu";
            this.ribbonBar_Cnclu.Size = new System.Drawing.Size(374, 62);
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
            // textBox_AccountCardNo
            // 
            // 
            // 
            // 
            this.textBox_AccountCardNo.Border.Class = "TextBoxBorder";
            this.textBox_AccountCardNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox_AccountCardNo.ForeColor = System.Drawing.Color.Black;
            this.textBox_AccountCardNo.Location = new System.Drawing.Point(38, 50);
            this.textBox_AccountCardNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_AccountCardNo.MaxLength = 100;
            this.textBox_AccountCardNo.Name = "textBox_AccountCardNo";
            this.textBox_AccountCardNo.Size = new System.Drawing.Size(218, 21);
            this.textBox_AccountCardNo.TabIndex = 1;
            this.textBox_AccountCardNo.Text = "0";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(261, 54);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(65, 13);
            this.label26.TabIndex = 325;
            this.label26.Text = "شماره کارت:";
            // 
            // comboBox_BankName
            // 
            this.comboBox_BankName.DisplayMember = "Text";
            this.comboBox_BankName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_BankName.DropDownWidth = 120;
            this.comboBox_BankName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox_BankName.ForeColor = System.Drawing.Color.Black;
            this.comboBox_BankName.IntegralHeight = false;
            this.comboBox_BankName.ItemHeight = 15;
            this.comboBox_BankName.Items.AddRange(new object[] {
            this.comboItem9,
            this.comboItem10,
            this.comboItem16,
            this.comboItem11,
            this.comboItem14,
            this.comboItem17,
            this.comboItem12,
            this.comboItem13,
            this.comboItem18,
            this.comboItem19,
            this.comboItem15});
            this.comboBox_BankName.Location = new System.Drawing.Point(38, 110);
            this.comboBox_BankName.MaxDropDownItems = 20;
            this.comboBox_BankName.MaxLength = 50;
            this.comboBox_BankName.Name = "comboBox_BankName";
            this.comboBox_BankName.Size = new System.Drawing.Size(218, 21);
            this.comboBox_BankName.TabIndex = 3;
            // 
            // comboItem9
            // 
            this.comboItem9.Text = "ملی";
            // 
            // comboItem10
            // 
            this.comboItem10.Text = "ملت";
            // 
            // comboItem16
            // 
            this.comboItem16.Text = "تجارت";
            // 
            // comboItem11
            // 
            this.comboItem11.Text = "صادرات";
            // 
            // comboItem14
            // 
            this.comboItem14.Text = "سپه";
            // 
            // comboItem17
            // 
            this.comboItem17.Text = "کشاورزی";
            // 
            // comboItem12
            // 
            this.comboItem12.Text = "پاسارگاد";
            // 
            // comboItem13
            // 
            this.comboItem13.Text = "اقتصادنوین";
            // 
            // comboItem18
            // 
            this.comboItem18.Text = "سامان";
            // 
            // comboItem19
            // 
            this.comboItem19.Text = "پارسیان";
            // 
            // comboItem15
            // 
            this.comboItem15.Text = "مردم";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(260, 115);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(31, 13);
            this.label27.TabIndex = 326;
            this.label27.Text = "بانک:";
            // 
            // textBox_IBANNo
            // 
            // 
            // 
            // 
            this.textBox_IBANNo.Border.Class = "TextBoxBorder";
            this.textBox_IBANNo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox_IBANNo.ForeColor = System.Drawing.Color.Black;
            this.textBox_IBANNo.Location = new System.Drawing.Point(38, 140);
            this.textBox_IBANNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_IBANNo.MaxLength = 100;
            this.textBox_IBANNo.Name = "textBox_IBANNo";
            this.textBox_IBANNo.Size = new System.Drawing.Size(218, 21);
            this.textBox_IBANNo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(260, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 330;
            this.label2.Text = "شماره شبا:";
            // 
            // textBox_AccountName
            // 
            // 
            // 
            // 
            this.textBox_AccountName.Border.Class = "TextBoxBorder";
            this.textBox_AccountName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox_AccountName.ForeColor = System.Drawing.Color.Black;
            this.textBox_AccountName.Location = new System.Drawing.Point(38, 80);
            this.textBox_AccountName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_AccountName.MaxLength = 100;
            this.textBox_AccountName.Name = "textBox_AccountName";
            this.textBox_AccountName.Size = new System.Drawing.Size(218, 21);
            this.textBox_AccountName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(260, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 332;
            this.label1.Text = "نام صاحب حساب:";
            // 
            // groupPanel_Check
            // 
            this.groupPanel_Check.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel_Check.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel_Check.Controls.Add(this.label1);
            this.groupPanel_Check.Controls.Add(this.textBox_AccountName);
            this.groupPanel_Check.Controls.Add(this.label2);
            this.groupPanel_Check.Controls.Add(this.textBox_IBANNo);
            this.groupPanel_Check.Controls.Add(this.label27);
            this.groupPanel_Check.Controls.Add(this.comboBox_BankName);
            this.groupPanel_Check.Controls.Add(this.label3);
            this.groupPanel_Check.Controls.Add(this.textBox_AccountNumber);
            this.groupPanel_Check.Controls.Add(this.label26);
            this.groupPanel_Check.Controls.Add(this.textBox_AccountCardNo);
            this.groupPanel_Check.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel_Check.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel_Check.IsShadowEnabled = true;
            this.groupPanel_Check.Location = new System.Drawing.Point(0, 0);
            this.groupPanel_Check.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPanel_Check.Name = "groupPanel_Check";
            this.groupPanel_Check.Size = new System.Drawing.Size(374, 202);
            // 
            // 
            // 
            this.groupPanel_Check.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel_Check.Style.BackColorGradientAngle = 90;
            this.groupPanel_Check.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel_Check.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_Check.Style.BorderBottomWidth = 1;
            this.groupPanel_Check.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel_Check.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_Check.Style.BorderLeftWidth = 1;
            this.groupPanel_Check.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_Check.Style.BorderRightWidth = 1;
            this.groupPanel_Check.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_Check.Style.BorderTopWidth = 1;
            this.groupPanel_Check.Style.CornerDiameter = 4;
            this.groupPanel_Check.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel_Check.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel_Check.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel_Check.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel_Check.TabIndex = 1;
            this.groupPanel_Check.Text = "مشخصات حساب";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(260, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 325;
            this.label3.Text = "شماره حساب:";
            // 
            // textBox_AccountNumber
            // 
            // 
            // 
            // 
            this.textBox_AccountNumber.Border.Class = "TextBoxBorder";
            this.textBox_AccountNumber.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox_AccountNumber.ForeColor = System.Drawing.Color.Black;
            this.textBox_AccountNumber.Location = new System.Drawing.Point(38, 20);
            this.textBox_AccountNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_AccountNumber.MaxLength = 100;
            this.textBox_AccountNumber.Name = "textBox_AccountNumber";
            this.textBox_AccountNumber.Size = new System.Drawing.Size(218, 21);
            this.textBox_AccountNumber.TabIndex = 0;
            this.textBox_AccountNumber.Text = "0";
            // 
            // AccountPayNE_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 264);
            this.Controls.Add(this.groupPanel_Check);
            this.Controls.Add(this.ribbonBar_Cnclu);
            this.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(390, 300);
            this.MinimumSize = new System.Drawing.Size(390, 300);
            this.Name = "AccountPayNE_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نوع حساب";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AccountPayNE_frm_Load);
            this.groupPanel_Check.ResumeLayout(false);
            this.groupPanel_Check.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonBar ribbonBar_Cnclu;
        private DevComponents.DotNetBar.ButtonItem buttonItem_OK;
        private DevComponents.DotNetBar.ButtonItem buttonItem_Cancel;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_AccountCardNo;
        private System.Windows.Forms.Label label26;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBox_BankName;
        private DevComponents.Editors.ComboItem comboItem9;
        private DevComponents.Editors.ComboItem comboItem10;
        private DevComponents.Editors.ComboItem comboItem16;
        private DevComponents.Editors.ComboItem comboItem11;
        private DevComponents.Editors.ComboItem comboItem14;
        private DevComponents.Editors.ComboItem comboItem17;
        private DevComponents.Editors.ComboItem comboItem12;
        private DevComponents.Editors.ComboItem comboItem13;
        private DevComponents.Editors.ComboItem comboItem18;
        private DevComponents.Editors.ComboItem comboItem19;
        private DevComponents.Editors.ComboItem comboItem15;
        private System.Windows.Forms.Label label27;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_IBANNo;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_AccountName;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel_Check;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_AccountNumber;
    }
}