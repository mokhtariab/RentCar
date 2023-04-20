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
    public partial class OperatorRep_frm : Form
    {
        public OperatorRep_frm()
        {
            InitializeComponent();
        }

        private RentCarPrj.DataLinq.DataClasses_MainDataContext DCDC = new RentCarPrj.DataLinq.DataClasses_MainDataContext(Global_Cls.ConnectionStr);


        private void OperatorRep_frm_Load(object sender, EventArgs e)
        {
            SetDateToModules();
        }

        
   
        #region Set Date Module

        private void SetDateToModules()
        {
            PersianCalendar farsi = new PersianCalendar();

            comboBox_OperatorYear1.Text = farsi.GetYear(DateTime.Now).ToString(); comboBox_OperatorYear2.Text = comboBox_OperatorYear1.Text; 
            comboBox_OperatorMonth1.Text = farsi.GetMonth(DateTime.Now).ToString(); comboBox_OperatorMonth2.Text = comboBox_OperatorMonth1.Text;
            comboBox_Operatorday1.Text = farsi.GetDayOfMonth(DateTime.Now).ToString(); comboBox_OperatorDay2.Text = comboBox_Operatorday1.Text;
        }

        private void panel_DOperator1_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_OperatorMonth1.Text) > 6 && Convert.ToInt16(comboBox_Operatorday1.Text) == 31) comboBox_Operatorday1.Text = "30";
            if (Convert.ToInt16(comboBox_OperatorMonth1.Text) == 12 && (Convert.ToInt16(comboBox_Operatorday1.Text) == 31 || Convert.ToInt16(comboBox_Operatorday1.Text) == 30)) comboBox_Operatorday1.Text = "29";
        }


        private void panel_DOperator2_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt16(comboBox_OperatorMonth2.Text) > 6 && Convert.ToInt16(comboBox_OperatorDay2.Text) == 31) comboBox_OperatorDay2.Text = "30";
            if (Convert.ToInt16(comboBox_OperatorMonth2.Text) == 12 && (Convert.ToInt16(comboBox_OperatorDay2.Text) == 31 || Convert.ToInt16(comboBox_OperatorDay2.Text) == 30)) comboBox_OperatorDay2.Text = "29";
        }

        #endregion

   
        #region Preview Chart

        OperatorChart_frm CC = null;
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            if (CC == null)
            {
                //Sel Car
                string WCode = "";
                if (RadioButton_SelCar.Checked)
                {
                    for (int i = 0; i < listView_Operator.Items.Count; i++)
                    {
                        WCode += listView_Operator.Items[i].Tag.ToString();
                        WCode += ";";
                    }
                }


                //Series
                int YAxis = 1;
                if (radioButton_YFew.Checked)
                { YAxis = 1; }
                else if (radioButton_YRialy.Checked)
                { YAxis = 2; }


                //Sel Type Chart
                int SelTypeChart = comboBox_ChartType.SelectedIndex == -1 ? 0 : comboBox_ChartType.SelectedIndex;

                string Tit = " گزارش کارکرد کارگزاران از تاریخ " + comboBox_OperatorYear1.Text + "/" + comboBox_OperatorMonth1.Text + "/" + comboBox_Operatorday1.Text + " تا تاریخ " + comboBox_OperatorYear2.Text + "/" + comboBox_OperatorMonth2.Text + "/" + comboBox_OperatorDay2.Text;
                CC = new OperatorChart_frm(WCode, YAxis,
                    Global_Cls.ShamsiDateToMiladi(comboBox_OperatorYear1.Text, comboBox_OperatorMonth1.Text, comboBox_Operatorday1.Text),
                    Global_Cls.ShamsiDateToMiladi(comboBox_OperatorYear2.Text, comboBox_OperatorMonth2.Text, comboBox_OperatorDay2.Text),
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

        private void btnOperatorName_Click(object sender, EventArgs e)
        {
            SelectPerson_frm sp = new SelectPerson_frm(1,true);
            sp.ShowDialog();
            if (sp.CodeC != 0)
            {
                if (listView_Operator.Items.ContainsKey(sp.CodeC.ToString())) return;

                listView_Operator.Items.Add(sp.CodeC.ToString(), sp.NameC, 0);
                listView_Operator.Items[sp.CodeC.ToString()].Tag = sp.CodeC.ToString();
            }
        }

        private void btnDelItem_Click(object sender, EventArgs e)
        {
            int gh = listView_Operator.SelectedItems.Count;
            for (int i = 0; i < gh; i++)
            {
                listView_Operator.SelectedItems[0].Remove();
            }
        }

        #endregion


    }
}
