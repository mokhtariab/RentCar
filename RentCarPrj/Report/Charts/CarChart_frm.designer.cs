namespace RentCarPrj
{
    partial class CarChart_frm
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
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel3 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel4 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            this.contextMenuStripPrint = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelExMain = new DevComponents.DotNetBar.PanelEx();
            this.chartControlCar = new DevExpress.XtraCharts.ChartControl();
            this.contextMenuStripPrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel4)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStripPrint
            // 
            this.contextMenuStripPrint.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrintToolStripMenuItem});
            this.contextMenuStripPrint.Name = "contextMenuStripPrint";
            this.contextMenuStripPrint.Size = new System.Drawing.Size(97, 26);
            // 
            // PrintToolStripMenuItem
            // 
            this.PrintToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.830189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem";
            this.PrintToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.PrintToolStripMenuItem.Text = "چاپ";
            this.PrintToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            // 
            // panelExMain
            // 
            this.panelExMain.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelExMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelExMain.Font = new System.Drawing.Font("Tahoma", 10.86792F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panelExMain.Location = new System.Drawing.Point(0, 0);
            this.panelExMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelExMain.Name = "panelExMain";
            this.panelExMain.Size = new System.Drawing.Size(744, 42);
            this.panelExMain.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelExMain.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelExMain.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelExMain.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelExMain.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelExMain.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelExMain.Style.GradientAngle = 90;
            this.panelExMain.TabIndex = 4;
            this.panelExMain.Text = "گزارشات آماری براساس";
            // 
            // chartControlCar
            // 
            this.chartControlCar.ContextMenuStrip = this.contextMenuStripPrint;
            xyDiagram2.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram2.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.NumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number;
            xyDiagram2.AxisY.NumericOptions.Precision = 0;
            xyDiagram2.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram2.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControlCar.Diagram = xyDiagram2;
            this.chartControlCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControlCar.Location = new System.Drawing.Point(0, 42);
            this.chartControlCar.Name = "chartControlCar";
            this.chartControlCar.PaletteName = "Civic";
            sideBySideBarSeriesLabel3.LineVisible = true;
            series2.Label = sideBySideBarSeriesLabel3;
            series2.LegendText = "ساعتی";
            series2.Name = "Series 1";
            series2.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1;
            this.chartControlCar.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            sideBySideBarSeriesLabel4.LineVisible = true;
            this.chartControlCar.SeriesTemplate.Label = sideBySideBarSeriesLabel4;
            this.chartControlCar.Size = new System.Drawing.Size(744, 469);
            this.chartControlCar.TabIndex = 1;
            // 
            // CarChart_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 511);
            this.Controls.Add(this.chartControlCar);
            this.Controls.Add(this.panelExMain);
            this.Name = "CarChart_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "چارت اتومبیل ها";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CarChart_frm_Load);
            this.contextMenuStripPrint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelExMain;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPrint;
        private System.Windows.Forms.ToolStripMenuItem PrintToolStripMenuItem;
        public DevExpress.XtraCharts.ChartControl chartControlCar;

    }
}
