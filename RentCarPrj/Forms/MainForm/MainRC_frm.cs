using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using DevComponents.DotNetBar;
using RentCarPrj.Properties;
using Microsoft.VisualBasic.FileIO;
using System.Collections.ObjectModel;
using System.Globalization;
using RentCarPrj.DataLinq;
using DevComponents.DotNetBar.Rendering;


namespace RentCarPrj
{
    public partial class MainRC_frm : Form
    {

        public MainRC_frm()
        {
            InitializeComponent();
        }

        
        #region All Events in Forms
        

        public string UserPermission, UserPrmHouseFor;
        private void MainHM_frm_Shown(object sender, EventArgs e)
        {
            //main color
            if (Global_Cls.ColorDisplay == 0) { checkBoxItem_Black.Checked = true; checkBoxItem_Black_Click(this, null); }
            else if (Global_Cls.ColorDisplay == 1) { checkBoxItem_Silver.Checked = true; checkBoxItem_Silver_Click(this, null); }
            else if (Global_Cls.ColorDisplay == 2) { checkBoxItem_Blue.Checked = true; checkBoxItem_Blue_Click(this, null); }
            //

            //RentCarPrj.Properties.Settings.Default.Initialize( , Properties.Resources.ResourceManager.ResourceSetType.FullName = "\\Settings.settings";
            if (UserPermission != "" && UserPermission != "admin")
            {
                foreach (Control c in this.Controls["ribbonControl_Main"].Controls)
                {
                    if (c.Name != "")
                        foreach (Control c1 in this.Controls["ribbonControl_Main"].Controls[c.Name].Controls)
                        {
                            if (c1.Name != "")
                            {
                                string sp = UserPermission;
                                string st = "";
                                while (sp != "")
                                {
                                    st = sp.Substring(0, sp.IndexOf(","));
                                    sp = sp.Substring(sp.IndexOf(",") + 1, sp.Length - (sp.IndexOf(",") + 1));
                                    BaseItem item = (c1 as RibbonBar).GetItem(st);
                                    try
                                    {
                                        item.Enabled = false;
                                    }
                                    catch { }
                                }
                            }
                        }
                }
            }


            tabNameStr = "tabControlPanel_StartPnl,";

           //RentCarPrj.DataLinq.DataClasses_MainDataContext DCDC = new RentCarPrj.DataLinq.DataClasses_MainDataContext(Global_Cls.ConnectionStr);
           //if ((from gf in DCDC.SP_AlarmViewForDefinition(
           //                    Global_Cls.GetFinePeriod, Global_Cls.ExpDayCarEnter, Global_Cls.ExpDayCarDuty,
           //                    Global_Cls.ExpDayBodyInsu, Global_Cls.ExpDayThirdInsu)
           //     select gf).Count() > 0)
           //    buttonItem_AlarmList_Click(this, null);



            try
            {
                DataClasses_MainDataContext DMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

                TBL_Customer tbhc = DMDC.TBL_Customers.First(thfr => thfr.IsParent == true);
                rfLabelManageName.Text = "مدیریت: " + tbhc.CustomerName;
                rfLabelCoName.Text = "شرکت " + tbhc.AddressBusiness;
            }
            catch { }


            //codeing
            if (!Global_Cls.SoftwareCode.Contains("+S"))
            {
                buttonItem_SendSMS.Enabled = false;
                buttonItem_ReciveSMS.Enabled = false;
            }

            if (Global_Cls.SoftwareCode.Contains("L1") || Global_Cls.SoftwareCode.Contains("N1") || Global_Cls.SoftwareCode == "Trial")
            {
                buttonItem_FileRep.Enabled = false;
                buttonItem_RepCustomers.Enabled = false;
                buttonItem_RepOperator.Enabled = false;

                buttonItem_ieSearch.Enabled = false;
                buttonItem_SendEmail.Enabled = false;
                buttonItem_ChartPos.Enabled = false;

                buttonItem_AlarmList.Enabled = false;
                buttonItem_ActionList.Enabled = false;

                //ribbonTabItem_UNet.Enabled = false;
            }

            //if (Global_Cls.SoftwareCode == "Trial")
            //{
            //    buttonItem_ieSearch.Enabled = false;
            //    buttonItem_SearchHouse.Enabled = false;
            //}
            //codeing


        }



        private void MainHM_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Function_Cls.ExitForce)
                if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, "آیا از برنامه خارج می شوید؟"))
                {
                    e.Cancel = true;
                    return;
                }
            CloseAllOK = true;
            try
            {
                for (int i = 0; i < tabControl_Main.Tabs.Count; i++)
                    tabControl_Main.Tabs.RemoveAt(i);
            }
            catch { }


            //setting
            if (Global_Cls.BkpExitType == 2)
            {
                string RootStr = Global_Cls.MiladiDateToShamsi(DateTime.Today);
                RootStr = RootStr.Replace("/", "");
                RootStr = Global_Cls.BkpAutoRoot + "\\" + RootStr + " " + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + ".bak";
                Function_Cls.SetBackUpDBAll(RootStr);
            }
            if (Global_Cls.BkpExitType == 1) Func_CallTheBackUp();

            //main color
            if (checkBoxItem_Black.Checked) Global_Cls.ColorDisplay = 0;
            else if (checkBoxItem_Silver.Checked) Global_Cls.ColorDisplay = 1;
            else if (checkBoxItem_Blue.Checked) Global_Cls.ColorDisplay = 2;
            //

            Function_Cls.WriteToXmlFiles();

            timer_Main.Enabled = false;
        }


        private void MainHM_frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        public bool CloseAllOK = false;
        private void notifyToolStrip_ItemExit_Click(object sender, EventArgs e)
        {
            try
            {
                CloseAllOK = true;
                Close();
            }
            catch { }
        }

        private void MainHM_frm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Tab)
            {
                if (tabControl_Main.SelectedTabIndex == tabControl_Main.Tabs.Count - 1)
                    tabControl_Main.SelectedTabIndex = 0;
                else
                    tabControl_Main.SelectNextTab();
            }
        }

        #endregion



        #region Add Tabs to TabControl Functions & Add UserControl to Tabs

        //private int Cnt;
        public string tabNameStr;

        public void AddTabToTabControl(string tabName, string tabCaption, UserControl UC)
        {
            if (tabNameStr != null && tabNameStr.Contains(tabName + "Pnl,"))
            {
                tabControl_Main.SelectedPanel = (TabControlPanel)tabControl_Main.Controls[tabName + "Pnl"];
                UC.Dispose();
                return;
            }

            DevComponents.DotNetBar.TabItem NewTabItem = new DevComponents.DotNetBar.TabItem(this.components);
            DevComponents.DotNetBar.TabControlPanel NewTabControlPanel = new DevComponents.DotNetBar.TabControlPanel();

            NewTabControlPanel.Controls.Add(UC);
            UC.Dock = DockStyle.Fill;
            NewTabControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            NewTabControlPanel.Location = new System.Drawing.Point(0, 0);
            NewTabControlPanel.Padding = new System.Windows.Forms.Padding(1);
            NewTabControlPanel.Size = new System.Drawing.Size(778, 289);
            NewTabControlPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            NewTabControlPanel.Style.BorderColor.Color = System.Drawing.SystemColors.ControlDarkDark;
            NewTabControlPanel.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                 | DevComponents.DotNetBar.eBorderSide.Top)));
            NewTabControlPanel.Style.GradientAngle = -90;
            NewTabControlPanel.TabIndex = 1;

            NewTabControlPanel.TabItem = NewTabItem;
            NewTabItem.AttachedControl = NewTabControlPanel;

            
            //
            tabNameStr += tabName + "Pnl,";

            NewTabControlPanel.Name = tabName + "Pnl";
            NewTabControlPanel.Text = tabCaption;

            try
            {
                NewTabItem.Name = tabName + "Itm";
            }
            catch
            {
            }
            NewTabItem.Text = tabCaption;

            tabControl_Main.Controls.Add(NewTabControlPanel);
            tabControl_Main.Tabs.Add(NewTabItem);
            tabControl_Main.Refresh();

            tabControl_Main.SelectedPanel = NewTabControlPanel;
        }

        public void DeleteTabFromTabControl(DevComponents.DotNetBar.TabItem TabItemName)
        {
            tabControl_Main.Tabs.Remove(TabItemName);
            tabControl_Main.Controls.Remove(TabItemName.AttachedControl);
        }


        private void tabControl_Main_ControlRemoved(object sender, ControlEventArgs e)
        {
            tabNameStr = tabNameStr.Replace(tabControl_Main.SelectedPanel.Name + ",", "");
            tabControl_Main.Tabs.Capacity--;
        }
        
        private void buttonItem_Users_Click(object sender, EventArgs e)
        {
            ListUser_UC Uc = new ListUser_UC();
            AddTabToTabControl("User", " کاربران ", Uc);
        }


        private void buttonItem_PerTelMob_Click(object sender, EventArgs e)
        {
            ListTelMob_UC Uc = new ListTelMob_UC();
            AddTabToTabControl("ListTelMob", " دفتر تلفن ", Uc);
        }


        private void buttonItem_ListCar_Click(object sender, EventArgs e)
        {
            CarList_UC Uc = new CarList_UC();
            AddTabToTabControl("CarList", " لیست اتومبیل ها ", Uc);
        }

        private void buttonItem_CustomerList_Click(object sender, EventArgs e)
        {
            CustomerList_UC Uc = new CustomerList_UC();
            AddTabToTabControl("CustomerList", " لیست اشخاص ", Uc);
        }

        private void buttonItem_OperatorList_Click(object sender, EventArgs e)
        {
            OperatorList_UC Uc = new OperatorList_UC();
            AddTabToTabControl("OperatorList", " لیست کارگزاران ", Uc);
        }

        private void buttonItem_DelCars_Click(object sender, EventArgs e)
        {
            DelCarList_UC Uc = new DelCarList_UC();
            AddTabToTabControl("DelCarList", " لیست اتومبیل های حذف شده ", Uc);
        }
        
        private void buttonItem_AlarmList_Click(object sender, EventArgs e)
        {
            AlarmList_UC Uc = new AlarmList_UC();
            AddTabToTabControl("AlarmList", " آلارم ها ", Uc);
        }

        #endregion



        #region Backup Or Restore Functions
        private void buttonItem_Bkp_Click(object sender, EventArgs e)
        {
            Func_CallTheBackUp();
        }

        private void Func_CallTheBackUp()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "All Files(*.bak)|*.bak";
            if (dlg.ShowDialog() == DialogResult.OK)
                Function_Cls.SetBackUpDBAll(dlg.FileName);
        }
       
        private void buttonItem_Rst_Click(object sender, EventArgs e)
        {
            Func_CallTheRestore();
        }

        private void Func_CallTheRestore()
        {
            if (Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, "آیا نسبت به عمل بازیابی مطمئنید؟"))
                Function_Cls.Restore_Func(false);
        }
        #endregion



        #region All Settings
        private void checkBoxItem_Black_Click(object sender, EventArgs e)
        {
            RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(this, DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Black);
            //ribbonControl_Main.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Black;
        }

        private void checkBoxItem_Silver_Click(object sender, EventArgs e)
        {
            RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(this, DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Silver);
            //ribbonControl_Main.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Silver;
        }

        private void checkBoxItem_Blue_Click(object sender, EventArgs e)
        {
            RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(this, DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Blue);
//            ribbonControl_Main.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.Black;
        }

        private static void SettingForm_Open(int tabindex)
        {
            Setting_frm Sf = new Setting_frm();
            //Sf.tabControl_Setting.SelectedTabIndex = tabindex;
            if (tabindex != 4) Sf.treeView_Setting.SelectedNode = Sf.treeView_Setting.Nodes[tabindex].Nodes[0];
            else Sf.treeView_Setting.SelectedNode = Sf.treeView_Setting.Nodes[tabindex];
            Sf.ShowDialog();
        }

        private void ribbonBar_MainSet_DialogLauncherMouseDown(object sender, MouseEventArgs e)
        {
            //SettingForm_Open(0);
        }

        private void buttonItem_FirstSet_Click(object sender, EventArgs e)
        {
            SettingForm_Open(0);
        }

        private void buttonItem_AgencySet_Click(object sender, EventArgs e)
        {
            //SettingForm_Open(1);
        }

        private void buttonItem_BkpRstSet_Click(object sender, EventArgs e)
        {
            //SettingForm_Open(4);
        }

        private void buttonItem_OtherSet_Click(object sender, EventArgs e)
        {
            //SettingForm_Open(3);
        }

        private void buttonItem_SetSystem_Click(object sender, EventArgs e)
        {
            //SettingForm_Open(2);
        }


        #endregion



        #region Tools

        private void buttonItem_SendSMS_Click(object sender, EventArgs e)
        {
            Global_Cls.SendSMS_Advertisment(true, "", "");
        }

        private void buttonItem_SendEmail_Click(object sender, EventArgs e)
        {
            Global_Cls.SendEmail("");
        }

        private void buttonItem_ReciveSMS_Click(object sender, EventArgs e)
        {
            ReciveSMS_frm rsf = new ReciveSMS_frm();
            rsf.ShowDialog();
        }

        private void buttonItem_Calc_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }

        private void buttonItem_Notepad_Click(object sender, EventArgs e)
        {
            Process.Start("NotePad");
        }

        private void buttonItem_ieSearch_Click(object sender, EventArgs e)
        {
            Function_Cls.SearchInternet(1);
        }

        private void buttonItem_ChartPos_Click(object sender, EventArgs e)
        {
            Function_Cls.SearchInternet(2);
        }

     
        #endregion



        #region Reports


        CarRep_frm rcf = null;
        private void buttonItem_CarChart_Click(object sender, EventArgs e)
        {
            if (rcf == null)
            {
                rcf = new CarRep_frm();
                rcf.Disposed += new EventHandler(rcf_Disposed);
            }

            rcf.Show();
            rcf.BringToFront();
            rcf.Focus();
        }
        void rcf_Disposed(object sender, EventArgs e)
        {
            rcf = null;
        }

        CarRepList_frm crlf = null;
        private void buttonItem_CarList_Click(object sender, EventArgs e)
        {
            if (crlf == null)
            {
                crlf = new CarRepList_frm();
                crlf.Disposed += new EventHandler(crlf_Disposed);
            }
            crlf.Show();
            crlf.BringToFront();
            crlf.Focus();

            try { int tbinx = tabControl_Main.SelectedTabIndex; tabControl_Main.SelectedTabIndex = 0; tabControl_Main.SelectedTabIndex = tbinx; }
            catch { }
        }
        
        void crlf_Disposed(object sender, EventArgs e)
        {
            crlf = null;
        }
        
        OperatorRep_frm Orf = null;
        private void buttonItem_RepOperator_Click(object sender, EventArgs e)
        {
            if (Orf == null)
            {
                Orf = new OperatorRep_frm();
                Orf.Disposed += new EventHandler(Orf_Disposed);
            }

            Orf.Show();
            Orf.BringToFront();
            Orf.Focus();

            try { int tbinx = tabControl_Main.SelectedTabIndex; tabControl_Main.SelectedTabIndex = 0; tabControl_Main.SelectedTabIndex = tbinx; }
            catch { }
        }

        void Orf_Disposed(object sender, EventArgs e)
        {
            Orf = null;
        }

        private void buttonItem_RepCustomers_Click(object sender, EventArgs e)
        {
            CustomersDutyRep_frm cdr = new CustomersDutyRep_frm();
            cdr.ShowDialog();
        }


        #endregion



        #region Date Time UserName
        Int16 CounterColor = 0;
        private void timer_Main_Tick(object sender, EventArgs e)
        {
            //if (CounterColor == 100) CounterColor = 0;
            //label_main.ForeColor = Convert.ChangeType(CounterColor++, System.Drawing.Color);// Color.Khaki;// CounterColor++;
            label_main.Text = taghvim() + "           ساعت: " +
                DateTime.Now.TimeOfDay.Hours.ToString() + ":" +
                DateTime.Now.TimeOfDay.Minutes.ToString() + ":" +
                DateTime.Now.TimeOfDay.Seconds.ToString() + "         کاربر: " +
                Global_Cls.UserName_Exist.ToString();
            label_main.Left = bar_MainView.Width/2 - 250;
        }

        private string taghvim()
        {
            string TghvmStr = "";

            string[] fasl = new string[12];
            fasl[0] = "فروردین";
            fasl[1] = "اردیبهشت";
            fasl[2] = "خرداد";
            fasl[3] = "تیر";
            fasl[4] = "مرداد";
            fasl[5] = "شهریور";
            fasl[6] = "مهر";
            fasl[7] = "آبان";
            fasl[8] = "آذر";
            fasl[9] = "دی";
            fasl[10] = "بهمن";
            fasl[11] = "اسفند";
            string[] rooz = new string[7];
            rooz[0] = "شنبه"; rooz[1] = "یکشنبه"; rooz[2] = "دوشنبه"; rooz[3] = "سه شنبه"; rooz[4] = "چهارشنبه"; rooz[5] = "پنج شنبه"; rooz[6] = "جمعه";

            PersianCalendar farsi = new PersianCalendar();
            int a;
            DayOfWeek dd;

            dd = farsi.GetDayOfWeek(DateTime.Now);
            switch (dd.ToString())
            {
                case "Saturday":
                    TghvmStr = rooz[0].ToString();
                    break;
                case "Sunday":
                    TghvmStr = rooz[1].ToString();
                    break;
                case "Monday":
                    TghvmStr = rooz[2].ToString();
                    break;
                case "Tuesday":
                    TghvmStr = rooz[3].ToString();
                    break;
                case "Wednesday":
                    TghvmStr = rooz[4].ToString();
                    break;
                case "Thursday":
                    TghvmStr = rooz[5].ToString();
                    break;
                case "Friday":
                    TghvmStr = rooz[6].ToString();
                    break;
            }
            string str;
            a = farsi.GetDayOfMonth(DateTime.Now);
            TghvmStr += " " + Convert.ToString(a);
            str = Convert.ToString(a);
            a = farsi.GetMonth(DateTime.Now);
            TghvmStr += " " + fasl[a - 1];
            str += "/" + Convert.ToString(a);
            a = farsi.GetYear(DateTime.Now);
            TghvmStr += " " + Convert.ToString(a);
            str += "/" + Convert.ToString(a);

            return TghvmStr;
        }
        #endregion



        #region Button Click

        private void buttonItem_Help_Click(object sender, EventArgs e)
        {
            //Process.Start("RentHelp.chm");
        }

        public DutyNE_frm DtNE = null;
        private void buttonItem_DutyToPerson_Click(object sender, EventArgs e)
        {
            if (DtNE == null)
            {
                Function_Cls.CheckKeyFile(); 
                DtNE = new DutyNE_frm(true, 0, 0, int.Parse((sender as ButtonItem).Tag.ToString()), 0);
                DtNE.Disposed += new EventHandler(DtNE_Disposed);
            }

            DtNE.Show();
            DtNE.BringToFront();
            DtNE.Focus();

            try { int tbinx = tabControl_Main.SelectedTabIndex; tabControl_Main.SelectedTabIndex = 0; tabControl_Main.SelectedTabIndex = tbinx; }
            catch { }
        }

        void DtNE_Disposed(object sender, EventArgs e)
        {
            DtNE = null;
        }

        public CarNE_frm CarNE = null;
        private void buttonItem_CarNew_Click(object sender, EventArgs e)
        {
            if (CarNE == null)
            {
                if (sender == buttonItem_CarNew)
                    CarNE = new CarNE_frm(true, 0, 0);
                else if (sender == buttonItem_CarFreind)
                    CarNE = new CarNE_frm(true, 1, 0);
                else if (sender == buttonItem_CarOtherPerson)
                    CarNE = new CarNE_frm(true, 2, 0);
                CarNE.Disposed += new EventHandler(CarNE_Disposed);
            }
            CarNE.Show();
            CarNE.BringToFront();
            CarNE.Focus(); 
            
            try { int tbinx = tabControl_Main.SelectedTabIndex; tabControl_Main.SelectedTabIndex = 0; tabControl_Main.SelectedTabIndex = tbinx; }
            catch { }
        }

        void CarNE_Disposed(object sender, EventArgs e)
        {
            CarNE = null;
        }

        
        public CustomerNE_frm CNE = null;
        private void buttonItem_CuLord_Click(object sender, EventArgs e)
        {
            if (CNE == null)
            {
                if (sender == buttonItem_CuCustomer)
                    CNE = new CustomerNE_frm(true, 1, 0);
                else if (sender == buttonItem_CuLord)
                    CNE = new CustomerNE_frm(true, 2, 0);
                else if (sender == buttonItemCuWorkMate)
                    CNE = new CustomerNE_frm(true, 3, 0);
                else if (sender == buttonItem_CuOther)
                    CNE = new CustomerNE_frm(true, 4, 0);
                CNE.Disposed += new EventHandler(CNE_Disposed);
            }
            CNE.Show();
            CNE.BringToFront();
            CNE.Focus();

            try { int tbinx = tabControl_Main.SelectedTabIndex; tabControl_Main.SelectedTabIndex = 0; tabControl_Main.SelectedTabIndex = tbinx; }
            catch { }
        }

        void CNE_Disposed(object sender, EventArgs e)
        {
            CNE = null;
        }


        public OperatorNE_frm OpNE = null;
        private void buttonItem_OperatorNew_Click(object sender, EventArgs e)
        {
            if (OpNE == null)
            {
                OpNE = new OperatorNE_frm();
                OpNE.Disposed += new EventHandler(OpNE_Disposed);
            }

            OpNE.Show();
            OpNE.BringToFront();
            OpNE.Focus();

            try { int tbinx = tabControl_Main.SelectedTabIndex; tabControl_Main.SelectedTabIndex = 0; tabControl_Main.SelectedTabIndex = tbinx; }
            catch { }
        }

        void OpNE_Disposed(object sender, EventArgs e)
        {
            OpNE = null;
        }

        
        public AccountList_Frm ALF = null;
        private void buttonItem_AccountList_Click(object sender, EventArgs e)
        {
            if (ALF == null)
            {
                ALF = new AccountList_Frm();
                ALF.Disposed += new EventHandler(ALF_Disposed);
            }

            ALF.Show();
            ALF.BringToFront();
            ALF.Focus();
        }

        void ALF_Disposed(object sender, EventArgs e)
        {
            ALF = null;
        }

        public ActionList_Frm AcLF = null;
        private void buttonItem_ActionList_Click(object sender, EventArgs e)
        {
            if (AcLF == null)
            {
                AcLF = new ActionList_Frm();
                AcLF.Disposed += new EventHandler(AcLF_Disposed);
            }

            AcLF.Show();
            AcLF.BringToFront();
            AcLF.Focus();
        }

        void AcLF_Disposed(object sender, EventArgs e)
        {
            AcLF = null;
        }


        private void buttonItem_CarNew_MouseMove(object sender, MouseEventArgs e)
        {
            (sender as ButtonItem).Expanded = true;
        }

        #endregion


    }
}
