namespace RentCarPrj
{
    partial class CustomersDutyRep_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersDutyRep_frm));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition3 = new DevExpress.XtraGrid.StyleFormatCondition();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition4 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.CarName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textboxitem_status = new DevComponents.DotNetBar.TextBoxItem();
            this.buttonItem_StatusOK = new DevComponents.DotNetBar.ButtonItem();
            this.gridView_CustomerList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RowNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DutyDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DutyNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DutyTypeStr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CarNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CarPic = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.ColorSet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BodyNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EngineNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RentPersonName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DeliveryDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RejectDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OperatorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RentTypeStr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl_CustomerList = new DevExpress.XtraGrid.GridControl();
            this.itemPanelRCustomer = new DevComponents.DotNetBar.ItemPanel();
            this.buttonItemCustomSearch = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemSelector = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemCustomPrintList = new DevComponents.DotNetBar.ButtonItem();
            this.groupPanel4 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.button_RentPersonCode = new DevComponents.DotNetBar.ButtonX();
            this.label35 = new System.Windows.Forms.Label();
            this.textBox_RentPersonCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.button_View = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_CustomerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_CustomerList)).BeginInit();
            this.groupPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // CarName
            // 
            this.CarName.Caption = "نام اتومبیل";
            this.CarName.FieldName = "CarName";
            this.CarName.Name = "CarName";
            this.CarName.Visible = true;
            this.CarName.VisibleIndex = 4;
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
            // gridView_CustomerList
            // 
            this.gridView_CustomerList.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_CustomerList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_CustomerList.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_CustomerList.Appearance.Row.Options.UseTextOptions = true;
            this.gridView_CustomerList.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_CustomerList.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_CustomerList.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridView_CustomerList.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_CustomerList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.RowNumber,
            this.DutyDate,
            this.DutyNumber,
            this.DutyTypeStr,
            this.CarNumber,
            this.CarName,
            this.CarPic,
            this.ColorSet,
            this.BodyNo,
            this.EngineNumber,
            this.RentPersonName,
            this.DeliveryDate,
            this.RejectDate,
            this.OperatorName,
            this.RentTypeStr,
            this.TotalPrice});
            this.gridView_CustomerList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.PaleGreen;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.CarName;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = "1";
            styleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            styleFormatCondition2.Appearance.Options.UseBackColor = true;
            styleFormatCondition2.ApplyToRow = true;
            styleFormatCondition2.Column = this.CarName;
            styleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition2.Value1 = "2";
            styleFormatCondition3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            styleFormatCondition3.Appearance.Options.UseBackColor = true;
            styleFormatCondition3.ApplyToRow = true;
            styleFormatCondition3.Column = this.CarName;
            styleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition3.Value1 = "3";
            styleFormatCondition4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            styleFormatCondition4.Appearance.Options.UseBackColor = true;
            styleFormatCondition4.ApplyToRow = true;
            styleFormatCondition4.Column = this.CarName;
            styleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition4.Value1 = "4";
            this.gridView_CustomerList.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1,
            styleFormatCondition2,
            styleFormatCondition3,
            styleFormatCondition4});
            this.gridView_CustomerList.GridControl = this.gridControl_CustomerList;
            this.gridView_CustomerList.Name = "gridView_CustomerList";
            this.gridView_CustomerList.OptionsBehavior.Editable = false;
            this.gridView_CustomerList.OptionsCustomization.AllowGroup = false;
            this.gridView_CustomerList.OptionsCustomization.AllowRowSizing = true;
            this.gridView_CustomerList.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView_CustomerList.OptionsFilter.AllowFilterEditor = false;
            this.gridView_CustomerList.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridView_CustomerList.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView_CustomerList.OptionsView.ShowGroupPanel = false;
            this.gridView_CustomerList.OptionsView.ShowIndicator = false;
            // 
            // RowNumber
            // 
            this.RowNumber.Caption = "ردیف";
            this.RowNumber.FieldName = "RowNumber";
            this.RowNumber.Name = "RowNumber";
            this.RowNumber.Visible = true;
            this.RowNumber.VisibleIndex = 7;
            // 
            // DutyDate
            // 
            this.DutyDate.Caption = "تاریخ سرویس";
            this.DutyDate.FieldName = "DutyDate";
            this.DutyDate.Name = "DutyDate";
            this.DutyDate.Visible = true;
            this.DutyDate.VisibleIndex = 6;
            // 
            // DutyNumber
            // 
            this.DutyNumber.Caption = "شماره سرویس";
            this.DutyNumber.FieldName = "DutyNumber";
            this.DutyNumber.Name = "DutyNumber";
            this.DutyNumber.Visible = true;
            this.DutyNumber.VisibleIndex = 5;
            // 
            // DutyTypeStr
            // 
            this.DutyTypeStr.Caption = "وضعیت امانت ";
            this.DutyTypeStr.FieldName = "DutyTypeStr";
            this.DutyTypeStr.Name = "DutyTypeStr";
            // 
            // CarNumber
            // 
            this.CarNumber.Caption = "کد اتومبیل";
            this.CarNumber.FieldName = "CarNumber";
            this.CarNumber.Name = "CarNumber";
            // 
            // CarPic
            // 
            this.CarPic.Caption = "تصویر";
            this.CarPic.ColumnEdit = this.repositoryItemPictureEdit1;
            this.CarPic.FieldName = "CarPic";
            this.CarPic.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.CarPic.Name = "CarPic";
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            // 
            // ColorSet
            // 
            this.ColorSet.Caption = "رنگ خودرو";
            this.ColorSet.FieldName = "ColorSet";
            this.ColorSet.Name = "ColorSet";
            // 
            // BodyNo
            // 
            this.BodyNo.Caption = "شماره بدنه";
            this.BodyNo.FieldName = "BodyNo";
            this.BodyNo.Name = "BodyNo";
            // 
            // EngineNumber
            // 
            this.EngineNumber.Caption = "شماره موتور";
            this.EngineNumber.FieldName = "EngineNumber";
            this.EngineNumber.Name = "EngineNumber";
            // 
            // RentPersonName
            // 
            this.RentPersonName.Caption = "نام امانت گیرنده";
            this.RentPersonName.FieldName = "RentPersonName";
            this.RentPersonName.Name = "RentPersonName";
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.Caption = "تاریخ تحویل";
            this.DeliveryDate.FieldName = "DeliveryDate";
            this.DeliveryDate.Name = "DeliveryDate";
            this.DeliveryDate.Visible = true;
            this.DeliveryDate.VisibleIndex = 3;
            // 
            // RejectDate
            // 
            this.RejectDate.Caption = "تاریخ عودت";
            this.RejectDate.FieldName = "RejectDate";
            this.RejectDate.Name = "RejectDate";
            this.RejectDate.Visible = true;
            this.RejectDate.VisibleIndex = 2;
            // 
            // OperatorName
            // 
            this.OperatorName.Caption = "نام کارگزار";
            this.OperatorName.FieldName = "OperatorName";
            this.OperatorName.Name = "OperatorName";
            this.OperatorName.Visible = true;
            this.OperatorName.VisibleIndex = 1;
            // 
            // RentTypeStr
            // 
            this.RentTypeStr.Caption = "نوع اجاره";
            this.RentTypeStr.FieldName = "RentTypeStr";
            this.RentTypeStr.Name = "RentTypeStr";
            // 
            // TotalPrice
            // 
            this.TotalPrice.Caption = "مبلغ کل";
            this.TotalPrice.FieldName = "TotalPrice";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Visible = true;
            this.TotalPrice.VisibleIndex = 0;
            // 
            // gridControl_CustomerList
            // 
            this.gridControl_CustomerList.AllowDrop = true;
            this.gridControl_CustomerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_CustomerList.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl_CustomerList.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl_CustomerList.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl_CustomerList.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl_CustomerList.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl_CustomerList.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.gridControl_CustomerList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl_CustomerList.EmbeddedNavigator.TextStringFormat = "رکورد {0} از {1}";
            this.gridControl_CustomerList.Location = new System.Drawing.Point(0, 58);
            this.gridControl_CustomerList.LookAndFeel.SkinName = "Office 2010 Blue";
            this.gridControl_CustomerList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl_CustomerList.MainView = this.gridView_CustomerList;
            this.gridControl_CustomerList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl_CustomerList.Name = "gridControl_CustomerList";
            this.gridControl_CustomerList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.gridControl_CustomerList.Size = new System.Drawing.Size(922, 346);
            this.gridControl_CustomerList.TabIndex = 37;
            this.gridControl_CustomerList.UseEmbeddedNavigator = true;
            this.gridControl_CustomerList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_CustomerList});
            // 
            // itemPanelRCustomer
            // 
            // 
            // 
            // 
            this.itemPanelRCustomer.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(135)))), ((int)(((byte)(214)))));
            this.itemPanelRCustomer.BackgroundStyle.BackColor2 = System.Drawing.SystemColors.HotTrack;
            this.itemPanelRCustomer.BackgroundStyle.BorderBottomWidth = 1;
            this.itemPanelRCustomer.BackgroundStyle.BorderLeftWidth = 1;
            this.itemPanelRCustomer.BackgroundStyle.BorderRightWidth = 1;
            this.itemPanelRCustomer.BackgroundStyle.BorderTopWidth = 1;
            this.itemPanelRCustomer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanelRCustomer.BackgroundStyle.PaddingBottom = 1;
            this.itemPanelRCustomer.BackgroundStyle.PaddingLeft = 1;
            this.itemPanelRCustomer.BackgroundStyle.PaddingRight = 1;
            this.itemPanelRCustomer.BackgroundStyle.PaddingTop = 1;
            this.itemPanelRCustomer.ContainerControlProcessDialogKey = true;
            this.itemPanelRCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemPanelRCustomer.FitButtonsToContainerWidth = true;
            this.itemPanelRCustomer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.itemPanelRCustomer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.itemPanelRCustomer.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemCustomSearch,
            this.buttonItemSelector,
            this.buttonItemCustomPrintList});
            this.itemPanelRCustomer.Location = new System.Drawing.Point(0, 0);
            this.itemPanelRCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemPanelRCustomer.Name = "itemPanelRCustomer";
            this.itemPanelRCustomer.Size = new System.Drawing.Size(922, 58);
            this.itemPanelRCustomer.TabIndex = 40;
            this.itemPanelRCustomer.ThemeAware = true;
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
            this.buttonItemCustomSearch.Click += new System.EventHandler(this.buttonItemCustomSearch_Click);
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
            this.buttonItemCustomPrintList.Click += new System.EventHandler(this.buttonItemCustomPrintList_Click);
            // 
            // groupPanel4
            // 
            this.groupPanel4.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel4.Controls.Add(this.button_RentPersonCode);
            this.groupPanel4.Controls.Add(this.label35);
            this.groupPanel4.Controls.Add(this.textBox_RentPersonCode);
            this.groupPanel4.Controls.Add(this.button_View);
            this.groupPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupPanel4.Location = new System.Drawing.Point(0, 404);
            this.groupPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.groupPanel4.Name = "groupPanel4";
            this.groupPanel4.Size = new System.Drawing.Size(922, 52);
            // 
            // 
            // 
            this.groupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel4.Style.BackColorGradientAngle = 90;
            this.groupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderBottomWidth = 1;
            this.groupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderLeftWidth = 1;
            this.groupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderRightWidth = 1;
            this.groupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderTopWidth = 1;
            this.groupPanel4.Style.CornerDiameter = 4;
            this.groupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel4.TabIndex = 41;
            // 
            // button_RentPersonCode
            // 
            this.button_RentPersonCode.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_RentPersonCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_RentPersonCode.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_RentPersonCode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button_RentPersonCode.Location = new System.Drawing.Point(519, 12);
            this.button_RentPersonCode.Name = "button_RentPersonCode";
            this.button_RentPersonCode.Size = new System.Drawing.Size(67, 21);
            this.button_RentPersonCode.TabIndex = 341;
            this.button_RentPersonCode.Text = "...";
            this.button_RentPersonCode.Tooltip = "انتخاب از لیست";
            this.button_RentPersonCode.Click += new System.EventHandler(this.button_RentPersonCode_Click);
            // 
            // label35
            // 
            this.label35.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label35.ForeColor = System.Drawing.Color.Black;
            this.label35.Location = new System.Drawing.Point(808, 17);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(83, 13);
            this.label35.TabIndex = 342;
            this.label35.Text = "نام امانت گیرنده:";
            // 
            // textBox_RentPersonCode
            // 
            this.textBox_RentPersonCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBox_RentPersonCode.Border.Class = "TextBoxBorder";
            this.textBox_RentPersonCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBox_RentPersonCode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBox_RentPersonCode.ForeColor = System.Drawing.Color.Black;
            this.textBox_RentPersonCode.Location = new System.Drawing.Point(596, 12);
            this.textBox_RentPersonCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_RentPersonCode.MaxLength = 50;
            this.textBox_RentPersonCode.Name = "textBox_RentPersonCode";
            this.textBox_RentPersonCode.ReadOnly = true;
            this.textBox_RentPersonCode.Size = new System.Drawing.Size(206, 21);
            this.textBox_RentPersonCode.TabIndex = 340;
            // 
            // button_View
            // 
            this.button_View.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_View.BackColor = System.Drawing.Color.Transparent;
            this.button_View.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.button_View.Location = new System.Drawing.Point(67, 10);
            this.button_View.Name = "button_View";
            this.button_View.Size = new System.Drawing.Size(187, 28);
            this.button_View.TabIndex = 18;
            this.button_View.Text = "نمایش اطلاعات";
            this.button_View.Click += new System.EventHandler(this.button_View_Click);
            // 
            // CustomersDutyRep_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 456);
            this.Controls.Add(this.gridControl_CustomerList);
            this.Controls.Add(this.groupPanel4);
            this.Controls.Add(this.itemPanelRCustomer);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CustomersDutyRep_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "گزارش سرویس های اشخاص";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CustomersDutyRep_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView_CustomerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_CustomerList)).EndInit();
            this.groupPanel4.ResumeLayout(false);
            this.groupPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.TextBoxItem textboxitem_status;
        private DevComponents.DotNetBar.ButtonItem buttonItem_StatusOK;
        private DevExpress.XtraGrid.GridControl gridControl_CustomerList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_CustomerList;
        private DevComponents.DotNetBar.ItemPanel itemPanelRCustomer;
        private DevComponents.DotNetBar.ButtonItem buttonItemCustomSearch;
        private DevComponents.DotNetBar.ButtonItem buttonItemSelector;
        private DevComponents.DotNetBar.ButtonItem buttonItemCustomPrintList;
        private DevExpress.XtraGrid.Columns.GridColumn DutyNumber;
        private DevExpress.XtraGrid.Columns.GridColumn CarName;
        private DevExpress.XtraGrid.Columns.GridColumn DutyDate;
        private DevExpress.XtraGrid.Columns.GridColumn RentPersonName;
        private DevExpress.XtraGrid.Columns.GridColumn CarNumber;
        private DevExpress.XtraGrid.Columns.GridColumn DutyTypeStr;
        private DevExpress.XtraGrid.Columns.GridColumn ColorSet;
        private DevExpress.XtraGrid.Columns.GridColumn DeliveryDate;
        private DevExpress.XtraGrid.Columns.GridColumn RejectDate;
        private DevExpress.XtraGrid.Columns.GridColumn OperatorName;
        private DevExpress.XtraGrid.Columns.GridColumn RentTypeStr;
        private DevExpress.XtraGrid.Columns.GridColumn TotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn CarPic;
        private DevExpress.XtraGrid.Columns.GridColumn AddressBusiness;
        private DevExpress.XtraGrid.Columns.GridColumn TelBusiness;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel4;
        private DevComponents.DotNetBar.ButtonX button_View;
        private DevComponents.DotNetBar.ButtonX button_RentPersonCode;
        private System.Windows.Forms.Label label35;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_RentPersonCode;
        private DevExpress.XtraGrid.Columns.GridColumn RowNumber;
        private DevExpress.XtraGrid.Columns.GridColumn BodyNo;
        private DevExpress.XtraGrid.Columns.GridColumn EngineNumber;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
    }
}
