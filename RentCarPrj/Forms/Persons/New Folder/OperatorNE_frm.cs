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
        public OperatorNE_frm()
        {
            InitializeComponent();
        }

        public int NewOrEditOperator, OperatorID;
        private int MaxOperatorID;
        DataClasses_MainDataContext DCMD = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

        #region Load
        private void OperatorNE_frm_Load(object sender, EventArgs e)
        {
            SetDefault_OperatorNE();
        }

        private void SetDefault_OperatorNE()
        {
            try
            {
                var MaxID = (from prd in DCMD.Tbl_Operators
                             select prd.OperatorCode).Max();
                MaxOperatorID = MaxID;
            }
            catch
            {
                MaxOperatorID = 0;
            }

            //===========================================================================
            if (NewOrEditOperator == 2)
            {
                try
                {
                    Tbl_Operator tbhc = DCMD.Tbl_Operators.First(thfr => thfr.OperatorCode.Equals(OperatorID));
                    string DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhc.CreateDate));
                    comboBox_YearCD.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_MonthCD.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_DayCD.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                    textBox_OName.Text = tbhc.Name;
                    textBox_OParentN.Text = tbhc.ParentName;
                    textBox_OIDNO.Text = tbhc.IDNO.ToString();
                    textBox_ONationalCode.Text = tbhc.NationalCode;
                    textBox_OBrithCityName.Text = tbhc.BirthCityName;

                    string DateStr1 = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhc.BrithDate));
                    comboBox_YearBD.Text = Convert.ToInt16(DateStr1.Substring(0, 4)).ToString();
                    comboBox_MonthBD.Text = Convert.ToInt16(DateStr1.Substring(5, 2)).ToString();
                    comboBox_DayBD.Text = Convert.ToInt16(DateStr1.Substring(8, 2)).ToString();

                    textBox_OAddress.Text = tbhc.Address;
                    textBox_OTel.Text = tbhc.Tel;
                    textBox_Omobile.Text = tbhc.Mobile;
                    textBox_OEMail.Text = tbhc.email;
                    textBox_DiplomaNo.Text = tbhc.DiplomaNo;
                    comboBox_ActionType.Text = tbhc.ActionType;

                    string DateStr2 = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhc.EmployDate));
                    comboBox_YearED.Text = Convert.ToInt16(DateStr2.Substring(0, 4)).ToString();
                    comboBox_MonthED.Text = Convert.ToInt16(DateStr2.Substring(5, 2)).ToString();
                    comboBox_DayED.Text = Convert.ToInt16(DateStr2.Substring(8, 2)).ToString();

                    textBox_PriceMonthly.Text = tbhc.PriceMonthly.ToString();
                    nUpDown_PorsantPercent.Value = tbhc.PorsantPercent.Value;

                }
                catch(Exception ex)
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "در اطلاعات اولیه اشکال وجود دارد!",ex.Message);
                }
            }

            else if (NewOrEditOperator == 1)
            {
                //date
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
            }
            //--------------------------------------------------------
        }
        #endregion


        #region Save
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            if (textBox_OName.Text == "") { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "نام را وارد نمایید!"); textBox_OName.Focus(); return; }
            if (textBox_OIDNO.Text == "") { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "شماره شناسنامه را وارد نمایید!"); textBox_OIDNO.Focus(); return; }
            if (textBox_Omobile.Text == "") { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "موبایل را وارد نمایید!"); textBox_Omobile.Focus(); return; }
            panel_CDate1_Leave(this, null);
            panel_BrithDate_Leave(this, null);
            panel_EmployDate_Leave(this, null);
            if (OKFunction())
            {
                Close();
            }
        }

        //    if (NewOrEditConclusion == 2)
        //    {
        //        if (textBox_OName.Text != Name)
        //            if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, true, "آیا مایلید شماره برگه قرارداد تغییر کند؟"))
        //            { textBox_CncluNo.Focus(); return; }

        //        if (textBox_FileNo.Text != FileNoHolder)
        //            if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, true, "آیا مایلید شماره فایل تغییر کند؟"))
        //            { textBox_FileNo.Focus(); return; }
        //    }

        //    string MsgStr = "";
        //    if (NewOrEditConclusion == 1) MsgStr = "آیا به ثبت این قرارداد اطمینان دارید؟";
        //    else MsgStr = "آیا مایلید تفییرات ذخیره شوند؟";
        //    if (Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, MsgStr))
        //        if (OKFunction())
        //        {
        //            if (checkBox_ListConclusion.Checked) Global_Cls.MainForm.buttonItem_ListConclusion_Click(this, null);
        //            this.DialogResult = DialogResult.OK;
        //            this.Close();
        //        }
        //}

        private bool OKFunction()
        {
            if (NewOrEditOperator == 1)
                try
                {
                    Tbl_Operator THC = new Tbl_Operator()
                   {
                       CreateDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearCD.Text, comboBox_MonthCD.Text, comboBox_DayCD.Text),//textBox_Date.Text),
                       Name = textBox_OName.Text,
                       ParentName = textBox_OParentN.Text,
                       IDNO = int.Parse(textBox_OIDNO.Text == "" ? "0" : textBox_OIDNO.Text),

                       NationalCode = textBox_ONationalCode.Text,
                       BrithDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearBD.Text, comboBox_MonthBD.Text, comboBox_DayBD.Text),//textBox_Date.Text),,
                       BirthCityName = textBox_OBrithCityName.Text,
                       Address = textBox_OAddress.Text,

                       Tel = textBox_OTel.Text,
                       Mobile = textBox_Omobile.Text,
                       email = textBox_OEMail.Text,
                       DiplomaNo = textBox_DiplomaNo.Text,
                       ActionType = comboBox_ActionType.Text,
                       PriceMonthly = int.Parse((textBox_PriceMonthly.Text == "" ? "0" : textBox_PriceMonthly.Text).Replace(",", "")),
                       EmployDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearED.Text, comboBox_MonthED.Text, comboBox_DayED.Text),//textBox_Date.Text)
                       PorsantPercent = int.Parse(nUpDown_PorsantPercent.Value.ToString())
                   };
                    DCMD.Tbl_Operators.InsertOnSubmit(THC);
                    DCMD.SubmitChanges();
                }
                catch (Exception ex)
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "لطفا با کمی فاصله دوباره تایید کنید!", ex.Message);
                    return false;
                }
            else
                if (NewOrEditOperator == 2)
                    try
                    {
                        Tbl_Operator tbhc = DCMD.Tbl_Operators.First(thfh => thfh.IDNO.Equals(OperatorID));

                        tbhc.CreateDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearCD.Text, comboBox_MonthCD.Text, comboBox_DayCD.Text);//textBox_Date.Text);
                        tbhc.Name = textBox_OName.Text;
                        tbhc.ParentName = textBox_OParentN.Text;
                        tbhc.IDNO = int.Parse(textBox_OIDNO.Text);

                        tbhc.NationalCode = textBox_ONationalCode.Text;
                        tbhc.BrithDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearBD.Text, comboBox_MonthBD.Text, comboBox_DayBD.Text);//textBox_Date.Text);
                        tbhc.BirthCityName = textBox_OBrithCityName.Text;
                        tbhc.Address = textBox_OAddress.Text;

                        tbhc.Tel = textBox_OTel.Text;
                        tbhc.Mobile = textBox_Omobile.Text;
                        tbhc.email = textBox_OEMail.Text;
                        tbhc.DiplomaNo = textBox_DiplomaNo.Text;
                        tbhc.ActionType = comboBox_ActionType.Text;
                        tbhc.PriceMonthly = int.Parse(textBox_PriceMonthly.ToString());
                        tbhc.EmployDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearED.Text, comboBox_MonthED.Text, comboBox_DayED.Text);//textBox_Date.Text
                        tbhc.PorsantPercent = int.Parse(nUpDown_PorsantPercent.Value.ToString());
                        DCMD.SubmitChanges();
                    }

                    catch (Exception ex)
                    {
                        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "لطفا با کمی فاصله دوباره تایید کنید!", ex.Message);
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
        private void textBox_CostPrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox_CostPrice_TextChanged(object sender, EventArgs e)
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

        #endregion
        

       
    }
}
