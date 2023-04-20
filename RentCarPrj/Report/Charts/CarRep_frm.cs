using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RentCarPrj.Properties;
using System.Globalization;

namespace RentCarPrj
{
    public partial class CarRep_frm : Form
    {
        public CarRep_frm()
        {
            InitializeComponent();
        }

        private RentCarPrj.DataLinq.DataClasses_MainDataContext DCDC = new RentCarPrj.DataLinq.DataClasses_MainDataContext(Global_Cls.ConnectionStr);


        private void CarRep_frm_Load(object sender, EventArgs e)
        {
            SetDateToModules();
        }

        
   
        #region Set Date Module

        private void SetDateToModules()
        {
            PersianCalendar farsi = new PersianCalendar();

            //string DateStr = Global_Cls.MiladiDateToShamsi(DateTime.Today);
            comboBox_CarYear1.Text = farsi.GetYear(DateTime.Now).ToString(); comboBox_CarYear2.Text = comboBox_CarYear1.Text; 
            comboBox_CarMonth1.Text = farsi.GetMonth(DateTime.Now).ToString(); comboBox_CarMonth2.Text = comboBox_CarMonth1.Text;
            comboBox_Carday1.Text = farsi.GetDayOfMonth(DateTime.Now).ToString(); comboBox_CarDay2.Text = comboBox_Carday1.Text;
        }

        private void panel_DCar1_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_CarMonth1.Text) > 6 && Convert.ToInt16(comboBox_Carday1.Text) == 31) comboBox_Carday1.Text = "30";
            if (Convert.ToInt16(comboBox_CarMonth1.Text) == 12 && (Convert.ToInt16(comboBox_Carday1.Text) == 31 || Convert.ToInt16(comboBox_Carday1.Text) == 30)) comboBox_Carday1.Text = "29";
        }


        private void panel_DCar2_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_CarMonth2.Text) > 6 && Convert.ToInt16(comboBox_CarDay2.Text) == 31) comboBox_CarDay2.Text = "30";
            if (Convert.ToInt16(comboBox_CarMonth2.Text) == 12 && (Convert.ToInt16(comboBox_CarDay2.Text) == 31 || Convert.ToInt16(comboBox_CarDay2.Text) == 30)) comboBox_CarDay2.Text = "29";
        }

        #endregion

   
        #region Preview Chart

        CarChart_frm CC = null;
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            if (CC == null)
            {
                //Sel Car
                string WCode = "";
                if (RadioButton_SelCar.Checked)
                {
                    for (int i = 0; i < listView_Car.Items.Count; i++)
                    {
                        WCode += listView_Car.Items[i].Tag.ToString();
                        WCode += ";";
                    }
                }

                //Series
                int YAxis = 1;
                if (radioButton_YTime.Checked)
                { YAxis = 1; }
                else if (radioButton_YFew.Checked)
                { YAxis = 2; }
                else if (radioButton_YRialy.Checked)
                { YAxis = 3; }


                //Sel Type Chart
                int SelTypeChart = comboBox_ChartType.SelectedIndex == -1 ? 0 : comboBox_ChartType.SelectedIndex;

                string Tit = " گزارش کارکرد اتومبیل ها از تاریخ " + comboBox_CarYear1.Text + "/" + comboBox_CarMonth1.Text + "/" + comboBox_Carday1.Text + " تا تاریخ " + comboBox_CarYear2.Text + "/" + comboBox_CarMonth2.Text + "/" + comboBox_CarDay2.Text;
                CC = new CarChart_frm(WCode, YAxis,
                    Global_Cls.ShamsiDateToMiladi(comboBox_CarYear1.Text, comboBox_CarMonth1.Text, comboBox_Carday1.Text),
                    Global_Cls.ShamsiDateToMiladi(comboBox_CarYear2.Text, comboBox_CarMonth2.Text, comboBox_CarDay2.Text),
                    SelTypeChart + 1, Tit);
                CC.Disposed += new EventHandler(CC_Disposed);
            }
            CC.Show();
            CC.BringToFront();
            CC.Focus();

        }

        void CC_Disposed(object sender, EventArgs e)
        {
            CC = null;
        }

        private void btnCarName_Click(object sender, EventArgs e)
        {
            SelectPerson_frm sp = new SelectPerson_frm(2,true);
            sp.ShowDialog();
            if (sp.CodeC != 0)
            {
                if (listView_Car.Items.ContainsKey(sp.CodeC.ToString())) return;

                listView_Car.Items.Add(sp.CodeC.ToString(), sp.NameC, 0);
                listView_Car.Items[sp.CodeC.ToString()].Tag = sp.CodeC.ToString();
            }
        }

        private void btnDelItem_Click(object sender, EventArgs e)
        {
            int gh = listView_Car.SelectedItems.Count;
            for (int i = 0; i < gh; i++)
            {
                listView_Car.SelectedItems[0].Remove();
            }
        }


        #endregion



    }
}
