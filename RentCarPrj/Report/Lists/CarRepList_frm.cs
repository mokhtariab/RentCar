using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RentCarPrj.DataLinq;

namespace RentCarPrj
{
    public partial class CarRepList_frm : Form
    {
        public CarRepList_frm()
        {
            InitializeComponent();
        }
        
        DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

        private void CarRepList_frm_Load(object sender, EventArgs e)
        {
            SetAlarm();
        }
        
        private void SetAlarm()
        {
            DCMDC.SP_AlarmSetForTBLCar(Global_Cls.GetFinePeriod, Global_Cls.ExpDayCarEnter, Global_Cls.ExpDayCarDuty,
                                        Global_Cls.ExpDayBodyInsu, Global_Cls.ExpDayThirdInsu);
        }

        private void SearchPreview(string SStatus)
        {
            var SUS = from prd in DCMDC.TBL_Cars
                      select new
                      {
                          prd.CarID,
                          prd.CarNumber,
                          prd.BodyNO,
                          prd.CarName,
                          prd.CarPic,
                          prd.CarType,
                          prd.ColorSet,
                          CreateDate = Global_Cls.MiladiDateToShamsi(prd.CreateDate.Value == null ? DateTime.Now : prd.CreateDate.Value),
                          prd.DisciplineNO,
                          prd.EngineNO,
                          EnterTypeStr = (prd.EnterType == 1 ? "خرید" : prd.EnterType == 2 ? "همکار" : "شخص"),
                          prd.EnterType,
                          InsuranceBodyExpDate = Global_Cls.MiladiDateToShamsi(prd.InsuranceBodyExpDate.Value == null ? DateTime.Now : prd.InsuranceBodyExpDate.Value),
                          prd.InsuranceBodyPrice,
                          InsuranceThirdExpDate = Global_Cls.MiladiDateToShamsi(prd.InsuranceThirdExpDate.Value == null ? DateTime.Now : prd.InsuranceThirdExpDate.Value),
                          prd.InsuranceThirdPrice,
                          LordName = (DCMDC.TBL_Customers.First(Cr => Cr.CustomerID.Equals(prd.LordCode)).CustomerName),
                          prd.MadeCountry,
                          ProductDate = Global_Cls.MiladiDateToShamsi(prd.ProductDate.Value),
                          prd.RingType,
                          EndEnterDate = Global_Cls.MiladiDateToShamsi((DCMDC.TBL_CarEnters.First(Cr => Cr.CarID.Equals(prd.CarID)).EndEnterDate.Value) == null ? DateTime.Now : (DCMDC.TBL_CarEnters.First(Cr => Cr.CarID.Equals(prd.CarID)).EndEnterDate.Value)),
                          prd.Status,
                          prd.Active
                      };

            if (SStatus == "") SUS = SUS.Where(x => x.Status == null);
            else
                SUS = SUS.Where(x => x.Status.Contains(SStatus));

            gridControl_CarList.DataSource = SUS;
            gridControl_CarList.RefreshDataSource();

            PrintPreview_frm PP = new PrintPreview_frm(gridControl_CarList);
            PP.ShowDialog();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            SearchPreview("7;");
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            SearchPreview("1;");
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            SearchPreview("");
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            SearchPreview("2;");
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            SearchPreview("3;");
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            SearchPreview("4;");
        }

        private void buttonX8_Click(object sender, EventArgs e)
        {
            SearchPreview("5;");
        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
            SearchPreview("6;");
        }

        

    }
}
