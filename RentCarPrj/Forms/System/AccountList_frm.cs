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
    public partial class AccountList_Frm : Form
    {

        public AccountList_Frm()
        {
            InitializeComponent();
        }

        DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
        
        private void AccountList_Frm_Load(object sender, EventArgs e)
        {
            ShowListAccountSubRP(1);
            InterFaceChange();
        }

        private void InterFaceChange()
        {

            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains(buttonItemAddAccount.Name)) buttonItemAddAccount.Enabled = false;
                if (UPer.Contains(buttonItemEditAccount.Name)) buttonItemEditAccount.Enabled = false;
                if (UPer.Contains(buttonItemDelAccount.Name)) buttonItemDelAccount.Enabled = false;
                if (UPer.Contains(buttonItemAccountSubRPPrintList.Name)) buttonItemAccountSubRPPrintList.Enabled = false;
            }
        }

        private void ShowListAccountSubRP(int RowFocus)
        {
            var SUS = from prd in DCMDC.TBL_AccountNumbers
                      select new
                      {
                          prd.AccountID,
                          prd.AccountNumber,
                          prd.AccountName,
                          prd.AccountCardNo,
                          prd.BankName,
                          prd.IBANNo
                      };
            gridControl_CarSubRPList.DataSource = SUS;
            gridView_AccountSubRPList.FocusedRowHandle = RowFocus;
        }


        private void buttonItemSelector_Click(object sender, EventArgs e)
        {
            gridView_AccountSubRPList.ColumnsCustomization(new Point(100, 100));
        }

        private void buttonItemCarSubRPSearch_Click(object sender, EventArgs e)
        {
            gridView_AccountSubRPList.OptionsView.ShowAutoFilterRow = !gridView_AccountSubRPList.OptionsView.ShowAutoFilterRow;
        }

        private void buttonItemCarSubRPPrintList_Click(object sender, EventArgs e)
        {
            PrintPreview_frm PP = new PrintPreview_frm(gridControl_CarSubRPList);
            PP.ShowDialog();
        }
        private void buttonItemAddAccount_Click(object sender, EventArgs e)
        {
            int Index = gridView_AccountSubRPList.FocusedRowHandle;

            AccountPayNE_frm Uc = new AccountPayNE_frm(true, 0);
            Uc.ShowDialog();
            ShowListAccountSubRP(gridView_AccountSubRPList.RowCount);
        }

        private void buttonItemEditAccount_Click(object sender, EventArgs e)
        {
            if (buttonItemEditAccount.Enabled && buttonItemEditAccount.Visible)
            {
                if (gridView_AccountSubRPList.RowCount == 0) return;

                int Index = gridView_AccountSubRPList.FocusedRowHandle;

                AccountPayNE_frm Uc = new AccountPayNE_frm(false,
                    Convert.ToInt32(gridView_AccountSubRPList.GetRowCellValue(Index, "AccountID")));
                Uc.ShowDialog();
                ShowListAccountSubRP(Index);
            }
        }

        private void buttonItemDelAccount_Click(object sender, EventArgs e)
        {
            if (gridView_AccountSubRPList.RowCount == 0) return;

            int Index = gridView_AccountSubRPList.FocusedRowHandle;
            int AccountSubRPID = Convert.ToInt32(gridView_AccountSubRPList.GetRowCellValue(Index, "SubAccountCode"));
            int _AccountID = Convert.ToInt32(gridView_AccountSubRPList.GetRowCellValue(Index, "AccountID"));

            if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این ردیف حذف شود؟")) return;
            TBL_AccountNumber thsf = DCMDC.TBL_AccountNumbers.First(hf =>
                hf.AccountID.Equals(_AccountID));
            DCMDC.TBL_AccountNumbers.DeleteOnSubmit(thsf);
            DCMDC.SubmitChanges();
            ShowListAccountSubRP(Index - 1);
        }


    }
}
