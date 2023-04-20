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
    public partial class CustomerNE_frm : Form
    {
        int _customType = 0, _customID = 0;
        bool _newOrEditCustomer = false;

        public CustomerNE_frm(bool NewOrEditCustomer, int CustomType, int CustomID)
        {
            InitializeComponent();
            _customType = CustomType;
            _customID = CustomID;
            _newOrEditCustomer = NewOrEditCustomer;
        }



        DataClasses_MainDataContext DCMD = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

        #region Load
        private void CustomerNE_frm_Load(object sender, EventArgs e)
        {
            var SUS = from prd in DCMD.TBL_PrtCities
                      orderby prd.CityName_Fa
                      select prd;
            ComboBoxBrithCityName.DataSource = SUS;


            SetDefault_CustomerNE();
            //chkTel.Visible = _newOrEditCustomer;
        }

        private void SetDefault_CustomerNE()
        {

            if (!_newOrEditCustomer)
            {
                try
                {
                    TBL_Customer tbhc = DCMD.TBL_Customers.First(thfr => thfr.CustomerID.Equals(_customID));
                    string DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhc.CreateDate));
                    comboBox_Year1.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_Month1.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_day1.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();
                    textBox_CName.Text = tbhc.CustomerName;
                    textBox_CParentN.Text = tbhc.ParentName;
                    textBox_CIDNO.Text = tbhc.IDNO.ToString();
                    textBox_CNationalCode.Text = tbhc.NationalCode;
                    ComboBoxBrithCityName.Text = tbhc.BrithCityName;
                    string DateStr1 = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhc.BrithDate));
                    comboBox_Year2.Text = Convert.ToInt16(DateStr1.Substring(0, 4)).ToString();
                    comboBox_Month2.Text = Convert.ToInt16(DateStr1.Substring(5, 2)).ToString();
                    comboBox_Day2.Text = Convert.ToInt16(DateStr1.Substring(8, 2)).ToString();
                    textBox_Address.Text = tbhc.Address;
                    textBox_Tel.Text = tbhc.Tel;
                    textBox_mobile.Text = tbhc.Mobile;
                    textBox_EMail.Text = tbhc.Email;
                    comboBoxCustomType.SelectedIndex = tbhc.CustomerType.Value - 1;
                    comboBoxCustomType.Enabled = true;
                    
                    textBox_AddressBusiness.Text = tbhc.AddressBusiness;
                    textBox_TelBusiness.Text = tbhc.TelBusiness;

                    chkActive.Checked = tbhc.Active.Value;
                }
                catch(Exception ex)
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "در اطلاعات اولیه اشکال وجود دارد!", ex.ToString());
                }
            }
            else if (_newOrEditCustomer)
            {
                //date
                string DateStr2 = Global_Cls.MiladiDateToShamsi(DateTime.Today);
                comboBox_Year1.Text = Convert.ToInt16(DateStr2.Substring(0, 4)).ToString();
                comboBox_Month1.Text = Convert.ToInt16(DateStr2.Substring(5, 2)).ToString();
                comboBox_day1.Text = Convert.ToInt16(DateStr2.Substring(8, 2)).ToString();

                comboBox_Year2.Text = Convert.ToInt16(DateStr2.Substring(0, 4)).ToString();
                comboBox_Month2.Text = Convert.ToInt16(DateStr2.Substring(5, 2)).ToString();
                comboBox_Day2.Text = Convert.ToInt16(DateStr2.Substring(8, 2)).ToString();
                comboBoxCustomType.SelectedIndex = _customType - 1;
                comboBoxCustomType.Enabled = _customType == 4;
                ComboBoxBrithCityName.Text = "تهران";

            }
        }
        #endregion


        #region Save
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            if (textBox_CName.Text == "") { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "نام را وارد کنید!"); textBox_CName.Focus(); return; }
            if (textBox_CNationalCode.Text == "") { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "کد ملی را وارد کنید!"); textBox_CNationalCode.Focus(); return; }
            if (textBox_mobile.Text == "") { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "موبایل را وارد نمایید!"); textBox_mobile.Focus(); return; }


            panel_CDate1_Leave(this, null);
            panel_BrithDate_Leave(this, null);

            if (OKFunction())
                this.Close();
        }

        private bool OKFunction()
        {
            DataClasses_MainDataContext DCMD1 = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            if (_newOrEditCustomer)
                try
                {
                    TBL_Customer THC = new TBL_Customer
                    {
                        CreateDate = Global_Cls.ShamsiDateToMiladi(comboBox_Year1.Text, comboBox_Month1.Text, comboBox_day1.Text),
                        CustomerName = textBox_CName.Text,
                        ParentName = textBox_CParentN.Text,
                        IDNO = textBox_CIDNO.Text,
                        NationalCode = textBox_CNationalCode.Text,
                        BrithDate = Global_Cls.ShamsiDateToMiladi(comboBox_Year2.Text, comboBox_Month2.Text, comboBox_Day2.Text),
                        BrithCityName = ComboBoxBrithCityName.Text,
                        Address = textBox_Address.Text,
                        Tel = textBox_Tel.Text,
                        AddressBusiness = textBox_AddressBusiness.Text,
                        TelBusiness = textBox_TelBusiness.Text,
                        Mobile = textBox_mobile.Text,
                        Email = textBox_EMail.Text,
                        CustomerType = comboBoxCustomType.SelectedIndex + 1,
                        IsParent = false,
                        Active = chkActive.Checked
                    };
                    DCMD1.TBL_Customers.InsertOnSubmit(THC);
                    DCMD1.SubmitChanges();

                    //اضافه به دفتر تلفن
                    if (chkTel.Checked)
                    {
                        string StrName = "";
                        try
                        {
                            StrName = textBox_CName.Text.Substring(0, textBox_CName.Text.IndexOf(" "));
                        }
                        catch { StrName = ""; }
                        string StrFamily = "";
                        try
                        {
                            StrFamily = textBox_CName.Text.Substring(textBox_CName.Text.IndexOf(" ") + 1, textBox_CName.Text.Length - textBox_CName.Text.IndexOf(" ") - 1);
                        }
                        catch { StrFamily = ""; }

                        int a = Global_Cls.InsertPerTelMob(StrName,
                            StrFamily, textBox_Tel.Text, textBox_mobile.Text, textBox_EMail.Text, textBox_Address.Text, "");
                        if (a == 0)
                            Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, false, "مشخصات این فرد در دفتر تلفن ثبت گردید");
                    }

                }
                catch (Exception ex)
                {
                    if (ex.Message.IndexOf("Duplicated Row!") > -1)
                        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اطلاعات متقاضی قبلا وارد شده و تکراری است!", ex.Message);
                    else
                        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "ثبت نشد!", ex.Message);
                    return false;
                }
            else
                if (!_newOrEditCustomer)
                    try
                    {
                        TBL_Customer tbhc = DCMD1.TBL_Customers.First(thfh => thfh.CustomerID.Equals(_customID));

                        tbhc.CreateDate = Global_Cls.ShamsiDateToMiladi(comboBox_Year1.Text, comboBox_Month1.Text, comboBox_day1.Text);
                        tbhc.CustomerName = textBox_CName.Text;
                        tbhc.ParentName = textBox_CParentN.Text;
                        tbhc.IDNO = textBox_CIDNO.Text;
                        tbhc.NationalCode = textBox_CNationalCode.Text;
                        tbhc.BrithDate = Global_Cls.ShamsiDateToMiladi(comboBox_Year2.Text, comboBox_Month2.Text, comboBox_Day2.Text);
                        tbhc.BrithCityName = ComboBoxBrithCityName.Text;
                        tbhc.Address = textBox_Address.Text;
                        tbhc.Tel = textBox_Tel.Text;
                        tbhc.AddressBusiness = textBox_AddressBusiness.Text;
                        tbhc.TelBusiness = textBox_TelBusiness.Text;
                        tbhc.Mobile = textBox_mobile.Text;
                        tbhc.Email = textBox_EMail.Text;
                        tbhc.CustomerType = comboBoxCustomType.SelectedIndex + 1;
                        tbhc.Active = chkActive.Checked;
                        DCMD1.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.IndexOf("Duplicated Row!") > -1)
                            Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اطلاعات متقاضی قبلا وارد شده و تکراری است!", ex.Message);
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
        private void panel_CDate1_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_Month1.Text) > 6 && Convert.ToInt16(comboBox_day1.Text) == 31) comboBox_day1.Text = "30";
            if (Convert.ToInt16(comboBox_Month1.Text) == 12 && (Convert.ToInt16(comboBox_day1.Text) == 31 || Convert.ToInt16(comboBox_day1.Text) == 30)) comboBox_day1.Text = "29";
        }

        private void panel_BrithDate_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_Month2.Text) > 6 && Convert.ToInt16(comboBox_Day2.Text) == 31) comboBox_Day2.Text = "30";
            if (Convert.ToInt16(comboBox_Month2.Text) == 12 && (Convert.ToInt16(comboBox_Day2.Text) == 31 || Convert.ToInt16(comboBox_Day2.Text) == 30)) comboBox_Day2.Text = "29";
        }

        #endregion

    }
}
