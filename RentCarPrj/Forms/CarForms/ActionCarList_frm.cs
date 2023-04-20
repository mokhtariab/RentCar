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
    public partial class ActionCarList_frm : Form
    {
       
        int _carID,_nowKM;
        public ActionCarList_frm(int CarID)
        {
            InitializeComponent();
            _carID = CarID;
            _nowKM = DCMDC.Fn_RetKilometerUseNow(CarID).Value;
        }

        DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
        
        private void ActionCarList_frm_Load(object sender, EventArgs e)
        {
            ShowListAction(1);
            InterFaceChange();
            panelNowKM.Text = " کیلومتر فعلی: " + _nowKM;
        }

        private void InterFaceChange()
        {
            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains(buttonItemActionAdd.Name)) buttonItemActionAdd.Enabled = false;
                if (UPer.Contains(buttonItemActionEdit.Name)) buttonItemActionEdit.Enabled = false;
                if (UPer.Contains(buttonItemActionDel.Name)) buttonItemActionDel.Enabled = false;
                if (UPer.Contains(buttonItemActionCarPrintList.Name)) buttonItemActionCarPrintList.Enabled = false;
            }
        }

        private void ShowListAction(int RowFocus)
        {
            var SUS = from prd in DCMDC.TBL_ActionCars
                      where prd.CarID == _carID
                      orderby prd.ActionCode descending
                      select new
                      {
                          ActionDate = Global_Cls.MiladiDateToShamsi(prd.ActionDate.Value),
                          prd.ActionCode,
                          prd.ActionDsc,
                          prd.ActionPlace,
                          ActionTypeDsc = (DCMDC.TBL_ActionTypes.First(Cr => Cr.ActionTypeCode.Equals(prd.ActionTypeCode)).ActionTypeDsc),
                          prd.CarID,
                          prd.NextKM,
                          prd.NowKM,
                          prd.AlarmKM,
                          prd.ProductUse,
                          prd.TelPlace
                      };
            gridControl_ActionCarList.DataSource = SUS;
            gridView_ActionCarList.FocusedRowHandle = RowFocus;
        }


        private void buttonItemSelector_Click(object sender, EventArgs e)
        {
            gridView_ActionCarList.ColumnsCustomization(new Point(100, 100));
        }

        private void buttonItemActionCarSearch_Click(object sender, EventArgs e)
        {
            gridView_ActionCarList.OptionsView.ShowAutoFilterRow = !gridView_ActionCarList.OptionsView.ShowAutoFilterRow;
        }

        private void buttonItemActionCarPrintList_Click(object sender, EventArgs e)
        {
            PrintPreview_frm PP = new PrintPreview_frm(gridControl_ActionCarList);
            PP.ShowDialog();
        }

        private void buttonItemAddAction_Click(object sender, EventArgs e)
        {
            ActionCarNE_frm Uc = new ActionCarNE_frm(true, 0, _carID, _nowKM);
            Uc.ShowDialog();
            ShowListAction(1);
        }

        private void buttonItemEditAction_Click(object sender, EventArgs e)
        {
            if (buttonItemActionEdit.Enabled && buttonItemActionEdit.Visible)
            {
                if (gridView_ActionCarList.RowCount == 0) return;

                int Index = gridView_ActionCarList.FocusedRowHandle;

                ActionCarNE_frm Uc = new ActionCarNE_frm(false,
                    Convert.ToInt32(gridView_ActionCarList.GetRowCellValue(Index, "ActionCode")), _carID, _nowKM);
                Uc.ShowDialog();
                ShowListAction(Index);
            }
        }

        private void buttonItemDelAction_Click(object sender, EventArgs e)
        {
            if (gridView_ActionCarList.RowCount == 0) return;

            int Index = gridView_ActionCarList.FocusedRowHandle;
            int ActionCode = Convert.ToInt32(gridView_ActionCarList.GetRowCellValue(Index, "ActionCode"));

            if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این سرویس حذف شود؟")) return;
            TBL_ActionCar thsf = DCMDC.TBL_ActionCars.First(hf => 
                hf.CarID.Equals(_carID) && hf.ActionCode.Equals(ActionCode));
            DCMDC.TBL_ActionCars.DeleteOnSubmit(thsf);
            DCMDC.SubmitChanges();
            ShowListAction(Index - 1);
        }


    }
}
