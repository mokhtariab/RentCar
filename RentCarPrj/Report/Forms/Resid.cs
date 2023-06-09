using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data.Linq;
using System.Linq;

namespace RentCarPrj.Report
{
    public partial class Resid : DevExpress.XtraReports.UI.XtraReport
    {
        public Resid(int CarID, int DutyCode, int TypeCode)
        {
            InitializeComponent();

            sP_SetRepEjareNameMoshtariTableAdapter1.Fill(dataSetRentReport1.SP_SetRepEjareNameMoshtari, CarID, DutyCode);
            sP_GetRecPayDscTableAdapter1.Fill(dataSetRentReport1.SP_GetRecPayDsc, CarID, DutyCode, TypeCode);
            sP_GetAccountDscTableAdapter1.Fill(dataSetRentReport1.SP_GetAccountDsc);
            DataLinq.DataClasses_MainDataContext D = new DataLinq.DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            xrLabel121.Text = D.TBL_Customers.First(h => h.IsParent == true).Address+" تلفن: "+D.TBL_Customers.First(h => h.IsParent == true).Tel+
                "  " + D.TBL_Customers.First(h => h.IsParent == true).TelBusiness+
                "  " + D.TBL_Customers.First(h => h.IsParent == true).Mobile;

            try
            {
                PictureBox10.ImageUrl = Global_Cls.RootSaveLoad() + "\\PicsFilms\\Logo.jpg";
                PictureBox20.ImageUrl = Global_Cls.RootSaveLoad() + "\\PicsFilms\\Logo.jpg";
            }
            catch { }

        }

    }
}
