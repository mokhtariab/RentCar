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
    public partial class ActionPayNE_Frm : Form
    {
        int _recPayID = 0; 
        bool _newOrEditRecPay = false;

        public ActionPayNE_Frm(bool NewOrEditRecPay, int AccountID)
        {
            InitializeComponent();
            _recPayID = AccountID;
            _newOrEditRecPay = NewOrEditRecPay;
        }



        DataClasses_MainDataContext DCMD = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

        #region Load
        private void ActionPayNE_Frm_Load(object sender, EventArgs e)
        {
            SetDefault_َActionPayNE();
        }

        private void SetDefault_َActionPayNE()
        {
            if (!_newOrEditRecPay)
            {
                try
                {
                    this.Text = "ویرایش";
                    TBL_ActionType tbhc = DCMD.TBL_ActionTypes.First(thfr => thfr.ActionTypeCode.Equals(_recPayID));
                    textBox_ActionTypeDsc.Text = tbhc.ActionTypeDsc;
                }
                catch(Exception ex)
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "در اطلاعات اولیه اشکال وجود دارد!", ex.ToString());
                }
            }
            else if (_newOrEditRecPay)
            {
                textBox_ActionTypeDsc.Focus();
                this.Text = "ثبت عملیات جدید";
            }
        }
        #endregion


        #region Save
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            if (textBox_ActionTypeDsc.Text == "") { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "مشخصات تعمیرات و نگهداری را وارد کنید!"); textBox_ActionTypeDsc.Focus(); return; }
            
            if (OKFunction())
                this.Close();
        }

        private bool OKFunction()
        {
            DataClasses_MainDataContext DCMD1 = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            if (_newOrEditRecPay)

                try
                {
                    TBL_ActionType THC = new TBL_ActionType
                    {
                        ActionTypeDsc = textBox_ActionTypeDsc.Text,
                    };
                    DCMD1.TBL_ActionTypes.InsertOnSubmit(THC);
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
                        TBL_ActionType tbhc = DCMD1.TBL_ActionTypes.First(thfr => thfr.ActionTypeCode.Equals(_recPayID));
                        tbhc.ActionTypeDsc = textBox_ActionTypeDsc.Text;
                        
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
