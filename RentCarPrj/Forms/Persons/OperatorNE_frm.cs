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
    public partial class OperatorNE_frm : Form
    {
        int _operatorID = 0;
        bool _newOrEditOperator = false;
        //private int MaxOperatorID;

        public OperatorNE_frm(int OperatorID)
        {
            InitializeComponent();
            _operatorID = OperatorID;
            _newOrEditOperator = false;
        }
        public OperatorNE_frm()
        {
            InitializeComponent();
            _newOrEditOperator = true;
        }

        DataClasses_MainDataContext DCMD = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

        #region Load
        private void OperatorNE_frm_Load(object sender, EventArgs e)
        {
            var SUS = from prd in DCMD.TBL_PrtCities
                      orderby prd.CityName_Fa
                      select prd;
            ComboBoxBrithCityName.DataSource = SUS;

            SetDefault_OperatorNE();
        }

        private void SetDefault_OperatorNE()
        {
            if (!_newOrEditOperator)
            {
                try
                {
                    TBL_Operator tbhc = DCMD.TBL_Operators.First(thfr => thfr.OperatorCode.Equals(_operatorID));
                    string DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhc.CreateDate));
                    comboBox_YearCD.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_MonthCD.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_DayCD.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                    textBox_OName.Text = tbhc.OperatorName;
                    textBox_OParentN.Text = tbhc.ParentName;
                    textBox_OIDNO.Text = tbhc.IDNO.ToString();
                    textBox_ONationalCode.Text = tbhc.NationalCode;
                    ComboBoxBrithCityName.Text = tbhc.BirthCityName;

                    string DateStr1 = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhc.BrithDate));
                    comboBox_YearBD.Text = Convert.ToInt16(DateStr1.Substring(0, 4)).ToString();
                    comboBox_MonthBD.Text = Convert.ToInt16(DateStr1.Substring(5, 2)).ToString();
                    comboBox_DayBD.Text = Convert.ToInt16(DateStr1.Substring(8, 2)).ToString();

                    textBox_OAddress.Text = tbhc.Address;
                    textBox_OTel.Text = tbhc.Tel;
                    textBox_Omobile.Text = tbhc.Mobile;
                    textBox_OEMail.Text = tbhc.Email;
                    textBox_DiplomaNo.Text = tbhc.DiplomaNo;
                    comboBox_ActionType.Text = tbhc.ActionType;

                    string DateStr2 = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhc.EmployDate));
                    comboBox_YearED.Text = Convert.ToInt16(DateStr2.Substring(0, 4)).ToString();
                    comboBox_MonthED.Text = Convert.ToInt16(DateStr2.Substring(5, 2)).ToString();
                    comboBox_DayED.Text = Convert.ToInt16(DateStr2.Substring(8, 2)).ToString();

                    textBox_PriceMonthly.Text = tbhc.PriceMonthly.ToString();
                    nUpDown_PorsantPercent.Value = tbhc.PorsantPercent.Value;
                    
                    string DateStr3 = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhc.DiplomaExpDate));
                    comboBox_YearDED.Text = Convert.ToInt16(DateStr3.Substring(0, 4)).ToString();
                    comboBox_MonthDED.Text = Convert.ToInt16(DateStr3.Substring(5, 2)).ToString();
                    comboBox_DayDED.Text = Convert.ToInt16(DateStr3.Substring(8, 2)).ToString();
                }
                catch(Exception ex)
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "در اطلاعات اولیه اشکال وجود دارد!",ex.Message);
                }
            }

            else if (_newOrEditOperator)
            {
                //try
                //{
                //    var MaxID = (from prd in DCMD.TBL_Operators
                //                 select prd.OperatorCode).Max();
                //    MaxOperatorID = MaxID;
                //}
                //catch
                //{
                //    MaxOperatorID = 0;
                //}

                string DateStr = Global_Cls.MiladiDateToShamsi(DateTime.Today);
                comboBox_YearCD.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                comboBox_MonthCD.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                comboBox_DayCD.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                comboBox_YearBD.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                comboBox_MonthBD.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                comboBox_DayBD.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                comboBox_YearED.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                comboBox_MonthED.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                comboBox_DayED.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();
                
                comboBox_YearDED.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                comboBox_MonthDED.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                comboBox_DayDED.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                ComboBoxBrithCityName.Text = "تهران";
            }
        }
        #endregion


        #region Save
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            if (textBox_OName.Text == "") { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "نام را وارد کنید!"); textBox_OName.Focus(); return; }
            if (textBox_ONationalCode.Text == "") { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "کد ملی را وارد کنید!"); textBox_ONationalCode.Focus(); return; }
            if (textBox_Omobile.Text == "") { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "موبایل را وارد نمایید!"); textBox_Omobile.Focus(); return; }

            panel_CDate1_Leave(this, null);
            panel_BrithDate_Leave(this, null);
            panel_EmployDate_Leave(this, null);
            panelDiplomaExpDate_Leave(this, null);
            if (OKFunction())
                Close();
        }

        private bool OKFunction()
        {
            if (_newOrEditOperator)
                try
                {
                    DataClasses_MainDataContext DCMD1 = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
                    TBL_Operator THC = new TBL_Operator()
                   {
                       CreateDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearCD.Text, comboBox_MonthCD.Text, comboBox_DayCD.Text),
                       OperatorName = textBox_OName.Text,
                       ParentName = textBox_OParentN.Text,
                       IDNO = textBox_OIDNO.Text,

                       NationalCode = textBox_ONationalCode.Text,
                       BrithDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearBD.Text, comboBox_MonthBD.Text, comboBox_DayBD.Text),
                       BirthCityName = ComboBoxBrithCityName.Text,
                       Address = textBox_OAddress.Text,

                       Tel = textBox_OTel.Text,
                       Mobile = textBox_Omobile.Text,
                       Email = textBox_OEMail.Text,
                       DiplomaNo = textBox_DiplomaNo.Text,
                       ActionType = comboBox_ActionType.Text,
                       PriceMonthly = double.Parse((textBox_PriceMonthly.Text == "" ? "0" : textBox_PriceMonthly.Text).Replace(",", "")),
                       EmployDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearED.Text, comboBox_MonthED.Text, comboBox_DayED.Text),
                       PorsantPercent = int.Parse(nUpDown_PorsantPercent.Value.ToString()),
                       DiplomaExpDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearDED.Text, comboBox_MonthDED.Text, comboBox_DayDED.Text),
                   };
                    DCMD1.TBL_Operators.InsertOnSubmit(THC);
                    DCMD1.SubmitChanges();
                }
                catch (Exception ex)
                {
                    if (ex.Message.IndexOf("Duplicated Row!") > -1)
                        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اطلاعات کارگزار قبلا وارد شده و تکراری است!", ex.Message);
                    else
                        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "ثبت نشد!", ex.Message);
                    return false;
                }
            else
                if (!_newOrEditOperator)
                    try
                    {
                        TBL_Operator tbhc = DCMD.TBL_Operators.First(thfh => thfh.OperatorCode.Equals(_operatorID));

                        tbhc.CreateDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearCD.Text, comboBox_MonthCD.Text, comboBox_DayCD.Text);
                        tbhc.OperatorName = textBox_OName.Text;
                        tbhc.ParentName = textBox_OParentN.Text;
                        tbhc.IDNO = textBox_OIDNO.Text;

                        tbhc.NationalCode = textBox_ONationalCode.Text;
                        tbhc.BrithDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearBD.Text, comboBox_MonthBD.Text, comboBox_DayBD.Text);
                        tbhc.BirthCityName = ComboBoxBrithCityName.Text;
                        tbhc.Address = textBox_OAddress.Text;

                        tbhc.Tel = textBox_OTel.Text;
                        tbhc.Mobile = textBox_Omobile.Text;
                        tbhc.Email = textBox_OEMail.Text;
                        tbhc.DiplomaNo = textBox_DiplomaNo.Text;
                        tbhc.ActionType = comboBox_ActionType.Text;
                        tbhc.PriceMonthly = double.Parse((textBox_PriceMonthly.Text == "" ? "0" : textBox_PriceMonthly.Text).Replace(",", ""));
                        tbhc.EmployDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearED.Text, comboBox_MonthED.Text, comboBox_DayED.Text);
                        tbhc.PorsantPercent = int.Parse(nUpDown_PorsantPercent.Value.ToString());
                        tbhc.DiplomaExpDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearDED.Text, comboBox_MonthDED.Text, comboBox_DayDED.Text);

                        DCMD.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.IndexOf("Duplicated Row!") > -1)
                            Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اطلاعات کارگزار قبلا وارد شده و تکراری است!", ex.Message);
                        else
                            Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "ثبت نشد!", ex.Message);
                        return false;
                    }

            return true;
        }

        private void buttonItem_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


        #region Other
        TextBox tx = new TextBox();
        private void textBox_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
            { e.KeyChar = '\0'; return; }

            if (e.KeyChar == (char)Keys.Space)
            {
                tx = (TextBox)sender;
                if (tx.Text.Length < 18) tx.Text = tx.Text + "000";
                tx.SelectionStart = tx.Text.Length;
            }
        }

        private void textBox_Price_TextChanged(object sender, EventArgs e)
        {
            tx = (TextBox)sender;
            string str = tx.Text;
            int ts = tx.SelectionStart;
            if (tx.Text != "")
            {
                try
                {
                    str = System.String.Format("{0:###,###}", System.Int64.Parse(str, System.Globalization.NumberStyles.Number));
                }
                catch
                {
                    str = str.Replace(",", "");
                }
                tx.Text = str.Replace(" ", "");
                tx.SelectionStart = ts + 1;
            }

        }

        private void panel_CDate1_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_MonthCD.Text) > 6 && Convert.ToInt16(comboBox_DayCD.Text) == 31) comboBox_DayCD.Text = "30";
            if (Convert.ToInt16(comboBox_MonthCD.Text) == 12 && (Convert.ToInt16(comboBox_DayCD.Text) == 31 || Convert.ToInt16(comboBox_DayCD.Text) == 30)) comboBox_DayCD.Text = "29";
        }

        private void panel_BrithDate_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_MonthBD.Text) > 6 && Convert.ToInt16(comboBox_DayBD.Text) == 31) comboBox_DayBD.Text = "30";
            if (Convert.ToInt16(comboBox_MonthBD.Text) == 12 && (Convert.ToInt16(comboBox_DayBD.Text) == 31 || Convert.ToInt16(comboBox_DayBD.Text) == 30)) comboBox_DayBD.Text = "29";
        }

        private void panel_EmployDate_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_MonthED.Text) > 6 && Convert.ToInt16(comboBox_DayED.Text) == 31) comboBox_DayED.Text = "30";
            if (Convert.ToInt16(comboBox_MonthED.Text) == 12 && (Convert.ToInt16(comboBox_DayED.Text) == 31 || Convert.ToInt16(comboBox_DayED.Text) == 30)) comboBox_DayED.Text = "29";
        }

        private void panelDiplomaExpDate_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_MonthDED.Text) > 6 && Convert.ToInt16(comboBox_DayDED.Text) == 31) comboBox_DayDED.Text = "30";
            if (Convert.ToInt16(comboBox_MonthDED.Text) == 12 && (Convert.ToInt16(comboBox_DayDED.Text) == 31 || Convert.ToInt16(comboBox_DayDED.Text) == 30)) comboBox_DayDED.Text = "29";

        }
        #endregion
        

       
    }
}
