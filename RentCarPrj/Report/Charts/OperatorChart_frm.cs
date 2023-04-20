using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using RentCarPrj.DataLinq;

namespace RentCarPrj
{
    public partial class OperatorChart_frm : Form
    {
        string _OperatorCodes = "";
        int _YAxis;
        DateTime _Date1;
        DateTime _Date2;
        int _SelTypeChart = 1;
        string _Title = "";

        public OperatorChart_frm(string OperatorCodes, int YAxis, DateTime Date1, DateTime Date2, int SelTypeChart, string Title)
        {
            InitializeComponent();
            _OperatorCodes = OperatorCodes;
            _YAxis = YAxis;
            _Date1 = Date1;
            _Date2 = Date2;
            _SelTypeChart = SelTypeChart;
            _Title = Title;
        }

        
        private void OperatorChart_frm_Load(object sender, EventArgs e)
        {
            LoadChart(_SelTypeChart, _YAxis, _Date1, _Date2, _OperatorCodes, _Title);
        }

        public void LoadChart(int ChartType, int YAxis, DateTime Date1, DateTime Date2, string WCodeStr, string TitleStr)
        {
            SetTitle(TitleStr);
            SetChartType(ChartType);

            if (ChartType != 3)
            {
                chartControlCar.Series[0].PointOptions.PointView = DevExpress.XtraCharts.PointView.Values;
                //chartControlCar.Series[1].PointOptions.PointView = DevExpress.XtraCharts.PointView.Values;
                //chartControlCar.Series[2].PointOptions.PointView = DevExpress.XtraCharts.PointView.Values;
            }
            else
            {
                chartControlCar.Series[0].PointOptions.PointView = DevExpress.XtraCharts.PointView.ArgumentAndValues;
                //chartControlCar.Series[1].PointOptions.PointView = DevExpress.XtraCharts.PointView.ArgumentAndValues;
                //chartControlCar.Series[2].PointOptions.PointView = DevExpress.XtraCharts.PointView.ArgumentAndValues;
                chartControlCar.Series[0].ShowInLegend = false;
                //chartControlCar.Series[1].ShowInLegend = false;
                //chartControlCar.Series[2].ShowInLegend = false;
            }

            if (YAxis == 1)
                chartControlCar.Series[0].LegendText = "تعداد سرویس ها";
            else if (YAxis == 2)
                chartControlCar.Series[0].LegendText = "مبالغ سرویس ها";
            Data(Date1, Date2, WCodeStr, YAxis);

        }

        private void SetTitle(string TitleStr)
        {
            panelExMain.Text = TitleStr;
        }

        private void SortFunc(int SortType)
        {
            if (SortType == 1)
            {
                chartControlCar.Series[0].SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Descending;
            }
            else
                if (SortType == 2)
                {
                    chartControlCar.Series[1].SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Descending;
                }
                else if (SortType == 3)
                {
                    chartControlCar.Series[2].SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Descending;
                }
        }

        //private void SetAmountPercent(bool Amount_Percent)
        //{
        //    if (Amount_Percent)
        //    {
        //        chartControlCar.Series[0].PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number;
        //        chartControlCar.Series[0].PointOptions.ValueNumericOptions.Precision = 0;
        //        //chartControlCar.Series[0].PointOptions.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.;
        //        //chartControlCar.Series[0].PointOptions.ArgumentNumericOptions.Precision = 0;

        //        chartControlCar.Series[1].PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number;
        //        chartControlCar.Series[1].PointOptions.ValueNumericOptions.Precision = 0;
        //        //chartControlCar.Series[1].PointOptions.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Percent;
        //        //chartControlCar.Series[1].PointOptions.ArgumentNumericOptions.Precision = 0;

        //        chartControlCar.Series[2].PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number;
        //        chartControlCar.Series[2].PointOptions.ValueNumericOptions.Precision = 0;
        //        //chartControlCar.Series[2].PointOptions.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Percent;
        //        //chartControlCar.Series[2].PointOptions.ArgumentNumericOptions.Precision = 0;
        //    }
        //    else
        //    {
        //        chartControlCar.Series[0].PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Percent;
        //        chartControlCar.Series[0].PointOptions.ValueNumericOptions.Precision = 0;
        //        //chartControlCar.Series[0].PointOptions.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.;
        //        //chartControlCar.Series[0].PointOptions.ArgumentNumericOptions.Precision = 0;

        //        chartControlCar.Series[1].PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Percent;
        //        chartControlCar.Series[1].PointOptions.ValueNumericOptions.Precision = 0;
        //        //chartControlCar.Series[1].PointOptions.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Percent;
        //        //chartControlCar.Series[1].PointOptions.ArgumentNumericOptions.Precision = 0;

        //        chartControlCar.Series[2].PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Percent;
        //        chartControlCar.Series[2].PointOptions.ValueNumericOptions.Precision = 0;
        //        //chartControlCar.Series[2].PointOptions.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Percent;
        //        //chartControlCar.Series[2].PointOptions.ArgumentNumericOptions.Precision = 0;
        //    }
        //}

        private void SetChartType(int ChartType)
        {
            if (ChartType == 1)
            {
                chartControlCar.Series[0].ChangeView(DevExpress.XtraCharts.ViewType.Bar);
                //chartControlCar.Series[1].ChangeView(DevExpress.XtraCharts.ViewType.Bar);
                //chartControlCar.Series[2].ChangeView(DevExpress.XtraCharts.ViewType.Bar);
            }
            else
                if (ChartType == 2)
                {
                    chartControlCar.Series[0].ChangeView(DevExpress.XtraCharts.ViewType.Line);
                    //chartControlCar.Series[1].ChangeView(DevExpress.XtraCharts.ViewType.Line);
                    //chartControlCar.Series[2].ChangeView(DevExpress.XtraCharts.ViewType.Line);
                }
                else
                    if (ChartType == 3)
                    {
                        chartControlCar.Series[0].ChangeView(DevExpress.XtraCharts.ViewType.Pie3D);
                        //chartControlCar.Series[1].ChangeView(DevExpress.XtraCharts.ViewType.Pie3D);
                        //chartControlCar.Series[2].ChangeView(DevExpress.XtraCharts.ViewType.Pie3D);
                    }
                    else
                        if (ChartType == 4)
                        {
                            chartControlCar.Series[0].ChangeView(DevExpress.XtraCharts.ViewType.ManhattanBar);
                            //chartControlCar.Series[1].ChangeView(DevExpress.XtraCharts.ViewType.ManhattanBar);
                            //chartControlCar.Series[2].ChangeView(DevExpress.XtraCharts.ViewType.ManhattanBar);
                        }
        }

        private void Data(DateTime date1, DateTime date2, string CodeStr, int YAxis)
        {

            SqlConnection SqlConn = new SqlConnection(Global_Cls.ConnectionStr);
            SqlCommand SqlCmd = new SqlCommand();
            try { CodeStr = CodeStr.Replace(";", ",").Remove(CodeStr.Length - 1); }
            catch { }
            SqlCmd.CommandText =
                " SELECT dbo.TBL_CarDuty.CarID, dbo.TBL_CarDuty.DutyCode, dbo.TBL_CarDuty.OperatorCode, dbo.TBL_CarDuty.TotalPrice, dbo.TBL_Operator.OperatorName, "+
                " dbo.TBL_CarDuty.DutyDate into #tmp "+
                " FROM dbo.TBL_CarDuty INNER JOIN "+
                " dbo.TBL_Operator ON dbo.TBL_CarDuty.OperatorCode = dbo.TBL_Operator.OperatorCode "+
                " union "+
                " SELECT dbo.TBL_CarDuty.CarID, dbo.TBL_CarDuty.DutyCode, dbo.TBL_CarDuty.DriverCode, dbo.TBL_CarDuty.TotalPrice, dbo.TBL_Operator.OperatorName, "+
				" dbo.TBL_CarDuty.DutyDate "+
                " FROM dbo.TBL_CarDuty INNER JOIN "+
                " dbo.TBL_Operator ON dbo.TBL_CarDuty.DriverCode = dbo.TBL_Operator.OperatorCode "+
                " WHERE (dbo.TBL_CarDuty.DriverUse = 1) "+
                " "+
                " select OperatorName, "+
                "(case when (" + YAxis + " = 1)" +
	            " then count(*) "+
                " when (" + YAxis + " = 2) " +
                " then sum(TotalPrice) " +
                " end) as ActionValue " +
            
                " from #tmp "+
                "where DutyDate between '" + date1.ToShortDateString() + "' and '" + date2.ToShortDateString() + "' ";
            if (CodeStr != "")
                SqlCmd.CommandText += " and OperatorCode in (" + CodeStr + ")";
            SqlCmd.CommandText += "group by OperatorName  drop table #tmp";

            SqlCmd.CommandType = CommandType.Text;
            SqlCmd.Connection = SqlConn;
            SqlConn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(SqlCmd);

            DataSet gk = new DataSet();
            adapter.Fill(gk);

            chartControlCar.DataSource = gk.Tables[0];

            chartControlCar.Series[0].DataSource = gk.Tables[0];
            chartControlCar.Series[0].ArgumentDataMember = "OperatorName";
            chartControlCar.Series[0].ValueDataMembers[0] = "ActionValue";
        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //chartControlCar.ShowPrintPreview(DevExpress.XtraCharts.Printing.PrintSizeMode.Stretch);
            PrintPreview_frm PP = new PrintPreview_frm(chartControlCar);
            PP.ShowDialog();
        }
    }
}
