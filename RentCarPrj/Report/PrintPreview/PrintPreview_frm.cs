using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RentCarPrj
{
    public partial class PrintPreview_frm : Form
    {
        DevExpress.XtraGrid.GridControl _gridControl;
        DevExpress.XtraCharts.ChartControl _chartControl;
        DevExpress.XtraReports.UI.XtraReport _xtraReport;

        int _startLocation = 0;

        public PrintPreview_frm(DevExpress.XtraGrid.GridControl gridControl_ListDocPat)
        {
            InitializeComponent();
            _gridControl = gridControl_ListDocPat;
            _startLocation = 1;
        }

        public PrintPreview_frm(DevExpress.XtraReports.UI.XtraReport xtrareport_Docpat)
        {
            InitializeComponent();
            _xtraReport = xtrareport_Docpat;
            _startLocation = 2;
        }

        public PrintPreview_frm(DevExpress.XtraCharts.ChartControl chartControl)
        {
            InitializeComponent();
            _chartControl = chartControl;
            _startLocation = 3;
        }

        public PrintPreview_frm()
        {
            InitializeComponent();
        }


        private void PrintPreview_frm_Load(object sender, EventArgs e)
        {
            if (_startLocation == 1)
                LoadGridSet();
            else
                if (_startLocation == 2)
                    LoadReportSet();
                else
                    if (_startLocation == 3)
                        LoadChartSet();
            this.WindowState = FormWindowState.Maximized;
        }

        private void LoadGridSet()
        {
            printControlMain.PrintingSystem = printingSystemMain;

            printableComponentLinkMain.CreateDocument();

            printableComponentLinkMain.Component = _gridControl;
            printableComponentLinkMain.Landscape = true;

            printableComponentLinkMain.CreateDocument();
            printControlMain.Show();
        }

        private void LoadReportSet()
        {
            DevExpress.XtraReports.UI.ReportPrintTool pt = new DevExpress.XtraReports.UI.ReportPrintTool(_xtraReport);
            pt.Report.CreateDocument(true);

            DevExpress.XtraPrinting.PrintingSystemBase ps = pt.Report.PrintingSystemBase;


            printControlMain.PrintingSystem = ps;

            printControlMain.Show();
        }


        private void LoadChartSet()
        {
            printControlMain.PrintingSystem = printingSystemMain;

            printableComponentLinkMain.CreateDocument();

            printableComponentLinkMain.Component = _chartControl;
            (printableComponentLinkMain.Component as DevExpress.XtraCharts.ChartControl).OptionsPrint.SizeMode = DevExpress.XtraCharts.Printing.PrintSizeMode.Stretch;

            printableComponentLinkMain.Landscape = true;

            printableComponentLinkMain.CreateDocument();
            printControlMain.Show();
        }



    }
}
