using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using System.Collections.ObjectModel;
using System.Diagnostics;
using RentCarPrj.Properties;
using System.Data.SqlClient;
using RentCarPrj.DataLinq;

namespace RentCarPrj
{
    public partial class Certicate_frm : Form
    {

        public int _certicateCode;
        int _stepCode, _carID, _dutyType;
        bool CloseOK = false, _newOrEditCerticate;

        //StepCode = 0: سرویس
        // 1: تمدید سرویس
        // 2: عودت

        //DutyType = 0: شخص حقیقی
        //1: اشخاص حقوقی
        //2: هتل ها
        //3: فرودگاه ها
        //4: اشخاص خارجی
        //5: همکار
        //6: سایر

        public Certicate_frm(bool NewOrEditCerticate, int CerticateCode, int DutyType, int StepCode, int CarID)
        {
            InitializeComponent();
            _certicateCode = CerticateCode;
            _newOrEditCerticate = NewOrEditCerticate;
            _stepCode = StepCode;
            _carID = CarID;
            _dutyType = DutyType;
        }

        DataClasses_MainDataContext DCMD = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);



        #region Load Data
        
        private void Certicate_frm_Load(object sender, EventArgs e)
        {
            SetData_Certicate();
        }

        string DateStr = "";
        private void SetData_Certicate()
        {

            tabItem_DutyToPerson.Visible = _dutyType == 0 || _dutyType == 6;
            tabControlPanel_DutyToPerson.Visible = _dutyType == 0 || _dutyType == 6;

            tabItem_DutyCompany.Visible = _dutyType == 1;
            tabControlPanel_DutyCompany.Visible = _dutyType == 1;

            tabItem_DutyHotels.Visible = _dutyType == 2;
            tabControlPanel_DutyHotels.Visible = _dutyType == 2;

            tabItem_DutyAirport.Visible = _dutyType == 3;
            tabControlPanel_DutyFPerson.Visible = _dutyType == 3;

            tabItem_DutyFPerson.Visible = _dutyType == 4;
            tabControlPanel_DutyFPerson.Visible = _dutyType == 4;

            tabItem_DutyTooJob.Visible = _dutyType == 5;
            tabControlPanel_DutyTooJob.Visible = _dutyType == 5;

            this.tabControl_Certicate.FixedTabSize = new System.Drawing.Size(400, 35);

            var hh = from prd in DCMD.TBL_PrtCountries
                     select new { prd.CountryName_Fa };
            ComboBox_RentPersonCountryPrFg.DataSource = hh;


            if (!_newOrEditCerticate) //|| (_newOrEditCerticate && (_stepCode == 1 || _stepCode == 2)))
            {
                TBL_Certificate tbhf = DCMD.TBL_Certificates.First(thfh => thfh.CertificateCode.Equals(_certicateCode));

                tbhf.CertificateType = _dutyType;

                if (_dutyType == 0 || _dutyType == 6)
                {
                    checkBox_ChequePrIR.Checked = tbhf.Cheque.Value;
                    nUpDown_ChqFewPrIR.Value = tbhf.ChqFew.Value;
                    textBox_ChqPricesPrIR.Text = Global_Cls.DigitSeparator(tbhf.ChqPrices.Value.ToString());
                    textBox_ChqBanksPrIR.Text = tbhf.ChqBanks;

                    checkBox_SoftePrIR.Checked = tbhf.Softe.Value;
                    nUpDown_SofteFewPrIR.Value = tbhf.SofteFew.Value;
                    textBox_SoftePricePrIR.Text = Global_Cls.DigitSeparator(tbhf.SoftePrice.Value.ToString());
                    textBox_SofteNoPrIR.Text = tbhf.SofteNumbers;

                    checkBox_PayPricebitPrIR.Checked = tbhf.PayPricebit.Value;
                    textBox_PayPricePrIR.Text = Global_Cls.DigitSeparator(tbhf.PayPrice.Value.ToString());


                    Radio_HouseDocPrIR.Checked = tbhf.HouseDoc.Value;
                    comboBox_HouseDocLocationPrIR.Text = tbhf.HouseDocLocation;
                    textBox_HouseDocPlakNoPrIR.Text = tbhf.HouseDocPlakNo;
                    textBox_HouseDocParentPrIR.Text = tbhf.HouseDocParent;


                    Radio_DocEarthPrIR.Checked = tbhf.DocEarth.Value;
                    comboBox_DocEarthLocationPrIR.Text = tbhf.DocEarthLocation;
                    textBox_DocEarthPelakNOPrIR.Text = tbhf.DocEarthPelakNO;
                    textBox_DocEarthParentPrIR.Text = tbhf.DocEarthParent;

                    Radio_LicenceBusinessPrIR.Checked = tbhf.LicenceBusiness.Value;
                    textBox_LicenceNOPrIR.Text = tbhf.LicenceNO;


                    Radio_PayslipPrIR.Checked = tbhf.Payslip.Value;
                    textBox_PersNOPrIR.Text = tbhf.PersNO;
                    textBox_OrganPrIR.Text = tbhf.Organ;
                    textBox_PayslipParentPrIR.Text = tbhf.PayslipParent;

                    textBox_DscPrIR.Text = tbhf.Description;
                }


                else if (_dutyType == 1)
                {
                    checkBox_StatuteCo.Checked = tbhf.StatuteCo.Value;
                    textBox_NameCo.Text = tbhf.NameCo;
                    textBox_StatuteNOCo.Text = tbhf.StatuteNOCo;

                    checkBox_DefineCo.Checked = tbhf.Define.Value;
                    textBox_DefineNoCo.Text = tbhf.DefineNO;
                    textBox_DefinerNameCo.Text = tbhf.DefinerName;
                    textBox_DefinerTelCo.Text = tbhf.DefinerTel;
                    textBox_DefinerAddressCo.Text = tbhf.DefinerAddress;
                    DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhf.DefineDate));
                    comboBox_YearDDC.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_MonthDDC.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_DayDDC.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                    checkBox_ChequeCo.Checked = tbhf.Cheque.Value;
                    nUpDown_ChqFewCo.Value = tbhf.ChqFew.Value;
                    textBox_ChqPricesCo.Text = Global_Cls.DigitSeparator(tbhf.ChqPrices.Value.ToString());
                    textBox_ChqBanksCo.Text = tbhf.ChqBanks;

                    checkBox_PayPricebitCo.Checked = tbhf.PayPricebit.Value;
                    textBox_PayPriceCo.Text = Global_Cls.DigitSeparator(tbhf.PayPrice.Value.ToString());

                    textBox_DscCo.Text = tbhf.Description;
                }


                else if (_dutyType == 2)
                {
                    textBox_HotelName.Text = tbhf.HotelName;

                    checkBox_DefineHt.Checked = tbhf.Define.Value;
                    textBox_DefineNoHt.Text = tbhf.DefineNO;
                    textBox_DefinerNameHt.Text = tbhf.DefinerName;
                    textBox_DefinerTelHt.Text = tbhf.DefinerTel;
                    textBox_DefinerAddressHt.Text = tbhf.DefinerAddress;
                    DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhf.DefineDate));
                    comboBox_YearDDHt.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_MonthDDHt.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_DayDDHt.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                    textBox_DscHt.Text = tbhf.Description;

                }


                else if (_dutyType == 3)
                {
                    textBox_AirportName.Text = tbhf.AirportName;
                    textBox_AirportCoName.Text = tbhf.AirportCoName;

                    checkBox_DefineAirPort.Checked = tbhf.Define.Value;
                    textBox_DefineNOAirport.Text = tbhf.DefineNO;
                    textBox_DefinerNameAirport.Text = tbhf.DefinerName;
                    textBox_DefinerTelAirport.Text = tbhf.DefinerTel;
                    textBox_DefinerAddressAirport.Text = tbhf.DefinerAddress;
                    DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhf.DefineDate));
                    comboBox_YearADAirPrt.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_MonthADAirPrt.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_DayADAirPrt.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                    textBox_DscAirport.Text = tbhf.Description;

                }

                else if (_dutyType == 4)
                {
                    checkBox_DiplomaCopyPrFg.Checked=tbhf.DiplomaCopy.Value;
                    textBox_DiplomaNOPrFg.Text=tbhf.DiplomaNO;
                    DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhf.DiplomaDate));
                    comboBox_YearDDPrFg.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_MonthDDPrFg.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_DayDDPrFg.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();


                    checkBox_VisaPrFg.Checked=tbhf.Visa.Value;
                    textBox_VisaNOPrFg.Text=tbhf.VisaNO;
                    DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhf.VisaDate));
                    comboBox_YearVDPrFg.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_MonthVDPrFg.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_DayVDPrFg.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();


                    checkBox_PassportPrFg.Checked = tbhf.Passport.Value;
                    textBox_PassportNOPrFg.Text=tbhf.PassportNO;
                    DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhf.PassportExpDate));
                    comboBox_YearPEDPrFg.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_MonthPEDPrFg.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_DayPEDPrFg.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();


                    checkBox_TicketUsePrFg.Checked=tbhf.TicketUse.Value;
                    ComboBox_RentPersonCountryPrFg.Text = tbhf.RentPersonCountry;
                    DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhf.ComeBackDate));
                    comboBox_YearCBDPrFg.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_MonthCBDPrFg.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_DayCBDPrFg.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();


                    checkBox_PayPricebitPrFg.Checked=tbhf.PayPricebit.Value;
                    textBox_PayPricePrFg.Text = Global_Cls.DigitSeparator(tbhf.PayPrice.Value.ToString());

                    textBox_DscPrFg.Text=tbhf.Description;
                }


                else if (_dutyType == 5)
                {
                    Radio_ChequeTJob.Checked = tbhf.Cheque.Value;
                    nUpDown_ChqFewTJob.Value = tbhf.ChqFew.Value;
                    textBox_ChqPricesTJob.Text = Global_Cls.DigitSeparator(tbhf.ChqPrices.Value.ToString());
                    textBox_ChqBanksTJob.Text = tbhf.ChqBanks;


                    Radio_PayPricebitTJob.Checked = tbhf.PayPricebit.Value;
                    textBox_PayPriceTJob.Text = Global_Cls.DigitSeparator(tbhf.PayPrice.Value.ToString());

                    Radio_AmanatNameTJob.Checked = tbhf.TrustLetter.Value;

                    textBox_DscTJob.Text = tbhf.Description;

                }

            }
            else if (_newOrEditCerticate)
            {
                DateStr = Global_Cls.MiladiDateToShamsi(DateTime.Today);
                if (_dutyType == 1)
                {
                    comboBox_YearDDC.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_MonthDDC.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_DayDDC.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();
                }
                else if (_dutyType == 2)
                {
                    comboBox_YearDDHt.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_MonthDDHt.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_DayDDHt.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();
                }
                else if (_dutyType == 3)
                {
                    comboBox_YearADAirPrt.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_MonthADAirPrt.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_DayADAirPrt.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();
                }
                else if (_dutyType == 4)
                {
                    comboBox_YearDDPrFg.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_MonthDDPrFg.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_DayDDPrFg.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                    comboBox_YearVDPrFg.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_MonthVDPrFg.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_DayVDPrFg.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                    comboBox_YearPEDPrFg.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_MonthPEDPrFg.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_DayPEDPrFg.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                    comboBox_YearCBDPrFg.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_MonthCBDPrFg.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_DayCBDPrFg.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();
                }
            }

            if (_newOrEditCerticate)
            {
                try
                {
                    var MaxID = (from prd in DCMD.TBL_Certificates
                                 select prd.CertificateCode).Max();

                    var DelMaxID = 0;
                    try
                    {
                        DelMaxID = (from prd in DCMD.TBL_DelCertificates
                                    select prd.CertificateCode).Max();
                    }
                    catch { }

                    _certicateCode = (MaxID >= DelMaxID ? MaxID : DelMaxID) + 1;
                }
                catch
                {
                    _certicateCode = 1;
                }
            }
        }


       #endregion



        #region OK Data
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            if (OkFunction())
            {
                CloseOK = true;
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool CheckValidation()
        {
            if (_dutyType == 1)
                panel_DefineDateCo_Leave(this, null);
            else if (_dutyType == 2)
                panel_DateAD_Leave(this, null);
            else if (_dutyType == 3)
                panel_DefineDateAirport_Leave(this, null);
            else if (_dutyType == 4)
            {
                panel_DiplomaDatePrFg_Leave(this, null);
                panel_PassportExpDatePrFg_Leave(this, null);
                panel_VisaDatePrFg_Leave(this, null);
                panel_ComeBackDatePrFg_Leave(this, null);
            }


            //DutyType = 0: شخص حقیقی
            //1: اشخاص حقوقی
            //2: هتل ها
            //3: فرودگاه ها
            //4: اشخاص خارجی
            //5: همکار
            //6: سایر
            if (_dutyType == 0 || _dutyType == 6)
            {
                if (!checkBox_ChequePrIR.Checked && !checkBox_PayPricebitPrIR.Checked && !checkBox_SoftePrIR.Checked && textBox_DscPrIR.Text == "")
                { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "چک ها، یا سفته ها، یا مبلغ و یا سایر موارد را مشخص نمایید"); checkBox_ChequePrIR.Focus(); return false; }

                if (checkBox_ChequePrIR.Checked)
                {
                    if (nUpDown_ChqFewPrIR.Value == 0)
                    { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "تعداد چک را وارد نمایید"); nUpDown_ChqFewPrIR.Focus(); return false; }
                    if (textBox_ChqPricesPrIR.Text == "" || textBox_ChqPricesPrIR.Text == "0")
                    { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "مبلغ چک ها را وارد نمایید"); textBox_ChqPricesPrIR.Focus(); return false; }
                    if (textBox_ChqBanksPrIR.Text == "")
                    { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "شماره چک ها و نام بانکها را وارد نمایید"); textBox_ChqPricesPrIR.Focus(); return false; }
                }

                if (checkBox_SoftePrIR.Checked)
                {
                    if (nUpDown_SofteFewPrIR.Value == 0)
                    { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "تعداد سفته ها را وارد نمایید"); nUpDown_SofteFewPrIR.Focus(); return false; }
                    if (textBox_SoftePricePrIR.Text == "" || textBox_SoftePricePrIR.Text == "0")
                    { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "مبلغ سفته ها را وارد نمایید"); textBox_SoftePricePrIR.Focus(); return false; }
                    if (textBox_SofteNoPrIR.Text == "")
                    { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "شماره سفته ها را وارد نمایید"); textBox_SofteNoPrIR.Focus(); return false; }
                }

                if (checkBox_PayPricebitPrIR.Checked && (textBox_PayPricePrIR.Text == "" || textBox_PayPricePrIR.Text == "0"))
                { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "مبلغ را وارد نمایید"); textBox_PayPricePrIR.Focus(); return false; }


                if (tabControlPersian.SelectedTab == tabItemDoc)
                {
                    if (Radio_HouseDocPrIR.Checked)
                    {
                        if (comboBox_HouseDocLocationPrIR.Text == "" && textBox_HouseDocPlakNoPrIR.Text == "" && textBox_HouseDocParentPrIR.Text == "")
                        {
                            if (Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, true, "آیا مایلید بدون تکمیل ضمانت نامه ها تایید نمایید؟ "))
                                return true;
                        }

                        
                        if (comboBox_HouseDocLocationPrIR.Text == "")
                        { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "موقعیت سند ملک مسکونی را وارد نمایید"); comboBox_HouseDocLocationPrIR.Focus(); return false; }
                        if (textBox_HouseDocPlakNoPrIR.Text == "")
                        { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "پلاک ثبتی را وارد نمایید"); textBox_HouseDocPlakNoPrIR.Focus(); return false; }
                        if (textBox_HouseDocParentPrIR.Text == "")
                        { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "نسبت مالک سند با امانت گیرنده را وارد نمایید"); textBox_HouseDocParentPrIR.Focus(); return false; }
                    }

                    if (Radio_DocEarthPrIR.Checked)
                    {
                        if (comboBox_DocEarthLocationPrIR.Text == "" && textBox_DocEarthPelakNOPrIR.Text == "" && textBox_DocEarthParentPrIR.Text == "")
                        {
                            if (Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, true, "آیا مایلید بدون تکمیل ضمانت نامه ها تایید نمایید؟ "))
                                return true;
                        }

                        if (comboBox_DocEarthLocationPrIR.Text == "")
                        { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "موقعیت زمین را وارد نمایید"); comboBox_DocEarthLocationPrIR.Focus(); return false; }
                        if (textBox_DocEarthPelakNOPrIR.Text == "")
                        { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "پلاک ثبتی را وارد نمایید"); textBox_DocEarthPelakNOPrIR.Focus(); return false; }
                        if (textBox_DocEarthParentPrIR.Text == "")
                        { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "نسبت مالک سند با امانت گیرنده را وارد نمایید"); textBox_DocEarthParentPrIR.Focus(); return false; }
                    }
                }
                else
                {
                    if (Radio_LicenceBusinessPrIR.Checked)
                    {
                        if (textBox_LicenceNOPrIR.Text == "" )
                        {
                            if (Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, true, "آیا مایلید بدون تکمیل ضمانت نامه ها تایید نمایید؟ "))
                                return true;
                        }

                        if (textBox_LicenceNOPrIR.Text == "")
                        { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "شماره جواز را وارد نمایید"); textBox_LicenceNOPrIR.Focus(); return false; }
                    }

                    if (Radio_PayslipPrIR.Checked)
                    {
                        if (textBox_PersNOPrIR.Text == "" && textBox_OrganPrIR.Text == "" && textBox_PayslipParentPrIR.Text == "")
                        {
                            if (Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, true, "آیا مایلید بدون تکمیل ضمانت نامه ها تایید نمایید؟ "))
                                return true;
                        }

                        if (textBox_PersNOPrIR.Text == "")
                        { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "شماره پرسنلی کارمند را وارد نمایید"); textBox_PersNOPrIR.Focus(); return false; }
                        if (textBox_OrganPrIR.Text == "")
                        { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "ارگان کارمند را وارد نمایید"); textBox_OrganPrIR.Focus(); return false; }
                        if (textBox_PayslipParentPrIR.Text == "")
                        { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "نسبت با امانت گیرنده را وارد نمایید"); textBox_PayslipParentPrIR.Focus(); return false; }
                    }
                }
            }


            else if (_dutyType == 1)
            {
                if (!checkBox_StatuteCo.Checked && !checkBox_DefineCo.Checked)
                { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "اساسنامه و یا معرفی نامه را مشخص نمایید"); checkBox_StatuteCo.Focus(); return false; }

                if (!checkBox_ChequeCo.Checked && !checkBox_PayPricebitCo.Checked)
                { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "مبلغ و یا چک ها را مشخص نمایید"); checkBox_ChequeCo.Focus(); return false; }


                if (checkBox_StatuteCo.Checked)
                {
                    if (textBox_NameCo.Text == "")
                    { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "نام شرکت/سازمان را وارد نمایید"); textBox_NameCo.Focus(); return false; }
                    if (textBox_StatuteNOCo.Text == "")
                    { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "شماره ثبت شرکت را وارد نمایید"); textBox_StatuteNOCo.Focus(); return false; }
                }

                if (checkBox_DefineCo.Checked)
                {
                    if (textBox_DefineNoCo.Text == "")
                    { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "شماره معرفی نامه را وارد نمایید"); textBox_DefineNoCo.Focus(); return false; }
                    if (textBox_DefinerNameCo.Text == "")
                    { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "نام معرف را وارد نمایید"); textBox_DefinerNameCo.Focus(); return false; }
                }
                if (checkBox_ChequeCo.Checked)
                {
                    if (nUpDown_ChqFewCo.Value == 0)
                    { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "تعداد چک را وارد نمایید"); nUpDown_ChqFewCo.Focus(); return false; }
                    if (textBox_ChqPricesCo.Text == "" || textBox_ChqPricesCo.Text == "0")
                    { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "مبلغ چک ها را وارد نمایید"); textBox_ChqPricesCo.Focus(); return false; }
                    if (textBox_ChqBanksCo.Text == "")
                    { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "شماره چک ها و نام بانکها را وارد نمایید"); textBox_ChqPricesCo.Focus(); return false; }
                }

                if (checkBox_PayPricebitCo.Checked && (textBox_PayPriceCo.Text == "" || textBox_PayPriceCo.Text == "0"))
                { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "مبلغ را وارد نمایید"); textBox_PayPriceCo.Focus(); return false; }
            }


            else if (_dutyType == 2)
            {
                if (textBox_HotelName.Text == "")
                { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "نام هتل را وارد نمایید"); textBox_HotelName.Focus(); return false; }

                if (checkBox_DefineHt.Checked)
                {
                    if (textBox_DefineNoHt.Text == "")
                    { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "شماره معرفی نامه را وارد نمایید"); textBox_DefineNoHt.Focus(); return false; }
                    if (textBox_DefinerNameHt.Text == "")
                    { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "نام معرف را وارد نمایید"); textBox_DefinerNameHt.Focus(); return false; }
                }
            }


            else if (_dutyType == 3)
            {
                if (textBox_AirportName.Text == "")
                { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "نام فرودگاه را وارد نمایید"); textBox_AirportName.Focus(); return false; }

                if (textBox_AirportCoName.Text == "")
                { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "نام شرکت پیمانکاری فرودگاه را وارد نمایید"); textBox_AirportCoName.Focus(); return false; }

                if (checkBox_DefineAirPort.Checked)
                {
                    if (textBox_DefineNOAirport.Text == "")
                    { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "شماره معرفی نامه را وارد نمایید"); textBox_DefineNOAirport.Focus(); return false; }
                    if (textBox_DefinerNameAirport.Text == "")
                    { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "نام معرف را وارد نمایید"); textBox_DefinerNameAirport.Focus(); return false; }
                }
            }


            else if (_dutyType == 4)
            {
                if (textBox_DiplomaNOPrFg.Text == "")
                { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "شماره گواهی نامه را وارد نمایید"); textBox_DiplomaNOPrFg.Focus(); return false; }
                if (textBox_VisaNOPrFg.Text == "")
                { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "شماره ویزا را وارد نمایید"); textBox_VisaNOPrFg.Focus(); return false; }
                if (textBox_PassportNOPrFg.Text == "")
                { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "شماره گذرنامه را وارد نمایید"); textBox_PassportNOPrFg.Focus(); return false; }
                if (ComboBox_RentPersonCountryPrFg.Text == "")
                { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "نام کشور مقصد را وارد نمایید"); ComboBox_RentPersonCountryPrFg.Focus(); return false; }
            }


            else if (_dutyType == 5)
            {
                if (Radio_ChequeTJob.Checked)
                {
                    if (nUpDown_ChqFewTJob.Value == 0)
                    { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "تعداد چک را وارد نمایید"); nUpDown_ChqFewTJob.Focus(); return false; }
                    if (textBox_ChqPricesTJob.Text == "" || textBox_ChqPricesTJob.Text == "0")
                    { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "مبلغ چک ها را وارد نمایید"); textBox_ChqPricesTJob.Focus(); return false; }
                    if (textBox_ChqBanksTJob.Text == "")
                    { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "شماره چک ها و نام بانکها را وارد نمایید"); textBox_ChqPricesTJob.Focus(); return false; }
                }
                if (Radio_PayPricebitTJob.Checked && (textBox_PayPriceTJob.Text == "" || textBox_PayPriceTJob.Text == "0"))
                { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "مبلغ را وارد نمایید"); textBox_PayPriceTJob.Focus(); return false; }
            }
            return true;

        }
        
        
        
        private bool OkFunction()
        {
            if (!CheckValidation())
                return false;

            DataClasses_MainDataContext DCD = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            if (_newOrEditCerticate)
                try
                {

                    //DutyType = 0: شخص حقیقی
                    //1: اشخاص حقوقی
                    //2: هتل ها
                    //3: فرودگاه ها
                    //4: اشخاص خارجی
                    //5: همکار
                    //6: سایر

                    TBL_Certificate THF = new TBL_Certificate
                    {
                        CertificateCode = _certicateCode,
                        CarID =_carID,
                        CertificateType = _dutyType,
                        
                    };

                    if (_dutyType == 0 || _dutyType == 6)
                    {
                        THF.Cheque = checkBox_ChequePrIR.Checked;
                        THF.ChqFew = int.Parse(nUpDown_ChqFewPrIR.Value.ToString());
                        THF.ChqPrices = double.Parse((textBox_ChqPricesPrIR.Text == "" ? "0" : textBox_ChqPricesPrIR.Text).Replace(",", ""));
                        THF.ChqBanks = textBox_ChqBanksPrIR.Text;

                        THF.Softe = checkBox_SoftePrIR.Checked;
                        THF.SofteFew = int.Parse(nUpDown_SofteFewPrIR.Value.ToString());
                        THF.SoftePrice = double.Parse((textBox_SoftePricePrIR.Text == "" ? "0" : textBox_SoftePricePrIR.Text).Replace(",", ""));
                        THF.SofteNumbers = textBox_SofteNoPrIR.Text;

                        THF.PayPricebit = checkBox_PayPricebitPrIR.Checked;
                        THF.PayPrice = double.Parse((textBox_PayPricePrIR.Text == "" ? "0" : textBox_PayPricePrIR.Text).Replace(",", ""));


                        THF.HouseDoc = Radio_HouseDocPrIR.Checked;
                        THF.HouseDocLocation = comboBox_HouseDocLocationPrIR.Text;
                        THF.HouseDocPlakNo = textBox_HouseDocPlakNoPrIR.Text;
                        THF.HouseDocParent = textBox_HouseDocParentPrIR.Text;


                        THF.DocEarth = Radio_DocEarthPrIR.Checked;
                        THF.DocEarthLocation = comboBox_DocEarthLocationPrIR.Text;
                        THF.DocEarthPelakNO = textBox_DocEarthPelakNOPrIR.Text;
                        THF.DocEarthParent = textBox_DocEarthParentPrIR.Text;

                        THF.LicenceBusiness = Radio_LicenceBusinessPrIR.Checked;
                        THF.LicenceNO = textBox_LicenceNOPrIR.Text;


                        THF.Payslip = Radio_PayslipPrIR.Checked;
                        THF.PersNO = textBox_PersNOPrIR.Text;
                        THF.Organ = textBox_OrganPrIR.Text;
                        THF.PayslipParent = textBox_PayslipParentPrIR.Text;

                        THF.Description = textBox_DscPrIR.Text;
                    }


                    else if (_dutyType == 1)
                    {
                        THF.StatuteCo = checkBox_StatuteCo.Checked;
                        THF.NameCo = textBox_NameCo.Text;
                        THF.StatuteNOCo = textBox_StatuteNOCo.Text;

                        THF.Define = checkBox_DefineCo.Checked;
                        THF.DefineNO = textBox_DefineNoCo.Text;
                        THF.DefineDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearDDC.Text, comboBox_MonthDDC.Text, comboBox_DayDDC.Text);
                        THF.DefinerName = textBox_DefinerNameCo.Text;
                        THF.DefinerTel = textBox_DefinerTelCo.Text;
                        THF.DefinerAddress = textBox_DefinerAddressCo.Text;


                        THF.Cheque = checkBox_ChequeCo.Checked;
                        THF.ChqFew = int.Parse(nUpDown_ChqFewCo.Value.ToString());
                        THF.ChqPrices = double.Parse((textBox_ChqPricesCo.Text == "" ? "0" : textBox_ChqPricesCo.Text).Replace(",", ""));
                        THF.ChqBanks = textBox_ChqBanksCo.Text;


                        THF.PayPricebit = checkBox_PayPricebitCo.Checked;
                        THF.PayPrice = double.Parse((textBox_PayPriceCo.Text == "" ? "0" : textBox_PayPriceCo.Text).Replace(",", ""));

                        THF.Description = textBox_DscCo.Text;

                    }


                    else if (_dutyType == 2)
                    {
                        THF.HotelName = textBox_HotelName.Text;

                        THF.Define = checkBox_DefineHt.Checked;
                        THF.DefineNO = textBox_DefineNoHt.Text;
                        THF.DefineDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearDDHt.Text, comboBox_MonthDDHt.Text, comboBox_DayDDHt.Text);
                        THF.DefinerName = textBox_DefinerNameHt.Text;
                        THF.DefinerTel = textBox_DefinerTelHt.Text;
                        THF.DefinerAddress = textBox_DefinerAddressHt.Text;

                        THF.Description = textBox_DscHt.Text;

                    }


                    else if (_dutyType == 3)
                    {
                        THF.AirportName = textBox_AirportName.Text;
                        THF.AirportCoName = textBox_AirportCoName.Text;

                        THF.Define = checkBox_DefineAirPort.Checked;
                        THF.DefineNO = textBox_DefineNOAirport.Text;
                        THF.DefineDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearADAirPrt.Text, comboBox_MonthADAirPrt.Text, comboBox_DayADAirPrt.Text);
                        THF.DefinerName = textBox_DefinerNameAirport.Text;
                        THF.DefinerTel = textBox_DefinerTelAirport.Text;
                        THF.DefinerAddress = textBox_DefinerAddressAirport.Text;

                        THF.Description = textBox_DscAirport.Text;

                    }


                    else if (_dutyType == 4)
                    {
                        THF.DiplomaCopy = checkBox_DiplomaCopyPrFg.Checked;
                        THF.DiplomaNO = textBox_DiplomaNOPrFg.Text;
                        THF.DiplomaDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearDDPrFg.Text, comboBox_MonthDDPrFg.Text, comboBox_DayDDPrFg.Text);

                        THF.Visa = checkBox_VisaPrFg.Checked;
                        THF.VisaNO = textBox_VisaNOPrFg.Text;
                        THF.VisaDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearVDPrFg.Text, comboBox_MonthVDPrFg.Text, comboBox_DayVDPrFg.Text);

                        THF.Passport = checkBox_PassportPrFg.Checked;
                        THF.PassportNO = textBox_PassportNOPrFg.Text;
                        THF.PassportExpDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearPEDPrFg.Text, comboBox_MonthPEDPrFg.Text, comboBox_DayPEDPrFg.Text);

                        THF.TicketUse = checkBox_TicketUsePrFg.Checked;
                        THF.RentPersonCountry = ComboBox_RentPersonCountryPrFg.Text;
                        THF.ComeBackDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearCBDPrFg.Text, comboBox_MonthCBDPrFg.Text, comboBox_DayCBDPrFg.Text);

                        THF.PayPricebit = checkBox_PayPricebitPrFg.Checked;
                        THF.PayPrice = double.Parse((textBox_PayPricePrFg.Text == "" ? "0" : textBox_PayPricePrFg.Text).Replace(",", ""));

                        THF.Description = textBox_DscPrFg.Text;
                    }


                    else if (_dutyType == 5)
                    {

                        THF.Cheque = Radio_ChequeTJob.Checked;
                        THF.ChqFew = int.Parse(nUpDown_ChqFewTJob.Value.ToString());
                        THF.ChqPrices = double.Parse((textBox_ChqPricesTJob.Text == "" ? "0" : textBox_ChqPricesTJob.Text).Replace(",", ""));
                        THF.ChqBanks = textBox_ChqBanksTJob.Text;

                        THF.PayPricebit = Radio_PayPricebitTJob.Checked;
                        THF.PayPrice = double.Parse((textBox_PayPriceTJob.Text == "" ? "0" : textBox_PayPriceTJob.Text).Replace(",", ""));

                        THF.TrustLetter = Radio_AmanatNameTJob.Checked;

                        THF.Description = textBox_DscTJob.Text;

                    }

                    DCD.TBL_Certificates.InsertOnSubmit(THF);
                    DCD.SubmitChanges();
                }
                catch (Exception ex)
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "ثبت نشد!", ex.Message);
                    return false;
                }
            else
                if (!_newOrEditCerticate)
                    try
                    {
                        TBL_Certificate tbhf = DCD.TBL_Certificates.First(thfh => thfh.CertificateCode.Equals(_certicateCode));
                        {
                            //DutyType = 0: شخص حقیقی
                            //1: اشخاص حقوقی
                            //2: هتل ها
                            //3: فرودگاه ها
                            //4: اشخاص خارجی
                            //5: همکار
                            //6: سایر

                            tbhf.CarID = _carID;
                            tbhf.CertificateType = _dutyType;

                            if (_dutyType == 0 || _dutyType == 6)
                            {
                                tbhf.Cheque = checkBox_ChequePrIR.Checked;
                                tbhf.ChqFew = int.Parse(nUpDown_ChqFewPrIR.Value.ToString());
                                tbhf.ChqPrices = double.Parse((textBox_ChqPricesPrIR.Text == "" ? "0" : textBox_ChqPricesPrIR.Text).Replace(",", ""));
                                tbhf.ChqBanks = textBox_ChqBanksPrIR.Text;

                                tbhf.Softe = checkBox_SoftePrIR.Checked;
                                tbhf.SofteFew = int.Parse(nUpDown_SofteFewPrIR.Value.ToString());
                                tbhf.SoftePrice = double.Parse((textBox_SoftePricePrIR.Text == "" ? "0" : textBox_SoftePricePrIR.Text).Replace(",", ""));
                                tbhf.SofteNumbers = textBox_SofteNoPrIR.Text;

                                tbhf.PayPricebit = checkBox_PayPricebitPrIR.Checked;
                                tbhf.PayPrice = double.Parse((textBox_PayPricePrIR.Text == "" ? "0" : textBox_PayPricePrIR.Text).Replace(",", ""));


                                tbhf.HouseDoc = Radio_HouseDocPrIR.Checked;
                                tbhf.HouseDocLocation = comboBox_HouseDocLocationPrIR.Text;
                                tbhf.HouseDocPlakNo = textBox_HouseDocPlakNoPrIR.Text;
                                tbhf.HouseDocParent = textBox_HouseDocParentPrIR.Text;


                                tbhf.DocEarth = Radio_DocEarthPrIR.Checked;
                                tbhf.DocEarthLocation = comboBox_DocEarthLocationPrIR.Text;
                                tbhf.DocEarthPelakNO = textBox_DocEarthPelakNOPrIR.Text;
                                tbhf.DocEarthParent = textBox_DocEarthParentPrIR.Text;

                                tbhf.LicenceBusiness = Radio_LicenceBusinessPrIR.Checked;
                                tbhf.LicenceNO = textBox_LicenceNOPrIR.Text;


                                tbhf.Payslip = Radio_PayslipPrIR.Checked;
                                tbhf.PersNO = textBox_PersNOPrIR.Text;
                                tbhf.Organ = textBox_OrganPrIR.Text;
                                tbhf.PayslipParent = textBox_PayslipParentPrIR.Text;

                                tbhf.Description = textBox_DscPrIR.Text;
                            }


                            else if (_dutyType == 1)
                            {
                                tbhf.StatuteCo = checkBox_StatuteCo.Checked;
                                tbhf.NameCo = textBox_NameCo.Text;
                                tbhf.StatuteNOCo = textBox_StatuteNOCo.Text;

                                tbhf.Define = checkBox_DefineCo.Checked;
                                tbhf.DefineNO = textBox_DefineNoCo.Text;
                                tbhf.DefineDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearDDC.Text, comboBox_MonthDDC.Text, comboBox_DayDDC.Text);
                                tbhf.DefinerName = textBox_DefinerNameCo.Text;
                                tbhf.DefinerTel = textBox_DefinerTelCo.Text;
                                tbhf.DefinerAddress = textBox_DefinerAddressCo.Text;

                                tbhf.Cheque = checkBox_ChequeCo.Checked;
                                tbhf.ChqFew = int.Parse(nUpDown_ChqFewCo.Value.ToString());
                                tbhf.ChqPrices = double.Parse((textBox_ChqPricesCo.Text == "" ? "0" : textBox_ChqPricesCo.Text).Replace(",", ""));
                                tbhf.ChqBanks = textBox_ChqBanksCo.Text;

                                tbhf.PayPricebit = checkBox_PayPricebitCo.Checked;
                                tbhf.PayPrice = double.Parse((textBox_PayPriceCo.Text == "" ? "0" : textBox_PayPriceCo.Text).Replace(",", ""));

                                tbhf.Description = textBox_DscCo.Text;
                            }


                            else if (_dutyType == 2)
                            {
                                tbhf.HotelName = textBox_HotelName.Text;

                                tbhf.Define = checkBox_DefineHt.Checked;
                                tbhf.DefineNO = textBox_DefineNoHt.Text;
                                tbhf.DefineDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearDDHt.Text, comboBox_MonthDDHt.Text, comboBox_DayDDHt.Text);
                                tbhf.DefinerName = textBox_DefinerNameHt.Text;
                                tbhf.DefinerTel = textBox_DefinerTelHt.Text;
                                tbhf.DefinerAddress = textBox_DefinerAddressHt.Text;

                                tbhf.Description = textBox_DscHt.Text;
                            }


                            else if (_dutyType == 3)
                            {
                                tbhf.AirportName = textBox_AirportName.Text;
                                tbhf.AirportCoName = textBox_AirportCoName.Text;

                                tbhf.Define = checkBox_DefineAirPort.Checked;
                                tbhf.DefineNO = textBox_DefineNOAirport.Text;
                                tbhf.DefineDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearADAirPrt.Text, comboBox_MonthADAirPrt.Text, comboBox_DayADAirPrt.Text);
                                tbhf.DefinerName = textBox_DefinerNameAirport.Text;
                                tbhf.DefinerTel = textBox_DefinerTelAirport.Text;
                                tbhf.DefinerAddress = textBox_DefinerAddressAirport.Text;

                                tbhf.Description = textBox_DscAirport.Text;

                            }


                            else if (_dutyType == 4)
                            {
                                tbhf.DiplomaCopy = checkBox_DiplomaCopyPrFg.Checked;
                                tbhf.DiplomaNO = textBox_DiplomaNOPrFg.Text;
                                tbhf.DiplomaDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearDDPrFg.Text, comboBox_MonthDDPrFg.Text, comboBox_DayDDPrFg.Text);

                                tbhf.Visa = checkBox_VisaPrFg.Checked;
                                tbhf.VisaNO = textBox_VisaNOPrFg.Text;
                                tbhf.VisaDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearVDPrFg.Text, comboBox_MonthVDPrFg.Text, comboBox_DayVDPrFg.Text);

                                tbhf.Passport = checkBox_PassportPrFg.Checked;
                                tbhf.PassportNO = textBox_PassportNOPrFg.Text;
                                tbhf.PassportExpDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearPEDPrFg.Text, comboBox_MonthPEDPrFg.Text, comboBox_DayPEDPrFg.Text);

                                tbhf.TicketUse = checkBox_TicketUsePrFg.Checked;
                                tbhf.RentPersonCountry = ComboBox_RentPersonCountryPrFg.Text;
                                tbhf.ComeBackDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearCBDPrFg.Text, comboBox_MonthCBDPrFg.Text, comboBox_DayCBDPrFg.Text);

                                tbhf.PayPricebit = checkBox_PayPricebitPrFg.Checked;
                                tbhf.PayPrice = double.Parse((textBox_PayPricePrFg.Text == "" ? "0" : textBox_PayPricePrFg.Text).Replace(",", ""));

                                tbhf.Description = textBox_DscPrFg.Text;
                            }


                            else if (_dutyType == 5)
                            {

                                tbhf.Cheque = Radio_ChequeTJob.Checked;
                                tbhf.ChqFew = int.Parse(nUpDown_ChqFewTJob.Value.ToString());
                                tbhf.ChqPrices = double.Parse((textBox_ChqPricesTJob.Text == "" ? "0" : textBox_ChqPricesTJob.Text).Replace(",", ""));
                                tbhf.ChqBanks = textBox_ChqBanksTJob.Text;

                                tbhf.PayPricebit = Radio_PayPricebitTJob.Checked;
                                tbhf.PayPrice = double.Parse((textBox_PayPriceTJob.Text == "" ? "0" : textBox_PayPriceTJob.Text).Replace(",", ""));

                                tbhf.TrustLetter = Radio_AmanatNameTJob.Checked;

                                tbhf.Description = textBox_DscTJob.Text;

                            }
                        }
                        DCD.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "ثبت نشد!", ex.Message);
                        return false;
                    }

            return true;
        }


        #endregion



        #region UI Control Func
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

        private void textBox_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            tx = (TextBox)sender;
            if ((tx.Text.Contains(".") && e.KeyChar == '.')
                || (!System.Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Back && e.KeyChar != '.'))
            { e.KeyChar = '\0'; return; }
        }

        
        private void panel_DefineDateCo_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_MonthDDC.Text) > 6 && Convert.ToInt16(comboBox_DayDDC.Text) == 31) comboBox_DayDDC.Text = "30";
            if (Convert.ToInt16(comboBox_MonthDDC.Text) == 12 && (Convert.ToInt16(comboBox_DayDDC.Text) == 31 || Convert.ToInt16(comboBox_DayDDC.Text) == 30)) comboBox_DayDDC.Text = "29";
        }

        private void panel_DateAD_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_MonthDDHt.Text) > 6 && Convert.ToInt16(comboBox_DayDDHt.Text) == 31) comboBox_DayDDHt.Text = "30";
            if (Convert.ToInt16(comboBox_MonthDDHt.Text) == 12 && (Convert.ToInt16(comboBox_DayDDHt.Text) == 31 || Convert.ToInt16(comboBox_DayDDHt.Text) == 30)) comboBox_DayDDHt.Text = "29";
        }

        private void panel_DiplomaDatePrFg_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_MonthDDPrFg.Text) > 6 && Convert.ToInt16(comboBox_DayDDPrFg.Text) == 31) comboBox_DayDDPrFg.Text = "30";
            if (Convert.ToInt16(comboBox_MonthDDPrFg.Text) == 12 && (Convert.ToInt16(comboBox_DayDDPrFg.Text) == 31 || Convert.ToInt16(comboBox_DayDDPrFg.Text) == 30)) comboBox_DayDDPrFg.Text = "29";
        }

        private void panel_VisaDatePrFg_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_MonthVDPrFg.Text) > 6 && Convert.ToInt16(comboBox_DayVDPrFg.Text) == 31) comboBox_DayVDPrFg.Text = "30";
            if (Convert.ToInt16(comboBox_MonthVDPrFg.Text) == 12 && (Convert.ToInt16(comboBox_DayVDPrFg.Text) == 31 || Convert.ToInt16(comboBox_DayVDPrFg.Text) == 30)) comboBox_DayVDPrFg.Text = "29";
        }

        private void panel_ComeBackDatePrFg_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_MonthCBDPrFg.Text) > 6 && Convert.ToInt16(comboBox_DayCBDPrFg.Text) == 31) comboBox_DayCBDPrFg.Text = "30";
            if (Convert.ToInt16(comboBox_MonthCBDPrFg.Text) == 12 && (Convert.ToInt16(comboBox_DayCBDPrFg.Text) == 31 || Convert.ToInt16(comboBox_DayCBDPrFg.Text) == 30)) comboBox_DayCBDPrFg.Text = "29";
        }

        private void panel_PassportExpDatePrFg_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_MonthPEDPrFg.Text) > 6 && Convert.ToInt16(comboBox_DayPEDPrFg.Text) == 31) comboBox_DayPEDPrFg.Text = "30";
            if (Convert.ToInt16(comboBox_MonthPEDPrFg.Text) == 12 && (Convert.ToInt16(comboBox_DayPEDPrFg.Text) == 31 || Convert.ToInt16(comboBox_DayPEDPrFg.Text) == 30)) comboBox_DayPEDPrFg.Text = "29";
        }

        private void panel_DefineDateAirport_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_YearADAirPrt.Text) > 6 && Convert.ToInt16(comboBox_DayADAirPrt.Text) == 31) comboBox_DayADAirPrt.Text = "30";
            if (Convert.ToInt16(comboBox_MonthADAirPrt.Text) == 12 && (Convert.ToInt16(comboBox_DayADAirPrt.Text) == 31 || Convert.ToInt16(comboBox_DayADAirPrt.Text) == 30)) comboBox_DayADAirPrt.Text = "29";
        }



        private void Certicate_frm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Tab)
            {
                if (tabControl_Certicate.SelectedTabIndex == tabControl_Certicate.Tabs.Count - 1)
                    tabControl_Certicate.SelectedTabIndex = 0;
                else
                    tabControl_Certicate.SelectNextTab();
            }
        }

        private void Certicate_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Global_Cls.MainForm.CloseAllOK && !CloseOK && !Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, "آیا از این فرم خارج می شوید؟"))
                e.Cancel = true;
        }

        private void buttonItemCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        
        //2:Co
        private void checkBox_StatuteCo_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == checkBox_StatuteCo)
                groupPanelStatuteCo.Enabled = checkBox_StatuteCo.Checked;
            if (sender == checkBox_DefineCo)
                groupPanelDefineCo.Enabled = checkBox_DefineCo.Checked;
            if (sender == checkBox_PayPricebitCo)
                groupPanelPayPricebitCo.Enabled = checkBox_PayPricebitCo.Checked;
            if (sender == checkBox_ChequeCo)
                groupPanelChequeCo.Enabled = checkBox_ChequeCo.Checked;
        }

        private void Radio_ChequeTJob_CheckedChanged(object sender, EventArgs e)
        {
            groupPanelChequeTJob.Enabled = Radio_ChequeTJob.Checked;
            groupPanelPayPricebitTj.Enabled = Radio_PayPricebitTJob.Checked;
        }

        private void checkBox_ChequePrIR_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == checkBox_ChequePrIR)
                groupPanelChequePrIR.Enabled = checkBox_ChequePrIR.Checked;
            if (sender == checkBox_SoftePrIR)
                groupPanelSoftePrIR.Enabled = checkBox_SoftePrIR.Checked;
            if (sender == checkBox_PayPricebitPrIR)
                groupPanelPayPricebitPrIR.Enabled = checkBox_PayPricebitPrIR.Checked;
        }

        private void Radio_HouseDocPrIR_CheckedChanged(object sender, EventArgs e)
        {
            groupPanelHouseDocPrIR.Enabled = Radio_HouseDocPrIR.Checked;
            groupPanelDocEarthPrIR.Enabled = Radio_DocEarthPrIR.Checked;
        }

        private void Radio_LicenceBusinessPrIR_CheckedChanged(object sender, EventArgs e)
        {
            groupPanelLicenceBusinessPrIR.Enabled = Radio_LicenceBusinessPrIR.Checked;
            groupPanelPayslipPrIR.Enabled = Radio_PayslipPrIR.Checked;
        }




    }
}
