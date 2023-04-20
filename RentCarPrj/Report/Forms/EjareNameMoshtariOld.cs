using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace RentCarPrj.Report
{
    public partial class EjareNameMoshtariOld : DevExpress.XtraReports.UI.XtraReport
    {
        public EjareNameMoshtariOld(int CarID, int DutyCode, int TypeCode)
        {
            InitializeComponent();
            SP_SetRepEjareNameMoshtariTableAdapter1.Fill(dataSetRentReport1.SP_SetRepEjareNameMoshtari, CarID, DutyCode);
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
