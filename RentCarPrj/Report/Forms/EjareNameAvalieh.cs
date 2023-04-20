using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data.Linq;
using System.Linq;

namespace RentCarPrj.Report
{
    public partial class EjareNameAvalieh : DevExpress.XtraReports.UI.XtraReport
    {
        public EjareNameAvalieh(int CarID)
        {
            InitializeComponent();
            sP_SetRepEjareNameAvaliehTableAdapter.Fill(dataSetRentReport1.SP_SetRepEjareNameAvalieh, CarID);

            DataLinq.DataClasses_MainDataContext D = new DataLinq.DataClasses_MainDataContext(Global_Cls.ConnectionStr);

            LabelAddress.Text = D.TBL_Customers.First(h => h.IsParent == true).Address;
            LabelCo.Text = "« شرکت " + D.TBL_Customers.First(h => h.IsParent == true).AddressBusiness + " »";
            LabelMobile.Text = D.TBL_Customers.First(h => h.IsParent == true).Mobile;
            LabelTel.Text = D.TBL_Customers.First(h => h.IsParent == true).Tel;
            LabelTelBusiness.Text = D.TBL_Customers.First(h => h.IsParent == true).TelBusiness;

            try
            {
                PictureBox10.ImageUrl = Global_Cls.RootSaveLoad() + "\\PicsFilms\\Logo.jpg";
                PictureBox20.ImageUrl = Global_Cls.RootSaveLoad() + "\\PicsFilms\\Logo.jpg";
            }
            catch { }

        }

    }
}
