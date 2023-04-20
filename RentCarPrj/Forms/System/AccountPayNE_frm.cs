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
    public partial class AccountPayNE_frm : Form
    {
        int _recPayID = 0; 
        bool _newOrEditRecPay = false;

        public AccountPayNE_frm(bool NewOrEditRecPay, int AccountID)
        {
            InitializeComponent();
            _recPayID = AccountID;
            _newOrEditRecPay = NewOrEditRecPay;
        }



        DataClasses_MainDataContext DCMD = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

        #region Load
        private void AccountPayNE_frm_Load(object sender, EventArgs e)
        {
            SetDefault_AccountPayNE();
        }

        private void SetDefault_AccountPayNE()
        {
            if (!_newOrEditRecPay)
            {
                try
                {
                    this.Text = "ویرایش";
                    TBL_AccountNumber tbhc = DCMD.TBL_AccountNumbers.First(thfr => thfr.AccountID.Equals(_recPayID));
                    textBox_AccountNumber.Text = tbhc.AccountNumber;
                    textBox_AccountName.Text = tbhc.AccountName;
                    textBox_AccountCardNo.Text = tbhc.AccountCardNo;
                    textBox_IBANNo.Text = tbhc.IBANNo;
                    comboBox_BankName.Text = tbhc.BankName;
                }
                catch(Exception ex)
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "در اطلاعات اولیه اشکال وجود دارد!", ex.ToString());
                }
            }
            else if (_newOrEditRecPay)
            {
                textBox_AccountNumber.Focus();
                this.Text = "ثبت حساب جدید";
            }
        }
        #endregion


        #region Save
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            if ((textBox_AccountNumber.Text == "0" || textBox_AccountNumber.Text == "") &&
                (textBox_AccountCardNo.Text == "0" || textBox_AccountCardNo.Text == "")) 
            { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "شماره حساب یا شماره کارت را وارد کنید!"); textBox_AccountNumber.Focus(); return; }
            
            

            if (OKFunction())
                this.Close();
        }

        private bool OKFunction()
        {
            DataClasses_MainDataContext DCMD1 = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            if (_newOrEditRecPay)

                try
                {
                    TBL_AccountNumber THC = new TBL_AccountNumber
                    {
                        AccountName = textBox_AccountName.Text,
                        AccountCardNo = textBox_AccountCardNo.Text,
                        AccountNumber = textBox_AccountNumber.Text,
                        BankName = comboBox_BankName.Text,
                        IBANNo = textBox_IBANNo.Text
                    };
                    DCMD1.TBL_AccountNumbers.InsertOnSubmit(THC);
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
                        TBL_AccountNumber tbhc = DCMD1.TBL_AccountNumbers.First(thfr => thfr.AccountID.Equals(_recPayID));
                        tbhc.AccountName = textBox_AccountName.Text;
                        tbhc.AccountNumber = textBox_AccountNumber.Text;
                        tbhc.AccountCardNo = textBox_AccountCardNo.Text;
                        tbhc.BankName = comboBox_BankName.Text;
                        tbhc.IBANNo = textBox_IBANNo.Text;
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

      
       

    }
}
