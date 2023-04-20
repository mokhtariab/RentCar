using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RentCarPrj.Properties;
using RentCarPrj.DataLinq;

namespace RentCarPrj
{
    public partial class CustomerList_UC : UserControl
    {
        public CustomerList_UC()
        {
            InitializeComponent();
            ShowListCustomer(1);
            InterFaceChange();
        }
        
        DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);


        #region Load & UI
        private void CustomerList_UC_Load(object sender, EventArgs e)
        {
            ShowListCustomer(1);
            InterFaceChange();
        }

        private void InterFaceChange()
        {
            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains(buttonItemCustomEdit.Name)) buttonItemCustomEdit.Enabled = false;
                if (UPer.Contains(buttonItemCustomDel.Name)) buttonItemCustomDel.Enabled = false;
                if (UPer.Contains(buttonItemCustomPrintList.Name)) buttonItemCustomPrintList.Enabled = false;
                if (UPer.Contains(buttonItemCustSMS.Name)) buttonItemCustSMS.Enabled = false;
                if (UPer.Contains(buttonItemCustEmail.Name)) buttonItemCustEmail.Enabled = false;
            }

            //codeing
            if (!Global_Cls.SoftwareCode.Contains("+S"))
            {
                buttonItemCustSMS.Enabled = false;
            }
            if (Global_Cls.SoftwareCode.Contains("L1") || Global_Cls.SoftwareCode.Contains("N1") || Global_Cls.SoftwareCode == "Trial")
            {
                buttonItemCustEmail.Enabled = false;
            }
            //if (Global_Cls.SoftwareCode == "Trial")
            //{
            //    buttonItem_ieSearch.Enabled = false;
            //    buttonItem_SearchHouse.Enabled = false;
            //}
            //codeing
        }

        private void CustomerList_UC_Layout(object sender, LayoutEventArgs e)
        {
            try 
            { 
                ShowListCustomer(gridView_CustomerList.RowCount); 
            }
            catch { }
        }

        #endregion


        #region Search

        private void ShowListCustomer(int RowFocus)
        {
            var SUS = from prd in DCMDC.TBL_Customers
                      where prd.IsParent == false
                      select new
                      {
                          CreateDate = Global_Cls.MiladiDateToShamsi(prd.CreateDate.Value),
                          prd.CustomerID,
                          prd.CustomerType,
                          prd.BrithCityName,
                          BrithDate = Global_Cls.MiladiDateToShamsi(prd.BrithDate.Value),
                          prd.CustomerName,
                          prd.Email,
                          prd.IDNO,
                          prd.Mobile,
                          prd.NationalCode,
                          prd.ParentName,
                          prd.Address,
                          prd.Tel,
                          prd.AddressBusiness,
                          prd.TelBusiness,
                          prd.Active
                      };
            gridControl_CustomerList.DataSource = SUS;
            gridView_CustomerList.FocusedRowHandle = RowFocus;
        }
        #endregion


        #region All Buttons

        
        CustomerNE_frm CNE = null;
        int IndexCNE = 0;
        private void buttonItemCustomEdit_Click(object sender, EventArgs e)
        {
            if (buttonItemCustomEdit.Enabled && buttonItemCustomEdit.Visible)
            {
                if (gridView_CustomerList.RowCount == 0) return;
                IndexCNE = gridView_CustomerList.FocusedRowHandle;

                if (CNE == null)
                {
                    CNE = new CustomerNE_frm(false, 0, Convert.ToInt32(gridView_CustomerList.GetRowCellValue(IndexCNE, "CustomerID")));
                    CNE.Disposed += new EventHandler(CNE_Disposed);
                }
                CNE.Show();
                CNE.BringToFront();
                CNE.Focus();
            }
        }

        void CNE_Disposed(object sender, EventArgs e)
        {
            CNE = null;
            ShowListCustomer(IndexCNE);
        }

        private void buttonItemCustomDel_Click(object sender, EventArgs e)
        {
            if (gridView_CustomerList.RowCount == 0) return;

            int Index = gridView_CustomerList.FocusedRowHandle;
            int CustID = Convert.ToInt32(gridView_CustomerList.GetRowCellValue(Index, "CustomerID"));

            if (!DCMDC.CheckCustomerCode(CustID).Value)
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, " فعالیت این متقاضی در سیستم موجود می باشد. درنتیجه امکان حذف وجود ندارد ");
                return;
            }

            
            if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این متقاضی حذف شود؟")) return;
            TBL_Customer thsf = DCMDC.TBL_Customers.First(hf => hf.CustomerID.Equals(CustID));
            DCMDC.TBL_Customers.DeleteOnSubmit(thsf);
            DCMDC.SubmitChanges();
            ShowListCustomer(Index - 1);
        }

        private void buttonItemCustomSearch_Click(object sender, EventArgs e)
        {
            gridView_CustomerList.OptionsView.ShowAutoFilterRow = !gridView_CustomerList.OptionsView.ShowAutoFilterRow;
        }

        private void buttonItemSelector_Click(object sender, EventArgs e)
        {
            gridView_CustomerList.ColumnsCustomization(new Point(100, 100));
        }

        private void buttonItemCustomPrintList_Click(object sender, EventArgs e)
        {
            gridView_CustomerList.FormatConditions[0].Appearance.BackColor = Color.White;
            gridView_CustomerList.FormatConditions[1].Appearance.BackColor = Color.White;
            gridView_CustomerList.FormatConditions[2].Appearance.BackColor = Color.White;
            gridView_CustomerList.FormatConditions[3].Appearance.BackColor = Color.White;
            gridView_CustomerList.FormatConditions[4].Appearance.BackColor = Color.White;

            PrintPreview_frm PP = new PrintPreview_frm(gridControl_CustomerList);
            PP.ShowDialog();

            gridView_CustomerList.FormatConditions[0].Appearance.BackColor = Color.PaleGreen;
            gridView_CustomerList.FormatConditions[1].Appearance.BackColor = Color.Bisque;
            gridView_CustomerList.FormatConditions[2].Appearance.BackColor = Color.Pink;
            gridView_CustomerList.FormatConditions[3].Appearance.BackColor = Color.LemonChiffon;
            gridView_CustomerList.FormatConditions[4].Appearance.BackColor = Color.Gainsboro;
        }


        private void label1_CheckedChanged(object sender, EventArgs e)
        {
            string ActiveFilterString = "  ";
            if (chkAmanat.Checked)
                ActiveFilterString = " (CustomerType = 1 and Active = true) ";
            else if (chkMalek.Checked)
                ActiveFilterString = " (CustomerType = 2 and Active = true) ";
            else if (chkHamkar.Checked)
                ActiveFilterString = " (CustomerType = 3 and Active = true) ";
            else if (chkOther.Checked)
                ActiveFilterString = " (CustomerType = 4 and Active = true) ";
            else if (chkDeActiveCustom.Checked)
                ActiveFilterString = " Active = false ";

            gridView_CustomerList.ActiveFilterString = ActiveFilterString;
            gridView_CustomerList.ApplyColumnsFilter();
        }
        #endregion

        private void buttonItemSMS_Click(object sender, EventArgs e)
        {
            Global_Cls.SendSMS_Advertisment(true, "", "");
        }

        private void buttonItemEmail_Click(object sender, EventArgs e)
        {
            Global_Cls.SendEmail("");
        }




    }
}
