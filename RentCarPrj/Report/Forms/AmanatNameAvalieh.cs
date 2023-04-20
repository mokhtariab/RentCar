using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Linq;

namespace RentCarPrj.Report
{
    public partial class AmanatNameAvalieh : DevExpress.XtraReports.UI.XtraReport
    {
        public AmanatNameAvalieh(int CarID, int DutyCode)
        {
            InitializeComponent();
            sP_SetRepAmanatHamkarViewTableAdapter1.Fill(dataSetRentReport1.SP_SetRepAmanatHamkarView, CarID, DutyCode);

            //DataLinq.DataClasses_MainDataContext D = new DataLinq.DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            //this.Watermark.Text = " شرکت " + D.TBL_Customers.First(h => h.IsParent == true).AddressBusiness;

            try
            {
                PictureBox10.ImageUrl = Global_Cls.RootSaveLoad() + "\\PicsFilms\\Logo.jpg";
                PictureBox20.ImageUrl = Global_Cls.RootSaveLoad() + "\\PicsFilms\\Logo.jpg";

            }
            catch { }
        }

        
    }
}
