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
    public partial class OperatorList_UC : UserControl
    {
        public OperatorList_UC()
        {
            InitializeComponent();
        }
        
        DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

        #region Load & UI

        private void OperatorList_UC_Load(object sender, EventArgs e)
        {
            ShowListOperator(1);
            InterFaceChange();
        }

        private void InterFaceChange()
        {
            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains(buttonItemOperatorEdit.Name)) buttonItemOperatorEdit.Enabled = false;
                if (UPer.Contains(buttonItemOperatorDel.Name)) buttonItemOperatorDel.Enabled = false;
                if (UPer.Contains(buttonItemOperatorPrintList.Name)) buttonItemOperatorPrintList.Enabled = false;
            }
        }

        private void OperatorList_UC_Layout(object sender, LayoutEventArgs e)
        {
            try
            {
                ShowListOperator(gridView_OperatorList.RowCount);
            }
            catch { }

        }


        #endregion


        #region Search
        private void ShowListOperator(int RowFocus)
        {
            var SUS = from prd in DCMDC.TBL_Operators
                      select new
                      {
                          CreateDate = Global_Cls.MiladiDateToShamsi(prd.CreateDate.Value),
                          prd.OperatorCode,
                          prd.Address,
                          BrithDate = Global_Cls.MiladiDateToShamsi(prd.BrithDate.Value),
                          prd.OperatorName,
                          prd.Email,
                          prd.IDNO,
                          prd.Mobile,
                          prd.NationalCode,
                          prd.ParentName,
                          prd.Tel,
                          prd.PorsantPercent,
                          prd.PriceMonthly,
                          EmployDate = Global_Cls.MiladiDateToShamsi(prd.EmployDate.Value),
                          prd.ActionType,
                          prd.DiplomaNo,
                          prd.BirthCityName,
                          DiplomaExpDate = Global_Cls.MiladiDateToShamsi(prd.DiplomaExpDate.Value)
                      };
            gridControl_OperatorList.DataSource = SUS;
            gridView_OperatorList.FocusedRowHandle = RowFocus;
        }


        #endregion


        #region All Buttons

        OperatorNE_frm ONE = null;
        int IndexONE = 0;
        private void buttonItemOperatorEdit_Click(object sender, EventArgs e)
        {
            if (buttonItemOperatorEdit.Enabled && buttonItemOperatorEdit.Visible)
            {
                if (gridView_OperatorList.RowCount == 0) return;

                IndexONE = gridView_OperatorList.FocusedRowHandle;

                if (ONE == null)
                {
                    ONE = new OperatorNE_frm(Convert.ToInt32(gridView_OperatorList.GetRowCellValue(IndexONE, "OperatorCode")));
                    ONE.Disposed += new EventHandler(ONE_Disposed);
                }
                ONE.Show();
                ONE.BringToFront();
                ONE.Focus();
            }
        }

        void ONE_Disposed(object sender, EventArgs e)
        {
            ONE = null;
            ShowListOperator(IndexONE);
        }
        

        private void buttonItemOperatorDel_Click(object sender, EventArgs e)
        {
            if (gridView_OperatorList.RowCount == 0) return;
            int Index = gridView_OperatorList.FocusedRowHandle;
            int OpCode = Convert.ToInt32(gridView_OperatorList.GetRowCellValue(Index, "OperatorCode"));

            if (!DCMDC.CheckOperatorCode(OpCode).Value)
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, " فعالیت این کارگزار در سیستم می باشد. درنتیجه امکان حذف وجود ندارد ");
                return;
            }

            if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این کارگزار حذف شود؟")) return;
            TBL_Operator thsf = DCMDC.TBL_Operators.First(hf => hf.OperatorCode.Equals(OpCode));
            DCMDC.TBL_Operators.DeleteOnSubmit(thsf);
            DCMDC.SubmitChanges();
            ShowListOperator(Index - 1);
        }

        private void buttonItemOperatorSearch_Click(object sender, EventArgs e)
        {
            gridView_OperatorList.OptionsView.ShowAutoFilterRow = !gridView_OperatorList.OptionsView.ShowAutoFilterRow;
        }

        private void buttonItemSelector_Click(object sender, EventArgs e)
        {
            gridView_OperatorList.ColumnsCustomization(new Point(100, 100));
        }

        private void buttonItemOperatorPrintList_Click(object sender, EventArgs e)
        {
            PrintPreview_frm PP = new PrintPreview_frm(gridControl_OperatorList);
            PP.ShowDialog();
        }

        private void button_OperatorPrice_Click(object sender, EventArgs e)
        {

        }


        #endregion

    }
}
