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
    public partial class CarEnterNE_frm : Form
    {
        int _carID = 0, _carEnterID = 0;//, _nowKM = 0;
        bool CloseOK = false, _newOrEditCarEnter = false;

        public CarEnterNE_frm(bool NewOrEditCarEnter, int CarEnterID, int CarID, int LordCode, string LordName)
        {
            InitializeComponent();
            _carID = CarID;
            _carEnterID = CarEnterID;
            //_nowKM = NowKM;
            _newOrEditCarEnter = NewOrEditCarEnter;
            textBox_RenterCode.Tag = LordCode;
            textBox_RenterCode.Text = DCMD.TBL_Customers.First(Cr => Cr.IsParent == true).CustomerName;
        }


        DataClasses_MainDataContext DCMD = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

        #region Load
        private void CarEnterNE_frm_Load(object sender, EventArgs e)
        {
            SetDefault_CarEnterNE();
            NewEditCarFace = _newOrEditCarEnter;
            textBoxMod.Text = "0";
        }

        string EditCarEnterNumber = "";
        private void SetDefault_CarEnterNE()
        {
            if (!_newOrEditCarEnter)
            {
                try
                {
                    TBL_CarEnter tbhc = DCMD.TBL_CarEnters.First(thfr => thfr.CarID.Equals(_carID) && thfr.CarEnterID.Equals(_carEnterID));
                    textBoxCarEnterNumber.Text = tbhc.CarEnterNumber;
                    EditCarEnterNumber = textBoxCarEnterNumber.Text;

                    string DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhc.StartEnterDate));
                    comboBox_YearSE.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_MonthSE.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_DaySE.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                    DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhc.EndEnterDate));
                    comboBox_YearEE.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_MonthEE.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_DayEE.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                    nUpDown_StartTime.Value = tbhc.StartTime.HasValue ? tbhc.StartTime.Value : 0;
                    nUpDown_EndTime.Value = tbhc.EndTime.HasValue ? tbhc.EndTime.Value : 0;

                    textBoxCarFaceID.Tag = tbhc.CarFaceID.ToString();
                    textBoxKM.Text = (DCMD.TBL_CarFaces.First(Cr => Cr.CarFaceID.Equals(tbhc.CarFaceID)).KilometerUse).ToString();
                    var pp = (from str in DCMD.SP_SetCarFaceView(tbhc.CarFaceID) select new { str.CarFaceDscStr }).Single();
                    textBoxCarFaceID.Text = pp.CarFaceDscStr;
                    textBoxOil.Text = (DCMD.TBL_CarFaces.First(Cr => Cr.CarFaceID.Equals(tbhc.CarFaceID)).OilUse).ToString();

                    textBoxCertifiedDsc.Text = tbhc.CertifiedDsc;

                    CheckBoxTimeSet.Checked = tbhc.TimeSet.Value;
                    nUpDownTimePeriod.Value = tbhc.TimePeriod.Value;
                    textBoxTimePrice.Text = Global_Cls.DigitSeparator(tbhc.TimePrice.ToString());

                    CheckBoxDailySet.Checked = tbhc.DailySet.Value;
                    nUpDownDailyPeriod.Value = tbhc.DailyPeriod.Value;
                    textBoxDailyPrice.Text = Global_Cls.DigitSeparator(tbhc.DailyPrice.ToString());

                    CheckBoxMounthlySet.Checked = tbhc.MounthlySet.Value;
                    nUpDownMounthlyPeriod.Value = tbhc.MounthlyPeriod.Value;
                    textBoxMonthlyPrice.Text = Global_Cls.DigitSeparator(tbhc.MonthlyPrice.ToString());

                    CheckBoxWeeklySet.Checked = tbhc.WeeklySet.Value;
                    nUpDownWeeklyPeriod.Value = tbhc.WeeklyPeriod.Value;
                    textBoxWeeklyPrice.Text = Global_Cls.DigitSeparator(tbhc.WeeklyPrice.ToString());

                    textBoxTotalPrice.Text = Global_Cls.DigitSeparator(tbhc.TotalPrice.ToString());
                   
                    textBox_RenterCode.Tag = tbhc.RenterCode;
                    textBox_RenterCode.Text = DCMD.TBL_Customers.First(Cr => Cr.IsParent == true).CustomerName;

                    textBoxDescription.Text = tbhc.Description;

                }
                catch (Exception ex)
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "در اطلاعات اولیه اشکال وجود دارد!", ex.ToString());
                }
            }
            else if (_newOrEditCarEnter)
            {
                try
                {
                    var MaxID = (from prd in DCMD.TBL_CarEnters
                                 where prd.CarID == _carID
                                 select prd.CarEnterID).Max();
                   
                    var DelMaxID = 0;
                    try
                    {
                        DelMaxID = (from prd in DCMD.TBL_DelCarEnters
                                    where prd.CarID == _carID
                                    select prd.CarEnterID).Max();
                    }
                    catch { }

                    _carEnterID = (MaxID >= DelMaxID ? MaxID : DelMaxID) + 1;
                }
                catch
                {
                    _carEnterID = 1;
                }


                ////CarEnterNumber
                string MaxNumber = "0";
                try
                {
                    MaxNumber = (from prd in DCMD.TBL_CarEnters
                                 select prd.CarEnterNumber).Max();
                }
                catch { }

                string DelMaxNumber = "0";
                try
                {
                    DelMaxNumber = (from prd in DCMD.TBL_DelCarEnters
                                    select prd.CarEnterNumber).Max();
                }
                catch { }

                try { textBoxCarEnterNumber.Text = MaxNumber.CompareTo(DelMaxNumber) == 1 ? MaxNumber : DelMaxNumber; }
                catch { }
                try
                {
                    textBoxCarEnterNumber.Text = (double.Parse(textBoxCarEnterNumber.Text == "" ? "0" : textBoxCarEnterNumber.Text) + 1).ToString(); 
                }
                catch
                {
                }
                /////CarEnterNumber

                ////date
                string DateStr = Global_Cls.MiladiDateToShamsi(DateTime.Today);
                comboBox_YearEE.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                comboBox_MonthEE.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                comboBox_DayEE.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                comboBox_YearSE.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                comboBox_MonthSE.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                comboBox_DaySE.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

            }
        }
        #endregion


        #region Save
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            if (textBoxCarEnterNumber.Text == "" || textBoxCarEnterNumber.Text == "0")
            { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "کد قرارداد را وارد نمایید"); textBoxCarEnterNumber.Focus(); return; }
            if (textBox_RenterCode.Text == "") { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, " اجاره دهنده را وارد کنید!"); textBox_RenterCode.Focus(); return; }
            if (textBoxTotalPrice.Text == "" || textBoxTotalPrice.Text == "0") { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "جمع کل محاسبه نشده است!"); textBoxTotalPrice.Focus(); return; }
            if (textBoxMod.Text != "" && textBoxMod.Text != "0") { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "مبالغ پرداختی با مبلغ کل متفاوت است!"); textBoxTotalPrice.Focus(); return; }
            if (textBoxKM.Text == "" || textBoxKM.Text == "0") { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "عدد کیلومتر وارد نشده است!"); textBoxKM.Focus(); return; }


            panel_EndEnterDate_Leave(this, null);
            panel_StartEnterDate_Leave(this, null);

            if (OKFunction())
            {
                this.DialogResult = DialogResult.OK;
                CloseOK = true;
                this.Close();
            }
        }

        private bool OKFunction()
        {
            if (_newOrEditCarEnter || (!_newOrEditCarEnter && EditCarEnterNumber != textBoxCarEnterNumber.Text))
            {
                int ExistCarEnterNumber = 0;
                try
                {
                    ExistCarEnterNumber = (from prd in DCMD.TBL_CarEnters
                                      where prd.CarEnterNumber == textBoxCarEnterNumber.Text
                                      select prd.CarEnterNumber).Count();
                }
                catch { }

                if (ExistCarEnterNumber == 0)
                    try
                    {
                        ExistCarEnterNumber = (from prd in DCMD.TBL_DelCarEnters
                                               where prd.CarEnterNumber == textBoxCarEnterNumber.Text
                                               select prd.CarEnterNumber).Count();
                    }
                    catch { }

                if (ExistCarEnterNumber > 0)
                { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "کد قرارداد تکراری است"); textBoxCarEnterNumber.Focus(); return false; }
            }


            DataClasses_MainDataContext DCMD1 = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            if (_newOrEditCarEnter)

                try
                {
                    TBL_CarEnter THC = new TBL_CarEnter
                    {
                        CarID = _carID,
                        CarEnterID = _carEnterID,
                        EnterDate = DateTime.Today,
                        EnterType = 0,
                        CarEnterNumber = textBoxCarEnterNumber.Text,
                        StartEnterDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearSE.Text, comboBox_MonthSE.Text, comboBox_DaySE.Text),
                        EndEnterDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearEE.Text, comboBox_MonthEE.Text, comboBox_DayEE.Text),
                        
                        StartTime = short.Parse(nUpDown_StartTime.Value.ToString()),
                        EndTime = short.Parse(nUpDown_EndTime.Value.ToString()),

                        CarFaceID = int.Parse(textBoxCarFaceID.Tag.ToString()),
                        CertifiedDsc = textBoxCertifiedDsc.Text,

                        TimeSet = CheckBoxTimeSet.Checked,
                        TimePeriod = int.Parse(nUpDownTimePeriod.Value.ToString()),
                        TimePrice = double.Parse(textBoxTimePrice.Text.Replace(",", "") == "" ? "0" : textBoxTimePrice.Text.Replace(",", "")),

                        DailySet = CheckBoxDailySet.Checked,
                        DailyPeriod = int.Parse(nUpDownDailyPeriod.Value.ToString()),
                        DailyPrice = double.Parse(textBoxDailyPrice.Text.Replace(",", "") == "" ? "0" : textBoxDailyPrice.Text.Replace(",", "")),

                        WeeklySet = CheckBoxWeeklySet.Checked,
                        WeeklyPeriod = int.Parse(nUpDownWeeklyPeriod.Value.ToString()),
                        WeeklyPrice = double.Parse(textBoxWeeklyPrice.Text.Replace(",", "") == "" ? "0" : textBoxWeeklyPrice.Text.Replace(",", "")),

                        MounthlySet = CheckBoxMounthlySet.Checked,
                        MounthlyPeriod = int.Parse(nUpDownMounthlyPeriod.Value.ToString()),
                        MonthlyPrice = double.Parse(textBoxMonthlyPrice.Text.Replace(",", "") == "" ? "0" : textBoxMonthlyPrice.Text.Replace(",", "")),

                        TotalPrice = double.Parse(textBoxTotalPrice.Text.Replace(",", "")),
                        RenterCode = int.Parse(textBox_RenterCode.Tag.ToString()),

                        Description = textBoxDescription.Text
                    };
                    DCMD1.TBL_CarEnters.InsertOnSubmit(THC);
                    DCMD1.SubmitChanges();
                }
                catch (Exception ex)
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "ثبت نشد!", ex.Message);
                    return false;
                }
            else
                if (!_newOrEditCarEnter)
                    try
                    {
                        TBL_CarEnter tbhc = DCMD1.TBL_CarEnters.First(thfr => thfr.CarID.Equals(_carID) && thfr.CarEnterID.Equals(_carEnterID));
                        tbhc.CarEnterNumber = textBoxCarEnterNumber.Text;
                        tbhc.StartEnterDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearSE.Text, comboBox_MonthSE.Text, comboBox_DaySE.Text);
                        tbhc.EndEnterDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearEE.Text, comboBox_MonthEE.Text, comboBox_DayEE.Text);
                        
                        tbhc.StartTime = short.Parse(nUpDown_StartTime.Value.ToString());
                        tbhc.EndTime = short.Parse(nUpDown_EndTime.Value.ToString());

                        tbhc.CarFaceID = int.Parse(textBoxCarFaceID.Tag.ToString());
                        tbhc.CertifiedDsc = textBoxCertifiedDsc.Text;
                        tbhc.EnterType = 0;

                        tbhc.TimeSet = CheckBoxTimeSet.Checked;
                        tbhc.TimePeriod = int.Parse(nUpDownTimePeriod.Value.ToString());
                        tbhc.TimePrice = double.Parse(textBoxTimePrice.Text.Replace(",", "") == "" ? "0" : textBoxTimePrice.Text.Replace(",", ""));

                        tbhc.DailySet = CheckBoxDailySet.Checked;
                        tbhc.DailyPeriod = int.Parse(nUpDownDailyPeriod.Value.ToString());
                        tbhc.DailyPrice = double.Parse(textBoxDailyPrice.Text.Replace(",", "") == "" ? "0" : textBoxDailyPrice.Text.Replace(",", ""));

                        tbhc.WeeklySet = CheckBoxWeeklySet.Checked;
                        tbhc.WeeklyPeriod = int.Parse(nUpDownWeeklyPeriod.Value.ToString());
                        tbhc.WeeklyPrice = double.Parse(textBoxWeeklyPrice.Text.Replace(",", "") == "" ? "0" : textBoxWeeklyPrice.Text.Replace(",", ""));

                        tbhc.MounthlySet = CheckBoxMounthlySet.Checked;
                        tbhc.MounthlyPeriod = int.Parse(nUpDownMounthlyPeriod.Value.ToString());
                        tbhc.MonthlyPrice = double.Parse(textBoxMonthlyPrice.Text.Replace(",", "") == "" ? "0" : textBoxMonthlyPrice.Text.Replace(",", ""));

                        tbhc.TotalPrice = double.Parse(textBoxTotalPrice.Text.Replace(",", ""));
                        tbhc.RenterCode = int.Parse(textBox_RenterCode.Tag.ToString());

                        tbhc.Description = textBoxDescription.Text;

                        DCMD1.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
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

        private void button_RenterCode_Click(object sender, EventArgs e)
        {
            SelectPerson_frm sp = new SelectPerson_frm(0);
            sp.ShowDialog();
            textBox_RenterCode.Tag = sp.CodeC;
            textBox_RenterCode.Text = sp.NameC;
        }


        #region Other

        TextBox tx = new TextBox();
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
                tx.Text = str;
                tx.SelectionStart = ts + 1;
            }

            if (sender == textBoxTotalPrice)
                 textBoxMod.Text = Global_Cls.DigitSeparator((double.Parse(textBoxTotalPrice.Text.Replace(",", "") == "" ? "0" : textBoxTotalPrice.Text.Replace(",", "")) - double.Parse((textBoxMod.Tag ?? 0).ToString())).ToString()); 
                
        }

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


        private void panel_StartEnterDate_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_MonthSE.Text) > 6 && Convert.ToInt16(comboBox_DaySE.Text) == 31) comboBox_DaySE.Text = "30";
            if (Convert.ToInt16(comboBox_MonthSE.Text) == 12 && (Convert.ToInt16(comboBox_DaySE.Text) == 31 || Convert.ToInt16(comboBox_DaySE.Text) == 30)) comboBox_DaySE.Text = "29";
        }

        private void panel_EndEnterDate_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_MonthEE.Text) > 6 && Convert.ToInt16(comboBox_DayEE.Text) == 31) comboBox_DayEE.Text = "30";
            if (Convert.ToInt16(comboBox_MonthEE.Text) == 12 && (Convert.ToInt16(comboBox_DayEE.Text) == 31 || Convert.ToInt16(comboBox_DayEE.Text) == 30)) comboBox_DayEE.Text = "29";
        }




        #endregion

        bool NewEditCarFace;
        private void buttonCarFaceID_Click(object sender, EventArgs e)
        {
            CarFace_frm cf = new CarFace_frm(NewEditCarFace, int.Parse((textBoxCarFaceID.Tag ?? 0).ToString()), 1, _carID, "", false);
            if (cf.ShowDialog() == DialogResult.OK)
            {

                textBoxCarFaceID.Tag = cf._carFaceCode.ToString();
                try
                {
                    DataClasses_MainDataContext DCMD1 = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
                    textBoxKM.Text = (DCMD1.TBL_CarFaces.First(Cr => Cr.CarFaceID.Equals(cf._carFaceCode)).KilometerUse).ToString();
                    textBoxOil.Text = (DCMD1.TBL_CarFaces.First(Cr => Cr.CarFaceID.Equals(cf._carFaceCode)).OilUse).ToString();

                    var pp = (from str in DCMD1.SP_SetCarFaceView(cf._carFaceCode) select new { str.CarFaceDscStr }).Single();
                    textBoxCarFaceID.Text = pp.CarFaceDscStr;
                    NewEditCarFace = false;

                }
                catch { }
            }

        }

        private void buttonCarSubRP_Click(object sender, EventArgs e)
        {
            if (textBox_RenterCode.Tag == null || textBox_RenterCode.Tag.ToString() == "0")
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "ابتدا طرف اجاره را مشخص کنید");
                return;
            }

            CarSubRPList_Frm CS = new CarSubRPList_Frm(_carID, _carEnterID, 0, int.Parse(textBox_RenterCode.Tag.ToString()));
            CS.ShowDialog();
            textBoxMod.Text = Global_Cls.DigitSeparator((double.Parse(textBoxTotalPrice.Text.Replace(",", "")) - CS.SumPricePublic).ToString());
        }

        private void CheckBoxTimeSet_Click(object sender, EventArgs e)
        {
            SetPrice();
        }

        private void SetPrice()
        {
            textBoxTotalPrice.Text = "0";
            if (CheckBoxTimeSet.Checked)
                textBoxTotalPrice.Text = Global_Cls.DigitSeparator((decimal.Parse((textBoxTotalPrice.Text == "" ? "0" : textBoxTotalPrice.Text).Replace(",", "")) + decimal.Parse(textBoxTimePrice.Text.Replace(",", "")) * nUpDownTimePeriod.Value).ToString());
            if (CheckBoxDailySet.Checked)
                textBoxTotalPrice.Text = Global_Cls.DigitSeparator((decimal.Parse((textBoxTotalPrice.Text == "" ? "0" : textBoxTotalPrice.Text).Replace(",", "")) + decimal.Parse(textBoxDailyPrice.Text.Replace(",", "")) * nUpDownDailyPeriod.Value).ToString());
            if (CheckBoxWeeklySet.Checked)
                textBoxTotalPrice.Text = Global_Cls.DigitSeparator((decimal.Parse((textBoxTotalPrice.Text == "" ? "0" : textBoxTotalPrice.Text).Replace(",", "")) + decimal.Parse(textBoxWeeklyPrice.Text.Replace(",", "")) * nUpDownWeeklyPeriod.Value).ToString());
            if (CheckBoxMounthlySet.Checked)
                textBoxTotalPrice.Text = Global_Cls.DigitSeparator((decimal.Parse((textBoxTotalPrice.Text == "" ? "0" : textBoxTotalPrice.Text).Replace(",", "")) + decimal.Parse(textBoxMonthlyPrice.Text.Replace(",", "")) * nUpDownMounthlyPeriod.Value).ToString());
        }

        private void nUpDownTimePeriod_ValueChanged(object sender, EventArgs e)
        {
            SetPrice();
        }

        private void CarEnterNE_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Global_Cls.MainForm.CloseAllOK && !CloseOK && !Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, "آیا از این فرم خارج می شوید؟"))
                e.Cancel = true;
            else if (_newOrEditCarEnter && !CloseOK)
                {
                    if (textBoxCarFaceID.Tag != null)
                    {
                        TBL_CarFace tcf = DCMD.TBL_CarFaces.First(vg => vg.CarFaceID.Equals(textBoxCarFaceID.Tag));
                        DCMD.TBL_CarFaces.DeleteOnSubmit(tcf);
                        DCMD.SubmitChanges();
                    }


                    var SUS1 = (from prd in DCMD.TBL_CarSubRPs
                                where prd.CarID == _carID && prd.SubCarCode == _carEnterID && prd.TypeCode == 0
                                select prd).ToArray();

                    for (int i = 0; i < SUS1.Count(); i++)
                    {
                        try
                        {
                            TBL_CarRecPay tcf1 = DCMD.TBL_CarRecPays.First(vg => vg.RecPayID.Equals(SUS1[i].RecPayID));
                            DCMD.TBL_CarRecPays.DeleteOnSubmit(tcf1);
                            DCMD.SubmitChanges();
                        }
                        catch { }

                        try
                        {
                            TBL_CarSubRP tcfr = DCMD.TBL_CarSubRPs.First(vg => vg.SubCarCode.Equals(SUS1[i].SubCarCode) &&
                                vg.CarID.Equals(SUS1[i].CarID) && vg.RecPayID.Equals(SUS1[i].RecPayID));
                            DCMD.TBL_CarSubRPs.DeleteOnSubmit(tcfr);
                            DCMD.SubmitChanges();
                        }
                        catch { }
                    }
                }


        }
    }



}
