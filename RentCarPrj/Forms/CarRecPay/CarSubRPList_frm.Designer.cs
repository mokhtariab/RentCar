namespace RentCarPrj
{
    partial class CarSubRPList_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarSubRPList_Frm));
            this.gridControl_CarSubRPList = new DevExpress.XtraGrid.GridControl();
            this.gridView_CarSubRPList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RecPayID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RecPayDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RPCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TransferType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RecPayPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChqNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChqDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChqBank = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChqFor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChqPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Comment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemPanelCarSubRP = new DevComponents.DotNetBar.ItemPanel();
            this.buttonItemCost = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemChq = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemDebit = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemEditRecPay = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemDelRecPay = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemCarSubRPSearch = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemSelector = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemCarSubRPPrintList = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar_CarFace = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem_OK = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_CarSubRPList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_CarSubRPList)).BeginInit();
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
            this.gridControl_CarSubRPList.MainView = this.gridView_CarSubRPList;
            this.gridControl_CarSubRPList.Name = "gridControl_CarSubRPList";
            this.gridControl_CarSubRPList.Size = new System.Drawing.Size(679, 280);
            this.gridControl_CarSubRPList.TabIndex = 40;
            this.gridControl_CarSubRPList.UseEmbeddedNavigator = true;
            this.gridControl_CarSubRPList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_CarSubRPList});
            // 
            // gridView_CarSubRPList
            // 
            this.gridView_CarSubRPList.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView_CarSubRPList.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_CarSubRPList.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_CarSubRPList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gridView_CarSubRPList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_CarSubRPList.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_CarSubRPList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_CarSubRPList.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_CarSubRPList.Appearance.Row.Options.UseTextOptions = true;
            this.gridView_CarSubRPList.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_CarSubRPList.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_CarSubRPList.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridView_CarSubRPList.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_CarSubRPList.ColumnPanelRowHeight = 25;
            this.gridView_CarSubRPList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.RecPayID,
            this.RecPayDate,
            this.RPCustomerName,
            this.TransferType,
            this.RecPayPrice,
            this.ChqNO,
            this.ChqDate,
            this.ChqBank,
            this.ChqFor,
            this.ChqPerson,
            this.Comment});
            this.gridView_CarSubRPList.CustomizationFormBounds = new System.Drawing.Rectangle(1374, 615, 216, 171);
            this.gridView_CarSubRPList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater;
            styleFormatCondition1.Value1 = "1";
            this.gridView_CarSubRPList.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView_CarSubRPList.GridControl = this.gridControl_CarSubRPList;
            this.gridView_CarSubRPList.Name = "gridView_CarSubRPList";
            this.gridView_CarSubRPList.OptionsBehavior.Editable = false;
            this.gridView_CarSubRPList.OptionsCustomization.AllowGroup = false;
            this.gridView_CarSubRPList.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView_CarSubRPList.OptionsFilter.AllowFilterEditor = false;
            this.gridView_CarSubRPList.OptionsLayout.Columns.StoreAllOptions = true;
            this.gridView_CarSubRPList.OptionsLayout.Columns.StoreAppearance = true;
            this.gridView_CarSubRPList.OptionsLayout.StoreAllOptions = true;
            this.gridView_CarSubRPList.OptionsLayout.StoreAppearance = true;
            this.gridView_CarSubRPList.OptionsPrint.PrintPreview = true;
            this.gridView_CarSubRPList.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView_CarSubRPList.OptionsView.ShowFooter = true;
            this.gridView_CarSubRPList.OptionsView.ShowGroupPanel = false;
            this.gridView_CarSubRPList.OptionsView.ShowIndicator = false;
            this.gridView_CarSubRPList.PaintStyleName = "Skin";
            this.gridView_CarSubRPList.RowHeight = 20;
            // 
            // RecPayID
            // 
            this.RecPayID.Caption = "کد";
            this.RecPayID.FieldName = "RecPayID";
            this.RecPayID.Name = "RecPayID";
            // 
            // RecPayDate
            // 
            this.RecPayDate.Caption = "تاریخ دریافت پرداخت";
            this.RecPayDate.FieldName = "RecPayDate";
            this.RecPayDate.Name = "RecPayDate";
            this.RecPayDate.Visible = true;
            this.RecPayDate.VisibleIndex = 6;
            this.RecPayDate.Width = 148;
            // 
            // RPCustomerName
            // 
            this.RPCustomerName.Caption = "نام شخص";
            this.RPCustomerName.FieldName = "RPCustomerName";
            this.RPCustomerName.Name = "RPCustomerName";
            this.RPCustomerName.Width = 113;
            // 
            // TransferType
            // 
            this.TransferType.Caption = "نوع";
            this.TransferType.FieldName = "TransferType";
            this.TransferType.Name = "TransferType";
            this.TransferType.Visible = true;
            this.TransferType.VisibleIndex = 5;
            this.TransferType.Width = 83;
            // 
            // RecPayPrice
            // 
            this.RecPayPrice.Caption = "مبلغ";
            this.RecPayPrice.FieldName = "RecPayPrice";
            this.RecPayPrice.Name = "RecPayPrice";
            this.RecPayPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.RecPayPrice.Visible = true;
            this.RecPayPrice.VisibleIndex = 4;
            this.RecPayPrice.Width = 91;
            // 
            // ChqNO
            // 
            this.ChqNO.Caption = "شماره چک";
            this.ChqNO.FieldName = "ChqNO";
            this.ChqNO.Name = "ChqNO";
            this.ChqNO.Visible = true;
            this.ChqNO.VisibleIndex = 3;
            this.ChqNO.Width = 108;
            // 
            // ChqDate
            // 
            this.ChqDate.Caption = "تاریخ چک";
            this.ChqDate.FieldName = "ChqDate";
            this.ChqDate.Name = "ChqDate";
            this.ChqDate.Visible = true;
            this.ChqDate.VisibleIndex = 2;
            this.ChqDate.Width = 89;
            // 
            // ChqBank
            // 
            this.ChqBank.Caption = "نام بانک";
            this.ChqBank.FieldName = "ChqBank";
            this.ChqBank.Name = "ChqBank";
            this.ChqBank.Visible = true;
            this.ChqBank.VisibleIndex = 1;
            this.ChqBank.Width = 85;
            // 
            // ChqFor
            // 
            this.ChqFor.Caption = "بابت";
            this.ChqFor.FieldName = "ChqFor";
            this.ChqFor.Name = "ChqFor";
            this.ChqFor.Width = 104;
            // 
            // ChqPerson
            // 
            this.ChqPerson.Caption = "در وجه";
            this.ChqPerson.FieldName = "ChqPerson";
            this.ChqPerson.Name = "ChqPerson";
            this.ChqPerson.Visible = true;
            this.ChqPerson.VisibleIndex = 0;
            this.ChqPerson.Width = 71;
            // 
            // Comment
            // 
            this.Comment.Caption = "توضیحات";
            this.Comment.FieldName = "Comment";
            this.Comment.Name = "Comment";
            this.Comment.Width = 122;
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
            this.buttonItemCost,
            this.buttonItemChq,
            this.buttonItemDebit,
            this.buttonItemEditRecPay,
            this.buttonItemDelRecPay,
            this.buttonItemCarSubRPSearch,
            this.buttonItemSelector,
            this.buttonItemCarSubRPPrintList});
            this.itemPanelCarSubRP.Location = new System.Drawing.Point(0, 0);
            this.itemPanelCarSubRP.Name = "itemPanelCarSubRP";
            this.itemPanelCarSubRP.Size = new System.Drawing.Size(679, 57);
            this.itemPanelCarSubRP.TabIndex = 41;
            this.itemPanelCarSubRP.ThemeAware = true;
            // 
            // buttonItemCost
            // 
            this.buttonItemCost.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemCost.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemCost.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemCost.Image")));
            this.buttonItemCost.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemCost.Name = "buttonItemCost";
            this.buttonItemCost.Text = "ثبت نقدی";
            this.buttonItemCost.ThemeAware = true;
            this.buttonItemCost.Click += new System.EventHandler(this.buttonItemCost_Click);
            // 
            // buttonItemChq
            // 
            this.buttonItemChq.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemChq.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemChq.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemChq.Image")));
            this.buttonItemChq.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemChq.Name = "buttonItemChq";
            this.buttonItemChq.Text = "ثبت چک";
            this.buttonItemChq.ThemeAware = true;
            this.buttonItemChq.Click += new System.EventHandler(this.buttonItemChq_Click);
            // 
            // buttonItemDebit
            // 
            this.buttonItemDebit.BeginGroup = true;
            this.buttonItemDebit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemDebit.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemDebit.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemDebit.Image")));
            this.buttonItemDebit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemDebit.Name = "buttonItemDebit";
            this.buttonItemDebit.Text = "ثبت بدهی-قرض";
            this.buttonItemDebit.ThemeAware = true;
            this.buttonItemDebit.Click += new System.EventHandler(this.buttonItemDebit_Click);
            // 
            // buttonItemEditRecPay
            // 
            this.buttonItemEditRecPay.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemEditRecPay.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemEditRecPay.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemEditRecPay.Image")));
            this.buttonItemEditRecPay.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemEditRecPay.Name = "buttonItemEditRecPay";
            this.buttonItemEditRecPay.Text = "ویرایش";
            this.buttonItemEditRecPay.ThemeAware = true;
            this.buttonItemEditRecPay.Click += new System.EventHandler(this.buttonItemEditRecPay_Click);
            // 
            // buttonItemDelRecPay
            // 
            this.buttonItemDelRecPay.BeginGroup = true;
            this.buttonItemDelRecPay.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemDelRecPay.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemDelRecPay.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemDelRecPay.Image")));
            this.buttonItemDelRecPay.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemDelRecPay.Name = "buttonItemDelRecPay";
            this.buttonItemDelRecPay.Text = "حذف";
            this.buttonItemDelRecPay.ThemeAware = true;
            this.buttonItemDelRecPay.Click += new System.EventHandler(this.buttonItemDelRecPay_Click);
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
            // buttonItemCarSubRPPrintList
            // 
            this.buttonItemCarSubRPPrintList.BeginGroup = true;
            this.buttonItemCarSubRPPrintList.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemCarSubRPPrintList.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemCarSubRPPrintList.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemCarSubRPPrintList.Image")));
            this.buttonItemCarSubRPPrintList.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemCarSubRPPrintList.Name = "buttonItemCarSubRPPrintList";
            this.buttonItemCarSubRPPrintList.Text = "چاپ لیست";
            this.buttonItemCarSubRPPrintList.ThemeAware = true;
            this.buttonItemCarSubRPPrintList.Click += new System.EventHandler(this.buttonItemCarSubRPPrintList_Click);
            // 
            // ribbonBar_CarFace
            // 
            this.ribbonBar_CarFace.AutoOverflowEnabled = true;
            this.ribbonBar_CarFace.AutoScroll = true;
            this.ribbonBar_CarFace.AutoScrollMinSize = new System.Drawing.Size(480, 50);
            // 
            // 
            // 
            this.ribbonBar_CarFace.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar_CarFace.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar_CarFace.ContainerControlProcessDialogKey = true;
            this.ribbonBar_CarFace.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ribbonBar_CarFace.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonBar_CarFace.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem_OK});
            this.ribbonBar_CarFace.Location = new System.Drawing.Point(0, 337);
            this.ribbonBar_CarFace.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonBar_CarFace.Name = "ribbonBar_CarFace";
            this.ribbonBar_CarFace.Size = new System.Drawing.Size(679, 50);
            this.ribbonBar_CarFace.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.ribbonBar_CarFace.TabIndex = 42;
            // 
            // 
            // 
            this.ribbonBar_CarFace.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.ribbonBar_CarFace.TitleStyle.CornerTypeBottomLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.ribbonBar_CarFace.TitleStyle.CornerTypeBottomRight = DevComponents.DotNetBar.eCornerType.Rounded;
            this.ribbonBar_CarFace.TitleStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded;
            this.ribbonBar_CarFace.TitleStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded;
            // 
            // 
            // 
            this.ribbonBar_CarFace.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar_CarFace.TitleVisible = false;
            // 
            // buttonItem_OK
            // 
            this.buttonItem_OK.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem_OK.FixedSize = new System.Drawing.Size(200, 50);
            this.buttonItem_OK.HotFontBold = true;
            this.buttonItem_OK.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem_OK.Image")));
            this.buttonItem_OK.ImageListSizeSelection = DevComponents.DotNetBar.eButtonImageListSelection.Default;
            this.buttonItem_OK.Name = "buttonItem_OK";
            this.buttonItem_OK.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F2);
            this.buttonItem_OK.SubItemsExpandWidth = 20;
            this.buttonItem_OK.Text = "تایید و بسته شدن";
            this.buttonItem_OK.Tooltip = "F2";
            this.buttonItem_OK.Click += new System.EventHandler(this.buttonItem_OK_Click);
            // 
            // CarSubRPList_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 387);
            this.Controls.Add(this.gridControl_CarSubRPList);
            this.Controls.Add(this.itemPanelCarSubRP);
            this.Controls.Add(this.ribbonBar_CarFace);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CarSubRPList_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست نجوه دریافت پرداخت مبالغ قراردادها";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CarSubRPList_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_CarSubRPList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_CarSubRPList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_CarSubRPList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_CarSubRPList;
        private DevExpress.XtraGrid.Columns.GridColumn RPCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn ChqNO;
        private DevExpress.XtraGrid.Columns.GridColumn ChqDate;
        private DevExpress.XtraGrid.Columns.GridColumn ChqBank;
        private DevExpress.XtraGrid.Columns.GridColumn ChqFor;
        private DevExpress.XtraGrid.Columns.GridColumn RecPayDate;
        private DevExpress.XtraGrid.Columns.GridColumn Comment;
        private DevExpress.XtraGrid.Columns.GridColumn RecPayID;
        private DevComponents.DotNetBar.ItemPanel itemPanelCarSubRP;
        private DevComponents.DotNetBar.ButtonItem buttonItemEditRecPay;
        private DevComponents.DotNetBar.ButtonItem buttonItemDelRecPay;
        private DevComponents.DotNetBar.ButtonItem buttonItemCarSubRPSearch;
        private DevComponents.DotNetBar.ButtonItem buttonItemSelector;
        private DevComponents.DotNetBar.ButtonItem buttonItemCarSubRPPrintList;
        private DevComponents.DotNetBar.ButtonItem buttonItemCost;
        private DevExpress.XtraGrid.Columns.GridColumn RecPayPrice;
        private DevExpress.XtraGrid.Columns.GridColumn TransferType;
        private DevExpress.XtraGrid.Columns.GridColumn ChqPerson;
        private DevComponents.DotNetBar.RibbonBar ribbonBar_CarFace;
        private DevComponents.DotNetBar.ButtonItem buttonItem_OK;
        private DevComponents.DotNetBar.ButtonItem buttonItemChq;
        private DevComponents.DotNetBar.ButtonItem buttonItemDebit;
    }
}