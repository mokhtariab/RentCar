using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Linq;

namespace RentCarPrj.Report
{
    public partial class Mamoriat : DevExpress.XtraReports.UI.XtraReport
    {
        public Mamoriat(int CarID, int DutyCode, bool MamOrTamdid, int TypeCode)
        {
            InitializeComponent();

            sP_SetRepEjareNameMoshtariTableAdapter1.Fill(dataSetRentReport1.SP_SetRepEjareNameMoshtari, CarID, DutyCode);
            sP_GetRecPayDscTableAdapter1.Fill(dataSetRentReport1.SP_GetRecPayDsc, CarID, DutyCode, TypeCode);

            if (!MamOrTamdid)
                labelMr.Text = "تمدید سرویس";
            DataLinq.DataClasses_MainDataContext D = new DataLinq.DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            LabelCO.Text = "« شرکت " + D.TBL_Customers.First(h => h.IsParent == true).AddressBusiness + " »";

            try
            {
                PictureBox10.ImageUrl = Global_Cls.RootSaveLoad() + "\\PicsFilms\\Logo.jpg";
                PictureBox20.ImageUrl = Global_Cls.RootSaveLoad() + "\\PicsFilms\\Logo.jpg";
            }
            catch { }

        }

    }
}
