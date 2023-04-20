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
using System.Globalization;

namespace RentCarPrj
{
    public partial class CustomersDutyRep_frm : Form
    {
        public CustomersDutyRep_frm()
        {
            InitializeComponent();
        }
        
        DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);


        #region Load & UI
        private void CustomersDutyRep_frm_Load(object sender, EventArgs e)
        {
            SetDateToModules();
            ShowListCustomer(1);
            
        }

        private void SetDateToModules()
        {
            //PersianCalendar farsi = new PersianCalendar();
            //comboBox_CustomerYear1.Text = farsi.GetYear(DateTime.Now).ToString(); comboBox_CustomerYear2.Text = comboBox_CustomerYear1.Text;
            //comboBox_CustomerMonth1.Text = farsi.GetMonth(DateTime.Now).ToString(); comboBox_CustomerMonth2.Text = comboBox_CustomerMonth1.Text;
            //comboBox_CustomerDay1.Text = farsi.GetDayOfMonth(DateTime.Now).ToString(); comboBox_CustomerDay2.Text = comboBox_CustomerDay1.Text;
        }

        #endregion


        #region Search

        private void ShowListCustomer(int RowFocus)
        {
            var SUS = (from prd in DCMDC.TBL_CarDuties
                      join k in DCMDC.TBL_Cars on prd.CarID equals k.CarID into h1
                      from h2 in h1.DefaultIfEmpty()
                      where prd.RentPersonCode == int.Parse((textBox_RentPersonCode.Tag??0).ToString())
                      orderby prd.DutyDate
                      select new
                      {
                          prd.DutyNumber,
                          prd.DriverUse,
                          
                          h2.CarNumber,
                          h2.BodyNO,
                          h2.EngineNO,
                          h2.CarName,
                          h2.CarPic,
                          h2.ColorSet,

                          DutyDate = Global_Cls.MiladiDateToShamsi(prd.DutyDate.Value),
                          DutyTypeStr = (prd.DutyType == 0 ? "سرویس" : prd.DutyType == 1 ? "تمدید" : "عودت"),
                          prd.DutyType,
                          OperatorName = (DCMDC.TBL_Operators.First(Cr => Cr.OperatorCode.Equals(prd.OperatorCode)).OperatorName),
                          RentPersonName = (DCMDC.TBL_Customers.First(Cr => Cr.CustomerID.Equals(prd.RentPersonCode)).CustomerName),
                          DeliveryDate = Global_Cls.MiladiDateToShamsi(prd.DeliveryDate.Value),
                          RejectDate = Global_Cls.MiladiDateToShamsi(prd.RejectDate.Value),
                          RentTypeStr = (prd.RentType == 0 ? "شخص حقیقی" : prd.RentType == 1 ? "اشخاص حقوقی" : prd.RentType == 2 ? "هتل ها" : prd.RentType == 3 ? "فرودگاه ها" : prd.RentType == 4 ? "اشخاص خارجی" : prd.RentType == 5 ? "همکار" : "سایر"),
                          prd.RentType,
                          prd.TotalPrice
                      }).AsEnumerable()
                        .Select((prd, j) => new
                        {
                            RowNumber = j + 1,
                            prd.DutyNumber,
                            prd.DriverUse,

                            prd.CarNumber,
                            prd.BodyNO,
                            prd.EngineNO,
                            prd.CarName,
                            prd.CarPic,
                            prd.ColorSet,

                            prd.DutyDate,
                            prd.DutyTypeStr,
                            prd.DutyType,
                            prd.OperatorName,
                            prd.RentPersonName,
                            prd.DeliveryDate,
                            prd.RejectDate,
                            prd.RentTypeStr,
                            prd.RentType,
                            prd.TotalPrice
                        }).ToList();
            gridControl_CustomerList.DataSource = SUS;
            gridView_CustomerList.FocusedRowHandle = RowFocus;
        }
        #endregion


        #region All Buttons

        private void buttonItemCustomEdit_Click(object sender, EventArgs e)
        {
            if (gridView_CustomerList.RowCount == 0) return;
            int Index = gridView_CustomerList.FocusedRowHandle;

            CustomerNE_frm Uc = new CustomerNE_frm(false, 0, Convert.ToInt32(gridView_CustomerList.GetRowCellValue(Index, "CustomerID")));
            Uc.ShowDialog();
            ShowListCustomer(Index);
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
            PrintPreview_frm ppf = new PrintPreview_frm(gridControl_CustomerList);
            ppf.ShowDialog();
        }


       
        #endregion

        //private void panel_RpCustomer1_Leave(object sender, EventArgs e)
        //{
        //    if (Convert.ToInt16(comboBox_CustomerMonth1.Text) > 6 && Convert.ToInt16(comboBox_CustomerDay1.Text) == 31) comboBox_CustomerDay1.Text = "30";
        //    if (Convert.ToInt16(comboBox_CustomerMonth1.Text) == 12 && (Convert.ToInt16(comboBox_CustomerDay1.Text) == 31 || Convert.ToInt16(comboBox_CustomerDay1.Text) == 30)) comboBox_CustomerDay1.Text = "29";
        //}

        //private void panel_DRpCustomer2_Leave(object sender, EventArgs e)
        //{
        //    if (Convert.ToInt16(comboBox_CustomerMonth2.Text) > 6 && Convert.ToInt16(comboBox_CustomerDay2.Text) == 31) comboBox_CustomerDay2.Text = "30";
        //    if (Convert.ToInt16(comboBox_CustomerMonth2.Text) == 12 && (Convert.ToInt16(comboBox_CustomerDay2.Text) == 31 || Convert.ToInt16(comboBox_CustomerDay2.Text) == 30)) comboBox_CustomerDay2.Text = "29";
        //}

        private void button_View_Click(object sender, EventArgs e)
        {
            ShowListCustomer(gridView_CustomerList.RowCount);
        }

        private void button_RentPersonCode_Click(object sender, EventArgs e)
        {
            SelectPerson_frm sp = new SelectPerson_frm(0, 0);
            sp.ShowDialog();
            if (sp.CodeC != 0)
            {
                textBox_RentPersonCode.Tag = sp.CodeC;
                textBox_RentPersonCode.Text = sp.NameC;
            }
        }




    }
}
