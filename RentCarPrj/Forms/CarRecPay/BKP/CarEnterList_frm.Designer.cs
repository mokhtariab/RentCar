namespace RentCarPrj
{
    partial class CarEnterList_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarEnterList_UC));
            this.gridControl_CarEnterList = new DevExpress.XtraGrid.GridControl();
            this.gridView_CarEnterList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CarID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CarEnterID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CertifiedDsc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StartEnterDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NowKM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemPanelCarEnter = new DevComponents.DotNetBar.ItemPanel();
            this.buttonItemAddCarEnter = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemEditCarEnter = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemDelCarEnter = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemCarEnterSearch = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemSelector = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemCarEnterPrintList = new DevComponents.DotNetBar.ButtonItem();
            this.RenterName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EndEnterDate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_CarEnterList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_CarEnterList)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_CarEnterList
            // 
            this.gridControl_CarEnterList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_CarEnterList.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl_CarEnterList.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl_CarEnterList.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl_CarEnterList.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl_CarEnterList.EmbeddedNavigator.Buttons.First.Hint = "ابتدا";
            this.gridControl_CarEnterList.EmbeddedNavigator.Buttons.Last.Hint = "آخرین";
            this.gridControl_CarEnterList.EmbeddedNavigator.Buttons.Next.Hint = "بعدی";
            this.gridControl_CarEnterList.EmbeddedNavigator.Buttons.NextPage.Hint = "صفحه بعدی";
            this.gridControl_CarEnterList.EmbeddedNavigator.Buttons.Prev.Hint = "قبلی";
            this.gridControl_CarEnterList.EmbeddedNavigator.Buttons.PrevPage.Hint = "صفحه قبلی";
            this.gridControl_CarEnterList.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl_CarEnterList.EmbeddedNavigator.Name = "";
            this.gridControl_CarEnterList.EmbeddedNavigator.Text = "لیست اتومبیل ها";
            this.gridControl_CarEnterList.EmbeddedNavigator.TextStringFormat = "رکورد {0} از {1}";
            this.gridControl_CarEnterList.Location = new System.Drawing.Point(0, 57);
            this.gridControl_CarEnterList.LookAndFeel.SkinName = "Money Twins";
            this.gridControl_CarEnterList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl_CarEnterList.MainView = this.gridView_CarEnterList;
            this.gridControl_CarEnterList.Name = "gridControl_CarEnterList";
            this.gridControl_CarEnterList.Size = new System.Drawing.Size(856, 332);
            this.gridControl_CarEnterList.TabIndex = 40;
            this.gridControl_CarEnterList.UseEmbeddedNavigator = true;
            this.gridControl_CarEnterList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_CarEnterList});
            // 
            // gridView_CarEnterList
            // 
            this.gridView_CarEnterList.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView_CarEnterList.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_CarEnterList.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_CarEnterList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gridView_CarEnterList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_CarEnterList.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_CarEnterList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_CarEnterList.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_CarEnterList.Appearance.Row.Options.UseTextOptions = true;
            this.gridView_CarEnterList.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_CarEnterList.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_CarEnterList.ColumnPanelRowHeight = 25;
            this.gridView_CarEnterList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CarID,
            this.CarEnterID,
            this.RenterName,
            this.StartEnterDate,
            this.EndEnterDate,
            this.TotalPrice,
            this.NowKM,
            this.CertifiedDsc});
            this.gridView_CarEnterList.CustomizationFormBounds = new System.Drawing.Rectangle(1374, 615, 216, 171);
            this.gridView_CarEnterList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater;
            styleFormatCondition1.Value1 = "1";
            this.gridView_CarEnterList.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView_CarEnterList.GridControl = this.gridControl_CarEnterList;
            this.gridView_CarEnterList.Name = "gridView_CarEnterList";
            this.gridView_CarEnterList.OptionsBehavior.Editable = false;
            this.gridView_CarEnterList.OptionsCustomization.AllowGroup = false;
            this.gridView_CarEnterList.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView_CarEnterList.OptionsFilter.AllowFilterEditor = false;
            this.gridView_CarEnterList.OptionsLayout.Columns.StoreAllOptions = true;
            this.gridView_CarEnterList.OptionsLayout.Columns.StoreAppearance = true;
            this.gridView_CarEnterList.OptionsLayout.StoreAllOptions = true;
            this.gridView_CarEnterList.OptionsLayout.StoreAppearance = true;
            this.gridView_CarEnterList.OptionsPrint.PrintPreview = true;
            this.gridView_CarEnterList.OptionsPrint.UsePrintStyles = true;
            this.gridView_CarEnterList.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView_CarEnterList.OptionsView.ShowGroupPanel = false;
            this.gridView_CarEnterList.OptionsView.ShowIndicator = false;
            this.gridView_CarEnterList.PaintStyleName = "Skin";
            this.gridView_CarEnterList.RowHeight = 20;
            // 
            // CarID
            // 
            this.CarID.Caption = "کد اتومبیل";
            this.CarID.FieldName = "CarID";
            this.CarID.Name = "CarID";
            // 
            // CarEnterID
            // 
            this.CarEnterID.Caption = "کد قرارداد";
            this.CarEnterID.FieldName = "CarEnterID";
            this.CarEnterID.Name = "CarEnterID";
            this.CarEnterID.Visible = true;
            this.CarEnterID.VisibleIndex = 6;
            this.CarEnterID.Width = 81;
            // 
            // CertifiedDsc
            // 
            this.CertifiedDsc.Caption = "ضمانت ها";
            this.CertifiedDsc.FieldName = "CertifiedDsc";
            this.CertifiedDsc.Name = "CertifiedDsc";
            this.CertifiedDsc.Visible = true;
            this.CertifiedDsc.VisibleIndex = 0;
            this.CertifiedDsc.Width = 108;
            // 
            // StartEnterDate
            // 
            this.StartEnterDate.Caption = "تاریخ شروع";
            this.StartEnterDate.FieldName = "StartEnterDate";
            this.StartEnterDate.Name = "StartEnterDate";
            this.StartEnterDate.Visible = true;
            this.StartEnterDate.VisibleIndex = 5;
            this.StartEnterDate.Width = 80;
            // 
            // TotalPrice
            // 
            this.TotalPrice.Caption = "کل مبلغ";
            this.TotalPrice.FieldName = "TotalPrice";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Visible = true;
            this.TotalPrice.VisibleIndex = 2;
            this.TotalPrice.Width = 113;
            // 
            // NowKM
            // 
            this.NowKM.Caption = "کیلومتر فعلی";
            this.NowKM.FieldName = "NowKM";
            this.NowKM.Name = "NowKM";
            this.NowKM.Visible = true;
            this.NowKM.VisibleIndex = 1;
            this.NowKM.Width = 113;
            // 
            // itemPanelCarEnter
            // 
            // 
            // 
            // 
            this.itemPanelCarEnter.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(135)))), ((int)(((byte)(214)))));
            this.itemPanelCarEnter.BackgroundStyle.BackColor2 = System.Drawing.SystemColors.HotTrack;
            this.itemPanelCarEnter.BackgroundStyle.BorderBottomWidth = 1;
            this.itemPanelCarEnter.BackgroundStyle.BorderLeftWidth = 1;
            this.itemPanelCarEnter.BackgroundStyle.BorderRightWidth = 1;
            this.itemPanelCarEnter.BackgroundStyle.BorderTopWidth = 1;
            this.itemPanelCarEnter.BackgroundStyle.PaddingBottom = 1;
            this.itemPanelCarEnter.BackgroundStyle.PaddingLeft = 1;
            this.itemPanelCarEnter.BackgroundStyle.PaddingRight = 1;
            this.itemPanelCarEnter.BackgroundStyle.PaddingTop = 1;
            this.itemPanelCarEnter.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemPanelCarEnter.FitButtonsToContainerWidth = true;
            this.itemPanelCarEnter.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.itemPanelCarEnter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.itemPanelCarEnter.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemAddCarEnter,
            this.buttonItemEditCarEnter,
            this.buttonItemDelCarEnter,
            this.buttonItemCarEnterSearch,
            this.buttonItemSelector,
            this.buttonItemCarEnterPrintList});
            this.itemPanelCarEnter.Location = new System.Drawing.Point(0, 0);
            this.itemPanelCarEnter.Name = "itemPanelCarEnter";
            this.itemPanelCarEnter.Size = new System.Drawing.Size(856, 57);
            this.itemPanelCarEnter.TabIndex = 41;
            this.itemPanelCarEnter.ThemeAware = true;
            // 
            // buttonItemAddCarEnter
            // 
            this.buttonItemAddCarEnter.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemAddCarEnter.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemAddCarEnter.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemAddCarEnter.Image")));
            this.buttonItemAddCarEnter.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.NotSet;
            this.buttonItemAddCarEnter.ImagePaddingHorizontal = 8;
            this.buttonItemAddCarEnter.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemAddCarEnter.Name = "buttonItemAddCarEnter";
            this.buttonItemAddCarEnter.Text = "قرارداد جدید";
            this.buttonItemAddCarEnter.ThemeAware = true;
            this.buttonItemAddCarEnter.Click += new System.EventHandler(this.buttonItemAddCarEnter_Click);
            // 
            // buttonItemEditCarEnter
            // 
            this.buttonItemEditCarEnter.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemEditCarEnter.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemEditCarEnter.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemEditCarEnter.Image")));
            this.buttonItemEditCarEnter.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.NotSet;
            this.buttonItemEditCarEnter.ImagePaddingHorizontal = 8;
            this.buttonItemEditCarEnter.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemEditCarEnter.Name = "buttonItemEditCarEnter";
            this.buttonItemEditCarEnter.Text = "ویرایش";
            this.buttonItemEditCarEnter.ThemeAware = true;
            this.buttonItemEditCarEnter.Click += new System.EventHandler(this.buttonItemEditCarEnter_Click);
            // 
            // buttonItemDelCarEnter
            // 
            this.buttonItemDelCarEnter.BeginGroup = true;
            this.buttonItemDelCarEnter.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemDelCarEnter.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemDelCarEnter.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemDelCarEnter.Image")));
            this.buttonItemDelCarEnter.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.NotSet;
            this.buttonItemDelCarEnter.ImagePaddingHorizontal = 8;
            this.buttonItemDelCarEnter.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemDelCarEnter.Name = "buttonItemDelCarEnter";
            this.buttonItemDelCarEnter.Text = "حذف";
            this.buttonItemDelCarEnter.ThemeAware = true;
            this.buttonItemDelCarEnter.Click += new System.EventHandler(this.buttonItemDelCarEnter_Click);
            // 
            // buttonItemCarEnterSearch
            // 
            this.buttonItemCarEnterSearch.AutoCheckOnClick = true;
            this.buttonItemCarEnterSearch.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemCarEnterSearch.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemCarEnterSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemCarEnterSearch.Image")));
            this.buttonItemCarEnterSearch.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.NotSet;
            this.buttonItemCarEnterSearch.ImagePaddingHorizontal = 8;
            this.buttonItemCarEnterSearch.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemCarEnterSearch.Name = "buttonItemCarEnterSearch";
            this.buttonItemCarEnterSearch.Text = "جستجو";
            this.buttonItemCarEnterSearch.ThemeAware = true;
            this.buttonItemCarEnterSearch.Click += new System.EventHandler(this.buttonItemCarEnterSearch_Click);
            // 
            // buttonItemSelector
            // 
            this.buttonItemSelector.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemSelector.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemSelector.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemSelector.Image")));
            this.buttonItemSelector.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.NotSet;
            this.buttonItemSelector.ImagePaddingHorizontal = 8;
            this.buttonItemSelector.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemSelector.Name = "buttonItemSelector";
            this.buttonItemSelector.Text = "انتخاب فیلدها";
            this.buttonItemSelector.ThemeAware = true;
            this.buttonItemSelector.Click += new System.EventHandler(this.buttonItemSelector_Click);
            // 
            // buttonItemCarEnterPrintList
            // 
            this.buttonItemCarEnterPrintList.BeginGroup = true;
            this.buttonItemCarEnterPrintList.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemCarEnterPrintList.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemCarEnterPrintList.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemCarEnterPrintList.Image")));
            this.buttonItemCarEnterPrintList.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.NotSet;
            this.buttonItemCarEnterPrintList.ImagePaddingHorizontal = 8;
            this.buttonItemCarEnterPrintList.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemCarEnterPrintList.Name = "buttonItemCarEnterPrintList";
            this.buttonItemCarEnterPrintList.Text = "چاپ لیست";
            this.buttonItemCarEnterPrintList.ThemeAware = true;
            this.buttonItemCarEnterPrintList.Click += new System.EventHandler(this.buttonItemCarEnterPrintList_Click);
            // 
            // RenterName
            // 
            this.RenterName.Caption = "اجاره دهنده";
            this.RenterName.FieldName = "RenterCode";
            this.RenterName.Name = "RenterName";
            this.RenterName.Visible = true;
            this.RenterName.VisibleIndex = 3;
            // 
            // EndEnterDate
            // 
            this.EndEnterDate.Caption = "تاریخ پایان";
            this.EndEnterDate.FieldName = "EndEnterDate";
            this.EndEnterDate.Name = "EndEnterDate";
            this.EndEnterDate.Visible = true;
            this.EndEnterDate.VisibleIndex = 4;
            // 
            // CarEnterList_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl_CarEnterList);
            this.Controls.Add(this.itemPanelCarEnter);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "CarEnterList_UC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(856, 389);
            this.Load += new System.EventHandler(this.CarEnterList_UC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_CarEnterList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_CarEnterList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_CarEnterList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_CarEnterList;
        private DevExpress.XtraGrid.Columns.GridColumn TotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn NowKM;
        private DevExpress.XtraGrid.Columns.GridColumn StartEnterDate;
        private DevExpress.XtraGrid.Columns.GridColumn CarID;
        private DevComponents.DotNetBar.ItemPanel itemPanelCarEnter;
        private DevComponents.DotNetBar.ButtonItem buttonItemEditCarEnter;
        private DevComponents.DotNetBar.ButtonItem buttonItemDelCarEnter;
        private DevComponents.DotNetBar.ButtonItem buttonItemCarEnterSearch;
        private DevComponents.DotNetBar.ButtonItem buttonItemSelector;
        private DevComponents.DotNetBar.ButtonItem buttonItemCarEnterPrintList;
        private DevComponents.DotNetBar.ButtonItem buttonItemAddCarEnter;
        private DevExpress.XtraGrid.Columns.GridColumn CarEnterID;
        private DevExpress.XtraGrid.Columns.GridColumn CertifiedDsc;
        private DevExpress.XtraGrid.Columns.GridColumn RenterName;
        private DevExpress.XtraGrid.Columns.GridColumn EndEnterDate;
    }
}