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
    public partial class CarSubRPList_Frm : Form
    {

        int _carID, _subCarCode, _customerCode;
        byte _typeCode;
        public double SumPricePublic = 0;

        public CarSubRPList_Frm(int CarID, int SubCarCode, byte TypeCode, int CustomerCode)
        {
            //TypeCode 0:EnterCode 1:DutyCode 2:BackDuty
            InitializeComponent();
            _carID = CarID;
            _subCarCode = SubCarCode;
            _typeCode = TypeCode;
            _customerCode = CustomerCode;
        }

        DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

        private void CarSubRPList_Frm_Load(object sender, EventArgs e)
        {
            ShowListCarSubRP(1);
            InterFaceChange();
            Text = _typeCode == 0 ? "لیست پرداختی ها به افراد" : "لیست دریافتی ها از افراد";
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

        private void ShowListCarSubRP(int RowFocus)
        {
            var SUS = from prd in DCMDC.TBL_CarSubRPs
                      join k in DCMDC.TBL_CarRecPays on prd.RecPayID equals k.RecPayID
                      where prd.CarID == _carID && prd.SubCarCode == _subCarCode && prd.TypeCode == _typeCode && prd.Active == true
                      select new
                      {
                          RecPayDate = Global_Cls.MiladiDateToShamsi(k.RecPayDate.Value),
                          ChqDate = Global_Cls.MiladiDateToShamsi(k.ChqDate.Value),
                          prd.CarID,
                          prd.SubCarCode,
                          prd.TypeCode,
                          k.ChqBank,
                          k.ChqFor,
                          k.ChqNO,
                          k.ChqPerson,
                          k.Comment,
                          k.RecPayID,
                          k.RecPayPrice,
                          k.RecPayType,
                          TransferType = (k.TransferType == 0 ? "نقدی" : k.TransferType == 1 ? "چک" : "بدهی-قرض"),
                          RPCustomerName = (DCMDC.TBL_Customers.First(Cr => Cr.CustomerID.Equals(k.RPCustomerCode)).CustomerName)
                      };
            gridControl_CarSubRPList.DataSource = SUS;
            gridView_CarSubRPList.FocusedRowHandle = RowFocus;
            SumPricePublic = double.Parse((gridView_CarSubRPList.Columns["RecPayPrice"].SummaryItem.SummaryValue??0).ToString());
        }


        private void buttonItemSelector_Click(object sender, EventArgs e)
        {
            gridView_CarSubRPList.ColumnsCustomization(new Point(100, 100));
        }

        private void buttonItemCarSubRPSearch_Click(object sender, EventArgs e)
        {
            gridView_CarSubRPList.OptionsView.ShowAutoFilterRow = !gridView_CarSubRPList.OptionsView.ShowAutoFilterRow;
        }

        private void buttonItemCarSubRPPrintList_Click(object sender, EventArgs e)
        {
            PrintPreview_frm PP = new PrintPreview_frm(gridControl_CarSubRPList);
            PP.ShowDialog();
        }

        private void buttonItemEditRecPay_Click(object sender, EventArgs e)
        {
            if (gridView_CarSubRPList.RowCount == 0) return;

            int Index = gridView_CarSubRPList.FocusedRowHandle;

            CarRecPayNE_frm Uc = new CarRecPayNE_frm(false,
                Convert.ToInt32(gridView_CarSubRPList.GetRowCellValue(Index, "RecPayID")), Convert.ToInt32(gridView_CarSubRPList.GetRowCellValue(Index, "RecPayType")), 
                _customerCode, _carID, _typeCode, _subCarCode, 0);
            Uc.ShowDialog();
            ShowListCarSubRP(Index);

        }

        private void buttonItemDelRecPay_Click(object sender, EventArgs e)
        {
            if (gridView_CarSubRPList.RowCount == 0) return;

            int Index = gridView_CarSubRPList.FocusedRowHandle;
            int CarSubRPID = Convert.ToInt32(gridView_CarSubRPList.GetRowCellValue(Index, "SubCarCode"));
            int RecPayID = Convert.ToInt32(gridView_CarSubRPList.GetRowCellValue(Index, "RecPayID"));

            if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این ردیف حذف شود؟")) return;
            TBL_CarSubRP thsf = DCMDC.TBL_CarSubRPs.First(hf =>
                hf.CarID.Equals(_carID) && hf.SubCarCode.Equals(CarSubRPID) && hf.RecPayID.Equals(RecPayID));
            DCMDC.TBL_CarSubRPs.DeleteOnSubmit(thsf);
            DCMDC.SubmitChanges();
            
            TBL_CarRecPay thrp = DCMDC.TBL_CarRecPays.First(hf =>hf.RecPayID.Equals(RecPayID));
            DCMDC.TBL_CarRecPays.DeleteOnSubmit(thrp);
            DCMDC.SubmitChanges();
            
            ShowListCarSubRP(Index - 1);
        }

        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonItemCost_Click(object sender, EventArgs e)
        {
            int RecPayType = _typeCode == 0 ? 1 : 0;

            CarRecPayNE_frm Uc = new CarRecPayNE_frm(true, 0, RecPayType,
                _customerCode, _carID, _typeCode, _subCarCode, 0);
            Uc.ShowDialog();
            ShowListCarSubRP(gridView_CarSubRPList.RowCount);

        }

        private void buttonItemChq_Click(object sender, EventArgs e)
        {
            int RecPayType = _typeCode == 0 ? 1 : 0;

            CarRecPayNE_frm Uc = new CarRecPayNE_frm(true, 0, RecPayType,
                _customerCode, _carID, _typeCode, _subCarCode, 1);
            Uc.ShowDialog();
            ShowListCarSubRP(gridView_CarSubRPList.RowCount);

        }

        private void buttonItemDebit_Click(object sender, EventArgs e)
        {
            int RecPayType = _typeCode == 0 ? 1 : 0;

            CarRecPayNE_frm Uc = new CarRecPayNE_frm(true, 0, RecPayType,
                _customerCode, _carID, _typeCode, _subCarCode, 2);
            Uc.ShowDialog();
            ShowListCarSubRP(gridView_CarSubRPList.RowCount);

        }


    }
}
