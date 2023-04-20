namespace RentCarPrj
{
    partial class ActionCarList_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActionCarList_frm));
            this.gridControl_ActionCarList = new DevExpress.XtraGrid.GridControl();
            this.gridView_ActionCarList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CarID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ActionCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ActionTypeDsc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ActionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ActionPlace = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TelPlace = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductUse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NowKM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NextKM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ActionDsc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemPanelActionCar = new DevComponents.DotNetBar.ItemPanel();
            this.buttonItemActionAdd = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemActionEdit = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemActionDel = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemActionCarSearch = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemSelector = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemActionCarPrintList = new DevComponents.DotNetBar.ButtonItem();
            this.panelNowKM = new DevComponents.DotNetBar.PanelEx();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ActionCarList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_ActionCarList)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_ActionCarList
            // 
            this.gridControl_ActionCarList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_ActionCarList.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl_ActionCarList.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl_ActionCarList.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl_ActionCarList.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl_ActionCarList.EmbeddedNavigator.Buttons.First.Hint = "ابتدا";
            this.gridControl_ActionCarList.EmbeddedNavigator.Buttons.Last.Hint = "آخرین";
            this.gridControl_ActionCarList.EmbeddedNavigator.Buttons.Next.Hint = "بعدی";
            this.gridControl_ActionCarList.EmbeddedNavigator.Buttons.NextPage.Hint = "صفحه بعدی";
            this.gridControl_ActionCarList.EmbeddedNavigator.Buttons.Prev.Hint = "قبلی";
            this.gridControl_ActionCarList.EmbeddedNavigator.Buttons.PrevPage.Hint = "صفحه قبلی";
            this.gridControl_ActionCarList.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl_ActionCarList.EmbeddedNavigator.Text = "لیست اتومبیل ها";
            this.gridControl_ActionCarList.EmbeddedNavigator.TextStringFormat = "رکورد {0} از {1}";
            this.gridControl_ActionCarList.Location = new System.Drawing.Point(0, 57);
            this.gridControl_ActionCarList.LookAndFeel.SkinName = "Office 2010 Blue";
            this.gridControl_ActionCarList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl_ActionCarList.MainView = this.gridView_ActionCarList;
            this.gridControl_ActionCarList.Name = "gridControl_ActionCarList";
            this.gridControl_ActionCarList.Size = new System.Drawing.Size(856, 300);
            this.gridControl_ActionCarList.TabIndex = 40;
            this.gridControl_ActionCarList.UseEmbeddedNavigator = true;
            this.gridControl_ActionCarList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_ActionCarList});
            this.gridControl_ActionCarList.DoubleClick += new System.EventHandler(this.buttonItemEditAction_Click);
            // 
            // gridView_ActionCarList
            // 
            this.gridView_ActionCarList.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView_ActionCarList.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_ActionCarList.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_ActionCarList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gridView_ActionCarList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_ActionCarList.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_ActionCarList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_ActionCarList.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_ActionCarList.Appearance.Row.Options.UseTextOptions = true;
            this.gridView_ActionCarList.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_ActionCarList.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_ActionCarList.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridView_ActionCarList.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_ActionCarList.ColumnPanelRowHeight = 25;
            this.gridView_ActionCarList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.CarID,
            this.ActionCode,
            this.ActionTypeDsc,
            this.ActionDate,
            this.ActionPlace,
            this.TelPlace,
            this.ProductUse,
            this.NowKM,
            this.NextKM,
            this.ActionDsc});
            this.gridView_ActionCarList.CustomizationFormBounds = new System.Drawing.Rectangle(1374, 615, 216, 171);
            this.gridView_ActionCarList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater;
            styleFormatCondition1.Value1 = "1";
            this.gridView_ActionCarList.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView_ActionCarList.GridControl = this.gridControl_ActionCarList;
            this.gridView_ActionCarList.Name = "gridView_ActionCarList";
            this.gridView_ActionCarList.OptionsBehavior.Editable = false;
            this.gridView_ActionCarList.OptionsCustomization.AllowGroup = false;
            this.gridView_ActionCarList.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView_ActionCarList.OptionsFilter.AllowFilterEditor = false;
            this.gridView_ActionCarList.OptionsLayout.Columns.StoreAllOptions = true;
            this.gridView_ActionCarList.OptionsLayout.Columns.StoreAppearance = true;
            this.gridView_ActionCarList.OptionsLayout.StoreAllOptions = true;
            this.gridView_ActionCarList.OptionsLayout.StoreAppearance = true;
            this.gridView_ActionCarList.OptionsPrint.PrintPreview = true;
            this.gridView_ActionCarList.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView_ActionCarList.OptionsView.ShowGroupPanel = false;
            this.gridView_ActionCarList.OptionsView.ShowIndicator = false;
            this.gridView_ActionCarList.PaintStyleName = "Skin";
            this.gridView_ActionCarList.RowHeight = 20;
            // 
            // CarID
            // 
            this.CarID.Caption = "کد اتومبیل";
            this.CarID.FieldName = "CarID";
            this.CarID.Name = "CarID";
            // 
            // ActionCode
            // 
            this.ActionCode.Caption = "کد سرویس";
            this.ActionCode.FieldName = "ActionCode";
            this.ActionCode.Name = "ActionCode";
            this.ActionCode.Visible = true;
            this.ActionCode.VisibleIndex = 7;
            this.ActionCode.Width = 81;
            // 
            // ActionTypeDsc
            // 
            this.ActionTypeDsc.Caption = "نوع سرویس";
            this.ActionTypeDsc.FieldName = "ActionTypeDsc";
            this.ActionTypeDsc.Name = "ActionTypeDsc";
            this.ActionTypeDsc.Visible = true;
            this.ActionTypeDsc.VisibleIndex = 6;
            this.ActionTypeDsc.Width = 108;
            // 
            // ActionDate
            // 
            this.ActionDate.Caption = "تاریخ انجام";
            this.ActionDate.FieldName = "ActionDate";
            this.ActionDate.Name = "ActionDate";
            this.ActionDate.Visible = true;
            this.ActionDate.VisibleIndex = 5;
            this.ActionDate.Width = 80;
            // 
            // ActionPlace
            // 
            this.ActionPlace.Caption = "محل انجام";
            this.ActionPlace.FieldName = "ActionPlace";
            this.ActionPlace.Name = "ActionPlace";
            this.ActionPlace.Visible = true;
            this.ActionPlace.VisibleIndex = 4;
            this.ActionPlace.Width = 113;
            // 
            // TelPlace
            // 
            this.TelPlace.Caption = "تلفن تماس محل";
            this.TelPlace.FieldName = "TelPlace";
            this.TelPlace.Name = "TelPlace";
            this.TelPlace.Visible = true;
            this.TelPlace.VisibleIndex = 3;
            this.TelPlace.Width = 126;
            // 
            // ProductUse
            // 
            this.ProductUse.Caption = "مواد/محصول مصرفی";
            this.ProductUse.FieldName = "ProductUse";
            this.ProductUse.Name = "ProductUse";
            this.ProductUse.Visible = true;
            this.ProductUse.VisibleIndex = 2;
            this.ProductUse.Width = 127;
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
            // NextKM
            // 
            this.NextKM.Caption = "کیلومتر بعدی";
            this.NextKM.FieldName = "NextKM";
            this.NextKM.Name = "NextKM";
            this.NextKM.Visible = true;
            this.NextKM.VisibleIndex = 0;
            this.NextKM.Width = 104;
            // 
            // ActionDsc
            // 
            this.ActionDsc.Caption = "توضیحات";
            this.ActionDsc.FieldName = "ActionDsc";
            this.ActionDsc.Name = "ActionDsc";
            this.ActionDsc.Width = 122;
            // 
            // itemPanelActionCar
            // 
            // 
            // 
            // 
            this.itemPanelActionCar.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(135)))), ((int)(((byte)(214)))));
            this.itemPanelActionCar.BackgroundStyle.BackColor2 = System.Drawing.SystemColors.HotTrack;
            this.itemPanelActionCar.BackgroundStyle.BorderBottomWidth = 1;
            this.itemPanelActionCar.BackgroundStyle.BorderLeftWidth = 1;
            this.itemPanelActionCar.BackgroundStyle.BorderRightWidth = 1;
            this.itemPanelActionCar.BackgroundStyle.BorderTopWidth = 1;
            this.itemPanelActionCar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanelActionCar.BackgroundStyle.PaddingBottom = 1;
            this.itemPanelActionCar.BackgroundStyle.PaddingLeft = 1;
            this.itemPanelActionCar.BackgroundStyle.PaddingRight = 1;
            this.itemPanelActionCar.BackgroundStyle.PaddingTop = 1;
            this.itemPanelActionCar.ContainerControlProcessDialogKey = true;
            this.itemPanelActionCar.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemPanelActionCar.FitButtonsToContainerWidth = true;
            this.itemPanelActionCar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.itemPanelActionCar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.itemPanelActionCar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemActionAdd,
            this.buttonItemActionEdit,
            this.buttonItemActionDel,
            this.buttonItemActionCarSearch,
            this.buttonItemSelector,
            this.buttonItemActionCarPrintList});
            this.itemPanelActionCar.Location = new System.Drawing.Point(0, 0);
            this.itemPanelActionCar.Name = "itemPanelActionCar";
            this.itemPanelActionCar.Size = new System.Drawing.Size(856, 57);
            this.itemPanelActionCar.TabIndex = 41;
            this.itemPanelActionCar.ThemeAware = true;
            // 
            // buttonItemActionAdd
            // 
            this.buttonItemActionAdd.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemActionAdd.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemActionAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemActionAdd.Image")));
            this.buttonItemActionAdd.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemActionAdd.Name = "buttonItemActionAdd";
            this.buttonItemActionAdd.Text = "سرویس جدید";
            this.buttonItemActionAdd.ThemeAware = true;
            this.buttonItemActionAdd.Click += new System.EventHandler(this.buttonItemAddAction_Click);
            // 
            // buttonItemActionEdit
            // 
            this.buttonItemActionEdit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemActionEdit.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemActionEdit.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemActionEdit.Image")));
            this.buttonItemActionEdit.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemActionEdit.Name = "buttonItemActionEdit";
            this.buttonItemActionEdit.Text = "ویرایش";
            this.buttonItemActionEdit.ThemeAware = true;
            this.buttonItemActionEdit.Click += new System.EventHandler(this.buttonItemEditAction_Click);
            // 
            // buttonItemActionDel
            // 
            this.buttonItemActionDel.BeginGroup = true;
            this.buttonItemActionDel.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemActionDel.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemActionDel.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemActionDel.Image")));
            this.buttonItemActionDel.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemActionDel.Name = "buttonItemActionDel";
            this.buttonItemActionDel.Text = "حذف";
            this.buttonItemActionDel.ThemeAware = true;
            this.buttonItemActionDel.Click += new System.EventHandler(this.buttonItemDelAction_Click);
            // 
            // buttonItemActionCarSearch
            // 
            this.buttonItemActionCarSearch.AutoCheckOnClick = true;
            this.buttonItemActionCarSearch.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemActionCarSearch.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemActionCarSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemActionCarSearch.Image")));
            this.buttonItemActionCarSearch.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemActionCarSearch.Name = "buttonItemActionCarSearch";
            this.buttonItemActionCarSearch.Text = "جستجو";
            this.buttonItemActionCarSearch.ThemeAware = true;
            this.buttonItemActionCarSearch.Click += new System.EventHandler(this.buttonItemActionCarSearch_Click);
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
            // buttonItemActionCarPrintList
            // 
            this.buttonItemActionCarPrintList.BeginGroup = true;
            this.buttonItemActionCarPrintList.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemActionCarPrintList.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemActionCarPrintList.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemActionCarPrintList.Image")));
            this.buttonItemActionCarPrintList.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemActionCarPrintList.Name = "buttonItemActionCarPrintList";
            this.buttonItemActionCarPrintList.Text = "چاپ لیست";
            this.buttonItemActionCarPrintList.ThemeAware = true;
            this.buttonItemActionCarPrintList.Click += new System.EventHandler(this.buttonItemActionCarPrintList_Click);
            // 
            // panelNowKM
            // 
            this.panelNowKM.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelNowKM.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelNowKM.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panelNowKM.Location = new System.Drawing.Point(0, 357);
            this.panelNowKM.Name = "panelNowKM";
            this.panelNowKM.Size = new System.Drawing.Size(856, 32);
            this.panelNowKM.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelNowKM.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelNowKM.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelNowKM.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelNowKM.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelNowKM.Style.ForeColor.Color = System.Drawing.Color.Maroon;
            this.panelNowKM.Style.GradientAngle = 90;
            this.panelNowKM.TabIndex = 42;
            // 
            // ActionCarList_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 389);
            this.Controls.Add(this.gridControl_ActionCarList);
            this.Controls.Add(this.panelNowKM);
            this.Controls.Add(this.itemPanelActionCar);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ActionCarList_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سیستم ثبت تعمیرات و نگهداری اتومبیل";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ActionCarList_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ActionCarList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_ActionCarList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_ActionCarList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_ActionCarList;
        private DevExpress.XtraGrid.Columns.GridColumn ActionPlace;
        private DevExpress.XtraGrid.Columns.GridColumn TelPlace;
        private DevExpress.XtraGrid.Columns.GridColumn ProductUse;
        private DevExpress.XtraGrid.Columns.GridColumn NowKM;
        private DevExpress.XtraGrid.Columns.GridColumn NextKM;
        private DevExpress.XtraGrid.Columns.GridColumn ActionDate;
        private DevExpress.XtraGrid.Columns.GridColumn ActionDsc;
        private DevExpress.XtraGrid.Columns.GridColumn CarID;
        private DevComponents.DotNetBar.ItemPanel itemPanelActionCar;
        private DevComponents.DotNetBar.ButtonItem buttonItemActionEdit;
        private DevComponents.DotNetBar.ButtonItem buttonItemActionDel;
        private DevComponents.DotNetBar.ButtonItem buttonItemActionCarSearch;
        private DevComponents.DotNetBar.ButtonItem buttonItemSelector;
        private DevComponents.DotNetBar.ButtonItem buttonItemActionCarPrintList;
        private DevComponents.DotNetBar.ButtonItem buttonItemActionAdd;
        private DevExpress.XtraGrid.Columns.GridColumn ActionCode;
        private DevExpress.XtraGrid.Columns.GridColumn ActionTypeDsc;
        private DevComponents.DotNetBar.PanelEx panelNowKM;
    }
}