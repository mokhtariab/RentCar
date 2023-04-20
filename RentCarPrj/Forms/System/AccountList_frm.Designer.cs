namespace RentCarPrj
{
    partial class AccountList_Frm
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountList_Frm));
            this.gridControl_CarSubRPList = new DevExpress.XtraGrid.GridControl();
            this.gridView_AccountSubRPList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.AccountID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AccountNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AccountCardNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AccountName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BankName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IBANNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemPanelCarSubRP = new DevComponents.DotNetBar.ItemPanel();
            this.buttonItemAddAccount = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemEditAccount = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemDelAccount = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemCarSubRPSearch = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemSelector = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemAccountSubRPPrintList = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_CarSubRPList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_AccountSubRPList)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_CarSubRPList
            // 
            this.gridControl_CarSubRPList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_CarSubRPList.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl_CarSubRPList.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl_CarSubRPList.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl_CarSubRPList.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl_CarSubRPList.EmbeddedNavigator.Buttons.First.Hint = "ابتدا";
            this.gridControl_CarSubRPList.EmbeddedNavigator.Buttons.Last.Hint = "آخرین";
            this.gridControl_CarSubRPList.EmbeddedNavigator.Buttons.Next.Hint = "بعدی";
            this.gridControl_CarSubRPList.EmbeddedNavigator.Buttons.NextPage.Hint = "صفحه بعدی";
            this.gridControl_CarSubRPList.EmbeddedNavigator.Buttons.Prev.Hint = "قبلی";
            this.gridControl_CarSubRPList.EmbeddedNavigator.Buttons.PrevPage.Hint = "صفحه قبلی";
            this.gridControl_CarSubRPList.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl_CarSubRPList.EmbeddedNavigator.Text = "لیست اتومبیل ها";
            this.gridControl_CarSubRPList.EmbeddedNavigator.TextStringFormat = "رکورد {0} از {1}";
            this.gridControl_CarSubRPList.Location = new System.Drawing.Point(0, 57);
            this.gridControl_CarSubRPList.LookAndFeel.SkinName = "Office 2010 Blue";
            this.gridControl_CarSubRPList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl_CarSubRPList.MainView = this.gridView_AccountSubRPList;
            this.gridControl_CarSubRPList.Name = "gridControl_CarSubRPList";
            this.gridControl_CarSubRPList.Size = new System.Drawing.Size(679, 249);
            this.gridControl_CarSubRPList.TabIndex = 40;
            this.gridControl_CarSubRPList.UseEmbeddedNavigator = true;
            this.gridControl_CarSubRPList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_AccountSubRPList});
            this.gridControl_CarSubRPList.DoubleClick += new System.EventHandler(this.buttonItemEditAccount_Click);
            // 
            // gridView_AccountSubRPList
            // 
            this.gridView_AccountSubRPList.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView_AccountSubRPList.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_AccountSubRPList.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_AccountSubRPList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gridView_AccountSubRPList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_AccountSubRPList.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_AccountSubRPList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_AccountSubRPList.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_AccountSubRPList.Appearance.Row.Options.UseTextOptions = true;
            this.gridView_AccountSubRPList.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_AccountSubRPList.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_AccountSubRPList.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridView_AccountSubRPList.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_AccountSubRPList.ColumnPanelRowHeight = 25;
            this.gridView_AccountSubRPList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.AccountID,
            this.AccountNumber,
            this.AccountCardNo,
            this.AccountName,
            this.BankName,
            this.IBANNo});
            this.gridView_AccountSubRPList.CustomizationFormBounds = new System.Drawing.Rectangle(808, 444, 216, 171);
            this.gridView_AccountSubRPList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater;
            styleFormatCondition1.Value1 = "1";
            this.gridView_AccountSubRPList.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView_AccountSubRPList.GridControl = this.gridControl_CarSubRPList;
            this.gridView_AccountSubRPList.Name = "gridView_AccountSubRPList";
            this.gridView_AccountSubRPList.OptionsBehavior.Editable = false;
            this.gridView_AccountSubRPList.OptionsCustomization.AllowGroup = false;
            this.gridView_AccountSubRPList.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView_AccountSubRPList.OptionsFilter.AllowFilterEditor = false;
            this.gridView_AccountSubRPList.OptionsLayout.Columns.StoreAllOptions = true;
            this.gridView_AccountSubRPList.OptionsLayout.Columns.StoreAppearance = true;
            this.gridView_AccountSubRPList.OptionsLayout.StoreAllOptions = true;
            this.gridView_AccountSubRPList.OptionsLayout.StoreAppearance = true;
            this.gridView_AccountSubRPList.OptionsPrint.PrintPreview = true;
            this.gridView_AccountSubRPList.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView_AccountSubRPList.OptionsView.ShowFooter = true;
            this.gridView_AccountSubRPList.OptionsView.ShowGroupPanel = false;
            this.gridView_AccountSubRPList.OptionsView.ShowIndicator = false;
            this.gridView_AccountSubRPList.PaintStyleName = "Skin";
            this.gridView_AccountSubRPList.RowHeight = 20;
            // 
            // AccountID
            // 
            this.AccountID.Caption = "کد";
            this.AccountID.FieldName = "AccountID";
            this.AccountID.Name = "AccountID";
            this.AccountID.Visible = true;
            this.AccountID.VisibleIndex = 5;
            // 
            // AccountNumber
            // 
            this.AccountNumber.Caption = "شماره حساب";
            this.AccountNumber.FieldName = "AccountNumber";
            this.AccountNumber.Name = "AccountNumber";
            this.AccountNumber.Visible = true;
            this.AccountNumber.VisibleIndex = 4;
            // 
            // AccountCardNo
            // 
            this.AccountCardNo.Caption = "شماره کارت";
            this.AccountCardNo.FieldName = "AccountCardNo";
            this.AccountCardNo.Name = "AccountCardNo";
            this.AccountCardNo.Visible = true;
            this.AccountCardNo.VisibleIndex = 3;
            // 
            // AccountName
            // 
            this.AccountName.Caption = "نام صاحب حساب";
            this.AccountName.FieldName = "AccountName";
            this.AccountName.Name = "AccountName";
            this.AccountName.Visible = true;
            this.AccountName.VisibleIndex = 2;
            // 
            // BankName
            // 
            this.BankName.Caption = "نام بانک";
            this.BankName.FieldName = "BankName";
            this.BankName.Name = "BankName";
            this.BankName.Visible = true;
            this.BankName.VisibleIndex = 1;
            // 
            // IBANNo
            // 
            this.IBANNo.Caption = "شماره شبا";
            this.IBANNo.FieldName = "IBANNo";
            this.IBANNo.Name = "IBANNo";
            this.IBANNo.Visible = true;
            this.IBANNo.VisibleIndex = 0;
            // 
            // itemPanelCarSubRP
            // 
            // 
            // 
            // 
            this.itemPanelCarSubRP.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(135)))), ((int)(((byte)(214)))));
            this.itemPanelCarSubRP.BackgroundStyle.BackColor2 = System.Drawing.SystemColors.HotTrack;
            this.itemPanelCarSubRP.BackgroundStyle.BorderBottomWidth = 1;
            this.itemPanelCarSubRP.BackgroundStyle.BorderLeftWidth = 1;
            this.itemPanelCarSubRP.BackgroundStyle.BorderRightWidth = 1;
            this.itemPanelCarSubRP.BackgroundStyle.BorderTopWidth = 1;
            this.itemPanelCarSubRP.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanelCarSubRP.BackgroundStyle.PaddingBottom = 1;
            this.itemPanelCarSubRP.BackgroundStyle.PaddingLeft = 1;
            this.itemPanelCarSubRP.BackgroundStyle.PaddingRight = 1;
            this.itemPanelCarSubRP.BackgroundStyle.PaddingTop = 1;
            this.itemPanelCarSubRP.ContainerControlProcessDialogKey = true;
            this.itemPanelCarSubRP.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemPanelCarSubRP.FitButtonsToContainerWidth = true;
            this.itemPanelCarSubRP.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.itemPanelCarSubRP.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.itemPanelCarSubRP.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemAddAccount,
            this.buttonItemEditAccount,
            this.buttonItemDelAccount,
            this.buttonItemCarSubRPSearch,
            this.buttonItemSelector,
            this.buttonItemAccountSubRPPrintList});
            this.itemPanelCarSubRP.Location = new System.Drawing.Point(0, 0);
            this.itemPanelCarSubRP.Name = "itemPanelCarSubRP";
            this.itemPanelCarSubRP.Size = new System.Drawing.Size(679, 57);
            this.itemPanelCarSubRP.TabIndex = 41;
            this.itemPanelCarSubRP.ThemeAware = true;
            // 
            // buttonItemAddAccount
            // 
            this.buttonItemAddAccount.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemAddAccount.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemAddAccount.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemAddAccount.Image")));
            this.buttonItemAddAccount.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemAddAccount.Name = "buttonItemAddAccount";
            this.buttonItemAddAccount.Text = "ثبت حساب جدید";
            this.buttonItemAddAccount.ThemeAware = true;
            this.buttonItemAddAccount.Click += new System.EventHandler(this.buttonItemAddAccount_Click);
            // 
            // buttonItemEditAccount
            // 
            this.buttonItemEditAccount.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemEditAccount.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemEditAccount.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemEditAccount.Image")));
            this.buttonItemEditAccount.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemEditAccount.Name = "buttonItemEditAccount";
            this.buttonItemEditAccount.Text = "ویرایش";
            this.buttonItemEditAccount.ThemeAware = true;
            this.buttonItemEditAccount.Click += new System.EventHandler(this.buttonItemEditAccount_Click);
            // 
            // buttonItemDelAccount
            // 
            this.buttonItemDelAccount.BeginGroup = true;
            this.buttonItemDelAccount.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemDelAccount.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemDelAccount.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemDelAccount.Image")));
            this.buttonItemDelAccount.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemDelAccount.Name = "buttonItemDelAccount";
            this.buttonItemDelAccount.Text = "حذف";
            this.buttonItemDelAccount.ThemeAware = true;
            this.buttonItemDelAccount.Click += new System.EventHandler(this.buttonItemDelAccount_Click);
            // 
            // buttonItemCarSubRPSearch
            // 
            this.buttonItemCarSubRPSearch.AutoCheckOnClick = true;
            this.buttonItemCarSubRPSearch.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemCarSubRPSearch.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemCarSubRPSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemCarSubRPSearch.Image")));
            this.buttonItemCarSubRPSearch.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemCarSubRPSearch.Name = "buttonItemCarSubRPSearch";
            this.buttonItemCarSubRPSearch.Text = "جستجو";
            this.buttonItemCarSubRPSearch.ThemeAware = true;
            this.buttonItemCarSubRPSearch.Click += new System.EventHandler(this.buttonItemCarSubRPSearch_Click);
            // 
            // buttonItemSelector
            // 
            this.buttonItemSelector.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemSelector.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemSelector.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemSelector.Image")));
            this.buttonItemSelector.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemSelector.Name = "buttonItemSelector";
            this.buttonItemSelector.Text = "انتخاب فیلدها";
            this.buttonItemSelector.ThemeAware = true;
            this.buttonItemSelector.Click += new System.EventHandler(this.buttonItemSelector_Click);
            // 
            // buttonItemAccountSubRPPrintList
            // 
            this.buttonItemAccountSubRPPrintList.BeginGroup = true;
            this.buttonItemAccountSubRPPrintList.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemAccountSubRPPrintList.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemAccountSubRPPrintList.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemAccountSubRPPrintList.Image")));
            this.buttonItemAccountSubRPPrintList.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemAccountSubRPPrintList.Name = "buttonItemAccountSubRPPrintList";
            this.buttonItemAccountSubRPPrintList.Text = "چاپ لیست";
            this.buttonItemAccountSubRPPrintList.ThemeAware = true;
            this.buttonItemAccountSubRPPrintList.Click += new System.EventHandler(this.buttonItemCarSubRPPrintList_Click);
            // 
            // AccountList_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 306);
            this.Controls.Add(this.gridControl_CarSubRPList);
            this.Controls.Add(this.itemPanelCarSubRP);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AccountList_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شماره حساب";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AccountList_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_CarSubRPList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_AccountSubRPList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_CarSubRPList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_AccountSubRPList;
        private DevComponents.DotNetBar.ItemPanel itemPanelCarSubRP;
        private DevComponents.DotNetBar.ButtonItem buttonItemEditAccount;
        private DevComponents.DotNetBar.ButtonItem buttonItemDelAccount;
        private DevComponents.DotNetBar.ButtonItem buttonItemCarSubRPSearch;
        private DevComponents.DotNetBar.ButtonItem buttonItemSelector;
        private DevComponents.DotNetBar.ButtonItem buttonItemAccountSubRPPrintList;
        private DevComponents.DotNetBar.ButtonItem buttonItemAddAccount;
        private DevExpress.XtraGrid.Columns.GridColumn AccountNumber;
        private DevExpress.XtraGrid.Columns.GridColumn AccountCardNo;
        private DevExpress.XtraGrid.Columns.GridColumn AccountID;
        private DevExpress.XtraGrid.Columns.GridColumn AccountName;
        private DevExpress.XtraGrid.Columns.GridColumn BankName;
        private DevExpress.XtraGrid.Columns.GridColumn IBANNo;
    }
}