namespace RentCarPrj
{
    partial class AlarmList_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmList_UC));
            this.gridViewAlarm = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DateAction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DscAction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NextKM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NowKM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl_AlarmList = new DevExpress.XtraGrid.GridControl();
            this.tBLCarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRentReport = new RentCarPrj.DataSetRentReport();
            this.gridView_AlarmList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CarName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CarPic = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.LordName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CarType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DisciplineNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EnterTypeStr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MadeCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColorSet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InsuranceThirdExpDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InsuranceBodyExpDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CarID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InsuranceThirdPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InsuranceBodyPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.textboxitem_status = new DevComponents.DotNetBar.TextBoxItem();
            this.buttonItem_StatusOK = new DevComponents.DotNetBar.ButtonItem();
            this.itemPanelCar = new DevComponents.DotNetBar.ItemPanel();
            this.buttonItemCustomSearch = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemSelector = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemCustomPrintList = new DevComponents.DotNetBar.ButtonItem();
            this.tBL_CarTableAdapter = new RentCarPrj.DataSetRentReportTableAdapters.TBL_CarTableAdapter();
            this.sP_AlarmViewForDefinitionTableAdapter = new RentCarPrj.DataSetRentReportTableAdapters.SP_AlarmViewForDefinitionTableAdapter();
            this.tBLCarSPAlarmViewForDefinitionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAlarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_AlarmList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLCarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRentReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_AlarmList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLCarSPAlarmViewForDefinitionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewAlarm
            // 
            this.gridViewAlarm.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewAlarm.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewAlarm.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewAlarm.Appearance.Row.Options.UseTextOptions = true;
            this.gridViewAlarm.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewAlarm.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewAlarm.ChildGridLevelName = " ";
            this.gridViewAlarm.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DateAction,
            this.DscAction,
            this.NextKM,
            this.NowKM});
            this.gridViewAlarm.GridControl = this.gridControl_AlarmList;
            this.gridViewAlarm.Name = "gridViewAlarm";
            this.gridViewAlarm.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridViewAlarm.OptionsBehavior.Editable = false;
            this.gridViewAlarm.OptionsCustomization.AllowGroup = false;
            this.gridViewAlarm.OptionsDetail.AllowZoomDetail = false;
            this.gridViewAlarm.OptionsDetail.EnableMasterViewMode = false;
            this.gridViewAlarm.OptionsDetail.ShowDetailTabs = false;
            this.gridViewAlarm.OptionsFilter.AllowFilterEditor = false;
            this.gridViewAlarm.OptionsFilter.AllowMRUFilterList = false;
            this.gridViewAlarm.OptionsSelection.InvertSelection = true;
            this.gridViewAlarm.OptionsSelection.UseIndicatorForSelection = false;
            this.gridViewAlarm.OptionsView.ShowChildrenInGroupPanel = true;
            this.gridViewAlarm.OptionsView.ShowDetailButtons = false;
            this.gridViewAlarm.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridViewAlarm.OptionsView.ShowGroupPanel = false;
            this.gridViewAlarm.OptionsView.ShowIndicator = false;
            this.gridViewAlarm.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewAlarm.ViewCaption = " ";
            // 
            // DateAction
            // 
            this.DateAction.Caption = "تاریخ انجام";
            this.DateAction.FieldName = "DateAction";
            this.DateAction.Name = "DateAction";
            this.DateAction.Visible = true;
            this.DateAction.VisibleIndex = 3;
            // 
            // DscAction
            // 
            this.DscAction.Caption = "توضیح عملیات";
            this.DscAction.FieldName = "DscAction";
            this.DscAction.Name = "DscAction";
            this.DscAction.Visible = true;
            this.DscAction.VisibleIndex = 2;
            // 
            // NextKM
            // 
            this.NextKM.Caption = "کیلومتر بعدی";
            this.NextKM.FieldName = "NextKM";
            this.NextKM.Name = "NextKM";
            this.NextKM.Visible = true;
            this.NextKM.VisibleIndex = 1;
            // 
            // NowKM
            // 
            this.NowKM.Caption = "کیلومتر فعلی";
            this.NowKM.FieldName = "NowKM";
            this.NowKM.Name = "NowKM";
            this.NowKM.Visible = true;
            this.NowKM.VisibleIndex = 0;
            // 
            // gridControl_AlarmList
            // 
            this.gridControl_AlarmList.DataSource = this.tBLCarBindingSource;
            this.gridControl_AlarmList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_AlarmList.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl_AlarmList.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl_AlarmList.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl_AlarmList.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl_AlarmList.EmbeddedNavigator.Buttons.First.Hint = "ابتدا";
            this.gridControl_AlarmList.EmbeddedNavigator.Buttons.Last.Hint = "آخرین";
            this.gridControl_AlarmList.EmbeddedNavigator.Buttons.Next.Hint = "بعدی";
            this.gridControl_AlarmList.EmbeddedNavigator.Buttons.NextPage.Hint = "صفحه بعدی";
            this.gridControl_AlarmList.EmbeddedNavigator.Buttons.Prev.Hint = "قبلی";
            this.gridControl_AlarmList.EmbeddedNavigator.Buttons.PrevPage.Hint = "صفحه قبلی";
            this.gridControl_AlarmList.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl_AlarmList.EmbeddedNavigator.Text = "لیست اتومبیل ها";
            this.gridControl_AlarmList.EmbeddedNavigator.TextStringFormat = "رکورد {0} از {1}";
            gridLevelNode1.LevelTemplate = this.gridViewAlarm;
            gridLevelNode1.RelationName = "TBL_Car_SP_AlarmViewForDefinition";
            this.gridControl_AlarmList.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl_AlarmList.Location = new System.Drawing.Point(0, 57);
            this.gridControl_AlarmList.LookAndFeel.SkinName = "Office 2010 Black";
            this.gridControl_AlarmList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl_AlarmList.MainView = this.gridView_AlarmList;
            this.gridControl_AlarmList.Name = "gridControl_AlarmList";
            this.gridControl_AlarmList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit1,
            this.repositoryItemPictureEdit1});
            this.gridControl_AlarmList.Size = new System.Drawing.Size(969, 490);
            this.gridControl_AlarmList.TabIndex = 41;
            this.gridControl_AlarmList.UseEmbeddedNavigator = true;
            this.gridControl_AlarmList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_AlarmList,
            this.gridViewAlarm});
            // 
            // tBLCarBindingSource
            // 
            this.tBLCarBindingSource.DataMember = "TBL_Car";
            this.tBLCarBindingSource.DataSource = this.dataSetRentReport;
            // 
            // dataSetRentReport
            // 
            this.dataSetRentReport.DataSetName = "DataSetRentReport";
            this.dataSetRentReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView_AlarmList
            // 
            this.gridView_AlarmList.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView_AlarmList.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_AlarmList.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_AlarmList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gridView_AlarmList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_AlarmList.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_AlarmList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_AlarmList.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_AlarmList.Appearance.Row.Options.UseTextOptions = true;
            this.gridView_AlarmList.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_AlarmList.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_AlarmList.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridView_AlarmList.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_AlarmList.ChildGridLevelName = "AlarmView";
            this.gridView_AlarmList.ColumnPanelRowHeight = 25;
            this.gridView_AlarmList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CarName,
            this.CarPic,
            this.LordName,
            this.CarType,
            this.DisciplineNO,
            this.EnterTypeStr,
            this.MadeCountry,
            this.ColorSet,
            this.ProductDate,
            this.InsuranceThirdExpDate,
            this.InsuranceBodyExpDate,
            this.CarID,
            this.InsuranceThirdPrice,
            this.InsuranceBodyPrice});
            this.gridView_AlarmList.CustomizationFormBounds = new System.Drawing.Rectangle(1374, 615, 216, 171);
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater;
            styleFormatCondition1.Value1 = "1";
            this.gridView_AlarmList.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView_AlarmList.GridControl = this.gridControl_AlarmList;
            this.gridView_AlarmList.Name = "gridView_AlarmList";
            this.gridView_AlarmList.OptionsBehavior.Editable = false;
            this.gridView_AlarmList.OptionsCustomization.AllowGroup = false;
            this.gridView_AlarmList.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView_AlarmList.OptionsFilter.AllowFilterEditor = false;
            this.gridView_AlarmList.OptionsLayout.Columns.StoreAllOptions = true;
            this.gridView_AlarmList.OptionsLayout.Columns.StoreAppearance = true;
            this.gridView_AlarmList.OptionsLayout.StoreAllOptions = true;
            this.gridView_AlarmList.OptionsLayout.StoreAppearance = true;
            this.gridView_AlarmList.OptionsPrint.PrintDetails = true;
            this.gridView_AlarmList.OptionsPrint.PrintPreview = true;
            this.gridView_AlarmList.OptionsView.ShowChildrenInGroupPanel = true;
            this.gridView_AlarmList.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView_AlarmList.OptionsView.ShowGroupPanel = false;
            this.gridView_AlarmList.OptionsView.ShowIndicator = false;
            this.gridView_AlarmList.PaintStyleName = "Skin";
            this.gridView_AlarmList.PreviewFieldName = "colLordCode";
            this.gridView_AlarmList.RowHeight = 20;
            // 
            // CarName
            // 
            this.CarName.Caption = "نام اتومبیل";
            this.CarName.FieldName = "CarName";
            this.CarName.Name = "CarName";
            this.CarName.OptionsColumn.AllowEdit = false;
            this.CarName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.CarName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.CarName.Visible = true;
            this.CarName.VisibleIndex = 6;
            this.CarName.Width = 115;
            // 
            // CarPic
            // 
            this.CarPic.Caption = "تصویر";
            this.CarPic.ColumnEdit = this.repositoryItemPictureEdit1;
            this.CarPic.FieldName = "CarPic";
            this.CarPic.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.CarPic.Name = "CarPic";
            this.CarPic.OptionsColumn.AllowEdit = false;
            this.CarPic.OptionsColumn.AllowFocus = false;
            this.CarPic.OptionsColumn.AllowMove = false;
            this.CarPic.OptionsColumn.AllowSize = false;
            this.CarPic.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.CarPic.OptionsFilter.AllowFilter = false;
            this.CarPic.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.CarPic.Width = 126;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            // 
            // LordName
            // 
            this.LordName.Caption = "نام مالک";
            this.LordName.FieldName = "LordName";
            this.LordName.Name = "LordName";
            this.LordName.Visible = true;
            this.LordName.VisibleIndex = 5;
            this.LordName.Width = 146;
            // 
            // CarType
            // 
            this.CarType.Caption = "نوع اتومبیل";
            this.CarType.FieldName = "CarType";
            this.CarType.Name = "CarType";
            this.CarType.Visible = true;
            this.CarType.VisibleIndex = 4;
            this.CarType.Width = 173;
            // 
            // DisciplineNO
            // 
            this.DisciplineNO.Caption = "شماره پلاک";
            this.DisciplineNO.FieldName = "DisciplineNO";
            this.DisciplineNO.Name = "DisciplineNO";
            this.DisciplineNO.Width = 97;
            // 
            // EnterTypeStr
            // 
            this.EnterTypeStr.Caption = "نوع ورود";
            this.EnterTypeStr.FieldName = "EnterTypeStr";
            this.EnterTypeStr.Name = "EnterTypeStr";
            // 
            // MadeCountry
            // 
            this.MadeCountry.Caption = "کشور سازنده";
            this.MadeCountry.FieldName = "MadeCountry";
            this.MadeCountry.Name = "MadeCountry";
            // 
            // ColorSet
            // 
            this.ColorSet.Caption = "رنگ";
            this.ColorSet.FieldName = "ColorSet";
            this.ColorSet.Name = "ColorSet";
            this.ColorSet.Visible = true;
            this.ColorSet.VisibleIndex = 3;
            this.ColorSet.Width = 69;
            // 
            // ProductDate
            // 
            this.ProductDate.Caption = "تاریخ تولید";
            this.ProductDate.FieldName = "ProductDate";
            this.ProductDate.Name = "ProductDate";
            this.ProductDate.Visible = true;
            this.ProductDate.VisibleIndex = 2;
            this.ProductDate.Width = 103;
            // 
            // InsuranceThirdExpDate
            // 
            this.InsuranceThirdExpDate.Caption = "اتمام بیمه ثالث";
            this.InsuranceThirdExpDate.FieldName = "InsuranceThirdExpDate";
            this.InsuranceThirdExpDate.Name = "InsuranceThirdExpDate";
            this.InsuranceThirdExpDate.Visible = true;
            this.InsuranceThirdExpDate.VisibleIndex = 1;
            this.InsuranceThirdExpDate.Width = 62;
            // 
            // InsuranceBodyExpDate
            // 
            this.InsuranceBodyExpDate.Caption = "اتمام بیمه بدنه";
            this.InsuranceBodyExpDate.FieldName = "InsuranceBodyExpDate";
            this.InsuranceBodyExpDate.Name = "InsuranceBodyExpDate";
            this.InsuranceBodyExpDate.Visible = true;
            this.InsuranceBodyExpDate.VisibleIndex = 0;
            this.InsuranceBodyExpDate.Width = 58;
            // 
            // CarID
            // 
            this.CarID.Caption = "کد اتومبیل";
            this.CarID.FieldName = "CarID";
            this.CarID.Name = "CarID";
            // 
            // InsuranceThirdPrice
            // 
            this.InsuranceThirdPrice.Caption = "مبلغ بیمه ثالث";
            this.InsuranceThirdPrice.FieldName = "InsuranceThirdPrice";
            this.InsuranceThirdPrice.Name = "InsuranceThirdPrice";
            // 
            // InsuranceBodyPrice
            // 
            this.InsuranceBodyPrice.Caption = "مبلغ بیمه بدنه";
            this.InsuranceBodyPrice.FieldName = "InsuranceBodyPrice";
            this.InsuranceBodyPrice.Name = "InsuranceBodyPrice";
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            this.repositoryItemImageEdit1.PopupFormSize = new System.Drawing.Size(260, 150);
            // 
            // textboxitem_status
            // 
            this.textboxitem_status.Name = "textboxitem_status";
            this.textboxitem_status.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textboxitem_status.WatermarkColor = System.Drawing.SystemColors.GrayText;
            // 
            // buttonItem_StatusOK
            // 
            this.buttonItem_StatusOK.ForeColor = System.Drawing.Color.Black;
            this.buttonItem_StatusOK.HotFontBold = true;
            this.buttonItem_StatusOK.Icon = ((System.Drawing.Icon)(resources.GetObject("buttonItem_StatusOK.Icon")));
            this.buttonItem_StatusOK.Name = "buttonItem_StatusOK";
            this.buttonItem_StatusOK.Text = "تایید";
            // 
            // itemPanelCar
            // 
            // 
            // 
            // 
            this.itemPanelCar.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(135)))), ((int)(((byte)(214)))));
            this.itemPanelCar.BackgroundStyle.BackColor2 = System.Drawing.SystemColors.HotTrack;
            this.itemPanelCar.BackgroundStyle.BorderBottomWidth = 1;
            this.itemPanelCar.BackgroundStyle.BorderLeftWidth = 1;
            this.itemPanelCar.BackgroundStyle.BorderRightWidth = 1;
            this.itemPanelCar.BackgroundStyle.BorderTopWidth = 1;
            this.itemPanelCar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanelCar.BackgroundStyle.PaddingBottom = 1;
            this.itemPanelCar.BackgroundStyle.PaddingLeft = 1;
            this.itemPanelCar.BackgroundStyle.PaddingRight = 1;
            this.itemPanelCar.BackgroundStyle.PaddingTop = 1;
            this.itemPanelCar.ContainerControlProcessDialogKey = true;
            this.itemPanelCar.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemPanelCar.FitButtonsToContainerWidth = true;
            this.itemPanelCar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.itemPanelCar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.itemPanelCar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemCustomSearch,
            this.buttonItemSelector,
            this.buttonItem1,
            this.buttonItemCustomPrintList});
            this.itemPanelCar.Location = new System.Drawing.Point(0, 0);
            this.itemPanelCar.Name = "itemPanelCar";
            this.itemPanelCar.Size = new System.Drawing.Size(969, 57);
            this.itemPanelCar.TabIndex = 40;
            this.itemPanelCar.ThemeAware = true;
            // 
            // buttonItemCustomSearch
            // 
            this.buttonItemCustomSearch.AutoCheckOnClick = true;
            this.buttonItemCustomSearch.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemCustomSearch.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemCustomSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemCustomSearch.Image")));
            this.buttonItemCustomSearch.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemCustomSearch.Name = "buttonItemCustomSearch";
            this.buttonItemCustomSearch.Text = "جستجو";
            this.buttonItemCustomSearch.ThemeAware = true;
            this.buttonItemCustomSearch.Click += new System.EventHandler(this.buttonItemAlarmSearch_Click);
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
            // buttonItem1
            // 
            this.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem1.Enabled = false;
            this.buttonItem1.ForeColor = System.Drawing.Color.Gold;
            this.buttonItem1.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem1.Image")));
            this.buttonItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem3,
            this.buttonItem2});
            this.buttonItem1.Text = "شکل نمایشی";
            this.buttonItem1.ThemeAware = true;
            this.buttonItem1.Visible = false;
            // 
            // buttonItem3
            // 
            this.buttonItem3.Name = "buttonItem3";
            this.buttonItem3.Text = "جدولی";
            this.buttonItem3.ThemeAware = true;
            // 
            // buttonItem2
            // 
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.Text = "کارتی";
            this.buttonItem2.ThemeAware = true;
            // 
            // buttonItemCustomPrintList
            // 
            this.buttonItemCustomPrintList.BeginGroup = true;
            this.buttonItemCustomPrintList.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemCustomPrintList.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemCustomPrintList.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemCustomPrintList.Image")));
            this.buttonItemCustomPrintList.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemCustomPrintList.Name = "buttonItemCustomPrintList";
            this.buttonItemCustomPrintList.Text = "چاپ لیست";
            this.buttonItemCustomPrintList.ThemeAware = true;
            this.buttonItemCustomPrintList.Click += new System.EventHandler(this.buttonItemAlarmPrintList_Click);
            // 
            // tBL_CarTableAdapter
            // 
            this.tBL_CarTableAdapter.ClearBeforeFill = true;
            // 
            // sP_AlarmViewForDefinitionTableAdapter
            // 
            this.sP_AlarmViewForDefinitionTableAdapter.ClearBeforeFill = true;
            // 
            // tBLCarSPAlarmViewForDefinitionBindingSource
            // 
            this.tBLCarSPAlarmViewForDefinitionBindingSource.DataMember = "TBL_Car_SP_AlarmViewForDefinition";
            this.tBLCarSPAlarmViewForDefinitionBindingSource.DataSource = this.tBLCarBindingSource;
            // 
            // AlarmList_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl_AlarmList);
            this.Controls.Add(this.itemPanelCar);
            this.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AlarmList_UC";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(969, 547);
            this.Load += new System.EventHandler(this.AlarmList_UC_Load);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.AlarmList_UC_Layout);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAlarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_AlarmList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLCarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRentReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_AlarmList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLCarSPAlarmViewForDefinitionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.TextBoxItem textboxitem_status;
        private DevComponents.DotNetBar.ButtonItem buttonItem_StatusOK;
        private DevComponents.DotNetBar.ItemPanel itemPanelCar;
        private DevComponents.DotNetBar.ButtonItem buttonItemCustomSearch;
        private DevComponents.DotNetBar.ButtonItem buttonItemSelector;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItem3;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ButtonItem buttonItemCustomPrintList;
        private System.Windows.Forms.BindingSource tBLCarBindingSource;
        private DataSetRentReport dataSetRentReport;
        private RentCarPrj.DataSetRentReportTableAdapters.TBL_CarTableAdapter tBL_CarTableAdapter;
        private RentCarPrj.DataSetRentReportTableAdapters.SP_AlarmViewForDefinitionTableAdapter sP_AlarmViewForDefinitionTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl_AlarmList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_AlarmList;
        private DevExpress.XtraGrid.Columns.GridColumn CarName;
        private DevExpress.XtraGrid.Columns.GridColumn CarPic;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn LordName;
        private DevExpress.XtraGrid.Columns.GridColumn CarType;
        private DevExpress.XtraGrid.Columns.GridColumn DisciplineNO;
        private DevExpress.XtraGrid.Columns.GridColumn EnterTypeStr;
        private DevExpress.XtraGrid.Columns.GridColumn MadeCountry;
        private DevExpress.XtraGrid.Columns.GridColumn ColorSet;
        private DevExpress.XtraGrid.Columns.GridColumn ProductDate;
        private DevExpress.XtraGrid.Columns.GridColumn InsuranceThirdExpDate;
        private DevExpress.XtraGrid.Columns.GridColumn InsuranceBodyExpDate;
        private DevExpress.XtraGrid.Columns.GridColumn CarID;
        private DevExpress.XtraGrid.Columns.GridColumn InsuranceThirdPrice;
        private DevExpress.XtraGrid.Columns.GridColumn InsuranceBodyPrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAlarm;
        private DevExpress.XtraGrid.Columns.GridColumn DateAction;
        private DevExpress.XtraGrid.Columns.GridColumn DscAction;
        private DevExpress.XtraGrid.Columns.GridColumn NextKM;
        private DevExpress.XtraGrid.Columns.GridColumn NowKM;
        private System.Windows.Forms.BindingSource tBLCarSPAlarmViewForDefinitionBindingSource;
    }
}
