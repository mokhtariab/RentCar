using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace RentCarPrj.Report
{
    public partial class EjareNameMoshtari : DevExpress.XtraReports.UI.XtraReport
    {
        public EjareNameMoshtari(int CarID, int DutyCode, int TypeCode)
        {
            InitializeComponent();
            sP_SetRepEjareNameMoshtariTableAdapter1.Fill(dataSetRentReport1.SP_SetRepEjareNameMoshtari, CarID, DutyCode);
            sP_GetRecPayDscTableAdapter1.Fill(dataSetRentReport1.SP_GetRecPayDsc, CarID, DutyCode, TypeCode);

            try
            {
                PictureBox10.ImageUrl = Global_Cls.RootSaveLoad() + "\\PicsFilms\\Logo.jpg";
                PictureBox20.ImageUrl = Global_Cls.RootSaveLoad() + "\\PicsFilms\\Logo.jpg";
            }
            catch { }

        }

    }
}
