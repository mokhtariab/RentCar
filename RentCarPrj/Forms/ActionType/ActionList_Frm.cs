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
    public partial class ActionList_Frm : Form
    {

        public ActionList_Frm()
        {
            InitializeComponent();
        }

        DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
        
        private void ActionList_Frm_Load(object sender, EventArgs e)
        {
            ShowListActionSubRP(1);
            InterFaceChange();
        }

        private void InterFaceChange()
        {

            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains(buttonItemAddAction.Name)) buttonItemAddAction.Enabled = false;
                if (UPer.Contains(buttonItemEditAction.Name)) buttonItemEditAction.Enabled = false;
                if (UPer.Contains(buttonItemDelAction.Name)) buttonItemDelAction.Enabled = false;
                if (UPer.Contains(buttonItemActionSubRPPrintList.Name)) buttonItemActionSubRPPrintList.Enabled = false;
            }
        }

        private void ShowListActionSubRP(int RowFocus)
        {
            var SUS = from prd in DCMDC.TBL_ActionTypes
                      select new
                      {
                          prd.ActionTypeCode,
                          prd.ActionTypeDsc 
                          
                      };
            gridControl_ActionSubRPList.DataSource = SUS;
            gridView_ActionSubRPList.FocusedRowHandle = RowFocus;
        }


        private void buttonItemSelector_Click(object sender, EventArgs e)
        {
            gridView_ActionSubRPList.ColumnsCustomization(new Point(100, 100));
        }

        private void buttonItemCarSubRPSearch_Click(object sender, EventArgs e)
        {
            gridView_ActionSubRPList.OptionsView.ShowAutoFilterRow = !gridView_ActionSubRPList.OptionsView.ShowAutoFilterRow;
        }

        private void buttonItemCarSubRPPrintList_Click(object sender, EventArgs e)
        {
            PrintPreview_frm PP = new PrintPreview_frm(gridControl_ActionSubRPList);
            PP.ShowDialog();
        }
        private void buttonItemAddAction_Click(object sender, EventArgs e)
        {
            int Index = gridView_ActionSubRPList.FocusedRowHandle;

            ActionPayNE_Frm Uc = new ActionPayNE_Frm(true, 0);
            Uc.ShowDialog();
            ShowListActionSubRP(gridView_ActionSubRPList.RowCount);
        }

        private void buttonItemEditAction_Click(object sender, EventArgs e)
        {
            if (buttonItemEditAction.Enabled && buttonItemEditAction.Visible)
            {
                if (gridView_ActionSubRPList.RowCount == 0) return;

                int Index = gridView_ActionSubRPList.FocusedRowHandle;

                ActionPayNE_Frm Uc = new ActionPayNE_Frm(false,
                    Convert.ToInt32(gridView_ActionSubRPList.GetRowCellValue(Index, "ActionTypeCode")));
                Uc.ShowDialog();
                ShowListActionSubRP(Index);
            }
        }

        private void buttonItemDelAction_Click(object sender, EventArgs e)
        {
            if (gridView_ActionSubRPList.RowCount == 0) return;

            int Index = gridView_ActionSubRPList.FocusedRowHandle;
            int AccountSubRPID = Convert.ToInt32(gridView_ActionSubRPList.GetRowCellValue(Index, "SubActionCode"));
            int _AccountID = Convert.ToInt32(gridView_ActionSubRPList.GetRowCellValue(Index, "ActionTypeCode"));

            if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این ردیف حذف شود؟")) return;
            TBL_ActionType thsf = DCMDC.TBL_ActionTypes.First(hf => hf.ActionTypeCode.Equals(_AccountID));
            DCMDC.TBL_ActionTypes.DeleteOnSubmit(thsf);
            DCMDC.SubmitChanges();
            ShowListActionSubRP(Index - 1);
        }


    }
}
