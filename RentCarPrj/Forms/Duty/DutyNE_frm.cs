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
    public partial class DutyNE_frm: Form
    {
        int _dutyCode, _carID, _dutyType;
        bool CloseOK = false, _newOrEditDuty;
        int _rentType = 0;//سرویس جدید0، تمدید1،عودت2
        int CarFaceDscTag, CertifedCodeTag;
        
        //DutyType = 0: شخص حقیقی
        //1: اشخاص حقوقی
        //2: هتل ها
        //3: فرودگاه ها
        //4: اشخاص خارجی
        //5: همکار
        //6: سایر

        public DutyNE_frm(bool NewOrEditDuty, int DutyCode, int CarID, int DutyType, int RentType)
        {
            InitializeComponent();
            _dutyCode = DutyCode;
            _newOrEditDuty = NewOrEditDuty;
            _dutyType = DutyType;
            _carID = CarID;
            _rentType = RentType;
        }

        DataClasses_MainDataContext DCMD = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);


        #region Load Data

        private void DutyNE_frm_Load(object sender, EventArgs e)
        {
            InterFaceSet();
            SetData_DutyNE();
            NewEditCarFace = _newOrEditDuty;
            NewEditCerticate = _newOrEditDuty;
        }

        private void InterFaceSet()
        {
            //            Start Use Permission
            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains(checkBoxItemRenterPrint.Name)) checkBoxItemRenterPrint.Enabled = false;
                if (UPer.Contains(checkBoxItemDutyPrint.Name)) checkBoxItemDutyPrint.Enabled = false;
                if(UPer.Contains(checkBoxItemSMS.Name)) checkBoxItemSMS.Enabled = false; 
            }
            //            End Use Permission

            //codeing
            if (!Global_Cls.SoftwareCode.Contains("+S"))
                checkBoxItemSMS.Visible = false;
            //codeing
        }


        string EditِDutyNumber = "";
        public void SetData_DutyNE()
        {

            string DateStr = "";

            var SUS = from prd in DCMD.TBL_PrtCities
                      orderby prd.CityName_Fa
                      select prd;
            comboBox_CityLimit.DataSource = SUS;

            if (_rentType == 0)
            {
                tabControlPanelDutyBack.Visible = false;
                tabItemDutyBack.Visible = false;
            }
            else if (_rentType == 1)
            {
                Text = "تمدید سرویس";
                tabItem_MainDuty.Text = "تمدید سرویس";
                tabControlPanelDutyBack.Visible = false;
                tabItemDutyBack.Visible = false;
                tabControlPanel_CarFaceCertif.Visible = false;
                tabItem_CarFaceCertif.Visible = false;

                checkBoxItem_CarFace.Visible = false;
            }
            else if (_rentType == 2)
            {
                Text = "عودت";
                tabControlPanel_MainDuty.Text = "عودت";

                tabControlPanel_MainDuty.Visible = false;
                tabItem_MainDuty.Visible = false;

                checkBoxItemDutyPrint.Visible = false;
                checkBoxItemEjarename.Visible = false;
                checkBoxItemRenterPrint.Visible = false;
                checkBoxItemSMS.Visible = false;

                checkBoxItemDutyPrint.Checked = false;
                checkBoxItemEjarename.Checked = false;
                checkBoxItemRenterPrint.Checked = false;

                button_CertifedCode.Visible = false;
                //textBox_CertifedCode.Visible = false;
                //label5.Visible = false;

                checkBox_khalafi.Visible = true;
            }


            if (!_newOrEditDuty)
            {
                button_CarID.Visible = false;
                button_RentPersonCode.Visible = false;
                comboBox_DutyType.Enabled = false;

                try
                {
                    TBL_CarDuty tbhf = DCMD.TBL_CarDuties.First(thfh => thfh.DutyCode == _dutyCode && thfh.CarID == _carID);
                    
                    textBoxDutyNumber.Text = tbhf.DutyNumber;
                    EditِDutyNumber = textBoxDutyNumber.Text;

                    comboBox_DutyType.SelectedIndex = tbhf.DutyType.Value;
                    comboBox_DutyType.Enabled = false;

                    DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhf.DutyDate));
                    comboBox_YearDD.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_MonthDD.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_DayDD.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                    textBox_OperatorCode.Tag = tbhf.OperatorCode;
                    textBox_OperatorCode.Text = DCMD.TBL_Operators.First(C => C.OperatorCode.Equals(tbhf.OperatorCode)).OperatorName;

                    textBox_RenterCode.Tag = tbhf.RenterCode;
                    textBox_RenterCode.Text = DCMD.TBL_Customers.First(C => C.CustomerID.Equals(tbhf.RenterCode)).CustomerName;

                    textBox_RentPersonCode.Tag = tbhf.RentPersonCode;
                    textBox_RentPersonCode.Text = DCMD.TBL_Customers.First(C => C.CustomerID.Equals(tbhf.RentPersonCode)).CustomerName;

                    textBox_CarID.Tag = tbhf.CarID;
                    textBox_CarID.Text = DCMD.TBL_Cars.First(C => C.CarID.Equals(tbhf.CarID)).CarName;

                    checkBox_DriverUse.Checked = tbhf.DriverUse.Value;
                    textBox_DriverCode.Tag = tbhf.DriverCode;
                    if (tbhf.DriverCode != 0)
                        textBox_DriverCode.Text = DCMD.TBL_Operators.First(C => C.OperatorCode.Equals(tbhf.DriverCode)).OperatorName;

                    DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhf.DeliveryDate));
                    comboBox_YearDL.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_MonthDL.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_DayDL.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                    nUpDown_DeliveryTime.Value = tbhf.DeliveryTime.Value;
                    comboBox_DeliveryDay.Text = tbhf.DeliveryDay;
                    nUpDownDeliveryKM.Value = tbhf.DeliveryKM.Value;

                    DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhf.RejectDate));
                    comboBox_YearRD.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_MonthRD.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_DayRD.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                    nUpDown_RejectTime.Value = tbhf.RejectTime.Value;
                    comboBox_RejectDay.Text = tbhf.RejectDay;
                    nUpDownRejectKM.Value = tbhf.RejectKM.Value;

                    textBox_FineTime.Text = Global_Cls.DigitSeparator(tbhf.FineTime.ToString());
                    textBox_FineDay.Text = Global_Cls.DigitSeparator(tbhf.FineDay.ToString());
                    textBox_FineKillometer.Text = Global_Cls.DigitSeparator(tbhf.FineKillometer.ToString());

                    comboBox_CityLimit.Text = tbhf.CityLimit;
                    nUpDown_FreeKillometer.Value = tbhf.FreeKillometer.Value;

                    if (_rentType != 1)
                    {
                        textBox_CarFaceDsc.Tag = tbhf.CarFaceCode.ToString();
                        textBox_KMUse.Text = (DCMD.TBL_CarFaces.First(Cr => Cr.CarFaceID.Equals(tbhf.CarFaceCode)).KilometerUse).ToString();
                        textBox_Oil.Text = (DCMD.TBL_CarFaces.First(Cr => Cr.CarFaceID.Equals(tbhf.CarFaceCode)).OilUse).ToString();
                        var pp = (from str in DCMD.SP_SetCarFaceView(tbhf.CarFaceCode) select new { str.CarFaceDscStr }).Single();
                        textBox_CarFaceDsc.Text = pp.CarFaceDscStr;
                    }

                    if (_rentType == 0)
                    {
                        textBox_CertifedCode.Tag = tbhf.CertifedCode.ToString();
                        var dd = (from str in DCMD.SP_SetCertificateView(tbhf.CertifedCode) select new { str.CertificateDsc }).Single();
                        textBox_CertifedCode.Text = dd.CertificateDsc;
                    }

                    if (_rentType != 2)
                    {
                        textBoxCarfarePrice.Text = Global_Cls.DigitSeparator(tbhf.CarfarePrice.ToString());

                        checkBoxKM.Checked = tbhf.KMSet.Value;
                        nUpDownKMPeriod.Value = tbhf.KMPeriod.Value;
                        textBoxKillometerPrice.Text = Global_Cls.DigitSeparator(tbhf.KMPrice.ToString());

                        checkBoxTime.Checked = tbhf.TimeSet.Value;
                        nUpDownTimePeriod.Value = tbhf.TimePeriod.Value;
                        textBoxTimePrice.Text = Global_Cls.DigitSeparator(tbhf.TimePrice.ToString());

                        checkBoxDaily.Checked = tbhf.DailySet.Value;
                        nUpDownDailyPeriod.Value = tbhf.DailyPeriod.Value;
                        textBoxDailyPrice.Text = Global_Cls.DigitSeparator(tbhf.DailyPrice.ToString());

                        checkBoxWeekly.Checked = tbhf.WeeklySet.Value;
                        nUpDownWeeklyPeriod.Value = tbhf.WeeklyPeriod.Value;
                        textBoxWeeklyPrice.Text = Global_Cls.DigitSeparator(tbhf.WeeklyPrice.ToString());

                        checkBoxMonthly.Checked = tbhf.MounthlySet.Value;
                        nUpDownMounthlyPeriod.Value = tbhf.MounthlyPeriod.Value;
                        textBoxMonthlyPrice.Text = Global_Cls.DigitSeparator(tbhf.MonthlyPrice.ToString());

                        textBox_TotalPrice.Text = Global_Cls.DigitSeparator(tbhf.TotalPrice.ToString());
                    }
                    else if (_rentType == 2)
                    {
                        DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhf.DutyDate));
                        comboBox_YearDD1.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                        comboBox_MonthDD1.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                        comboBox_DayDD1.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                        labelDutyNumber.Text = tbhf.DutyNumber;
                        label_DutyType.Text = comboBox_DutyType.Text;
                        label_OperatorCode.Text = textBox_OperatorCode.Text;
                        label_RenterCode.Text = textBox_RenterCode.Text;
                        label_RentPersonCode.Text = textBox_RentPersonCode.Text;
                        label_CarID.Text = textBox_CarID.Text;
                        label_DriverCode.Text = textBox_DriverCode.Text;

                        DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhf.RejectDate));
                        comboBox_YearRD1.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                        comboBox_MonthRD1.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                        comboBox_DayRD1.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                        nUpDown_RejectTime1.Value = tbhf.RejectTime.Value;
                        comboBox_RejectDay1.Text = tbhf.RejectDay;
                        nUpDownRejectKM1.Value = tbhf.RejectKM.Value;

                        DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhf.RealRejectDate));
                        comboBox_YearRRD.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                        comboBox_MonthRRD.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                        comboBox_DayRRD.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                        nUpDownRealRejectTime.Value = tbhf.RealRejectTime.Value;
                        comboBoxRealRejectDay.Text = tbhf.RealRejectDay;
                        nUpDownRealRejectKM.Value = tbhf.RealRejectKM.Value;

                        nUpDownRejectDelayKM.Value = tbhf.RejectDelayKM.Value;
                        nUpDownRejectDelayTime.Value = tbhf.RejectDelayTime.Value;
                        nUpDownRejectDelayDay.Value = tbhf.RejectDelayDay.Value;

                        textBox_FineTime1.Text = Global_Cls.DigitSeparator(tbhf.FineTime.ToString());
                        textBox_FineDay1.Text = Global_Cls.DigitSeparator(tbhf.FineDay.ToString());
                        textBox_FineKillometer1.Text = Global_Cls.DigitSeparator(tbhf.FineKillometer.ToString());

                        textBoxRejectDelayPrice.Text = Global_Cls.DigitSeparator(tbhf.RejectDelayPrice.ToString());
                        textBoxRejectConflictPrice.Text = Global_Cls.DigitSeparator(tbhf.RejectConflictPrice.ToString());
                        textBoxRejectFineAllPrice.Text = Global_Cls.DigitSeparator(tbhf.RejectFineAllPrice.ToString());

                        checkBoxAnomaly.Checked = tbhf.Anomaly.Value;
                        textBoxAnomalyPrice.Text = Global_Cls.DigitSeparator(tbhf.AnomalyPrice.ToString());

                        textBoxCarfarePrice2.Text = Global_Cls.DigitSeparator(tbhf.CarfarePrice.ToString());

                        var dd = (from str in DCMD.SP_SetCertificateView(tbhf.CertifedCode) select new { str.CertificateDsc }).Single();
                        textBox_CertifedCode.Text = dd.CertificateDsc;

                    }
                    textBoxMod.Text = "0";
                    textBox_ModBack.Text = "0";
                }
                catch (Exception ex)
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اشکال در لود", ex.Message);
                }

            }



            else if (_newOrEditDuty)
            {
                comboBox_DutyType.SelectedIndex = _dutyType;

                if (_rentType == 0)
                {
                    ///////////DutyNumber
                    int MaxNumber = 0;
                    try
                    {
                        MaxNumber = (from prd in DCMD.TBL_CarDuties
                                     orderby Convert.ToInt32(prd.DutyNumber)
                                     select Convert.ToInt32(prd.DutyNumber)
                                     ).Max();
                    }
                    catch { }

                    int DelMaxNumber = 0;
                    try
                    {
                        DelMaxNumber = (from prd in DCMD.TBL_DelCarDuties
                                        orderby Convert.ToInt32(prd.DutyNumber)
                                        select Convert.ToInt32(prd.DutyNumber)
                                        ).Max();
                    }
                    catch { }

                    try { textBoxDutyNumber.Text = MaxNumber.CompareTo(DelMaxNumber) == 1 ? MaxNumber.ToString() : DelMaxNumber.ToString(); }
                    catch { }

                    try { textBoxDutyNumber.Text = (double.Parse(textBoxDutyNumber.Text == "" ? "0" : textBoxDutyNumber.Text) + 1).ToString(); }
                    catch { }
                    ///////////////DutyNumber

                    DateStr = Global_Cls.MiladiDateToShamsi(DateTime.Today);
                    comboBox_YearDD.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_MonthDD.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_DayDD.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                    comboBox_YearDD1.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_MonthDD1.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_DayDD1.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                    comboBox_YearDL.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_MonthDL.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_DayDL.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                    comboBox_YearRD.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_MonthRD.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_DayRD.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                    comboBox_YearRRD.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_MonthRRD.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_DayRRD.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();


                    textBox_RenterCode.Tag = DCMD.TBL_Customers.First(C => C.IsParent == true).CustomerID;
                    textBox_RenterCode.Text = DCMD.TBL_Customers.First(C => C.IsParent == true).CustomerName;

                    textBox_FineDay.Text = Global_Cls.DigitSeparator(Global_Cls.FineDay.ToString());
                    textBox_FineTime.Text = Global_Cls.DigitSeparator(Global_Cls.FineTime.ToString());
                    textBox_FineKillometer.Text = Global_Cls.DigitSeparator(Global_Cls.FineKillometer.ToString());

                    comboBox_CityLimit.Text = Global_Cls.CityLimit;
                    nUpDown_FreeKillometer.Value = Global_Cls.FreeKillometer;

                }
                else if (_rentType == 1)
                {
                    button_CarID.Visible = false;
                    button_RentPersonCode.Visible = false;
                    comboBox_DutyType.Enabled = false;

                    try
                    {
                        TBL_CarDuty tbhf = DCMD.TBL_CarDuties.First(thfh => thfh.DutyCode == _dutyCode && thfh.CarID == _carID);

                        textBoxDutyNumber.Text = tbhf.DutyNumber;
                        textBoxDutyNumber.ReadOnly = true;

                        comboBox_DutyType.SelectedIndex = tbhf.DutyType.Value;

                        textBox_OperatorCode.Tag = tbhf.OperatorCode;
                        textBox_OperatorCode.Text = DCMD.TBL_Operators.First(C => C.OperatorCode.Equals(tbhf.OperatorCode)).OperatorName;

                        textBox_RenterCode.Tag = tbhf.RenterCode;
                        textBox_RenterCode.Text = DCMD.TBL_Customers.First(C => C.CustomerID.Equals(tbhf.RenterCode)).CustomerName;

                        textBox_RentPersonCode.Tag = tbhf.RentPersonCode;
                        textBox_RentPersonCode.Text = DCMD.TBL_Customers.First(C => C.CustomerID.Equals(tbhf.RentPersonCode)).CustomerName;

                        textBox_CarID.Tag = tbhf.CarID;
                        textBox_CarID.Text = DCMD.TBL_Cars.First(C => C.CarID.Equals(tbhf.CarID)).CarName;

                        checkBox_DriverUse.Checked = tbhf.DriverUse.Value;
                        textBox_DriverCode.Tag = tbhf.DriverCode;
                        if (tbhf.DriverCode != 0)
                            textBox_DriverCode.Text = DCMD.TBL_Operators.First(C => C.OperatorCode.Equals(tbhf.DriverCode)).OperatorName;


                        DateStr = Global_Cls.MiladiDateToShamsi(DateTime.Today);
                        comboBox_YearDD.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                        comboBox_MonthDD.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                        comboBox_DayDD.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                        DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhf.RejectDate));
                        comboBox_YearDL.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                        comboBox_MonthDL.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                        comboBox_DayDL.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                        nUpDown_DeliveryTime.Value = tbhf.RejectTime.Value;
                        comboBox_DeliveryDay.Text = tbhf.RejectDay;
                        nUpDownDeliveryKM.Value = tbhf.RejectKM.Value;

                        DateStr = Global_Cls.MiladiDateToShamsi(DateTime.Today);
                        comboBox_YearRD.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                        comboBox_MonthRD.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                        comboBox_DayRD.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                        //nUpDown_RejectTime.Value = tbhf.RejectTime.Value;
                        //comboBox_RejectDay.Text = tbhf.RejectDay;
                        //textBoxRejectKM.Text = tbhf.RejectKM.Value.ToString();

                        textBox_FineTime.Text = Global_Cls.DigitSeparator(tbhf.FineTime.ToString());
                        textBox_FineDay.Text = Global_Cls.DigitSeparator(tbhf.FineDay.ToString());
                        textBox_FineKillometer.Text = Global_Cls.DigitSeparator(tbhf.FineKillometer.ToString());

                        comboBox_CityLimit.Text = tbhf.CityLimit;
                        nUpDown_FreeKillometer.Value = tbhf.FreeKillometer.Value;


                        checkBoxKM.Checked = tbhf.KMSet.Value;
                        nUpDownKMPeriod.Value = tbhf.KMPeriod.Value;

                        checkBoxTime.Checked = tbhf.TimeSet.Value;
                        nUpDownTimePeriod.Value = tbhf.TimePeriod.Value;

                        checkBoxDaily.Checked = tbhf.DailySet.Value;
                        nUpDownDailyPeriod.Value = tbhf.DailyPeriod.Value;

                        checkBoxWeekly.Checked = tbhf.WeeklySet.Value;
                        nUpDownWeeklyPeriod.Value = tbhf.WeeklyPeriod.Value;

                        checkBoxMonthly.Checked = tbhf.MounthlySet.Value;
                        nUpDownMounthlyPeriod.Value = tbhf.MounthlyPeriod.Value;

                        try
                        {
                            CarFaceDscTag = tbhf.CarFaceCode.Value;
                            textBox_KMUse.Text = (DCMD.TBL_CarFaces.First(Cr => Cr.CarFaceID.Equals(tbhf.CarFaceCode)).KilometerUse).ToString();
                            textBox_Oil.Text = (DCMD.TBL_CarFaces.First(Cr => Cr.CarFaceID.Equals(tbhf.CarFaceCode)).OilUse).ToString();
                            var pp = (from str in DCMD.SP_SetCarFaceView(tbhf.CarFaceCode) select new { str.CarFaceDscStr }).Single();
                            textBox_CarFaceDsc.Text = pp.CarFaceDscStr;
                        }
                        catch { }
                        try
                        {
                            CertifedCodeTag = tbhf.CertifedCode.Value;
                            var dd = (from str in DCMD.SP_SetCertificateView(tbhf.CertifedCode) select new { str.CertificateDsc }).Single();
                            textBox_CertifedCode.Text = dd.CertificateDsc;
                        }
                        catch { }

                    }
                    catch (Exception ex)
                    {
                        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اشکال در لود", ex.Message);
                    }


                }
                else if (_rentType == 2)
                {
                    try
                    {

                        TBL_CarDuty tbhf = DCMD.TBL_CarDuties.First(thfh => thfh.DutyCode == _dutyCode && thfh.CarID == _carID);

                        DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhf.DutyDate));
                        comboBox_YearDD.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                        comboBox_MonthDD.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                        comboBox_DayDD.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();
                        
                        textBoxDutyNumber.Text = tbhf.DutyNumber;
                        
                        textBox_OperatorCode.Tag = tbhf.OperatorCode;
                        textBox_OperatorCode.Text = DCMD.TBL_Operators.First(C => C.OperatorCode.Equals(tbhf.OperatorCode)).OperatorName;

                        textBox_RenterCode.Tag = tbhf.RenterCode;
                        textBox_RenterCode.Text = DCMD.TBL_Customers.First(C => C.CustomerID.Equals(tbhf.RenterCode)).CustomerName;

                        textBox_RentPersonCode.Tag = tbhf.RentPersonCode;
                        textBox_RentPersonCode.Text = DCMD.TBL_Customers.First(C => C.CustomerID.Equals(tbhf.RentPersonCode)).CustomerName;

                        textBox_CarID.Tag = tbhf.CarID;
                        textBox_CarID.Text = DCMD.TBL_Cars.First(C => C.CarID.Equals(tbhf.CarID)).CarName;

                        checkBox_DriverUse.Checked = tbhf.DriverUse.Value;
                        textBox_DriverCode.Tag = tbhf.DriverCode;
                        if (tbhf.DriverCode != 0)
                            textBox_DriverCode.Text = DCMD.TBL_Operators.First(C => C.OperatorCode.Equals(tbhf.DriverCode)).OperatorName;

                        DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhf.DeliveryDate));
                        comboBox_YearDL.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                        comboBox_MonthDL.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                        comboBox_DayDL.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                        nUpDown_DeliveryTime.Value = tbhf.DeliveryTime.Value;
                        comboBox_DeliveryDay.Text = tbhf.DeliveryDay;
                        nUpDownDeliveryKM.Value = tbhf.DeliveryKM.Value;

                        DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhf.RejectDate));
                        comboBox_YearRD.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                        comboBox_MonthRD.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                        comboBox_DayRD.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                        nUpDown_RejectTime.Value = tbhf.RejectTime.Value;
                        comboBox_RejectDay.Text = tbhf.RejectDay;
                        nUpDownRejectKM.Value = tbhf.RejectKM.Value;

                        textBox_FineTime.Text = Global_Cls.DigitSeparator(tbhf.FineTime.ToString());
                        textBox_FineDay.Text = Global_Cls.DigitSeparator(tbhf.FineDay.ToString());
                        textBox_FineKillometer.Text = Global_Cls.DigitSeparator(tbhf.FineKillometer.ToString());

                        comboBox_CityLimit.Text = tbhf.CityLimit;
                        nUpDown_FreeKillometer.Value = tbhf.FreeKillometer.Value;
                        try
                        {
                            CarFaceDscTag = tbhf.CarFaceCode.Value;
                            textBox_KMUse.Text = (DCMD.TBL_CarFaces.First(Cr => Cr.CarFaceID.Equals(tbhf.CarFaceCode)).KilometerUse).ToString();
                            textBox_Oil.Text = (DCMD.TBL_CarFaces.First(Cr => Cr.CarFaceID.Equals(tbhf.CarFaceCode)).OilUse).ToString();
                            var pp = (from str in DCMD.SP_SetCarFaceView(tbhf.CarFaceCode) select new { str.CarFaceDscStr }).Single();
                            textBox_CarFaceDsc.Text = pp.CarFaceDscStr;
                        }
                        catch { }
                        try
                        {
                            CertifedCodeTag = tbhf.CertifedCode.Value;
                            var dd = (from str in DCMD.SP_SetCertificateView(tbhf.CertifedCode) select new { str.CertificateDsc }).Single();
                            textBox_CertifedCode.Text = dd.CertificateDsc;
                        }
                        catch { }

                        DateStr = Global_Cls.MiladiDateToShamsi(DateTime.Today);
                        comboBox_YearDD1.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                        comboBox_MonthDD1.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                        comboBox_DayDD1.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                        labelDutyNumber.Text = tbhf.DutyNumber;
                        label_DutyType.Text = comboBox_DutyType.Text;
                        label_OperatorCode.Text = textBox_OperatorCode.Text;
                        label_RenterCode.Text = textBox_RenterCode.Text;
                        label_RentPersonCode.Text = textBox_RentPersonCode.Text;
                        label_CarID.Text = textBox_CarID.Text;
                        label_DriverCode.Text = textBox_DriverCode.Text;


                        DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhf.RejectDate));
                        comboBox_YearRD1.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                        comboBox_MonthRD1.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                        comboBox_DayRD1.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                        nUpDown_RejectTime1.Value = tbhf.RejectTime.Value;
                        comboBox_RejectDay1.Text = tbhf.RejectDay;
                        nUpDownRejectKM1.Value = tbhf.RejectKM.Value;

                        DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhf.RejectDate));
                        comboBox_YearRRD.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                        comboBox_MonthRRD.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                        comboBox_DayRRD.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                        nUpDownRealRejectTime.Value = tbhf.RejectTime.Value;
                        comboBoxRealRejectDay.Text = tbhf.RejectDay;
                        nUpDownRealRejectKM.Value = tbhf.RejectKM.Value;

                        textBox_FineTime1.Text = Global_Cls.DigitSeparator(tbhf.FineTime.ToString());
                        textBox_FineDay1.Text = Global_Cls.DigitSeparator(tbhf.FineDay.ToString());
                        textBox_FineKillometer1.Text = Global_Cls.DigitSeparator(tbhf.FineKillometer.ToString());

                        //checkBoxAnomaly.Checked = tbhf.Anomaly.Value;
                        //textBoxAnomalyPrice.Text = Global_Cls.DigitSeparator(tbhf.AnomalyPrice.ToString());

                    }
                    catch (Exception ex)
                    {
                        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اشکال در لود", ex.Message);
                    }
                } 
                
                try
                {
                    var MaxID = (from prd in DCMD.TBL_CarDuties
                                 where prd.CarID == _carID
                                 select prd.DutyCode).Max();
                    _dutyCode = MaxID + 1;
                }
                catch
                {
                    _dutyCode = 1;
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
                Close();
            }
        }

        private bool OkFunction()
        {
            if (!CheckValidation()) return false;

            DataClasses_MainDataContext DCD = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            if (_newOrEditDuty)
                try
                {
                    TBL_CarDuty THF = new TBL_CarDuty
                    {
                        CarID = int.Parse(textBox_CarID.Tag.ToString()),
                        
                        DutyNumber = textBoxDutyNumber.Text,

                        DutyCode = _dutyCode,
                        DutyType = comboBox_DutyType.SelectedIndex,
                        RentType =_rentType,
                        OperatorCode = int.Parse(textBox_OperatorCode.Tag.ToString()),
                        RenterCode = int.Parse(textBox_RenterCode.Tag.ToString()),
                        RentPersonCode = int.Parse(textBox_RentPersonCode.Tag.ToString()),
                        DriverUse = checkBox_DriverUse.Checked,
                        DriverCode = int.Parse((textBox_DriverCode.Tag??0).ToString()),

                        DeliveryTime = int.Parse(nUpDown_DeliveryTime.Value.ToString()),
                        DeliveryDay = comboBox_DeliveryDay.Text,
                        DeliveryDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearDL.Text, comboBox_MonthDL.Text, comboBox_DayDL.Text),
                        DeliveryKM = int.Parse(nUpDownDeliveryKM.Value.ToString()),

                        CityLimit = comboBox_CityLimit.Text,
                        FreeKillometer = int.Parse(nUpDown_FreeKillometer.Value.ToString()),
                    };

                    if (_rentType == 0)
                    {
                        THF.CertifedCode = int.Parse((textBox_CertifedCode.Tag ?? 0).ToString());
                        THF.CarFaceCode = int.Parse((textBox_CarFaceDsc.Tag ?? 0).ToString());
                    }
                    if (_rentType == 2)
                        THF.CarFaceCode = int.Parse((textBox_CarFaceDsc.Tag ?? 0).ToString());

                    if (_rentType != 2)
                    {
                        THF.DutyDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearDD.Text, comboBox_MonthDD.Text, comboBox_DayDD.Text);

                        THF.RejectTime = int.Parse(nUpDown_RejectTime.Value.ToString());
                        THF.RejectDay = comboBox_RejectDay.Text;
                        THF.RejectDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearRD.Text, comboBox_MonthRD.Text, comboBox_DayRD.Text);
                        THF.RejectKM = int.Parse(nUpDownRejectKM.Value.ToString());

                        if (checkBox_DriverUse.Checked)
                            THF.CarfarePrice = double.Parse((textBoxCarfarePrice.Text == "" ? "0" : textBoxCarfarePrice.Text).Replace(",", ""));

                        THF.KMSet = checkBoxKM.Checked;
                        THF.KMPeriod = int.Parse(nUpDownKMPeriod.Value.ToString());
                        THF.KMPrice = double.Parse((textBoxKillometerPrice.Text == "" ? "0" : textBoxKillometerPrice.Text).Replace(",", ""));

                        THF.TimeSet = checkBoxTime.Checked;
                        THF.TimePeriod = int.Parse(nUpDownTimePeriod.Value.ToString());
                        THF.TimePrice = double.Parse((textBoxTimePrice.Text == "" ? "0" : textBoxTimePrice.Text).Replace(",", ""));

                        THF.DailySet = checkBoxDaily.Checked;
                        THF.DailyPeriod = int.Parse(nUpDownDailyPeriod.Value.ToString());
                        THF.DailyPrice = double.Parse((textBoxDailyPrice.Text == "" ? "0" : textBoxDailyPrice.Text).Replace(",", ""));

                        THF.WeeklySet = checkBoxWeekly.Checked;
                        THF.WeeklyPeriod = int.Parse(nUpDownWeeklyPeriod.Value.ToString());
                        THF.WeeklyPrice = double.Parse((textBoxWeeklyPrice.Text == "" ? "0" : textBoxWeeklyPrice.Text).Replace(",", ""));

                        THF.MounthlySet = checkBoxMonthly.Checked;
                        THF.MounthlyPeriod = int.Parse(nUpDownMounthlyPeriod.Value.ToString());
                        THF.MonthlyPrice = double.Parse((textBoxMonthlyPrice.Text == "" ? "0" : textBoxMonthlyPrice.Text).Replace(",", ""));

                        THF.FineTime = double.Parse((textBox_FineTime.Text == "" ? "0" : textBox_FineTime.Text).Replace(",", ""));
                        THF.FineDay = double.Parse((textBox_FineDay.Text == "" ? "0" : textBox_FineDay.Text).Replace(",", ""));
                        THF.FineKillometer = double.Parse((textBox_FineKillometer.Text == "" ? "0" : textBox_FineKillometer.Text).Replace(",", ""));

                        THF.TotalPrice = double.Parse((textBox_TotalPrice.Text == "" ? "0" : textBox_TotalPrice.Text).Replace(",", ""));
                    }
                    else
                    {
                        THF.DutyDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearDD1.Text, comboBox_MonthDD1.Text, comboBox_DayDD1.Text);

                        THF.RejectTime = int.Parse(nUpDown_RejectTime1.Value.ToString());
                        THF.RejectDay = comboBox_RejectDay1.Text;
                        THF.RejectDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearRD1.Text, comboBox_MonthRD1.Text, comboBox_DayRD1.Text);
                        THF.RejectKM = int.Parse(nUpDownRejectKM1.Value.ToString());

                        THF.RealRejectTime = int.Parse(nUpDownRealRejectTime.Value.ToString());
                        THF.RealRejectDay = comboBoxRealRejectDay.Text;
                        THF.RealRejectDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearRRD.Text, comboBox_MonthRRD.Text, comboBox_DayRRD.Text);
                        THF.RealRejectKM = int.Parse(nUpDownRealRejectKM.Value.ToString());


                        THF.RejectDelayKM = int.Parse(nUpDownRejectDelayKM.Value.ToString());
                        THF.FineKillometer = double.Parse(textBox_FineKillometer1.Text.Replace(",", ""));

                        THF.RejectDelayDay = int.Parse(nUpDownRejectDelayDay.Value.ToString());
                        THF.FineDay = double.Parse((textBox_FineDay1.Text == "" ? "0" : textBox_FineDay1.Text).Replace(",", ""));

                        THF.RejectDelayTime = int.Parse(nUpDownRejectDelayTime.Value.ToString());
                        THF.FineTime = double.Parse((textBox_FineTime1.Text == "" ? "0" : textBox_FineTime1.Text).Replace(",", ""));

                        THF.RejectConflictPrice = double.Parse((textBoxRejectConflictPrice.Text == "" ? "0" : textBoxRejectConflictPrice.Text).Replace(",", ""));
                        THF.RejectDelayPrice = double.Parse((textBoxRejectDelayPrice.Text == "" ? "0" : textBoxRejectDelayPrice.Text).Replace(",", ""));
                        THF.RejectFineAllPrice = double.Parse((textBox_TotalPrice.Text == "" ? "0" : textBox_TotalPrice.Text).Replace(",", ""));

                        THF.Anomaly = checkBoxAnomaly.Checked;
                        THF.AnomalyPrice = double.Parse((textBoxAnomalyPrice.Text == "" ? "0" : textBoxAnomalyPrice.Text).Replace(",", ""));

                        if (checkBox_DriverUse.Checked)
                            THF.CarfarePrice = double.Parse((textBoxCarfarePrice2.Text == "" ? "0" : textBoxCarfarePrice2.Text).Replace(",", ""));
                    }

                    DCD.TBL_CarDuties.InsertOnSubmit(THF);
                    DCD.SubmitChanges();
                }
                catch (Exception ex)
                {
                    if (ex.Message.IndexOf("Duplicated Row!") > -1)
                        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اطلاعات وارد شده تکراری است!");
                    else
                        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "لطفا با کمی فاصله دوباره تایید کنید!", ex.ToString());

                    return false;
                }
            else
                if (!_newOrEditDuty)
                    try
                    {
                        TBL_CarDuty tbhf = DCD.TBL_CarDuties.First(thfh => thfh.DutyCode == _dutyCode && thfh.CarID == _carID);

                        tbhf.DutyNumber = textBoxDutyNumber.Text;

                        tbhf.DutyType = comboBox_DutyType.SelectedIndex;
                        tbhf.OperatorCode = int.Parse(textBox_OperatorCode.Tag.ToString());
                        tbhf.RenterCode = int.Parse(textBox_RenterCode.Tag.ToString());
                        tbhf.RentPersonCode = int.Parse(textBox_RentPersonCode.Tag.ToString());
                        tbhf.CarID = int.Parse(textBox_CarID.Tag.ToString());
                        tbhf.DriverUse = checkBox_DriverUse.Checked;
                        tbhf.DriverCode = int.Parse((textBox_DriverCode.Tag??0).ToString());
                        tbhf.DeliveryTime = int.Parse(nUpDown_DeliveryTime.Value.ToString());
                        tbhf.DeliveryDay = comboBox_DeliveryDay.Text;
                        tbhf.DeliveryDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearDL.Text, comboBox_MonthDL.Text, comboBox_DayDL.Text);
                        tbhf.DeliveryKM = int.Parse(nUpDownDeliveryKM.Value.ToString());

                        tbhf.CityLimit = comboBox_CityLimit.Text;
                        tbhf.FreeKillometer = int.Parse(nUpDown_FreeKillometer.Value.ToString());
                        tbhf.TotalPrice = double.Parse((textBox_TotalPrice.Text == "" ? "0" : textBox_TotalPrice.Text).Replace(",", ""));
                        
                        if (_rentType == 0)
                        {
                            tbhf.CertifedCode = int.Parse((textBox_CertifedCode.Tag ?? 0).ToString());
                            tbhf.CarFaceCode = int.Parse((textBox_CarFaceDsc.Tag ?? 0).ToString());
                        }
                        if (_rentType == 2)
                            tbhf.CarFaceCode = int.Parse((textBox_CarFaceDsc.Tag ?? 0).ToString());

                        if (_rentType != 2)
                        {
                            tbhf.DutyDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearDD.Text, comboBox_MonthDD.Text, comboBox_DayDD.Text);

                            tbhf.RejectTime = int.Parse(nUpDown_RejectTime.Value.ToString());
                            tbhf.RejectDay = comboBox_RejectDay.Text;
                            tbhf.RejectDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearRD.Text, comboBox_MonthRD.Text, comboBox_DayRD.Text);
                            tbhf.RejectKM = int.Parse(nUpDownRejectKM.Value.ToString());


                            tbhf.KMSet = checkBoxKM.Checked;
                            tbhf.KMPeriod = int.Parse(nUpDownKMPeriod.Value.ToString());
                            tbhf.KMPrice = double.Parse((textBoxKillometerPrice.Text == "" ? "0" : textBoxKillometerPrice.Text).Replace(",", ""));

                            tbhf.TimeSet = checkBoxTime.Checked;
                            tbhf.TimePeriod = int.Parse(nUpDownTimePeriod.Value.ToString());
                            tbhf.TimePrice = double.Parse((textBoxTimePrice.Text == "" ? "0" : textBoxTimePrice.Text).Replace(",", ""));

                            tbhf.DailySet = checkBoxDaily.Checked;
                            tbhf.DailyPeriod = int.Parse(nUpDownDailyPeriod.Value.ToString());
                            tbhf.DailyPrice = double.Parse((textBoxDailyPrice.Text == "" ? "0" : textBoxDailyPrice.Text).Replace(",", ""));

                            tbhf.WeeklySet = checkBoxWeekly.Checked;
                            tbhf.WeeklyPeriod = int.Parse(nUpDownWeeklyPeriod.Value.ToString());
                            tbhf.WeeklyPrice = double.Parse((textBoxWeeklyPrice.Text == "" ? "0" : textBoxWeeklyPrice.Text).Replace(",", ""));

                            tbhf.MounthlySet = checkBoxMonthly.Checked;
                            tbhf.MounthlyPeriod = int.Parse(nUpDownMounthlyPeriod.Value.ToString());
                            tbhf.MonthlyPrice = double.Parse((textBoxMonthlyPrice.Text == "" ? "0" : textBoxMonthlyPrice.Text).Replace(",", ""));

                            tbhf.FineTime = double.Parse((textBox_FineTime.Text == "" ? "0" : textBox_FineTime.Text).Replace(",", ""));
                            tbhf.FineDay = double.Parse((textBox_FineDay.Text == "" ? "0" : textBox_FineDay.Text).Replace(",", ""));
                            tbhf.FineKillometer = double.Parse((textBox_FineKillometer.Text == "" ? "0" : textBox_FineKillometer.Text).Replace(",", ""));

                            tbhf.TotalPrice = double.Parse((textBox_TotalPrice.Text == "" ? "0" : textBox_TotalPrice.Text).Replace(",", ""));
                            tbhf.CarfarePrice = double.Parse((textBoxCarfarePrice.Text == "" ? "0" : textBoxCarfarePrice.Text).Replace(",", ""));
                        }
                        else
                        {
                            tbhf.DutyDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearDD1.Text, comboBox_MonthDD1.Text, comboBox_DayDD1.Text);

                            tbhf.RejectTime = int.Parse(nUpDown_RejectTime1.Value.ToString());
                            tbhf.RejectDay = comboBox_RejectDay1.Text;
                            tbhf.RejectDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearRD1.Text, comboBox_MonthRD1.Text, comboBox_DayRD1.Text);
                            tbhf.RejectKM = int.Parse(nUpDownRejectKM1.Value.ToString());

                            tbhf.RealRejectTime = int.Parse(nUpDownRealRejectTime.Value.ToString());
                            tbhf.RealRejectDay = comboBoxRealRejectDay.Text;
                            tbhf.RealRejectDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearRRD.Text, comboBox_MonthRRD.Text, comboBox_DayRRD.Text);
                            tbhf.RealRejectKM = int.Parse(nUpDownRealRejectKM.Value.ToString());


                            tbhf.RejectDelayKM = int.Parse(nUpDownRejectDelayKM.Value.ToString());
                            tbhf.FineKillometer = double.Parse((textBox_FineKillometer1.Text == "" ? "0" : textBox_FineKillometer1.Text).Replace(",", ""));

                            tbhf.RejectDelayDay = int.Parse(nUpDownRejectDelayDay.Value.ToString());
                            tbhf.FineDay = double.Parse((textBox_FineDay1.Text == "" ? "0" : textBox_FineDay1.Text).Replace(",", ""));

                            tbhf.RejectDelayTime = int.Parse(nUpDownRejectDelayTime.Value.ToString());
                            tbhf.FineTime = double.Parse((textBox_FineTime1.Text == "" ? "0" : textBox_FineTime1.Text).Replace(",", ""));

                            tbhf.RejectConflictPrice = double.Parse((textBoxRejectConflictPrice.Text == "" ? "0" : textBoxRejectConflictPrice.Text).Replace(",", ""));
                            tbhf.RejectDelayPrice = double.Parse((textBoxRejectDelayPrice.Text == "" ? "0" : textBoxRejectDelayPrice.Text).Replace(",", ""));
                            tbhf.RejectFineAllPrice = double.Parse((textBox_TotalPrice.Text == "" ? "0" : textBox_TotalPrice.Text).Replace(",", ""));

                            tbhf.Anomaly = checkBoxAnomaly.Checked;
                            tbhf.AnomalyPrice = double.Parse((textBoxAnomalyPrice.Text == "" ? "0" : textBoxAnomalyPrice.Text).Replace(",", ""));

                            tbhf.CarfarePrice = double.Parse((textBoxCarfarePrice2.Text == "" ? "0" : textBoxCarfarePrice2.Text).Replace(",", ""));
                        }

                        DCD.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.IndexOf("Duplicated Row!") > -1)
                            Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اطلاعات وارد شده تکراری است!");
                        else
                            Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "لطفا با کمی فاصله دوباره تایید کنید!", ex.ToString());

                        return false;
                    }

            this.TopMost = false;


            if (checkBoxItemSMS.Visible && checkBoxItemSMS.Checked)
            {
                if (Classes.SMSClass.ConnectToPort())
                    Classes.SMSClass.SendList(
                        Classes.SMSClass.InsertToSMSList(
                        DCD.TBL_Customers.First(jj => jj.CustomerID==int.Parse(textBox_RentPersonCode.Tag.ToString())).Mobile,
                        Global_Cls.InitSMSMessage.Replace("{0}",textBoxDutyNumber.Text).Replace("{1}",DCD.TBL_Customers.First(thfr => thfr.IsParent == true).AddressBusiness).
                            Replace("{2}",comboBox_DeliveryDay.Text+ " "+ comboBox_YearDL.Text+"/"+comboBox_MonthDL.Text+"/"+comboBox_DayDL.Text).
                            Replace("{3}",comboBox_RejectDay.Text+ " "+ comboBox_YearRD.Text+"/"+comboBox_MonthRD.Text+"/"+comboBox_DayRD.Text)));
            }

            if (checkBoxItemDutyPrint.Visible && checkBoxItemDutyPrint.Checked)
            {
                try
                {
                    Report.Mamoriat RAIF = new Report.Mamoriat(_carID, _dutyCode, _rentType == 0 ? true : false, _rentType == 0 ? 1 : 2);
                    
                    PrintPreview_frm ppf = new PrintPreview_frm(RAIF);
                    ppf.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }

                try
                {
                    Report.Resid RAIF = new Report.Resid(_carID, _dutyCode, 1);
                    PrintPreview_frm ppf = new PrintPreview_frm(RAIF);
                    ppf.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }
            }

            if (checkBoxItemRenterPrint.Visible && checkBoxItemRenterPrint.Checked)
            { }
                
            if (checkBoxItemEjarename.Visible && checkBoxItemEjarename.Checked)
            {
                if (_dutyType == 5)
                {
                    try
                    {
                        //var SUS = from prd in DCMD.SP_SetRepAmanatHamkarView(_carID, _dutyCode)
                        //          select new { prd.DutyCode, prd.CarID };

                        Report.AmanatNameAvalieh RAIF = new Report.AmanatNameAvalieh(_carID, _dutyCode);

                        //RAIF.DataSource = SUS;
                        //RAIF.DataMember = "SP_SetAmanatHamkarView";
                        //RAIF.DataAdapter = "SP_SetAmanatHamkarView";
                        PrintPreview_frm ppf = new PrintPreview_frm(RAIF);
                        ppf.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(Convert.ToString(ex));
                    }

                }
                else
                {
                    //var SUS = from prd in DCMD.TBL_CarDuties
                    //          where prd.DutyCode == _dutyCode
                    //          select prd;
                    try
                    {
                        Report.EjareNameMoshtari RAIF = new Report.EjareNameMoshtari(_carID, _dutyCode, 1);
                        //RAIF.DataSource = SUS;
                        PrintPreview_frm ppf = new PrintPreview_frm(RAIF);
                        ppf.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(Convert.ToString(ex));
                    }

                    //SUS = from prd in DCMD.TBL_CarDuties
                    //      where prd.DutyCode == _dutyCode
                    //      select prd;
                    try
                    {
                        Report.TaahodName RAIF = new Report.TaahodName(_carID, _dutyCode, 1);
                        //RAIF.DataSource = SUS;
                        PrintPreview_frm ppf = new PrintPreview_frm(RAIF);
                        ppf.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(Convert.ToString(ex));
                    }

                    //try
                    //{
                    //    Report.TaahodNameOld RAIFO = new Report.TaahodNameOld(textBox_RentPersonCode.Text);
                    //    //RAIF.DataSource = SUS;
                    //    PrintPreview_frm ppf = new PrintPreview_frm(RAIFO);
                    //    ppf.ShowDialog();
                    //}
                    //catch (Exception ex)
                    //{
                    //    MessageBox.Show(Convert.ToString(ex));
                    //}
                }
            }


            if (checkBoxItem_CarFace.Visible && checkBoxItem_CarFace.Checked)
            {
                //var SUS = from prd in DCMD.TBL_Cars
                //          where prd.CarID == _carID
                //          select prd;
                try
                {
                    Report.MoshakhasatZaheri RAIF = new Report.MoshakhasatZaheri(int.Parse(textBox_CarFaceDsc.Tag.ToString()));
                    //RAIF.DataSource = SUS;
                    PrintPreview_frm ppf = new PrintPreview_frm(RAIF);
                    ppf.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }

            }

            return true;
        }

       private bool CheckValidation()
       {
           panel_DutyDate_Leave(this, null);
           panel_DeliveryDate_Leave(this, null);
           panel_RejectDate_Leave(this, null);

           if (_rentType == 2)
           {
               panel_DutyDate1_Leave(this, null);
               panelRealRejectDate_Leave(this, null);
           }


           if (textBoxDutyNumber.Text == "" || textBoxDutyNumber.Text == "0")
           { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "کد سرویس را وارد نمایید"); textBoxDutyNumber.Focus(); return false; }
           if (comboBox_DutyType.Text == "")
           { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "نوع درخواست را وارد نمایید"); comboBox_DutyType.Focus(); return false; }
           if (textBox_OperatorCode.Text == "")
           { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "نام کارگزار را وارد نمایید"); textBox_OperatorCode.Focus(); return false; }
           if (textBox_RenterCode.Text == "")
           { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "نام امانت دهنده را وارد نمایید"); textBox_RenterCode.Focus(); return false; }
           if (textBox_CarID.Text == "")
           { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "نام اتومبیل را وارد نمایید"); textBox_CarID.Focus(); return false; }
           if (textBox_RentPersonCode.Text == "")
           { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "نام امانت گیرنده را وارد نمایید"); textBox_RentPersonCode.Focus(); return false; }
           if (checkBox_DriverUse.Checked && textBox_DriverCode.Text == "")
           { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "نام راننده را وارد نمایید"); button_DriverCode.Focus(); return false; }

           if(_rentType != 1)
               if (textBox_CarFaceDsc.Tag == null || textBox_CarFaceDsc.Tag.ToString() == "0")
               { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "وضعیت ظاهری را مشخص نمایید"); button_CarFaceDsc.Focus(); return false; }

           if (_rentType == 0) 
               if (textBox_CertifedCode.Tag == null || textBox_CertifedCode.Tag.ToString() == "0")
               { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "وضعیت ضمانت نامه ها را مشخص نمایید"); button_CertifedCode.Focus(); return false; }

           /////check DutyNumber
           if (_rentType == 0 && (_newOrEditDuty || (!_newOrEditDuty && EditِDutyNumber != textBoxDutyNumber.Text)))
           {
               int ExistDutyNumber = 0;
               try
               {
                   ExistDutyNumber = (from prd in DCMD.TBL_CarDuties
                                      where prd.DutyNumber == textBoxDutyNumber.Text
                                      select prd.DutyNumber).Count();
               }
               catch { }

               if (ExistDutyNumber == 0)
                   try
                   {
                       ExistDutyNumber = (from prd in DCMD.TBL_DelCarDuties
                                          where prd.DutyNumber == textBoxDutyNumber.Text
                                          select prd.DutyNumber).Count();
                   }
                   catch { }

               if (ExistDutyNumber > 0)
               { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "کد سرویس تکراری است"); textBoxDutyNumber.Focus(); return false; }
           }
           /////check DutyNumber

           if (_rentType != 2)
           {
               if (textBox_TotalPrice.Text == "" || textBox_TotalPrice.Text == "0") { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "جمع کل محاسبه نشده است!"); textBox_TotalPrice.Focus(); return false; }
               if (textBoxMod.Text != "" && textBoxMod.Text != "0") { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "مبالغ پرداختی با مبلغ کل متفاوت است!"); textBox_TotalPrice.Focus(); return false; }
           }
           else
           {
               if (textBoxRejectFineAllPrice.Text == "" || textBoxRejectFineAllPrice.Text == "0") { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "جمع کل محاسبه نشده است!"); textBoxRejectFineAllPrice.Focus(); return false; }
               if (textBox_ModBack.Text != "" && textBox_ModBack.Text != "0") { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "مبالغ پرداختی با مبلغ کل متفاوت است!"); textBoxRejectFineAllPrice.Focus(); return false; }
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

            if (sender == textBox_TotalPrice)
                textBoxMod.Text = Global_Cls.DigitSeparator((double.Parse((textBox_TotalPrice.Text==""?"0":textBox_TotalPrice.Text).Replace(",", "")) - double.Parse((textBoxMod.Tag ?? 0).ToString())).ToString());
            if (sender == textBoxRejectFineAllPrice)
                textBox_ModBack.Text = Global_Cls.DigitSeparator((double.Parse((textBoxRejectFineAllPrice.Text==""?"0":textBoxRejectFineAllPrice.Text).Replace(",", "")) - double.Parse((textBox_ModBack.Tag ?? 0).ToString())).ToString());
                    
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

        ComboBox CB = new ComboBox();
        private void comboBox_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            CB = (ComboBox)sender;
            if ((CB.Text.Contains(".") && e.KeyChar == '.')
                || (!System.Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Back && e.KeyChar != '.'))
            { e.KeyChar = '\0'; return; }
        }


        private void panel_DutyDate_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_MonthDD.Text) > 6 && Convert.ToInt16(comboBox_DayDD.Text) == 31) comboBox_DayDD.Text = "30";
            if (Convert.ToInt16(comboBox_MonthDD.Text) == 12 && (Convert.ToInt16(comboBox_DayDD.Text) == 31 || Convert.ToInt16(comboBox_DayDD.Text) == 30)) comboBox_DayDD.Text = "29";
        }

        private void panel_DeliveryDate_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_MonthDL.Text) > 6 && Convert.ToInt16(comboBox_DayDL.Text) == 31) comboBox_DayDL.Text = "30";
            if (Convert.ToInt16(comboBox_MonthDL.Text) == 12 && (Convert.ToInt16(comboBox_DayDL.Text) == 31 || Convert.ToInt16(comboBox_DayDL.Text) == 30)) comboBox_DayDL.Text = "29";
            try
            {
                Global_Cls.ShamsiDateToMiladi(comboBox_YearDL.Text, comboBox_MonthDL.Text, comboBox_DayDL.Text);
            }
            catch 
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "تاریخ غلط است");
                comboBox_YearDL.Focus();
                return;
            }
        }
        
        private void panel_RejectDate_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_MonthRD.Text) > 6 && Convert.ToInt16(comboBox_DayRD.Text) == 31) comboBox_DayRD.Text = "30";
            if (Convert.ToInt16(comboBox_MonthRD.Text) == 12 && (Convert.ToInt16(comboBox_DayRD.Text) == 31 || Convert.ToInt16(comboBox_DayRD.Text) == 30)) comboBox_DayRD.Text = "29";

            //saeed
            if (nUpDownMounthlyPeriod.Value == 0 && nUpDownDailyPeriod.Value == 0)
            {
                nUpDownMounthlyPeriod.Value = Int16.Parse(comboBox_MonthRD.Text) - Int16.Parse(comboBox_MonthDL.Text);
                if (Int16.Parse(comboBox_DayRD.Text) - Int16.Parse(comboBox_DayDL.Text) > 0 && Int16.Parse(comboBox_MonthRD.Text) == Int16.Parse(comboBox_MonthDL.Text))
                {
                    nUpDownDailyPeriod.Value = Int16.Parse(comboBox_DayRD.Text) - Int16.Parse(comboBox_DayDL.Text);
                }
                else
                {
                    int u = (Int16.Parse(nUpDownMounthlyPeriod.Value.ToString()) - 1) * 30;
                    int i = u - Int16.Parse(comboBox_DayDL.Text);
                    try { nUpDownDailyPeriod.Value = Int16.Parse(comboBox_DayRD.Text) + i; }
                    catch { }
                }
            }
            //saeed
        }

        private void panel_DutyDate1_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_MonthDD1.Text) > 6 && Convert.ToInt16(comboBox_DayDD1.Text) == 31) comboBox_DayDD1.Text = "30";
            if (Convert.ToInt16(comboBox_MonthDD1.Text) == 12 && (Convert.ToInt16(comboBox_DayDD1.Text) == 31 || Convert.ToInt16(comboBox_DayDD1.Text) == 30)) comboBox_DayDD1.Text = "29";
        }

        private void panelRealRejectDate_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_MonthRRD.Text) > 6 && Convert.ToInt16(comboBox_DayRRD.Text) == 31) comboBox_DayRRD.Text = "30";
            if (Convert.ToInt16(comboBox_MonthRRD.Text) == 12 && (Convert.ToInt16(comboBox_DayRRD.Text) == 31 || Convert.ToInt16(comboBox_DayRRD.Text) == 30)) comboBox_DayRRD.Text = "29";
        }

        private void panel_RejectDate1_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_MonthRD1.Text) > 6 && Convert.ToInt16(comboBox_DayRD1.Text) == 31) comboBox_DayRD1.Text = "30";
            if (Convert.ToInt16(comboBox_MonthRD1.Text) == 12 && (Convert.ToInt16(comboBox_DayRD1.Text) == 31 || Convert.ToInt16(comboBox_DayRD1.Text) == 30)) comboBox_DayRD1.Text = "29";
        }


        private void DutyNE_frm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Tab)
            {
                if (tabControl_DutyNE.SelectedTabIndex == tabControl_DutyNE.Tabs.Count - 1)
                    tabControl_DutyNE.SelectedTabIndex = 0;
                else
                    tabControl_DutyNE.SelectNextTab();
            }
        }

        private void DutyNE_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Global_Cls.MainForm.CloseAllOK && !CloseOK && !Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, "آیا از این فرم خارج می شوید؟"))
                e.Cancel = true;
            else if (_newOrEditDuty && !CloseOK)
            {
                if (textBox_CarFaceDsc.Tag != null)
                {
                    TBL_CarFace tcf = DCMD.TBL_CarFaces.First(vg => vg.CarFaceID.Equals(textBox_CarFaceDsc.Tag));
                    DCMD.TBL_CarFaces.DeleteOnSubmit(tcf);
                    DCMD.SubmitChanges();
                }
                if (textBox_CertifedCode.Tag != null)
                {
                    TBL_Certificate tcc = DCMD.TBL_Certificates.First(vg => vg.CertificateCode.Equals(textBox_CertifedCode.Tag));
                    DCMD.TBL_Certificates.DeleteOnSubmit(tcc);
                    DCMD.SubmitChanges();
                }

                var SUS1 = (from prd in DCMD.TBL_CarSubRPs
                            where prd.CarID == _carID && prd.SubCarCode == _dutyCode && prd.TypeCode == 1
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
      

        private void buttonItemClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox_DutyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _dutyType = comboBox_DutyType.SelectedIndex;
            label_DutyType.Text = comboBox_DutyType.Text;
        }

        #endregion



        #region Select 

        private void button_OperatorCode_Click(object sender, EventArgs e)
        {
            SelectPerson_frm sp = new SelectPerson_frm(1);
            sp.ShowDialog();
            if (sp.CodeC != 0)
            {
                textBox_OperatorCode.Tag = sp.CodeC;
                textBox_OperatorCode.Text = sp.NameC;
            }
        }

        private void button_RenterCode_Click(object sender, EventArgs e)
        {
            SelectPerson_frm sp = new SelectPerson_frm(0);
            sp.ShowDialog();
            if (sp.CodeC != 0)
            {
                textBox_RenterCode.Tag = sp.CodeC;
                textBox_RenterCode.Text = sp.NameC;
            }
        }

        private void button_RentPersonCode_Click(object sender, EventArgs e)
        {
            int code = 0;
            if (_dutyType == 5) code = 3;
            SelectPerson_frm sp = new SelectPerson_frm(0, code);
            sp.ShowDialog();
            if (sp.CodeC != 0)
            {
                textBox_RentPersonCode.Tag = sp.CodeC;
                textBox_RentPersonCode.Text = sp.NameC;
            }
        }

        private void button_CarID_Click(object sender, EventArgs e)
        {
            SelectPerson_frm sp = new SelectPerson_frm(2);
            sp.ShowDialog();
            if (sp.CodeC != 0)
            {
                textBox_CarID.Tag = sp.CodeC;
                textBox_CarID.Text = sp.NameC;
                _carID = sp.CodeC;

                try
                {
                    var MaxID = (from prd in DCMD.TBL_CarDuties
                                 where prd.CarID == _carID
                                 select prd.DutyCode).Max();
                    _dutyCode = MaxID + 1;
                }
                catch
                {
                    _dutyCode = 1;
                }
            }
        }

        bool NewEditCarFace, NewEditCerticate;
        private void button_CarFaceDsc_Click(object sender, EventArgs e)
        {
            if (_carID == 0)
            { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "نام اتومبیل را وارد نمایید"); button_CarID.Focus(); return; }

            int CarFaceDsc = int.Parse((textBox_CarFaceDsc.Tag ?? 0).ToString());
            if (_newOrEditDuty && CarFaceDsc == 0 && (_rentType == 1 || _rentType == 2))
                CarFaceDsc = CarFaceDscTag;

            CarFace_frm cf = new CarFace_frm(NewEditCarFace, CarFaceDsc, _rentType + 2, _carID, textBox_CarID.Text, false);
            if (cf.ShowDialog() == DialogResult.OK)
            {
                textBox_CarFaceDsc.Tag = cf._carFaceCode.ToString();
                try
                {
                    DataClasses_MainDataContext DCMD1 = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
                    textBox_KMUse.Text = (DCMD1.TBL_CarFaces.First(Cr => Cr.CarFaceID.Equals(cf._carFaceCode)).KilometerUse).ToString();
                    textBox_Oil.Text = (DCMD1.TBL_CarFaces.First(Cr => Cr.CarFaceID.Equals(cf._carFaceCode)).OilUse).ToString();
                    textBoxRejectConflictPrice.Text = (DCMD1.TBL_CarFaces.First(Cr => Cr.CarFaceID.Equals(cf._carFaceCode)).FaceRepairePrice + DCMD1.TBL_CarFaces.First(Cr => Cr.CarFaceID.Equals(cf._carFaceCode)).TechRepairPrice).ToString();
                    
                    var pp = (from str in DCMD1.SP_SetCarFaceView(cf._carFaceCode) select new{str.CarFaceDscStr}).Single();

                    textBox_CarFaceDsc.Text = pp.CarFaceDscStr;
                    NewEditCarFace = false;
                }
                catch { }
            }
        }

        private void button_CertifedCode_Click(object sender, EventArgs e)
        {
            if (_carID == 0)
            { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "نام اتومبیل را وارد نمایید"); button_CarID.Focus(); return; }
            
            int CertifedCode = int.Parse((textBox_CertifedCode.Tag ?? 0).ToString());
            if (_newOrEditDuty && CertifedCode == 0 && (_rentType == 1 || _rentType == 2))
                CertifedCode = CertifedCodeTag;

            Certicate_frm cf = new Certicate_frm(NewEditCerticate, CertifedCode, _dutyType, _rentType, _carID);
            if (cf.ShowDialog() == DialogResult.OK)
            {
                textBox_CertifedCode.Tag = cf._certicateCode.ToString();
                try
                {
                    DataClasses_MainDataContext DCMD1 = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
                    var pp = (from str in DCMD1.SP_SetCertificateView(cf._certicateCode) select new { str.CertificateDsc}).Single();

                    textBox_CertifedCode.Text = pp.CertificateDsc;
                    NewEditCerticate = false;
                }
                catch { }
            }
        }

        private void button_DriverCode_Click(object sender, EventArgs e)
        {
            SelectPerson_frm sp = new SelectPerson_frm(1);
            sp.ShowDialog();
            if (sp.CodeC != 0)
            {
                textBox_DriverCode.Tag = sp.CodeC;
                textBox_DriverCode.Text = sp.NameC;
                checkBox_DriverUse.Checked = true;
            }
        }
        
        #endregion

        private void checkBoxKM_Click(object sender, EventArgs e)
        {
            textBox_TotalPrice.Text = "0";
            if (checkBoxKM.Checked)
                textBox_TotalPrice.Text = Global_Cls.DigitSeparator((decimal.Parse((textBox_TotalPrice.Text == "" ? "0" : textBox_TotalPrice.Text).Replace(",", "")) + decimal.Parse((textBoxKillometerPrice.Text == "" ? "0" : textBoxKillometerPrice.Text).Replace(",", "")) * nUpDownKMPeriod.Value).ToString());
            if (checkBoxTime.Checked)
                textBox_TotalPrice.Text = Global_Cls.DigitSeparator((decimal.Parse((textBox_TotalPrice.Text == "" ? "0" : textBox_TotalPrice.Text).Replace(",", "")) + decimal.Parse((textBoxTimePrice.Text == "" ? "0" : textBoxTimePrice.Text).Replace(",", "")) * nUpDownTimePeriod.Value).ToString());
            if (checkBoxDaily.Checked)
                textBox_TotalPrice.Text = Global_Cls.DigitSeparator((decimal.Parse((textBox_TotalPrice.Text == "" ? "0" : textBox_TotalPrice.Text).Replace(",", "")) + decimal.Parse((textBoxDailyPrice.Text == "" ? "0" : textBoxDailyPrice.Text).Replace(",", "")) * nUpDownDailyPeriod.Value).ToString());
            if (checkBoxWeekly.Checked)
                textBox_TotalPrice.Text = Global_Cls.DigitSeparator((decimal.Parse((textBox_TotalPrice.Text == "" ? "0" : textBox_TotalPrice.Text).Replace(",", "")) + decimal.Parse((textBoxWeeklyPrice.Text == "" ? "0" : textBoxWeeklyPrice.Text).Replace(",", "")) * nUpDownWeeklyPeriod.Value).ToString());
            if (checkBoxMonthly.Checked)
                textBox_TotalPrice.Text = Global_Cls.DigitSeparator((decimal.Parse((textBox_TotalPrice.Text == "" ? "0" : textBox_TotalPrice.Text).Replace(",", "")) + decimal.Parse((textBoxMonthlyPrice.Text == "" ? "0" : textBoxMonthlyPrice.Text).Replace(",", "")) * nUpDownMounthlyPeriod.Value).ToString());

            textBox_TotalPrice.Text = Global_Cls.DigitSeparator((decimal.Parse((textBox_TotalPrice.Text == "" ? "0" : textBox_TotalPrice.Text).Replace(",", "")) + decimal.Parse((textBoxCarfarePrice.Text == "" ? "0" : textBoxCarfarePrice.Text).Replace(",", ""))).ToString());
        }

        private void nUpDownRejectDelayKM_ValueChanged(object sender, EventArgs e)
        {
            textBoxRejectDelayPrice.Text =
            Global_Cls.DigitSeparator(
                (nUpDownRejectDelayKM.Value * (decimal.Parse(textBox_FineKillometer1.Text.Replace(",", ""))) +
            nUpDownRejectDelayTime.Value * (decimal.Parse(textBox_FineTime1.Text.Replace(",", ""))) +
            nUpDownRejectDelayDay.Value * (decimal.Parse(textBox_FineDay1.Text.Replace(",", "")))).ToString());
        }


        private void buttonCarSubRP_Click(object sender, EventArgs e)
        {
            if (_carID == 0) 
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "ابتدا اتومبیل را مشخص نمایید");
                return;
            }
            if (textBox_RentPersonCode.Tag == null)
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "امانت گیرنده را مشخص نمایید");
                return;
            }
            try
            {
                CarSubRPList_Frm CS = new CarSubRPList_Frm(_carID, _dutyCode, 1, int.Parse(textBox_RentPersonCode.Tag.ToString()));
                CS.ShowDialog();
                textBoxMod.Tag = CS.SumPricePublic;
                textBoxMod.Text = Global_Cls.DigitSeparator((double.Parse(textBox_TotalPrice.Text.Replace(",", "")) - double.Parse((textBoxMod.Tag ?? 0).ToString())).ToString());
            }
            catch { }
        }

        private void buttonRejectSubRP_Click(object sender, EventArgs e)
        {
            if (_carID == 0)
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "ابتدا اتومبیل را مشخص نمایید");
                return;
            }
            if (textBox_RentPersonCode.Tag == null)
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "امانت گیرنده را مشخص نمایید");
                return;
            }

            try
            {
                CarSubRPList_Frm CS = new CarSubRPList_Frm(_carID, _dutyCode, 2, int.Parse(textBox_RentPersonCode.Tag.ToString()));
                CS.ShowDialog();
                textBox_ModBack.Tag = CS.SumPricePublic;
                textBox_ModBack.Text = Global_Cls.DigitSeparator((double.Parse(textBoxRejectFineAllPrice.Text.Replace(",", "")) - double.Parse((textBox_ModBack.Tag ?? 0).ToString())).ToString());
            }
            catch { }
        }

        private void checkBoxAnomaly_CheckedChanged(object sender, EventArgs e)
        {
            textBoxAnomalyPrice.Enabled = checkBoxAnomaly.Checked;
        }

        private void textBoxRejectDelayPrice_Leave(object sender, EventArgs e)
        {
            //if (sender == textBoxAnomalyPrice || sender == textBoxRejectConflictPrice || sender == textBoxRejectDelayPrice)
                textBoxRejectFineAllPrice.Text =
                    Global_Cls.DigitSeparator((double.Parse((textBoxAnomalyPrice.Text == "" ? "0" : textBoxAnomalyPrice.Text).Replace(",", "")) +
                    double.Parse((textBoxRejectConflictPrice.Text == "" ? "0" : textBoxRejectConflictPrice.Text).Replace(",", "")) +
                    double.Parse((textBoxCarfarePrice2.Text == "" ? "0" : textBoxCarfarePrice2.Text).Replace(",", "")) +
                    double.Parse((textBoxRejectDelayPrice.Text == "" ? "0" : textBoxRejectDelayPrice.Text).Replace(",", ""))).ToString());
        }

        private void checkBox_DriverUse_CheckedChanged(object sender, EventArgs e)
        {
            textBoxCarfarePrice.Enabled = checkBox_DriverUse.Checked;
            textBoxCarfarePrice2.Enabled = checkBox_DriverUse.Checked;
        }


    }
}
