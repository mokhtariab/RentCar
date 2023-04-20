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
    public partial class CarRecPayNE_frm : Form
    {
        int _recPayID = 0, _customerCode, _recPayType, _carID, _subCarCode, _transferType; 
        byte _typeCode;
        bool _newOrEditRecPay = false;

        public CarRecPayNE_frm(bool NewOrEditRecPay, int RecPayID, int RecPayType, int CustomerCode, int CarID, byte TypeCode, int SubCarCode, int TransferType)
        {
            InitializeComponent();
            _recPayID = RecPayID;
            _newOrEditRecPay = NewOrEditRecPay;
            _recPayType = RecPayType;
            _customerCode = CustomerCode;
            _carID = CarID;
            _typeCode = TypeCode;
            _subCarCode = SubCarCode;

            _transferType = TransferType;
        }



        DataClasses_MainDataContext DCMD = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

        #region Load
        private void CarRecPayNE_frm_Load(object sender, EventArgs e)
        {
            var SUS = from prd in DCMD.TBL_AccountNumbers
                      select new { prd.AccountID, AccountStr = prd.BankName + " به نام " + prd.AccountName };
            comboBox_Account.DisplayMember = "AccountStr";
            comboBox_Account.ValueMember = "AccountID";
            comboBox_Account.DataSource = SUS;
            comboBox_Account.SelectedIndex = -1;

            SetDefault_CarRecPayNE();
            if (_typeCode == 0) labelDR.Text = "پرداختی به:";
        }

        private void SetDefault_CarRecPayNE()
        {
            if (!_newOrEditRecPay)
            {
                try
                {
                    TBL_CarRecPay tbhc = DCMD.TBL_CarRecPays.First(thfr => thfr.RecPayID.Equals(_recPayID));
                    string DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhc.RecPayDate));
                    comboBox_YearRP.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_MonthRP.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_DayRP.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                    DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhc.ChqDate));
                    comboBox_YearDC.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_MonthDC.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_DayDC.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                    textBoxChqFor.Text = tbhc.ChqFor;
                    textBoxChqNO.Text = tbhc.ChqNO;
                    textBoxChqPerson.Text = tbhc.ChqPerson;
                    textBoxComment.Text = tbhc.Comment;
                    textBoxRecPayPrice.Text = tbhc.RecPayPrice.Value.ToString();

                    labelRPCustomerName.Text = (DCMD.TBL_Customers.First(Cr => Cr.CustomerID.Equals(tbhc.RPCustomerCode)).CustomerName);
                    comboBoxTransferType.SelectedIndex = tbhc.TransferType.Value;
                    comboBoxChqBank.Text = tbhc.ChqBank;
                    try
                    {
                        comboBox_Account.SelectedValue = tbhc.AccountID;
                    }
                    catch { }
                }
                catch(Exception ex)
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "در اطلاعات اولیه اشکال وجود دارد!", ex.ToString());
                }
            }
            else if (_newOrEditRecPay)
            {
                //date
                string DateStr = Global_Cls.MiladiDateToShamsi(DateTime.Today);
                comboBox_YearRP.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                comboBox_MonthRP.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                comboBox_DayRP.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                comboBox_YearDC.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                comboBox_MonthDC.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                comboBox_DayDC.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                labelRPCustomerName.Text = (DCMD.TBL_Customers.First(Cr => Cr.CustomerID.Equals(_customerCode)).CustomerName);

                comboBoxTransferType.SelectedIndex = _transferType;
            }
        }
        #endregion


        #region Save
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            if (comboBoxTransferType.Text == "") { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "نوع تراکنش را وارد کنید!"); comboBoxTransferType.Focus(); return; }
            if (textBoxRecPayPrice.Text == "" || textBoxRecPayPrice.Text == "0") { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "مبلغ را وارد کنید!"); textBoxRecPayPrice.Focus(); return; }
            if (comboBoxTransferType.SelectedIndex == 1)
            {
                if (textBoxChqNO.Text == "") { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "شماره چک را وارد کنید!"); textBoxChqNO.Focus(); return; }
                if (comboBoxChqBank.Text == "") { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "نام بانک را وارد کنید!"); comboBoxChqBank.Focus(); return; }
            }

            panel_RecPayDate_Leave(this, null);
            panelChqDate_Leave(this, null);

            if (OKFunction())
                this.Close();
        }

        private bool OKFunction()
        {
            DataClasses_MainDataContext DCMD1 = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            if (_newOrEditRecPay)

                try
                {
                    TBL_CarRecPay THC = new TBL_CarRecPay
                    {
                        ChqBank = comboBoxChqBank.Text,
                        ChqDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearDC.Text, comboBox_MonthDC.Text, comboBox_DayDC.Text),
                        ChqFor = textBoxChqFor.Text,
                        ChqNO = textBoxChqNO.Text,
                        ChqPerson = textBoxChqPerson.Text,
                        Comment = textBoxComment.Text,
                        RecPayDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearRP.Text, comboBox_MonthRP.Text, comboBox_DayRP.Text),
                        RecPayPrice = double.Parse(textBoxRecPayPrice.Text.Replace(",", "")),
                        RecPayType = _recPayType,
                        RPCustomerCode = _customerCode,
                        TransferType = comboBoxTransferType.SelectedIndex,
                        AccountID = int.Parse((comboBox_Account.SelectedValue ?? 0).ToString())
                    };
                    DCMD1.TBL_CarRecPays.InsertOnSubmit(THC);
                    DCMD1.SubmitChanges();

                    int _maxRecPayID;
                    try
                    {
                        var MaxID = (from prd in DCMD1.TBL_CarRecPays
                                     select prd.RecPayID).Max();
                        _maxRecPayID = MaxID;
                    }
                    catch
                    {
                        _maxRecPayID = 1;
                    }

                    TBL_CarSubRP THR = new TBL_CarSubRP
                    {
                        CarID = _carID,
                        RecPayID = _maxRecPayID,
                        SubCarCode = _subCarCode,
                        TypeCode = _typeCode,
                        Active = true,
                    };
                    DCMD1.TBL_CarSubRPs.InsertOnSubmit(THR);
                    DCMD1.SubmitChanges();

                }
                catch (Exception ex)
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "ثبت نشد!", ex.Message);
                    return false;
                }
            else
                if (!_newOrEditRecPay)
                    try
                    {
                        TBL_CarRecPay tbhc = DCMD1.TBL_CarRecPays.First(thfr => thfr.RecPayID.Equals(_recPayID));

                        tbhc.ChqBank = comboBoxChqBank.Text;
                        tbhc.ChqDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearDC.Text, comboBox_MonthDC.Text, comboBox_DayDC.Text);
                        tbhc.ChqFor = textBoxChqFor.Text;
                        tbhc.ChqNO = textBoxChqNO.Text;
                        tbhc.ChqPerson = textBoxChqPerson.Text;
                        tbhc.Comment = textBoxComment.Text;
                        tbhc.RecPayDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearRP.Text, comboBox_MonthRP.Text, comboBox_DayRP.Text);
                        tbhc.RecPayPrice = double.Parse(textBoxRecPayPrice.Text.Replace(",", ""));
                        tbhc.RecPayType = _recPayType;
                        tbhc.RPCustomerCode = _customerCode;
                        tbhc.TransferType = comboBoxTransferType.SelectedIndex;
                        tbhc.AccountID = int.Parse((comboBox_Account.SelectedValue ?? 0).ToString());
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
            if (tx == textBoxRecPayPrice)
                labelMablagh.Text = Global_Cls.ConvertRaghamToHorof(Int64.Parse(textBoxRecPayPrice.Text.Replace(",", "")));
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

        private void panel_RecPayDate_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_MonthRP.Text) > 6 && Convert.ToInt16(comboBox_DayRP.Text) == 31) comboBox_DayRP.Text = "30";
            if (Convert.ToInt16(comboBox_MonthRP.Text) == 12 && (Convert.ToInt16(comboBox_DayRP.Text) == 31 || Convert.ToInt16(comboBox_DayRP.Text) == 30)) comboBox_DayRP.Text = "29";
        }
        
        private void panelChqDate_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_MonthDC.Text) > 6 && Convert.ToInt16(comboBox_DayDC.Text) == 31) comboBox_DayDC.Text = "30";
            if (Convert.ToInt16(comboBox_MonthDC.Text) == 12 && (Convert.ToInt16(comboBox_DayDC.Text) == 31 || Convert.ToInt16(comboBox_DayDC.Text) == 30)) comboBox_DayDC.Text = "29";
        }
        #endregion

        private void comboBoxTransferType_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupPanel_Check.Enabled = comboBoxTransferType.SelectedIndex == 1;
            comboBox_Account.Enabled = comboBoxTransferType.SelectedIndex == 0;
        }


    }
}
