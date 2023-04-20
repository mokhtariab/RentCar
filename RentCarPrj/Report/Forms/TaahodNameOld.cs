using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace RentCarPrj.Report
{
    public partial class TaahodNameOld : DevExpress.XtraReports.UI.XtraReport
    {
        public TaahodNameOld(string CustomerName)
        {
            InitializeComponent();
            LabelName.Text = CustomerName;
        }

    }
}
