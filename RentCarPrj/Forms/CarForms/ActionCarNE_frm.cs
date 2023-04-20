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
    public partial class ActionCarNE_frm : Form
    {
        int _carID = 0, _actionCarID = 0, _nowKM = 0;
        bool _newOrEditActionCar = false;

        public ActionCarNE_frm(bool NewOrEditActionCar, int ActionCarID, int CarID, int NowKM)
        {
            InitializeComponent();
            _carID = CarID;
            _actionCarID = ActionCarID;
            _nowKM = NowKM;
            _newOrEditActionCar = NewOrEditActionCar;
        }



        DataClasses_MainDataContext DCMD = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

        #region Load
        private void ActionCarNE_frm_Load(object sender, EventArgs e)
        {
            var SUS = from prd in DCMD.TBL_ActionTypes
                      select new { prd.ActionTypeCode, prd.ActionTypeDsc };
            comboBoxActionType.DisplayMember = "ActionTypeDsc";
            comboBoxActionType.ValueMember = "ActionTypeCode";
            comboBoxActionType.DataSource = SUS;

            
            var SUS1 = (from prd in DCMD.TBL_ActionCars
                       select new { prd.ActionPlace }).Distinct();
            ComboBox_ActionPlace.DisplayMember = "ActionPlace";
            ComboBox_ActionPlace.ValueMember = "ActionPlace";
            ComboBox_ActionPlace.DataSource = SUS1;

            var SUS2 = (from prd in DCMD.TBL_ActionCars
                        select new { prd.ProductUse }).Distinct();
            ComboBox_ProductUse.DisplayMember = "ProductUse";
            ComboBox_ProductUse.ValueMember = "ProductUse";
            ComboBox_ProductUse.DataSource = SUS2;

            SetDefault_ActionCarNE();
        }

        private void SetDefault_ActionCarNE()
        {
            if (!_newOrEditActionCar)
            {
                try
                {
                    TBL_ActionCar tbhc = DCMD.TBL_ActionCars.First(thfr => thfr.CarID.Equals(_carID) && thfr.ActionCode.Equals(_actionCarID));
                    string DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhc.ActionDate));
                    comboBox_Year1.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_Month1.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_day1.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();
                    ComboBox_ActionPlace.Text = tbhc.ActionPlace;
                    ComboBox_ProductUse.Text = tbhc.ProductUse;
                    textBox_NextKM.Text = tbhc.NextKM.Value.ToString();
                    textBox_NowKM.Text = tbhc.NowKM.Value.ToString();
                    textBox_AlarmKM.Text = tbhc.AlarmKM.Value.ToString();
                    textBox_ActionDsc.Text = tbhc.ActionDsc;
                    textBox_TelPlace.Text = tbhc.TelPlace;
                    comboBoxActionType.SelectedValue = tbhc.ActionTypeCode.Value;

                }
                catch(Exception ex)
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "در اطلاعات اولیه اشکال وجود دارد!", ex.ToString());
                }
            }
            else if (_newOrEditActionCar)
            {
                try
                {
                    var MaxID = (from prd in DCMD.TBL_ActionCars
                                 where prd.CarID == _carID
                                 select prd.ActionCode).Max();
                    _actionCarID = MaxID;
                }
                catch
                {
                    _actionCarID = 0;
                }

                //date
                string DateStr2 = Global_Cls.MiladiDateToShamsi(DateTime.Today);
                comboBox_Year1.Text = Convert.ToInt16(DateStr2.Substring(0, 4)).ToString();
                comboBox_Month1.Text = Convert.ToInt16(DateStr2.Substring(5, 2)).ToString();
                comboBox_day1.Text = Convert.ToInt16(DateStr2.Substring(8, 2)).ToString();

                textBox_NowKM.Text = _nowKM.ToString();
            }
        }
        #endregion


        #region Save
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            if (comboBoxActionType.Text == "") { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "نوع سرویس/عملیات را وارد کنید!"); comboBoxActionType.Focus(); return; }
            if (textBox_NowKM.Text == "") { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "کیلومتر فعلی را وارد کنید!"); textBox_NowKM.Focus(); return; }
            if (textBox_NextKM.Text == "") { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "کیلومتر بعدی را وارد نمایید!"); textBox_NextKM.Focus(); return; }

            textBox_NextKM_Leave(this, null);
            panel_ActionDate_Leave(this, null);

            if (OKFunction())
                this.Close();
        }

        private bool OKFunction()
        {
            DataClasses_MainDataContext DCMD1 = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            if (_newOrEditActionCar)

                try
                {
                    TBL_ActionCar THC = new TBL_ActionCar
                    {
                        CarID = _carID,
                        ActionCode = _actionCarID + 1,
                        ActionDate = Global_Cls.ShamsiDateToMiladi(comboBox_Year1.Text, comboBox_Month1.Text, comboBox_day1.Text),
                        ActionPlace = ComboBox_ActionPlace.Text,
                        ProductUse = ComboBox_ProductUse.Text,
                        NextKM = int.Parse(textBox_NextKM.Text),
                        NowKM = int.Parse(textBox_NowKM.Text),
                        ActionDsc = textBox_ActionDsc.Text,
                        TelPlace = textBox_TelPlace.Text,
                        ActionTypeCode = int.Parse(comboBoxActionType.SelectedValue.ToString()),
                        AlarmKM = int.Parse(textBox_AlarmKM.Text)
                    };
                    DCMD1.TBL_ActionCars.InsertOnSubmit(THC);
                    DCMD1.SubmitChanges();
                }
                catch (Exception ex)
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "ثبت نشد!", ex.Message);
                    return false;
                }
            else
                if (!_newOrEditActionCar)
                    try
                    {
                        TBL_ActionCar tbhc = DCMD1.TBL_ActionCars.First(thfr => thfr.CarID.Equals(_carID) && thfr.ActionCode.Equals(_actionCarID));

                        tbhc.ActionDate = Global_Cls.ShamsiDateToMiladi(comboBox_Year1.Text, comboBox_Month1.Text, comboBox_day1.Text);
                        tbhc.ActionPlace = ComboBox_ActionPlace.Text;
                        tbhc.ProductUse = ComboBox_ProductUse.Text;
                        tbhc.NextKM = int.Parse(textBox_NextKM.Text);
                        tbhc.NowKM = int.Parse(textBox_NowKM.Text);
                        tbhc.AlarmKM = int.Parse(textBox_AlarmKM.Text);
                        tbhc.ActionDsc = textBox_ActionDsc.Text;
                        tbhc.TelPlace = textBox_TelPlace.Text;
                        tbhc.ActionTypeCode = int.Parse(comboBoxActionType.SelectedValue.ToString());
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

        private void textBox_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tx = new TextBox();

            tx = (TextBox)sender;
            if ((tx.Text.Contains(".") && e.KeyChar == '.')
                || (!System.Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Back && e.KeyChar != '.'))
            { e.KeyChar = '\0'; return; }
        }

        private void panel_ActionDate_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_Month1.Text) > 6 && Convert.ToInt16(comboBox_day1.Text) == 31) comboBox_day1.Text = "30";
            if (Convert.ToInt16(comboBox_Month1.Text) == 12 && (Convert.ToInt16(comboBox_day1.Text) == 31 || Convert.ToInt16(comboBox_day1.Text) == 30)) comboBox_day1.Text = "29";
        }

        #endregion

        private void textBox_NextKM_Leave(object sender, EventArgs e)
        {
            if (textBox_AlarmKM.Text == "" || textBox_AlarmKM.Text == "0")
                textBox_AlarmKM.Text = (int.Parse(textBox_NextKM.Text) - Global_Cls.ExpKMService).ToString();
        }

        private void ComboBox_ActionPlace_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                textBox_TelPlace.Text = (from prd in DCMD.TBL_ActionCars
                                         where prd.ActionPlace == ComboBox_ActionPlace.Text
                                         orderby prd.ActionCode descending
                                         select new { prd.TelPlace }).Single().TelPlace;
            }
            catch 
            {
                textBox_TelPlace.Text = "";
            }
        }



    }
}
