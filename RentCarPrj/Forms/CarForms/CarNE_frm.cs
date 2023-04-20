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
    public partial class CarNE_frm : Form
    {

        int _enterType = 0, _carID = 0;
        bool _newOrEditCar = false;
        bool CloseOK = false;

        public CarNE_frm(bool NewOrEditCar, int EnterType, int CarID)
        {
            InitializeComponent();
            _enterType = EnterType;
            _carID = CarID;
            _newOrEditCar = NewOrEditCar;
        }
      
        DataClasses_MainDataContext DCMD = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);


        #region Load Data

        private void CarNE_frm_Load(object sender, EventArgs e)
        {
            var hh = from prd in DCMD.TBL_PrtCountries
                     select new { prd.CountryID, prd.CountryName_Fa};
            comboBox_MadeCountry.DataSource = hh;
            comboBox_MadeCountry.Text = "";

            //var hf = (from prd in DCMD.TBL_Cars
            //          select new { prd.CarType }.CarType).Distinct().ToArray();
            //comboBox_CarType.Items.AddRange(hf);
            //comboBox_CarType.Text = "";
            
            //var hz = (from prd in DCMD.TBL_Cars
            //          select new { prd.RingType }.RingType).Distinct().ToArray();
            //comboBox_RingType.Items.AddRange(hz);
            //comboBox_RingType.Text = "";

            comboBox_EnterType.SelectedIndex = _enterType;
            if (_enterType == 1) label_FName.Text = "نام همکار:";
            
            
            CheckPermission();

            SetData_CarNE();
            NewEditCarFace = _newOrEditCar;

            if (_enterType != 0)
            {
                tabItem_CarEnter.Visible = true;
                tabControlPanel_CarEnter.Visible = true;
                groupPanelCarFace.Visible = false;
                this.Height -= 85;
                checkBoxItem_Rent.Visible = true;
                ShowListCarEnter(1);
                InterFaceChange();
            }
            tabControl_CarNE.SelectedPanel = tabControlPanel_CarEnter;
            tabControl_CarNE.SelectedPanel = tabControlPanel_MainCar;
        }

        private void CheckPermission()
        {
            //            Start Use Permission
            //string UPer = Global_Cls.MainForm.UserPermission;
            //if (UPer != "" && UPer != "admin")
            //{
            //    if (UPer.Contains(checkBox_AddTelNotebook.Name)) checkBox_AddTelNotebook.Enabled = false;
            //    if (UPer.Contains(checkBoxItem_ListCuHouse.Name)) checkBoxItem_ListCuHouse.Enabled = false;
            //}
            //            End Use Permission
        }
        
        string EditCarNumber = "0";
        private void SetData_CarNE()
        {
            if (_enterType == 0)
            {
                textBox_LordCode.Tag = DCMD.TBL_Customers.First(C => C.IsParent == true).CustomerID;
                textBox_LordCode.Text = DCMD.TBL_Customers.First(C => C.IsParent == true).CustomerName;
                button_LordCode.Visible = false;
            }

            if (!_newOrEditCar)
            {
                try
                {
                    TBL_Car tbhf = DCMD.TBL_Cars.First(thfh => thfh.CarID.Equals(_carID));

                    byte[] b = null;
                    if (tbhf.CarPic != null)
                    {
                        b = new byte[tbhf.CarPic.Length];
                        b = tbhf.CarPic.ToArray();
                    }

                    try { pictureBoxCarPic.Image = byteArrayToImage(b); }
                    catch { }


                    if (_enterType == 0)
                    {
                        textBox_CarFaceID.Tag = tbhf.CarFaceID.ToString();
                        textBox_KM.Text = (DCMD.TBL_CarFaces.First(Cr => Cr.CarFaceID.Equals(tbhf.CarFaceID)).KilometerUse).ToString();
                        textBox_Oil.Text = (DCMD.TBL_CarFaces.First(Cr => Cr.CarFaceID.Equals(tbhf.CarFaceID)).OilUse).ToString();

                        var pp = (from str in DCMD.SP_SetCarFaceView(tbhf.CarFaceID) select new { str.CarFaceDscStr }).Single();
                        textBox_CarFaceID.Text = pp.CarFaceDscStr;
                    }
                    

                    string DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhf.CreateDate));
                    comboBox_YearCD.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_MonthCD.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_dayCD.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                    DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhf.ProductDate));
                    comboBox_YearPD.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_MonthPD.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_dayPD.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                    DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhf.InsuranceBodyExpDate));
                    comboBox_YearIB.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_MonthIB.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_dayIB.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                    DateStr = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhf.InsuranceThirdExpDate));
                    comboBox_YearIT.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                    comboBox_MonthIT.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                    comboBox_dayIT.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                    textBoxCarNumber.Text = tbhf.CarNumber;
                    EditCarNumber = textBoxCarNumber.Text;
                    textBox_LordCode.Tag = tbhf.LordCode;
                    textBox_LordCode.Text = DCMD.TBL_Customers.First(Cr => Cr.CustomerID.Equals(tbhf.LordCode)).CustomerName;


                    textBox_BodyNo.Text = tbhf.BodyNO;

                    textBox_DisciplineNO.Text = tbhf.DisciplineNO;
                    textBox_EngineNo.Text = tbhf.EngineNO;

                    textBox_InsuranceBodyPrice.Text = Global_Cls.DigitSeparator(tbhf.InsuranceBodyPrice.ToString());
                    textBox_InsuranceThirdPrice.Text = Global_Cls.DigitSeparator(tbhf.InsuranceThirdPrice.ToString());

                    textBox_PriceRentDay.Text = Global_Cls.DigitSeparator(tbhf.PriceRentDay.ToString());
                    textBox_PriceRentKM.Text = Global_Cls.DigitSeparator(tbhf.PriceRentKM.ToString());

                    textBox_PriceRentTime.Text = Global_Cls.DigitSeparator(tbhf.PriceRentTime.ToString());
                    textBox_RentDescription.Text = tbhf.RentDescription;

                    radioButton_InsuranceBodyOK.Checked = tbhf.InsuranceThird.Value;
                    radioButton_InsuranceBodyNOK.Checked = !tbhf.InsuranceThird.Value;
                    radioButton_InsuranceThirdOK.Checked = tbhf.InsuranceThird.Value;
                    radioButton_InsuranceThirdNOK.Checked = !tbhf.InsuranceThird.Value;

                    comboBox_CarName.Text = tbhf.CarName;
                    comboBox_CarType.Text = tbhf.CarType;
                    comboBox_ColorSet.Text = tbhf.ColorSet;
                    comboBox_MadeCountry.Text = tbhf.MadeCountry;
                    comboBox_RingType.Text = tbhf.RingType;

                    radioButtonProductShamsi.Checked = tbhf.ProductShamsiOrMilladi.Value;
                    radioButtonProductMilladi.Checked = !tbhf.ProductShamsiOrMilladi.Value;
                    DateTimeProductMilladi.Value = tbhf.ProductDateMilladi.Value;

                    textBox_PriceRentWeek.Text = Global_Cls.DigitSeparator(tbhf.PriceRentWeek.ToString());
                    textBox_PriceRentMonth.Text = Global_Cls.DigitSeparator(tbhf.PriceRentMonth.ToString());

                }
                catch (Exception ex)
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اشکال در لود", ex.Message);
                }

            }
            else if (_newOrEditCar)
            {
                try
                {
                    var MaxID = (from prd in DCMD.TBL_Cars
                                 select prd.CarID).Max();
                    var DelMaxID = 0;
                    try
                    {
                        DelMaxID = (from prd in DCMD.TBL_DelCars
                                    select prd.CarID).Max();
                    }
                    catch { }

                    _carID = (MaxID >= DelMaxID ? MaxID : DelMaxID) + 1;
                }
                catch
                {
                    _carID = 1;
                }

                int MaxNumber = 0;
                try
                {
                    MaxNumber = (from prd in DCMD.TBL_Cars
                                 orderby Convert.ToInt32(prd.CarNumber)
                                 select Convert.ToInt32(prd.CarNumber)
                                 ).Max();
                }
                catch { }

                int DelMaxNumber = 0;
                try
                {
                    DelMaxNumber = (from prd in DCMD.TBL_DelCars
                                    orderby Convert.ToInt32(prd.CarNumber)
                                    select Convert.ToInt32(prd.CarNumber)
                                   ).Max();
                }
                catch { }

                try { textBoxCarNumber.Text = MaxNumber.CompareTo(DelMaxNumber) == 1 ? MaxNumber.ToString() : DelMaxNumber.ToString(); }
                catch { }

                try { textBoxCarNumber.Text = (double.Parse(textBoxCarNumber.Text == "" ? "0" : textBoxCarNumber.Text) + 1).ToString(); }
                catch { }

                DateTimeProductMilladi.Text = "2012-01-01";
                
                string DateStr = Global_Cls.MiladiDateToShamsi(DateTime.Today);
                comboBox_YearCD.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                comboBox_MonthCD.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                comboBox_dayCD.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                comboBox_YearPD.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                comboBox_MonthPD.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                comboBox_dayPD.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                comboBox_YearIB.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                comboBox_MonthIB.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                comboBox_dayIB.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

                comboBox_YearIT.Text = Convert.ToInt16(DateStr.Substring(0, 4)).ToString();
                comboBox_MonthIT.Text = Convert.ToInt16(DateStr.Substring(5, 2)).ToString();
                comboBox_dayIT.Text = Convert.ToInt16(DateStr.Substring(8, 2)).ToString();

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
            panel_DateCD_Leave(this, null);
            panel_DateIB_Leave(this, null);
            panel_DateIT_Leave(this, null);
            panel_DatePD_Leave(this, null);


            if (textBoxCarNumber.Text == "" || textBoxCarNumber.Text == "0")
            { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "کد اتومبیل را وارد نمایید"); textBoxCarNumber.Focus(); return false; }
            if (textBox_LordCode.Text == "")
            { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "نام مالک را وارد نمایید"); textBox_LordCode.Focus(); return false; }
            if (comboBox_CarName.Text == "")
            { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "نام اتومبیل را وارد نمایید"); comboBox_CarName.Focus(); return false; }
            if (textBox_BodyNo.Text == "")
            { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "شماره شاسی را وارد نمایید"); textBox_BodyNo.Focus(); return false; }
            if (textBox_EngineNo.Text == "")
            { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "شماره موتور را وارد نمایید"); textBox_EngineNo.Focus(); return false; }
            if (textBox_DisciplineNO.Text == "")
            { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "شماره شهربانی را وارد نمایید"); textBox_DisciplineNO.Focus(); return false; }
            if (_enterType == 0 && textBox_KM.Text == "0" || textBox_KM.Text == "")
            { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "لطفا عدد کیلومتر را وارد نمایید"); button_CarFaceID.Focus(); return false; }
            if (_enterType != 0 && gridView_CarEnterList.RowCount == 0)
            { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "لطفا یک قرارداد ثبت نمایید");  return false; }


            if (_newOrEditCar || (!_newOrEditCar && EditCarNumber != textBoxCarNumber.Text) )
            {
                int ExistCarNumber = 0;
                try
                {
                    ExistCarNumber = (from prd in DCMD.TBL_Cars
                                      where prd.CarNumber == textBoxCarNumber.Text
                                      select prd.CarNumber).Count();
                }
                catch { }

                if (ExistCarNumber == 0)
                    try
                    {
                        ExistCarNumber = (from prd in DCMD.TBL_DelCars
                                          where prd.CarNumber == textBoxCarNumber.Text
                                          select prd.CarNumber).Count();
                    }
                    catch { }

                if (ExistCarNumber > 0)
                { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "کد اتومبیل تکراری است"); textBoxCarNumber.Focus(); return false; }
            }

            
            //System.Data.Linq.Binary b = null;
            //if (pictureBoxCarPic.Image != null)
            //    b = new System.Data.Linq.Binary(imageToByteArray(pictureBoxCarPic.Image));
            
            byte[] b = null;
            if (pictureBoxCarPic.Image != null)
                b = imageToByteArray(pictureBoxCarPic.Image);

            DataClasses_MainDataContext DCD = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            if (_newOrEditCar)
                try
                {
                    TBL_Car THF = new TBL_Car
                    {
                        CarID = _carID,
                        CarPic = b,
                        CarFaceID = int.Parse((textBox_CarFaceID.Tag ?? 0).ToString()),
                        CarNumber = textBoxCarNumber.Text,
                        LordCode = int.Parse((textBox_LordCode.Tag ?? 0).ToString()),
                        CreateDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearCD.Text, comboBox_MonthCD.Text, comboBox_dayCD.Text),//textBox_Date.Text),
                        CarName = comboBox_CarName.Text,
                        CarType = comboBox_CarType.Text,
                        ProductShamsiOrMilladi = radioButtonProductShamsi.Checked,
                        ProductDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearPD.Text, comboBox_MonthPD.Text, comboBox_dayPD.Text),//textBox_Date.Text),
                        ProductDateMilladi = DateTimeProductMilladi.Value,
                        EngineNO = textBox_EngineNo.Text,
                        BodyNO = textBox_BodyNo.Text,
                        DisciplineNO = textBox_DisciplineNO.Text.Replace(" ", ""),
                        MadeCountry = comboBox_MadeCountry.Text,
                        ColorSet = comboBox_ColorSet.Text,
                        RingType = comboBox_RingType.Text,
                        InsuranceThird = radioButton_InsuranceThirdOK.Checked,
                        InsuranceThirdPrice = double.Parse((textBox_InsuranceThirdPrice.Text == "" ? "0" : textBox_InsuranceThirdPrice.Text).Replace(",", "")),
                        InsuranceThirdExpDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearIT.Text, comboBox_MonthIT.Text, comboBox_dayIT.Text),//textBox_Date.Text),

                        InsuranceBody = radioButton_InsuranceBodyOK.Checked,
                        InsuranceBodyPrice = double.Parse((textBox_InsuranceBodyPrice.Text == "" ? "0" : textBox_InsuranceBodyPrice.Text).Replace(",", "")),
                        InsuranceBodyExpDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearIB.Text, comboBox_MonthIB.Text, comboBox_dayIB.Text),//textBox_Date.Text),
                        PriceRentTime = double.Parse((textBox_PriceRentTime.Text).Replace(",", "")),
                        PriceRentDay = double.Parse((textBox_PriceRentDay.Text).Replace(",", "")),
                        PriceRentKM = double.Parse((textBox_PriceRentKM.Text).Replace(",", "")),
                        PriceRentMonth = double.Parse((textBox_PriceRentMonth.Text).Replace(",", "")),
                        PriceRentWeek = double.Parse((textBox_PriceRentWeek.Text).Replace(",", "")),
                        RentDescription = textBox_RentDescription.Text,
                        EnterType = _enterType,
                    };
                    if (radioButton_InsuranceThirdOK.Checked == true)
                        THF.InsuranceBody = true;
                    else
                        THF.InsuranceBody = false;
                    if (radioButton_InsuranceBodyOK.Checked == true)
                        THF.InsuranceBody = true;
                    else
                        THF.InsuranceBody = false;
                    DCD.TBL_Cars.InsertOnSubmit(THF);
                    DCD.SubmitChanges();

                    Global_Cls.CarLayout = true;
                }
                catch (Exception ex)
                {
                    if (ex.Message.IndexOf("Duplicated Row!") > -1)
                        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اطلاعات وارد شده تکراری است!");
                    else if (ex.Message.IndexOf("Duplicated Tbl_Del!") > -1)
                        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اطلاعات وارد شده در حذفیات وجود دارد!");
                    else
                        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "لطفا با کمی فاصله دوباره تایید کنید!", ex.Message);

                    return false;
                }
            else
                if (!_newOrEditCar)
                    try
                    {
                        TBL_Car tbhf = DCD.TBL_Cars.First(thfh => thfh.CarID.Equals(_carID));
                        try { tbhf.CarPic = b; }
                        catch { }
                        tbhf.CarNumber = textBoxCarNumber.Text;
                        tbhf.CarFaceID = int.Parse((textBox_CarFaceID.Tag ?? 0).ToString());
                        tbhf.LordCode = int.Parse((textBox_LordCode.Tag ?? 0).ToString());
                        tbhf.CreateDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearCD.Text, comboBox_MonthCD.Text, comboBox_dayCD.Text);
                        tbhf.CarName = comboBox_CarName.Text;
                        tbhf.CarType = comboBox_CarType.Text;
                        tbhf.ProductShamsiOrMilladi = radioButtonProductShamsi.Checked;
                        tbhf.ProductDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearPD.Text, comboBox_MonthPD.Text, comboBox_dayPD.Text);
                        tbhf.ProductDateMilladi = DateTimeProductMilladi.Value;
                        tbhf.EngineNO = textBox_EngineNo.Text;
                        tbhf.BodyNO = textBox_BodyNo.Text;
                        tbhf.DisciplineNO = textBox_DisciplineNO.Text.Replace(" ", "");
                        tbhf.MadeCountry = comboBox_MadeCountry.Text;
                        tbhf.ColorSet = comboBox_ColorSet.Text;
                        tbhf.RingType = comboBox_RingType.Text;

                        tbhf.InsuranceThirdPrice = double.Parse(textBox_InsuranceThirdPrice.Text.Replace(",", ""));
                        tbhf.InsuranceThirdExpDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearIT.Text, comboBox_MonthIT.Text, comboBox_dayIT.Text);
                        tbhf.InsuranceBodyPrice = double.Parse(textBox_InsuranceBodyPrice.Text.Replace(",", ""));
                        tbhf.InsuranceBodyExpDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearIB.Text, comboBox_MonthIB.Text, comboBox_dayIB.Text);
                        tbhf.InsuranceThird = radioButton_InsuranceThirdOK.Checked;
                        tbhf.InsuranceBody = radioButton_InsuranceBodyOK.Checked;

                        tbhf.PriceRentTime = double.Parse(textBox_PriceRentTime.Text.Replace(",", ""));
                        tbhf.PriceRentDay = double.Parse(textBox_PriceRentDay.Text.Replace(",", ""));
                        tbhf.PriceRentKM = double.Parse(textBox_PriceRentKM.Text.Replace(",", ""));
                        tbhf.PriceRentWeek = double.Parse(textBox_PriceRentWeek.Text.Replace(",", ""));
                        tbhf.PriceRentMonth = double.Parse(textBox_PriceRentMonth.Text.Replace(",", ""));
                        tbhf.RentDescription = textBox_RentDescription.Text;
                        DCD.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.IndexOf("Duplicated Row!") > -1)
                            Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اطلاعات وارد شده تکراری است!");
                        else if (ex.Message.IndexOf("Duplicated Tbl_Del!") > -1)
                            Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اطلاعات وارد شده در حذفیات وجود دارد!");
                        else
                            Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "لطفا با کمی فاصله دوباره تایید کنید!", ex.Message);

                        return false;
                    }

            this.TopMost = false;
            if (checkBoxItem_CarFace.Checked)
            {
                var g = (from prd in DCMD.TBL_CarEnters
                      where prd.CarID == _carID
                      select prd.CarFaceID).Max();
                try
                {
                    Report.MoshakhasatZaheri RAIF = new Report.MoshakhasatZaheri(
                        _enterType == 0 ? int.Parse(textBox_CarFaceID.Tag.ToString()) : g.Value);
                    
                    PrintPreview_frm ppf = new PrintPreview_frm(RAIF);
                    ppf.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }

            }

            if (checkBoxItem_Rent.Visible && checkBoxItem_Rent.Checked)
            {
                try
                {
                    Report.EjareNameAvalieh RAIF = new Report.EjareNameAvalieh(_carID);

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

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
            return ms.ToArray();
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
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


        private void panel_DateCD_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_MonthCD.Text) > 6 && Convert.ToInt16(comboBox_dayCD.Text) == 31) comboBox_dayCD.Text = "30";
            if (Convert.ToInt16(comboBox_MonthCD.Text) == 12 && (Convert.ToInt16(comboBox_dayCD.Text) == 31 || Convert.ToInt16(comboBox_dayCD.Text) == 30)) comboBox_dayCD.Text = "29";
        }

        private void panel_DateIB_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_MonthIB.Text) > 6 && Convert.ToInt16(comboBox_dayIB.Text) == 31) comboBox_dayIB.Text = "30";
            if (Convert.ToInt16(comboBox_MonthIB.Text) == 12 && (Convert.ToInt16(comboBox_dayIB.Text) == 31 || Convert.ToInt16(comboBox_dayIB.Text) == 30)) comboBox_dayIB.Text = "29";
        }

        private void panel_DateIT_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_MonthIT.Text) > 6 && Convert.ToInt16(comboBox_dayIT.Text) == 31) comboBox_dayIT.Text = "30";
            if (Convert.ToInt16(comboBox_MonthIT.Text) == 12 && (Convert.ToInt16(comboBox_dayIT.Text) == 31 || Convert.ToInt16(comboBox_dayIT.Text) == 30)) comboBox_dayIT.Text = "29";
        }


        private void panel_DatePD_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_MonthPD.Text) > 6 && Convert.ToInt16(comboBox_dayPD.Text) == 31) comboBox_dayPD.Text = "30";
            if (Convert.ToInt16(comboBox_MonthPD.Text) == 12 && (Convert.ToInt16(comboBox_dayPD.Text) == 31 || Convert.ToInt16(comboBox_dayPD.Text) == 30)) comboBox_dayPD.Text = "29";
        }


        private void CarNE_frm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Tab)
            {
                if (tabControl_CarNE.SelectedTabIndex == tabControl_CarNE.Tabs.Count - 1)
                    tabControl_CarNE.SelectedTabIndex = 0;
                else
                    tabControl_CarNE.SelectNextTab();
            }
        }

        private void CarNE_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Global_Cls.MainForm.CloseAllOK && !CloseOK && !Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, "آیا از این فرم خارج می شوید؟"))
                e.Cancel = true;
            else if (_newOrEditCar && !CloseOK)
            {
                if (textBox_CarFaceID.Tag != null)
                {
                    TBL_CarFace tcf = DCMD.TBL_CarFaces.First(vg => vg.CarFaceID.Equals(textBox_CarFaceID.Tag));
                    DCMD.TBL_CarFaces.DeleteOnSubmit(tcf);
                    DCMD.SubmitChanges();
                }
                if (!PermissionAdd)
                {
                    var SUS = (from prd in DCMD.TBL_CarEnters
                               where prd.CarID == _carID
                               orderby prd.CarEnterID descending
                               select new { prd.CarEnterID, prd.CarFaceID, prd }).Single();

                    try
                    {
                        TBL_CarFace tcf = DCMD.TBL_CarFaces.First(vg => vg.CarFaceID.Equals(SUS.CarFaceID));
                        DCMD.TBL_CarFaces.DeleteOnSubmit(tcf);
                        DCMD.SubmitChanges();
                    }
                    catch { }

                    var SUS1 = (from prd in DCMD.TBL_CarSubRPs
                                where prd.CarID == _carID && prd.SubCarCode == SUS.CarEnterID && prd.TypeCode == 0
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

                    try
                    {
                        TBL_CarEnter tce = DCMD.TBL_CarEnters.First(vg => vg.CarEnterID.Equals(SUS.CarEnterID) && vg.CarID == _carID);
                        DCMD.TBL_CarEnters.DeleteOnSubmit(tce);
                        DCMD.SubmitChanges();
                        
                    }
                    catch { }

                }
            }

        }

        #endregion


        #region All Button

        private void button_LordCode_Click(object sender, EventArgs e)
        {
            int code = 0;
            if (_enterType == 1) code = 3;
            if (_enterType == 2) code = 2;

            SelectPerson_frm sp = new SelectPerson_frm(0, code);
            sp.ShowDialog();
            if (sp.CodeC != 0)
            {
                textBox_LordCode.Tag = sp.CodeC;
                textBox_LordCode.Text = sp.NameC;
            }
        }

        bool NewEditCarFace;
        private void button_CarFaceID_Click(object sender, EventArgs e)
        {
            CarFace_frm cf = new CarFace_frm(NewEditCarFace, int.Parse((textBox_CarFaceID.Tag ?? 0).ToString()), 0, _carID, comboBox_CarName.Text, false);
            if (cf.ShowDialog() == DialogResult.OK)
            {

                textBox_CarFaceID.Tag = cf._carFaceCode.ToString();
                try
                {
                    DataClasses_MainDataContext DCMD1 = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
                    textBox_KM.Text = (DCMD1.TBL_CarFaces.First(Cr => Cr.CarFaceID.Equals(cf._carFaceCode)).KilometerUse).ToString();
                    textBox_Oil.Text = (DCMD1.TBL_CarFaces.First(Cr => Cr.CarFaceID.Equals(cf._carFaceCode)).OilUse).ToString();

                    var pp = (from str in DCMD1.SP_SetCarFaceView(cf._carFaceCode) select new { str.CarFaceDscStr }).Single();

                    textBox_CarFaceID.Text = pp.CarFaceDscStr;
                    NewEditCarFace = false;

                }
                catch { }
            }
        }

        private void pictureBoxCarPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "All Image File|*.Jpg;*.Jpeg;*.bmp;*.png;*.tiff;*.tif;*.gif;*.ico";
            if (op.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBoxCarPic.Image = System.Drawing.Image.FromFile(op.FileName);
                }
                catch
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, " مسیر فایل و یا سورس فایل نامعتبر است. دوباره سعی کنید ");
                }
            }
        }

        private void button_DelPic_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBoxCarPic.Image = null;
                pictureBoxCarPic.Load("");
            }
            catch { }
        }

        private void buttonItem_Close_Click(object sender, EventArgs e)
        {
            Close();
        }


        #endregion


        #region Car Enter

        private void InterFaceChange()
        {

            //string UPer = Global_Cls.MainForm.UserPermission;
            //if (UPer != "" && UPer != "admin")
            //{
            //    if (UPer.Contains(button_Transmutation.Name + FileStatus.ToString())) button_Transmutation.Enabled = false;
            //    if (UPer.Contains(buttonItem_Active.Name + FileStatus.ToString())) buttonItem_Active.Enabled = false;
            //    if (UPer.Contains(buttonItem_NonActive.Name + FileStatus.ToString())) buttonItem_NonActive.Enabled = false;
            //    if (UPer.Contains(buttonItem_Del.Name + FileStatus.ToString())) buttonItem_Del.Enabled = false;
            //    if (UPer.Contains(buttonItem_ForMemorundom.Name + FileStatus.ToString())) buttonItem_ForMemorundom.Enabled = false;
            //    if (UPer.Contains(button_ShiftDel.Name)) button_ShiftDel.Enabled = false;
            //}
        }

        private void ShowListCarEnter(int RowFocus)
        {
            var SUS = from prd in DCMD.TBL_CarEnters
                      where prd.CarID == _carID
                      select new
                      {
                          prd.CarID,
                          prd.CarEnterID,
                          prd.CarEnterNumber,
                          StartEnterDate = Global_Cls.MiladiDateToShamsi(prd.StartEnterDate.Value),
                          EndEnterDate = Global_Cls.MiladiDateToShamsi(prd.EndEnterDate.Value),

                          prd.CertifiedDsc,

                          RenterName = (DCMD.TBL_Customers.First(Cr => Cr.CustomerID.Equals(prd.RenterCode)).CustomerName),
                          prd.TotalPrice,
                          NowKM = (DCMD.TBL_CarFaces.First(Cr => Cr.CarFaceID.Equals(prd.CarFaceID)).KilometerUse),
                          prd.EnterType,
                          prd.CarFaceID
                      };
            gridControl_CarEnterList.DataSource = SUS;
            gridView_CarEnterList.FocusedRowHandle = RowFocus;
        }


        private void buttonItemSelector_Click(object sender, EventArgs e)
        {
            gridView_CarEnterList.ColumnsCustomization(new Point(100, 100));
        }

        private void buttonItemCarEnterSearch_Click(object sender, EventArgs e)
        {
            gridView_CarEnterList.OptionsView.ShowAutoFilterRow = !gridView_CarEnterList.OptionsView.ShowAutoFilterRow;
        }

        private void buttonItemCarEnterPrintList_Click(object sender, EventArgs e)
        {
            gridControl_CarEnterList.ShowPreview();
        }
        
        bool PermissionAdd = true;
        private void buttonItemAddCarEnter_Click(object sender, EventArgs e)
        {
            int Index = gridView_CarEnterList.FocusedRowHandle;
            if (textBox_LordCode.Text == "")
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, " لطفا نام مالک (طرف قرارداد) را مشخص نمایید ");
                return;
            }
            CarEnterNE_frm Uc = new CarEnterNE_frm(true, 0, _carID, int.Parse(textBox_LordCode.Tag.ToString()), textBox_LordCode.Text);
            if (Uc.ShowDialog() == DialogResult.OK)
            {
                PermissionAdd = false;

                ShowListCarEnter(gridView_CarEnterList.RowCount);
            }
            else
                ShowListCarEnter(Index);
        }

        private void buttonItemEditCarEnter_Click(object sender, EventArgs e)
        {
            if (gridView_CarEnterList.RowCount == 0) return;

            int Index = gridView_CarEnterList.FocusedRowHandle;

            CarEnterNE_frm Uc = new CarEnterNE_frm(false,
                Convert.ToInt32(gridView_CarEnterList.GetRowCellValue(Index, "CarEnterID")), _carID, 0, "");
            Uc.ShowDialog();
            ShowListCarEnter(Index);
            
        }

        private void buttonItemDelCarEnter_Click(object sender, EventArgs e)
        {
            if (gridView_CarEnterList.RowCount == 0) return;

            int Index = gridView_CarEnterList.FocusedRowHandle;
            int CarEnterID = Convert.ToInt32(gridView_CarEnterList.GetRowCellValue(Index, "CarEnterID"));
            int CarFaceID = Convert.ToInt32(gridView_CarEnterList.GetRowCellValue(Index, "CarFaceID"));

            if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این قرارداد حذف شود؟")) return;
            
            
            try
            {
                TBL_CarFace tcf = DCMD.TBL_CarFaces.First(vg => vg.CarFaceID.Equals(CarFaceID));
                DCMD.TBL_CarFaces.DeleteOnSubmit(tcf);
                DCMD.SubmitChanges();
            }
            catch { }

            var SUS1 = (from prd in DCMD.TBL_CarSubRPs
                        where prd.CarID == _carID && prd.SubCarCode == CarEnterID && prd.TypeCode == 0
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

            try
            {
                TBL_CarEnter tce = DCMD.TBL_CarEnters.First(vg => vg.CarEnterID.Equals(CarEnterID) && vg.CarID == _carID);
                DCMD.TBL_CarEnters.DeleteOnSubmit(tce);
                DCMD.SubmitChanges();
            }
            catch { }


            try { ShowListCarEnter(Index - 1); }
            catch { }
        }
        #endregion

        private void tabControlPanel_CarEnter_Layout(object sender, LayoutEventArgs e)
        {
            try
            {
                ShowListCarEnter(gridView_CarEnterList.RowCount);
            }
            catch { }
        }

        private void gridView_CarEnterList_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int Index = gridView_CarEnterList.FocusedRowHandle;
            int CarEnterID = Convert.ToInt32(gridView_CarEnterList.GetRowCellValue(Index, "CarEnterID"));
            var SUS = (from prd in DCMD.TBL_CarEnters
                       where prd.CarID == _carID
                       select prd.CarEnterID).Max();
            
            buttonItemDelCarEnter.Enabled = CarEnterID == SUS;
            buttonItemEditCarEnter.Enabled = CarEnterID == SUS;
            buttonItemAddCarEnter.Enabled = PermissionAdd;
        }

        private void buttonItemEndCarEnter_Click(object sender, EventArgs e)
        {
            if (gridView_CarEnterList.RowCount == 0) return;
            int Index = gridView_CarEnterList.FocusedRowHandle;
            int CarEnterID = Convert.ToInt32(gridView_CarEnterList.GetRowCellValue(Index, "CarEnterID"));
            
            if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا به اتمام این قرارداد مطمئنید؟")) return;
            TBL_CarEnter thsf = DCMD.TBL_CarEnters.First(hf =>
                            hf.CarID.Equals(_carID) && hf.CarEnterID.Equals(CarEnterID));
            thsf.EnterType = 2;
            DCMD.SubmitChanges();
        }

        private void radioButtonProductMilladi_CheckedChanged(object sender, EventArgs e)
        {
            DateTimeProductMilladi.Enabled = radioButtonProductMilladi.Checked;
        }

        private void radioButtonProductShamsi_CheckedChanged(object sender, EventArgs e)
        {
            panel_ProductDate.Enabled = radioButtonProductShamsi.Checked;
        }

        private void textBox_DisciplineNO_Enter(object sender, EventArgs e)
        {
            textBox_DisciplineNO.SelectAll();
        }

        private void textBox_BodyNo_Enter(object sender, EventArgs e)
        {
            Global_Cls.GetFarsiOrLatinLanguage("En");
        }

        private void textBox_BodyNo_Leave(object sender, EventArgs e)
        {
            Global_Cls.GetFarsiOrLatinLanguage("Fa");
        }



    }
}
