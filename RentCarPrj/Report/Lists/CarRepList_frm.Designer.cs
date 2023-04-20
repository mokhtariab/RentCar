namespace RentCarPrj
{
    partial class CarRepList_frm
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
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Active = new DevExpress.XtraGrid.Columns.GridColumn();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX5 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX6 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX7 = new DevComponents.DotNetBar.ButtonX();
            this.gridControl_CarList = new DevExpress.XtraGrid.GridControl();
            this.gridView_CarList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCarName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CarPic = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.colLordCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCarType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDisciplineNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEnterType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMadeCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColorSet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EndEnterDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInsuranceThirdExpDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInsuranceBodyExpDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InsuranceThirdPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InsuranceBodyPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CarNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.buttonX8 = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_CarList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_CarList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // Status
            // 
            this.Status.Caption = "وضعیت";
            this.Status.FieldName = "Status";
            this.Status.Name = "Status";
            this.Status.OptionsColumn.AllowEdit = false;
            // 
            // Active
            // 
            this.Active.Caption = "فعال";
            this.Active.FieldName = "Active";
            this.Active.Name = "Active";
            this.Active.OptionsColumn.AllowEdit = false;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX1.Location = new System.Drawing.Point(79, 30);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(458, 37);
            this.buttonX1.TabIndex = 0;
            this.buttonX1.Text = "لیست اتومبیل های در حال سرویس";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX2.Location = new System.Drawing.Point(79, 88);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(458, 37);
            this.buttonX2.TabIndex = 1;
            this.buttonX2.Text = "لیست سرویس هایی که خلافی سررسید شده دارند";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX3.Location = new System.Drawing.Point(79, 146);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(458, 37);
            this.buttonX3.TabIndex = 2;
            this.buttonX3.Text = "لیست اتومبیل هایی که آماده به سرویس هستند";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX4.Location = new System.Drawing.Point(79, 204);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Size = new System.Drawing.Size(458, 37);
            this.buttonX4.TabIndex = 3;
            this.buttonX4.Text = "لیست اتومبیل هایی که قرارداد آنها در حال اتمام است";
            this.buttonX4.Click += new System.EventHandler(this.buttonX4_Click);
            // 
            // buttonX5
            // 
            this.buttonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX5.Location = new System.Drawing.Point(79, 262);
            this.buttonX5.Name = "buttonX5";
            this.buttonX5.Size = new System.Drawing.Size(458, 37);
            this.buttonX5.TabIndex = 4;
            this.buttonX5.Text = "لیست اتومبیل هایی که زمان سرویس آنها در حال اتمام است";
            this.buttonX5.Click += new System.EventHandler(this.buttonX5_Click);
            // 
            // buttonX6
            // 
            this.buttonX6.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX6.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX6.Location = new System.Drawing.Point(79, 320);
            this.buttonX6.Name = "buttonX6";
            this.buttonX6.Size = new System.Drawing.Size(458, 37);
            this.buttonX6.TabIndex = 5;
            this.buttonX6.Text = "لیست اتومبیل هایی که بیمه بدنه آنها در حال اتمام است";
            this.buttonX6.Click += new System.EventHandler(this.buttonX6_Click);
            // 
            // buttonX7
            // 
            this.buttonX7.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX7.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX7.Location = new System.Drawing.Point(79, 436);
            this.buttonX7.Name = "buttonX7";
            this.buttonX7.Size = new System.Drawing.Size(458, 37);
            this.buttonX7.TabIndex = 6;
            this.buttonX7.Text = "لیست اتومبیل هایی که تعمیر و نگهداری سررسید شده دارند";
            this.buttonX7.Click += new System.EventHandler(this.buttonX7_Click);
            // 
            // gridControl_CarList
            // 
            this.gridControl_CarList.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl_CarList.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl_CarList.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl_CarList.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl_CarList.EmbeddedNavigator.Buttons.First.Hint = "ابتدا";
            this.gridControl_CarList.EmbeddedNavigator.Buttons.Last.Hint = "آخرین";
            this.gridControl_CarList.EmbeddedNavigator.Buttons.Next.Hint = "بعدی";
            this.gridControl_CarList.EmbeddedNavigator.Buttons.NextPage.Hint = "صفحه بعدی";
            this.gridControl_CarList.EmbeddedNavigator.Buttons.Prev.Hint = "قبلی";
            this.gridControl_CarList.EmbeddedNavigator.Buttons.PrevPage.Hint = "صفحه قبلی";
            this.gridControl_CarList.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl_CarList.EmbeddedNavigator.Text = "لیست اتومبیل ها";
            this.gridControl_CarList.EmbeddedNavigator.TextStringFormat = "رکورد {0} از {1}";
            this.gridControl_CarList.Location = new System.Drawing.Point(397, 409);
            this.gridControl_CarList.LookAndFeel.SkinName = "Money Twins";
            this.gridControl_CarList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl_CarList.MainView = this.gridView_CarList;
            this.gridControl_CarList.Name = "gridControl_CarList";
            this.gridControl_CarList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageEdit1,
            this.repositoryItemPictureEdit1});
            this.gridControl_CarList.Size = new System.Drawing.Size(314, 217);
            this.gridControl_CarList.TabIndex = 38;
            this.gridControl_CarList.UseEmbeddedNavigator = true;
            this.gridControl_CarList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_CarList});
            this.gridControl_CarList.Visible = false;
            // 
            // gridView_CarList
            // 
            this.gridView_CarList.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView_CarList.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_CarList.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_CarList.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gridView_CarList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView_CarList.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView_CarList.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_CarList.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_CarList.Appearance.Row.Options.UseTextOptions = true;
            this.gridView_CarList.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_CarList.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView_CarList.AppearancePrint.EvenRow.BackColor = System.Drawing.Color.Transparent;
            this.gridView_CarList.AppearancePrint.EvenRow.BackColor2 = System.Drawing.Color.Transparent;
            this.gridView_CarList.AppearancePrint.EvenRow.BorderColor = System.Drawing.Color.Transparent;
            this.gridView_CarList.AppearancePrint.EvenRow.Options.UseBackColor = true;
            this.gridView_CarList.AppearancePrint.EvenRow.Options.UseBorderColor = true;
            this.gridView_CarList.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridView_CarList.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView_CarList.ColumnPanelRowHeight = 25;
            this.gridView_CarList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCarName,
            this.CarPic,
            this.colLordCode,
            this.colCarType,
            this.colDisciplineNO,
            this.colEnterType,
            this.colMadeCountry,
            this.colColorSet,
            this.colProductDate,
            this.EndEnterDate,
            this.colInsuranceThirdExpDate,
            this.colInsuranceBodyExpDate,
            this.gridColumn9,
            this.InsuranceThirdPrice,
            this.InsuranceBodyPrice,
            this.CarNumber,
            this.Status,
            this.Active});
            this.gridView_CarList.CustomizationFormBounds = new System.Drawing.Rectangle(1374, 615, 216, 171);
            this.gridView_CarList.GridControl = this.gridControl_CarList;
            this.gridView_CarList.Name = "gridView_CarList";
            this.gridView_CarList.OptionsBehavior.Editable = false;
            this.gridView_CarList.OptionsCustomization.AllowGroup = false;
            this.gridView_CarList.OptionsCustomization.AllowRowSizing = true;
            this.gridView_CarList.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView_CarList.OptionsFilter.AllowFilterEditor = false;
            this.gridView_CarList.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridView_CarList.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView_CarList.OptionsView.ShowGroupPanel = false;
            this.gridView_CarList.OptionsView.ShowIndicator = false;
            this.gridView_CarList.PaintStyleName = "Skin";
            this.gridView_CarList.RowHeight = 40;
            // 
            // colCarName
            // 
            this.colCarName.Caption = "نام اتومبیل";
            this.colCarName.FieldName = "CarName";
            this.colCarName.Name = "colCarName";
            this.colCarName.OptionsColumn.AllowEdit = false;
            this.colCarName.Visible = true;
            this.colCarName.VisibleIndex = 5;
            this.colCarName.Width = 86;
            // 
            // CarPic
            // 
            this.CarPic.Caption = "تصویر";
            this.CarPic.ColumnEdit = this.repositoryItemPictureEdit1;
            this.CarPic.FieldName = "CarPic";
            this.CarPic.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.CarPic.Name = "CarPic";
            this.CarPic.OptionsColumn.AllowEdit = false;
            this.CarPic.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.CarPic.Width = 131;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            // 
            // colLordCode
            // 
            this.colLordCode.Caption = "نام مالک";
            this.colLordCode.FieldName = "LordName";
            this.colLordCode.Name = "colLordCode";
            this.colLordCode.OptionsColumn.AllowEdit = false;
            this.colLordCode.Visible = true;
            this.colLordCode.VisibleIndex = 1;
            this.colLordCode.Width = 125;
            // 
            // colCarType
            // 
            this.colCarType.Caption = "نوع اتومبیل";
            this.colCarType.FieldName = "CarType";
            this.colCarType.Name = "colCarType";
            this.colCarType.OptionsColumn.AllowEdit = false;
            this.colCarType.Visible = true;
            this.colCarType.VisibleIndex = 2;
            this.colCarType.Width = 95;
            // 
            // colDisciplineNO
            // 
            this.colDisciplineNO.Caption = "شماره پلاک";
            this.colDisciplineNO.FieldName = "DisciplineNO";
            this.colDisciplineNO.Name = "colDisciplineNO";
            this.colDisciplineNO.OptionsColumn.AllowEdit = false;
            this.colDisciplineNO.Visible = true;
            this.colDisciplineNO.VisibleIndex = 4;
            this.colDisciplineNO.Width = 119;
            // 
            // colEnterType
            // 
            this.colEnterType.Caption = "نوع ورود";
            this.colEnterType.FieldName = "EnterTypeStr";
            this.colEnterType.Name = "colEnterType";
            this.colEnterType.OptionsColumn.AllowEdit = false;
            // 
            // colMadeCountry
            // 
            this.colMadeCountry.Caption = "کشور سازنده";
            this.colMadeCountry.FieldName = "MadeCountry";
            this.colMadeCountry.Name = "colMadeCountry";
            this.colMadeCountry.OptionsColumn.AllowEdit = false;
            // 
            // colColorSet
            // 
            this.colColorSet.Caption = "رنگ";
            this.colColorSet.FieldName = "ColorSet";
            this.colColorSet.Name = "colColorSet";
            this.colColorSet.OptionsColumn.AllowEdit = false;
            this.colColorSet.Visible = true;
            this.colColorSet.VisibleIndex = 3;
            this.colColorSet.Width = 70;
            // 
            // colProductDate
            // 
            this.colProductDate.Caption = "تاریخ تولید";
            this.colProductDate.FieldName = "ProductDate";
            this.colProductDate.Name = "colProductDate";
            this.colProductDate.OptionsColumn.AllowEdit = false;
            this.colProductDate.Width = 84;
            // 
            // EndEnterDate
            // 
            this.EndEnterDate.Caption = "تاریخ پایان قرارداد";
            this.EndEnterDate.FieldName = "EndEnterDate";
            this.EndEnterDate.Name = "EndEnterDate";
            this.EndEnterDate.OptionsColumn.AllowEdit = false;
            this.EndEnterDate.Visible = true;
            this.EndEnterDate.VisibleIndex = 0;
            this.EndEnterDate.Width = 129;
            // 
            // colInsuranceThirdExpDate
            // 
            this.colInsuranceThirdExpDate.Caption = "اتمام بیمه ثالث";
            this.colInsuranceThirdExpDate.FieldName = "InsuranceThirdExpDate";
            this.colInsuranceThirdExpDate.Name = "colInsuranceThirdExpDate";
            this.colInsuranceThirdExpDate.OptionsColumn.AllowEdit = false;
            this.colInsuranceThirdExpDate.Width = 87;
            // 
            // colInsuranceBodyExpDate
            // 
            this.colInsuranceBodyExpDate.Caption = "اتمام بیمه بدنه";
            this.colInsuranceBodyExpDate.FieldName = "InsuranceBodyExpDate";
            this.colInsuranceBodyExpDate.Name = "colInsuranceBodyExpDate";
            this.colInsuranceBodyExpDate.OptionsColumn.AllowEdit = false;
            this.colInsuranceBodyExpDate.Width = 96;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "کد";
            this.gridColumn9.FieldName = "CarID";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            // 
            // InsuranceThirdPrice
            // 
            this.InsuranceThirdPrice.Caption = "مبلغ بیمه ثالث";
            this.InsuranceThirdPrice.FieldName = "InsuranceThirdPrice";
            this.InsuranceThirdPrice.Name = "InsuranceThirdPrice";
            this.InsuranceThirdPrice.OptionsColumn.AllowEdit = false;
            // 
            // InsuranceBodyPrice
            // 
            this.InsuranceBodyPrice.Caption = "مبلغ بیمه بدنه";
            this.InsuranceBodyPrice.FieldName = "InsuranceBodyPrice";
            this.InsuranceBodyPrice.Name = "InsuranceBodyPrice";
            this.InsuranceBodyPrice.OptionsColumn.AllowEdit = false;
            // 
            // CarNumber
            // 
            this.CarNumber.Caption = "کد اتومبیل";
            this.CarNumber.FieldName = "CarNumber";
            this.CarNumber.Name = "CarNumber";
            this.CarNumber.OptionsColumn.AllowEdit = false;
            this.CarNumber.Visible = true;
            this.CarNumber.VisibleIndex = 6;
            this.CarNumber.Width = 85;
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            this.repositoryItemImageEdit1.PopupFormSize = new System.Drawing.Size(260, 150);
            // 
            // buttonX8
            // 
            this.buttonX8.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX8.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonX8.Location = new System.Drawing.Point(79, 378);
            this.buttonX8.Name = "buttonX8";
            this.buttonX8.Size = new System.Drawing.Size(458, 37);
            this.buttonX8.TabIndex = 39;
            this.buttonX8.Text = "لیست اتومبیل هایی که بیمه ثالث آنها در حال اتمام است";
            this.buttonX8.Click += new System.EventHandler(this.buttonX8_Click);
            // 
            // CarRepList_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(617, 502);
            this.Controls.Add(this.buttonX8);
            this.Controls.Add(this.gridControl_CarList);
            this.Controls.Add(this.buttonX7);
            this.Controls.Add(this.buttonX6);
            this.Controls.Add(this.buttonX5);
            this.Controls.Add(this.buttonX4);
            this.Controls.Add(this.buttonX3);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.buttonX1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "CarRepList_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "گزارش اتومبیل ها";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CarRepList_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_CarList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_CarList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private DevComponents.DotNetBar.ButtonX buttonX5;
        private DevComponents.DotNetBar.ButtonX buttonX6;
        private DevComponents.DotNetBar.ButtonX buttonX7;
        private DevExpress.XtraGrid.GridControl gridControl_CarList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_CarList;
        private DevExpress.XtraGrid.Columns.GridColumn colCarName;
        private DevExpress.XtraGrid.Columns.GridColumn CarPic;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colLordCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCarType;
        private DevExpress.XtraGrid.Columns.GridColumn colDisciplineNO;
        private DevExpress.XtraGrid.Columns.GridColumn colEnterType;
        private DevExpress.XtraGrid.Columns.GridColumn colMadeCountry;
        private DevExpress.XtraGrid.Columns.GridColumn colColorSet;
        private DevExpress.XtraGrid.Columns.GridColumn colProductDate;
        private DevExpress.XtraGrid.Columns.GridColumn EndEnterDate;
        private DevExpress.XtraGrid.Columns.GridColumn colInsuranceThirdExpDate;
        private DevExpress.XtraGrid.Columns.GridColumn colInsuranceBodyExpDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn InsuranceThirdPrice;
        private DevExpress.XtraGrid.Columns.GridColumn InsuranceBodyPrice;
        private DevExpress.XtraGrid.Columns.GridColumn CarNumber;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
        private DevExpress.XtraGrid.Columns.GridColumn Active;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevComponents.DotNetBar.ButtonX buttonX8;
    }
}