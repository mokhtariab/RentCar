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
    public partial class CarEnterList_UC : UserControl
    {
       
        int _carID;
        public CarEnterList_UC(int CarID)
        {
            InitializeComponent();
            _carID = CarID;
        }

        DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

        private void CarEnterList_UC_Load(object sender, EventArgs e)
        {
            ShowListCarEnter(1);
            InterFaceChange();

        }

        private void InterFaceChange()
        {

            //string UPer = Global_Cls.MainForm.UserPermission;
            //if (UPer != "" && UPer != "admin")
            //{
            //    if (UPer.Contains(button_Transmutation.Name + FileStatus.ToString())) button_Transmutation.Enabled = false;
            //    if (UPer.Contains(buttonItem_Active.Name + FileStatus.ToString())) buttonItem_Active.Enabled = false;
            //    if (UPer.Contains(buttonItem_NonActive.Name + FileStatus.ToString())) buttonItem_NonActive.Enabled = false;
            //    if (UPer.Contains(buttonItem_Del.Name + FileStatus.ToString())) buttonItem_Del.Enabled = false;
            //    if (UPer.Contains(buttonItem_ForMemorundom.Name + FileStatus.ToString())) buttonItem_ForMemorundom.Enabled = false;
            //    if (UPer.Contains(button_ShiftDel.Name)) button_ShiftDel.Enabled = false;
            //}
        }

        private void ShowListCarEnter(int RowFocus)
        {
            var SUS = from prd in DCMDC.TBL_CarEnters
                      where prd.CarID == _carID
                      select new
                      {
                          prd.CarID,
                          prd.CarEnterID,
                          
                          StartEnterDate = Global_Cls.MiladiDateToShamsi(prd.StartEnterDate.Value),
                          EndEnterDate = Global_Cls.MiladiDateToShamsi(prd.EndEnterDate.Value),
                          
                          prd.CertifiedDsc,
                          
                          RenterName = (DCMDC.TBL_Customers.First(Cr => Cr.CustomerID.Equals(prd.RenterCode)).CustomerName),
                          prd.TotalPrice,
                          NowKM = (DCMDC.Tbl_CarFaces.First(Cr => Cr.CarFaceID.Equals(prd.CarFaceID)).KilometerUse),

                          //prd.DailyPeriod,
                          //prd.DailyPrice,
                          //prd.DailySet,
                          //prd.MonthlyPrice,
                          //prd.MounthlyPeriod,
                          //prd.MounthlySet,
                          //prd.TimePeriod,
                          //prd.TimePrice,
                          //prd.TimeSet,
                          //prd.WeeklyPeriod,
                          //prd.WeeklyPrice,
                          //prd.WeeklySet
                          
                      };
            gridControl_CarEnterList.DataSource = SUS;
            gridView_CarEnterList.FocusedRowHandle = RowFocus;
        }


        private void buttonItemSelector_Click(object sender, EventArgs e)
        {
            gridView_CarEnterList.ColumnsCustomization(new Point(100, 100));
        }

        private void buttonItemCarEnterSearch_Click(object sender, EventArgs e)
        {
            gridView_CarEnterList.OptionsView.ShowAutoFilterRow = !gridView_CarEnterList.OptionsView.ShowAutoFilterRow;
        }

        private void buttonItemCarEnterPrintList_Click(object sender, EventArgs e)
        {
            gridControl_CarEnterList.ShowPreview();
        }

        private void buttonItemAddCarEnter_Click(object sender, EventArgs e)
        {
            if (gridView_CarEnterList.RowCount == 0) return;
            CarEnterNE_frm Uc = new CarEnterNE_frm(true, 0, _carID, 0);
            Uc.ShowDialog();
            ShowListCarEnter(gridView_CarEnterList.RowCount);
        }

        private void buttonItemEditCarEnter_Click(object sender, EventArgs e)
        {
            if (gridView_CarEnterList.RowCount == 0) return;

            int Index = gridView_CarEnterList.FocusedRowHandle;

            CarEnterNE_frm Uc = new CarEnterNE_frm(false,
                Convert.ToInt32(gridView_CarEnterList.GetRowCellValue(Index, "CarEnterID")), _carID, 0);
            Uc.ShowDialog();
            ShowListCarEnter(Index);

        }

        private void buttonItemDelCarEnter_Click(object sender, EventArgs e)
        {
            if (gridView_CarEnterList.RowCount == 0) return;

            int Index = gridView_CarEnterList.FocusedRowHandle;
            int CarEnterID = Convert.ToInt32(gridView_CarEnterList.GetRowCellValue(Index, "CarEnterID"));

            if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این قرارداد حذف شود؟")) return;
            TBL_CarEnter thsf = DCMDC.TBL_CarEnters.First(hf =>
                hf.CarID.Equals(_carID) && hf.CarEnterID.Equals(CarEnterID));
            DCMDC.TBL_CarEnters.DeleteOnSubmit(thsf);
            DCMDC.SubmitChanges();
            ShowListCarEnter(Index - 1);
        }


    }
}
