using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RentCarPrj.Properties;
using Microsoft.VisualBasic.FileIO;
using System.IO;
using System.Data.SqlClient;
using RentCarPrj.DataLinq;

namespace RentCarPrj
{
    public partial class Setting_frm : Form
    {
        public Setting_frm()
        {
            InitializeComponent();
        }

        DataClasses_MainDataContext DMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
        private bool CloseOK = false;


        #region Load & UI
        private void Setting_frm_Load(object sender, EventArgs e)
        {
            var SUS = from prd in DMDC.TBL_PrtCities
                      orderby prd.CityName_Fa
                      select prd;
            ComboBoxBrithCityName.DataSource = SUS;
            comboBox_CityLimit.DataSource = SUS;

            
            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains("Node_SetUnits")) treeView_Setting.Nodes["Node_FSet"].Nodes["Node_SetUnits"].Remove();
                if (UPer.Contains("Node_SetPosDef")) treeView_Setting.Nodes["Node_FSet"].Nodes["Node_SetPosDef"].Remove();
                if ((UPer.Contains("Node_SetPosDef") && UPer.Contains("Node_SetUnits")) || UPer.Contains("Node_FSet")) treeView_Setting.Nodes["Node_FSet"].Remove();
                if (UPer.Contains("Node_SetAlarms")) treeView_Setting.Nodes["Node_SetAlarms"].Remove();
                if (UPer.Contains("Node_SetBkpRst")) treeView_Setting.Nodes["Node_SetBkpRst"].Remove();
                if (UPer.Contains("Node_Sms")) treeView_Setting.Nodes["Node_SetSystem"].Nodes["Node_Sms"].Remove();

            }
            
            treeView_Setting.ExpandAll();
            TreeNodeMouseClickEventArgs a = new TreeNodeMouseClickEventArgs(treeView_Setting.SelectedNode, MouseButtons.Left, 1, 0, 0);
            treeView_Setting_NodeMouseClick(this, a);


            //sms start
            InitializeComboBoxSMS();

            cmbPort.Text = Global_Cls.SMSPort.ToString();
            cmbBaudRate.Text = Global_Cls.SMSBaudRate.ToString();
            cmbDataBits.Text = Global_Cls.SMSDataBits.ToString();
            cmbParity.SelectedIndex = Global_Cls.SMSParity;
            cmbStopBits.SelectedIndex = Global_Cls.SMSStopBits - 1;
            cmbFlowControl.SelectedIndex = Global_Cls.SMSFlowControl;
            cmbTimeOut.Text = Global_Cls.SMSTimeOut.ToString();

            cmbEncoding.SelectedIndex = Global_Cls.SMSEncoding;
            cmbLongMsg.SelectedIndex = Global_Cls.SMSLongMsg;
            chkDeliveryReport.Checked = Global_Cls.SMSDeliveryReport;


            //new 930925
            radioButtonInternet.Checked = Global_Cls.SMSSet;
            radioButtonGSM.Checked = !radioButtonInternet.Checked;
            textBoxUserName.Text = Global_Cls.IntUserName;
            textBoxPassword.Text = Global_Cls.IntPassword;
            textBoxTelNumber.Text = Global_Cls.IntTelNumber;
            textBoxInitSMSMessage.Text = Global_Cls.InitSMSMessage == "" ? textBoxInitSMSMessage.Text : Global_Cls.InitSMSMessage;
            //new 930925


            //sms end 


            //BkpRst start
            label_BkpAuto.Text = Global_Cls.BkpAutoRoot;
            radioButton_BkpAuto.Checked = (Global_Cls.BkpExitType == 2);
            radioButton_BkpNonAuto.Checked = (Global_Cls.BkpExitType == 1);
            radioButton_BkpNo.Checked = (Global_Cls.BkpExitType == 0);
            checkBox_BRPicFilm.Checked = Global_Cls.BkpRstPicsFilms;
            checkBox_BRDesignRep.Checked = Global_Cls.BkpRstDesignReport;
            //BkpRst end

            //All Alarm start
            nUpDownGetFinePeriod.Value = Global_Cls.GetFinePeriod;
            nUpDownExpDayCarEnter.Value = Global_Cls.ExpDayCarEnter;
            nUpDownExpDayBodyInsu.Value = Global_Cls.ExpDayBodyInsu;
            nUpDownExpDayCarDuty.Value = Global_Cls.ExpDayCarDuty;
            nUpDownExpDayThirdInsu.Value = Global_Cls.ExpDayThirdInsu;
            nUpDownExpKMService.Value = Global_Cls.ExpKMService;
            //All Alarm end


            //Set Pos Def start
            nUpDown_FreeKillometer.Value = Global_Cls.FreeKillometer;
            textBox_FineDay.Text = Global_Cls.DigitSeparator(Global_Cls.FineDay.ToString());
            textBox_FineTime.Text = Global_Cls.DigitSeparator(Global_Cls.FineTime.ToString());
            textBox_FineKillometer.Text = Global_Cls.DigitSeparator(Global_Cls.FineKillometer.ToString());
            comboBox_CityLimit.Text = Global_Cls.CityLimit;
            //Set Pos Def end

            //Default value for Start

            try
            {
                TBL_Customer tbhc = DMDC.TBL_Customers.First(thfr => thfr.IsParent == true);
                textBox_CName.Text = tbhc.CustomerName;
                textBox_CoName.Text = tbhc.AddressBusiness;
                textBox_CParentN.Text = tbhc.ParentName;
                textBox_CIDNO.Text = tbhc.IDNO.ToString();
                textBox_CNationalCode.Text = tbhc.NationalCode;
                ComboBoxBrithCityName.Text = tbhc.BrithCityName;
                string DateStr1 = Global_Cls.MiladiDateToShamsi(Convert.ToDateTime(tbhc.BrithDate));
                comboBox_YearBD.Text = Convert.ToInt16(DateStr1.Substring(0, 4)).ToString();
                comboBox_MonthBD.Text = Convert.ToInt16(DateStr1.Substring(5, 2)).ToString();
                comboBox_DayBD.Text = Convert.ToInt16(DateStr1.Substring(8, 2)).ToString();
                textBox_Address.Text = tbhc.Address;
                textBox_Tel.Text = tbhc.Tel;
                textBox_mobile.Text = tbhc.Mobile;
                textBox_EMail.Text = tbhc.Email;
            }
            catch
            {
                string DateStr1 = Global_Cls.MiladiDateToShamsi(DateTime.Now);
                comboBox_YearBD.Text = Convert.ToInt16(DateStr1.Substring(0, 4)).ToString();
                comboBox_MonthBD.Text = Convert.ToInt16(DateStr1.Substring(5, 2)).ToString();
                comboBox_DayBD.Text = Convert.ToInt16(DateStr1.Substring(8, 2)).ToString();
            }
           
            pictureBoxCarPic.ImageLocation = Global_Cls.RootSaveLoad() + "\\PicsFilms\\Logo.jpg";
            //
           
            
            //codeing
            if (!Global_Cls.SoftwareCode.Contains("+S"))
            {
                treeView_Setting.Nodes["Node_SetSystem"].Nodes["Node_Sms"].Remove();
            }
            if (Global_Cls.SoftwareCode.Contains("L1") || Global_Cls.SoftwareCode.Contains("N1") || Global_Cls.SoftwareCode == "Trial")
                treeView_Setting.Nodes["Node_SetOther"].Nodes["Node_SetAlarms"].Remove();

            ////                if ("L1,L2,N1,N2".Contains(Global_Cls.SoftwareCode)) treeView_Setting.Nodes["Node_SetOther"].Nodes["Node_WebPart"].Remove();
            //codeing
        }

        private void InitializeComboBoxSMS()
        {
            //-------------------------------------
            //Initialize COM Port DropDown List
            //-------------------------------------
            cmbPort.Items.Add("Select Port");
            for (int i = 1; i <= 256; i++)
            {
                cmbPort.Items.Add("COM" + i.ToString());
            }
            cmbPort.SelectedIndex = 0;


            //--------------------------------------
            //Initialize BaudRate DropDown List
            //--------------------------------------
            cmbBaudRate.Items.Add("110");
            cmbBaudRate.Items.Add("300");
            cmbBaudRate.Items.Add("1200");
            cmbBaudRate.Items.Add("2400");
            cmbBaudRate.Items.Add("4800");
            cmbBaudRate.Items.Add("9600");
            cmbBaudRate.Items.Add("14400");
            cmbBaudRate.Items.Add("19200");
            cmbBaudRate.Items.Add("38400");
            cmbBaudRate.Items.Add("57600");
            cmbBaudRate.Items.Add("115200");
            cmbBaudRate.Items.Add("230400");
            cmbBaudRate.Items.Add("460800");
            cmbBaudRate.Items.Add("921600");
            //cmbBaudRate.SelectedIndex = cmbBaudRate.FindString(((int)objSMS.BaudRate).ToString());

            //--------------------------------------
            //Initialize DataBits DropDown List
            //--------------------------------------
            cmbDataBits.Items.Add("4");
            cmbDataBits.Items.Add("5");
            cmbDataBits.Items.Add("6");
            cmbDataBits.Items.Add("7");
            cmbDataBits.Items.Add("8");
            //cmbDataBits.SelectedIndex = cmbDataBits.FindString(((int)objSMS.DataBits).ToString());


            //--------------------------------------
            //Initialize Parity DropDown List
            //--------------------------------------
            cmbParity.Items.Add("None");
            cmbParity.Items.Add("Odd");
            cmbParity.Items.Add("Even");
            cmbParity.Items.Add("Mark");
            cmbParity.Items.Add("Space");
            //cmbParity.SelectedIndex = (int)objSMS.Parity;


            //--------------------------------------
            //Initialize StopBits DropDown List
            //--------------------------------------
            cmbStopBits.Items.Add("1");
            cmbStopBits.Items.Add("2");
            cmbStopBits.Items.Add("1.5");
            //cmbStopBits.SelectedIndex = (int)objSMS.StopBits - 1;


            //--------------------------------------
            //Initialize FlowControl DropDown List
            //--------------------------------------
            cmbFlowControl.Items.Add("None");
            cmbFlowControl.Items.Add("Hardware");
            cmbFlowControl.Items.Add("Xon/Xoff");
            //cmbFlowControl.SelectedIndex = (int)objSMS.FlowControl;


            cmbEncoding.Items.Add("Default Alphabet");
            cmbEncoding.Items.Add("ANSI (8-bit)");
            cmbEncoding.Items.Add("Unicode (16-bit)");
            //cmbEncoding.SelectedIndex = (int)objSMS.Encoding;

            //----------------------------------------
            //Initialize Long Message DropDown List
            //----------------------------------------
            cmbLongMsg.Items.Add("Truncate");
            cmbLongMsg.Items.Add("Simple Split");
            cmbLongMsg.Items.Add("Formatted Split");
            cmbLongMsg.Items.Add("Concatenate");
        }

        private void buttonItem_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Setting_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Global_Cls.MainForm.CloseAllOK && !CloseOK && !Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, "آیا از این فرم خارج می شوید؟"))
                e.Cancel = true;
        }
        #endregion


        
        #region OK

        private void buttonItem_OK_Click(object sender, EventArgs e)
        {

            //sms start

            Global_Cls.SMSPort = cmbPort.Text;
            Global_Cls.SMSBaudRate = Convert.ToInt32(cmbBaudRate.Text);
            Global_Cls.SMSDataBits = Convert.ToInt32(cmbDataBits.Text);
            Global_Cls.SMSParity = cmbParity.SelectedIndex;
            Global_Cls.SMSStopBits = cmbStopBits.SelectedIndex + 1;
            Global_Cls.SMSFlowControl = cmbFlowControl.SelectedIndex;
            Global_Cls.SMSTimeOut = Convert.ToInt32(cmbTimeOut.Text);

            Global_Cls.SMSEncoding = cmbEncoding.SelectedIndex;
            Global_Cls.SMSLongMsg = cmbLongMsg.SelectedIndex;
            Global_Cls.SMSDeliveryReport = chkDeliveryReport.Checked;

            //new 930925
            Global_Cls.SMSSet = radioButtonInternet.Checked;
            Global_Cls.IntUserName = textBoxUserName.Text;
            Global_Cls.IntPassword = textBoxPassword.Text;
            Global_Cls.IntTelNumber = textBoxTelNumber.Text;
            Global_Cls.InitSMSMessage = textBoxInitSMSMessage.Text;
            //new 930925

            //Global_Cls.Comm_Port = Convert.ToInt32(cmbport.Text);
            //Global_Cls.Comm_BaudRate = Convert.ToInt32(cmbBaudRate.Text);
            //Global_Cls.Comm_TimeOut = Convert.ToInt32(cmbTimeOut.Text);
            //Global_Cls.Send_Unicode = chkunicode.Checked;
            //sms end

            //All Alarm start
            Global_Cls.GetFinePeriod = int.Parse(nUpDownGetFinePeriod.Value.ToString());
            Global_Cls.ExpDayCarEnter = int.Parse(nUpDownExpDayCarEnter.Value.ToString());
            Global_Cls.ExpDayBodyInsu = int.Parse(nUpDownExpDayBodyInsu.Value.ToString());
            Global_Cls.ExpDayCarDuty = int.Parse(nUpDownExpDayCarDuty.Value.ToString());
            Global_Cls.ExpDayThirdInsu = int.Parse(nUpDownExpDayThirdInsu.Value.ToString());
            Global_Cls.ExpKMService = int.Parse(nUpDownExpKMService.Value.ToString());
            //All Alarm end


            //Set Pos Def start
            Global_Cls.FreeKillometer = int.Parse(nUpDown_FreeKillometer.Value.ToString());
            Global_Cls.FineDay = double.Parse(textBox_FineDay.Text.Replace(",", ""));
            Global_Cls.FineTime = double.Parse(textBox_FineTime.Text.Replace(",", ""));
            Global_Cls.FineKillometer = double.Parse(textBox_FineKillometer.Text.Replace(",", ""));
            Global_Cls.CityLimit = comboBox_CityLimit.Text;
            //Set Pos Def end

            //Default value for Start

            try
            {
                TBL_Customer tbhc = DMDC.TBL_Customers.First(thfr => thfr.IsParent == true);

                tbhc.CustomerName = textBox_CName.Text;
                tbhc.AddressBusiness = textBox_CoName.Text;

                tbhc.ParentName = textBox_CParentN.Text;
                tbhc.IDNO = textBox_CIDNO.Text;
                tbhc.NationalCode = textBox_CNationalCode.Text;
                tbhc.BrithCityName = ComboBoxBrithCityName.Text;

                tbhc.BrithDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearBD.Text, comboBox_MonthBD.Text, comboBox_DayBD.Text);

                tbhc.Address = textBox_Address.Text;
                tbhc.Tel = textBox_Tel.Text;
                tbhc.Mobile = textBox_mobile.Text;
                tbhc.Email = textBox_EMail.Text;
                DMDC.SubmitChanges();
            }
            catch
            {
                TBL_Customer tbc = new TBL_Customer()
                {
                    Active = true,
                    CustomerType = 3,
                    IsParent = true,
                    CustomerName = textBox_CName.Text,
                    AddressBusiness = textBox_CoName.Text,

                    ParentName = textBox_CParentN.Text,
                    IDNO = textBox_CIDNO.Text,
                    NationalCode = textBox_CNationalCode.Text,
                    BrithCityName = ComboBoxBrithCityName.Text,

                    BrithDate = Global_Cls.ShamsiDateToMiladi(comboBox_YearBD.Text, comboBox_MonthBD.Text, comboBox_DayBD.Text),

                    Address = textBox_Address.Text,
                    Tel = textBox_Tel.Text,
                    Mobile = textBox_mobile.Text,
                    Email = textBox_EMail.Text,
                    CreateDate = DateTime.Now,
                };
                DMDC.TBL_Customers.InsertOnSubmit(tbc);
                DMDC.SubmitChanges();
            }
            try
            { FileSystem.DeleteFile(Global_Cls.RootSaveLoad() + "\\PicsFilms\\Logo.jpg"); }
            catch { }
            try { FileSystem.CopyFile(pictureBoxCarPic.ImageLocation, Global_Cls.RootSaveLoad() + @"\PicsFilms\Logo.Jpg"); }
            catch { }
            //

            //BkpRst start
            Global_Cls.BkpAutoRoot = label_BkpAuto.Text;
            if (radioButton_BkpAuto.Checked) Global_Cls.BkpExitType = 2;
            else if (radioButton_BkpNonAuto.Checked) Global_Cls.BkpExitType = 1;
            else Global_Cls.BkpExitType = 0;
            Global_Cls.BkpRstPicsFilms = checkBox_BRPicFilm.Checked;
            Global_Cls.BkpRstDesignReport = checkBox_BRDesignRep.Checked;
            //BkpRst end


            Function_Cls.WriteToXmlFiles();

            CloseOK = true;
            this.Close();

        }

        #endregion



        #region Other

        private void button_BkpAuto_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dir = new FolderBrowserDialog();
            dir.SelectedPath = label_BkpAuto.Text;
            if (dir.ShowDialog() == DialogResult.OK)
            {
                label_BkpAuto.Text = dir.SelectedPath;
            }
        }

        private void button_RstChangePass_Click(object sender, EventArgs e)
        {
            Function_Cls.Restore_Func(true);
        }

        private void treeView_Setting_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                if (e.Node.Name == "Node_SetUnits") tabControl_Setting.SelectedTab = tabControl_Setting.Tabs["tabItem_SetUnits"];
            }
            catch { }

            try
            {
                if (e.Node.Name == "Node_SetPosDef") tabControl_Setting.SelectedTab = tabControl_Setting.Tabs["tabItem_SetPosDef"];
            }
            catch { }

            try
            {
                if (e.Node.Name == "Node_SetAlarms") tabControl_Setting.SelectedTab = tabControl_Setting.Tabs["tabItem_SetAlarms"];
            }
            catch { }

            try
            {
                if (e.Node.Name == "Node_SetBkpRst") tabControl_Setting.SelectedTab = tabControl_Setting.Tabs["tabItem_SetBkpRst"];
            }
            catch { }

            try
            {
                if (e.Node.Name == "Node_Sms") tabControl_Setting.SelectedTab = tabControl_Setting.Tabs["tabItem_SMS"];
            }
            catch { }

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

        private void pictureBoxCarPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "All Image File|*.Jpg;";
            if (op.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBoxCarPic.ImageLocation = op.FileName;
                }
                catch
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, " مسیر فایل و یا سورس فایل نامعتبر است. دوباره سعی کنید ");
                }
            }

        }
        #endregion



        #region Other event

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

        private void panel_BrithDate_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_MonthBD.Text) > 6 && Convert.ToInt16(comboBox_DayBD.Text) == 31) comboBox_DayBD.Text = "30";
            if (Convert.ToInt16(comboBox_MonthBD.Text) == 12 && (Convert.ToInt16(comboBox_DayBD.Text) == 31 || Convert.ToInt16(comboBox_DayBD.Text) == 30)) comboBox_DayBD.Text = "29";
        }
        #endregion

        private void buttonTestCredit_Click(object sender, EventArgs e)
        {
            bool a = Global_Cls.SMSSet;
            Global_Cls.SMSSet = true;
            if (RentCarPrj.Classes.SMSClass.ConnectToPort())
            {
                double DCredit = RentCarPrj.Classes.SMSClass.GetCreditSMS(textBoxUserName.Text, textBoxPassword.Text);
                if (DCredit >= 1 && DCredit <= 10)
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اشکال ", " کد اشکال : " + DCredit.ToString());
                else
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SInformation, false, "مبلغ باقیمانده شارژ " + DCredit.ToString() + "ریال می باشد");
            }
            Global_Cls.SMSSet = a;
        }

        


    }
}