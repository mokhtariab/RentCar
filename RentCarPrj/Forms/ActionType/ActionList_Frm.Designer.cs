namespace RentCarPrj
{
    partial class ActionList_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActionList_Frm));
            this.gridControl_ActionSubRPList = new DevExpress.XtraGrid.GridControl();
            this.gridView_ActionSubRPList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ActionTypeCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ActionTypeDsc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemPanelCarSubRP = new DevComponents.DotNetBar.ItemPanel();
            this.buttonItemAddAction = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemEditAction = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemDelAction = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemCarSubRPSearch = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemSelector = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemActionSubRPPrintList = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ActionSubRPList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_ActionSubRPList)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl_ActionSubRPList
            // 
            this.gridControl_ActionSubRPList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_ActionSubRPList.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl_ActionSubRPList.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl_ActionSubRPList.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl_ActionSubRPList.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl_ActionSubRPList.EmbeddedNavigator.Buttons.First.Hint = "ابتدا";
            this.gridControl_ActionSubRPList.EmbeddedNavigator.Buttons.Last.Hint = "آخرین";
            this.gridControl_ActionSubRPList.EmbeddedNavigator.Buttons.Next.Hint = "بعدی";
            this.gridControl_ActionSubRPList.EmbeddedNavigator.Buttons.NextPage.Hint = "صفحه بعدی";
            this.gridControl_ActionSubRPList.EmbeddedNavigator.Buttons.Prev.Hint = "قبلی";
            this.gridControl_ActionSubRPList.EmbeddedNavigator.Buttons.PrevPage.Hint = "صفحه قبلی";
            this.gridControl_ActionSubRPList.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl_ActionSubRPList.EmbeddedNavigator.Text = "لیست اتومبیل ها";
            this.gridControl_ActionSubRPList.EmbeddedNavigator.TextStringFormat = "رکورد {0} از {1}";
            this.gridControl_ActionSubRPList.Location = new System.Drawing.Point(0, 57);
            this.gridControl_ActionSubRPList.LookAndFeel.SkinName = "Money Twins";
            this.gridControl_ActionSubRPList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl_ActionSubRPList.MainView = this.gridView_ActionSubRPList;
            this.gridControl_ActionSubRPList.Name = "gridControl_ActionSubRPList";
            this.gridControl_ActionSubRPList.Size = new System.Drawing.Size(590, 233);
            this.gridControl_ActionSubRPList.TabIndex = 40;
            this.gridControl_ActionSubRPList.UseEmbeddedNavigator = true;
            this.gridControl_ActionSubRPList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_ActionSubRPList});
            this.gridControl_ActionSubRPList.DoubleClick += new System.EventHandler(this.buttonItemEditAction_Click);
            // 
            // gridView_ActionSubRPList
            // 
            this.gridView_ActionSubRPList.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView_ActionSubRPList.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_ActionSubRPList.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_ActionSubRPList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gridView_ActionSubRPList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_ActionSubRPList.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_ActionSubRPList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_ActionSubRPList.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_ActionSubRPList.Appearance.Row.Options.UseTextOptions = true;
            this.gridView_ActionSubRPList.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_ActionSubRPList.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_ActionSubRPList.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridView_ActionSubRPList.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_ActionSubRPList.ColumnPanelRowHeight = 25;
            this.gridView_ActionSubRPList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ActionTypeCode,
            this.ActionTypeDsc});
            this.gridView_ActionSubRPList.CustomizationFormBounds = new System.Drawing.Rectangle(808, 444, 216, 171);
            this.gridView_ActionSubRPList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater;
            styleFormatCondition1.Value1 = "1";
            this.gridView_ActionSubRPList.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView_ActionSubRPList.GridControl = this.gridControl_ActionSubRPList;
            this.gridView_ActionSubRPList.Name = "gridView_ActionSubRPList";
            this.gridView_ActionSubRPList.OptionsBehavior.Editable = false;
            this.gridView_ActionSubRPList.OptionsCustomization.AllowGroup = false;
            this.gridView_ActionSubRPList.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView_ActionSubRPList.OptionsFilter.AllowFilterEditor = false;
            this.gridView_ActionSubRPList.OptionsLayout.Columns.StoreAllOptions = true;
            this.gridView_ActionSubRPList.OptionsLayout.Columns.StoreAppearance = true;
            this.gridView_ActionSubRPList.OptionsLayout.StoreAllOptions = true;
            this.gridView_ActionSubRPList.OptionsLayout.StoreAppearance = true;
            this.gridView_ActionSubRPList.OptionsPrint.PrintPreview = true;
            this.gridView_ActionSubRPList.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView_ActionSubRPList.OptionsView.ShowFooter = true;
            this.gridView_ActionSubRPList.OptionsView.ShowGroupPanel = false;
            this.gridView_ActionSubRPList.OptionsView.ShowIndicator = false;
            this.gridView_ActionSubRPList.PaintStyleName = "Skin";
            this.gridView_ActionSubRPList.RowHeight = 20;
            // 
            // ActionTypeCode
            // 
            this.ActionTypeCode.Caption = "کد";
            this.ActionTypeCode.FieldName = "ActionTypeCode";
            this.ActionTypeCode.Name = "ActionTypeCode";
            this.ActionTypeCode.Visible = true;
            this.ActionTypeCode.VisibleIndex = 1;
            this.ActionTypeCode.Width = 108;
            // 
            // ActionTypeDsc
            // 
            this.ActionTypeDsc.Caption = "نوع عملیات";
            this.ActionTypeDsc.FieldName = "ActionTypeDsc";
            this.ActionTypeDsc.Name = "ActionTypeDsc";
            this.ActionTypeDsc.Visible = true;
            this.ActionTypeDsc.VisibleIndex = 0;
            this.ActionTypeDsc.Width = 567;
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
            this.buttonItemAddAction,
            this.buttonItemEditAction,
            this.buttonItemDelAction,
            this.buttonItemCarSubRPSearch,
            this.buttonItemSelector,
            this.buttonItemActionSubRPPrintList});
            this.itemPanelCarSubRP.Location = new System.Drawing.Point(0, 0);
            this.itemPanelCarSubRP.Name = "itemPanelCarSubRP";
            this.itemPanelCarSubRP.Size = new System.Drawing.Size(590, 57);
            this.itemPanelCarSubRP.TabIndex = 41;
            this.itemPanelCarSubRP.ThemeAware = true;
            // 
            // buttonItemAddAction
            // 
            this.buttonItemAddAction.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemAddAction.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemAddAction.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemAddAction.Image")));
            this.buttonItemAddAction.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemAddAction.Name = "buttonItemAddAction";
            this.buttonItemAddAction.Text = "ثبت عملیات جدید";
            this.buttonItemAddAction.ThemeAware = true;
            this.buttonItemAddAction.Click += new System.EventHandler(this.buttonItemAddAction_Click);
            // 
            // buttonItemEditAction
            // 
            this.buttonItemEditAction.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemEditAction.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemEditAction.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemEditAction.Image")));
            this.buttonItemEditAction.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemEditAction.Name = "buttonItemEditAction";
            this.buttonItemEditAction.Text = "ویرایش";
            this.buttonItemEditAction.ThemeAware = true;
            this.buttonItemEditAction.Click += new System.EventHandler(this.buttonItemEditAction_Click);
            // 
            // buttonItemDelAction
            // 
            this.buttonItemDelAction.BeginGroup = true;
            this.buttonItemDelAction.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemDelAction.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemDelAction.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemDelAction.Image")));
            this.buttonItemDelAction.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemDelAction.Name = "buttonItemDelAction";
            this.buttonItemDelAction.Text = "حذف";
            this.buttonItemDelAction.ThemeAware = true;
            this.buttonItemDelAction.Click += new System.EventHandler(this.buttonItemDelAction_Click);
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
            // buttonItemActionSubRPPrintList
            // 
            this.buttonItemActionSubRPPrintList.BeginGroup = true;
            this.buttonItemActionSubRPPrintList.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemActionSubRPPrintList.ForeColor = System.Drawing.Color.Gold;
            this.buttonItemActionSubRPPrintList.Image = ((System.Drawing.Image)(resources.GetObject("buttonItemActionSubRPPrintList.Image")));
            this.buttonItemActionSubRPPrintList.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItemActionSubRPPrintList.Name = "buttonItemActionSubRPPrintList";
            this.buttonItemActionSubRPPrintList.Text = "چاپ لیست";
            this.buttonItemActionSubRPPrintList.ThemeAware = true;
            this.buttonItemActionSubRPPrintList.Click += new System.EventHandler(this.buttonItemCarSubRPPrintList_Click);
            // 
            // ActionList_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 290);
            this.Controls.Add(this.gridControl_ActionSubRPList);
            this.Controls.Add(this.itemPanelCarSubRP);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ActionList_Frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نوع تعمیرات و نگه داری";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ActionList_Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_ActionSubRPList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_ActionSubRPList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl_ActionSubRPList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_ActionSubRPList;
        private DevComponents.DotNetBar.ItemPanel itemPanelCarSubRP;
        private DevComponents.DotNetBar.ButtonItem buttonItemEditAction;
        private DevComponents.DotNetBar.ButtonItem buttonItemDelAction;
        private DevComponents.DotNetBar.ButtonItem buttonItemCarSubRPSearch;
        private DevComponents.DotNetBar.ButtonItem buttonItemSelector;
        private DevComponents.DotNetBar.ButtonItem buttonItemActionSubRPPrintList;
        private DevComponents.DotNetBar.ButtonItem buttonItemAddAction;
        private DevExpress.XtraGrid.Columns.GridColumn ActionTypeCode;
        private DevExpress.XtraGrid.Columns.GridColumn ActionTypeDsc;
    }
}