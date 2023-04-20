using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RentCarPrj.Properties;
using RentCarPrj.DataLinq;

namespace RentCarPrj
{
    public partial class UserPermission_frm : Form
    {
        public UserPermission_frm()
        {
            InitializeComponent();
        }

        public int UserIDIndex;
        public string PerUser;
        private bool CloseOK = false;


        public void UserPermission_LoadDataAndForm(int EnterId)
        {
            UserIDIndex = EnterId;

            DataClasses_MainDataContext DCDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

            //Check user's admin
            TBL_User thf = DCDC.TBL_Users.First(th => th.UserCode.Equals(UserIDIndex));
            if (thf.UserPermission == "admin")
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "امکان تغییر در سطح دسترسی کاربر اصلی وجود ندارد!"); 
                return;
            }

            for (int j = 0; j < tabControl_Permission.Controls.Count; j++)
                for (int i = 0; i < tabControl_Permission.Controls[j].Controls.Count; i++)
                    if (tabControl_Permission.Controls[j].Controls[i].GetType().FullName == "DevComponents.DotNetBar.Controls.CheckBoxX")
                    {
                        DevComponents.DotNetBar.Controls.CheckBoxX chb = (DevComponents.DotNetBar.Controls.CheckBoxX)tabControl_Permission.Controls[j].Controls[i];
                        if (thf.UserPermission == null || !(thf.UserPermission.Contains(chb.Name + ",")))
                            chb.Checked = true;

                    }


            //for (int i = 0; i < Global_Cls.HouseFor.Count; i++)
            //{
            //    DevComponents.DotNetBar.CheckBoxItem Ch = new DevComponents.DotNetBar.CheckBoxItem();
            //    Ch.Name = i.ToString();
            //    Ch.Text = Global_Cls.HouseFor[i];
            //    if (thf.UserPrmHouseFor != null && thf.UserPrmHouseFor.Contains(Ch.Text + ";"))
            //        Ch.Checked = true;

            //    itemPanel_HouseFor.Items.Add(Ch, i);
            //    itemPanel_HouseFor.Refresh();
            //}

            ShowDialog();
        }

        private void buttonItem_AllSel_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < tabControl_Permission.Controls.Count; j++)
                for (int i = 0; i < tabControl_Permission.Controls[j].Controls.Count; i++)
                    if (tabControl_Permission.Controls[j].Controls[i].GetType().FullName == "DevComponents.DotNetBar.Controls.CheckBoxX")
                    {
                        DevComponents.DotNetBar.Controls.CheckBoxX chb = (DevComponents.DotNetBar.Controls.CheckBoxX)tabControl_Permission.Controls[j].Controls[i];
                        chb.Checked = true;
                    }
        }

        private void buttonItem_AllDeSel_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < tabControl_Permission.Controls.Count; j++)
                for (int i = 0; i < tabControl_Permission.Controls[j].Controls.Count; i++)
                    if (tabControl_Permission.Controls[j].Controls[i].GetType().FullName == "DevComponents.DotNetBar.Controls.CheckBoxX")
                    {
                        DevComponents.DotNetBar.Controls.CheckBoxX chb = (DevComponents.DotNetBar.Controls.CheckBoxX)tabControl_Permission.Controls[j].Controls[i];
                        chb.Checked = false;
                    }
        }

        private void buttonItem_OK_Click(object sender, EventArgs e)
        {

            string StrUnCHK = "";
            for (int j = 0; j < tabControl_Permission.Controls.Count; j++)
                for (int i = 0; i < tabControl_Permission.Controls[j].Controls.Count; i++)
                    if (tabControl_Permission.Controls[j].Controls[i].GetType().FullName == "DevComponents.DotNetBar.Controls.CheckBoxX")
                    {
                        DevComponents.DotNetBar.Controls.CheckBoxX chbx = (DevComponents.DotNetBar.Controls.CheckBoxX)tabControl_Permission.Controls[j].Controls[i];
                        if (!chbx.Checked)
                            StrUnCHK += chbx.Name + ",";
                    }

            DataClasses_MainDataContext DCDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);

            TBL_User thf = DCDC.TBL_Users.First(th => th.UserCode.Equals(UserIDIndex));
            thf.UserPermission = StrUnCHK;
            thf.UserPrmHouseFor = "";//new
            DCDC.SubmitChanges();

            CloseOK = true;
            this.Close();
        }

        private void buttonItem_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserPermission_frm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar( Keys.Escape )) this.Close();
        }

        private void UserPermission_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Global_Cls.MainForm.CloseAllOK && !CloseOK && !Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, "آیا از این فرم خارج می شوید؟"))
                e.Cancel = true;
        }

        private void ribbonTabItem_Persons_CheckedChanged(object sender, EventArgs e)
        {
            if (ribbonTabItem_CusOper.Checked == false)
            {
                for (int j = 0; j < tabPage_Persons.Controls.Count; j++)

                    if (tabPage_Persons.Controls[j].GetType().FullName == "DevComponents.DotNetBar.Controls.CheckBoxX")
                    {
                        DevComponents.DotNetBar.Controls.CheckBoxX chb = (DevComponents.DotNetBar.Controls.CheckBoxX)tabPage_Persons.Controls[j];
                        chb.Checked = false;
                    }
            }
        }

        private void ribbonTabItem_Tools_CheckedChanged(object sender, EventArgs e)
        {
            if (ribbonTabItem_Tools.Checked == false)
            {
                for (int j = 0; j < tabPage_Tools.Controls.Count; j++)

                    if (tabPage_Tools.Controls[j].GetType().FullName == "DevComponents.DotNetBar.Controls.CheckBoxX")
                    {
                        DevComponents.DotNetBar.Controls.CheckBoxX chb = (DevComponents.DotNetBar.Controls.CheckBoxX)tabPage_Tools.Controls[j];
                        chb.Checked = false;
                    }
            }
        }



        private void ribbonTabItem_Reports_CheckedChanged(object sender, EventArgs e)
        {
            if (ribbonTabItem_Reports.Checked == false)
            {
                for (int j = 0; j < tabPage_Reports.Controls.Count; j++)

                    if (tabPage_Reports.Controls[j].GetType().FullName == "DevComponents.DotNetBar.Controls.CheckBoxX")
                    {
                        DevComponents.DotNetBar.Controls.CheckBoxX chb = (DevComponents.DotNetBar.Controls.CheckBoxX)tabPage_Reports.Controls[j];
                        chb.Checked = false;
                    }
            }

        }

        private void ribbonTabItem_CusOper_CheckedChanged(object sender, EventArgs e)
        {
            if (ribbonTabItem_CusOper.Checked == false )
            {
                for (int j = 0; j < tabPage_Persons.Controls.Count; j++)

                    if (tabPage_Persons.Controls[j].GetType().FullName == "DevComponents.DotNetBar.Controls.CheckBoxX")
                    {
                        DevComponents.DotNetBar.Controls.CheckBoxX chb = (DevComponents.DotNetBar.Controls.CheckBoxX)tabPage_Persons.Controls[j];
                        chb.Checked = false;
                    }
            }
        }

        private void ribbonTabItem_UNet_CheckedChanged(object sender, EventArgs e)
        {
            if (ribbonTabItem_UNet.Checked == false )
            {

                for (int j = 0; j < tabPage_UserNet.Controls.Count; j++)

                    if (tabPage_UserNet.Controls[j].GetType().FullName == "DevComponents.DotNetBar.Controls.CheckBoxX")
                    {
                        DevComponents.DotNetBar.Controls.CheckBoxX chb = (DevComponents.DotNetBar.Controls.CheckBoxX)tabPage_UserNet.Controls[j];
                        chb.Checked = false;
                    }
            }
        }

        private void ribbonTabItem_Setting_CheckedChanged(object sender, EventArgs e)
        {
            if (ribbonTabItem_Setting.Checked == false )
            {
                for (int j = 0; j < tabPage_Settings.Controls.Count; j++)

                    if (tabPage_Settings.Controls[j].GetType().FullName == "DevComponents.DotNetBar.Controls.CheckBoxX")
                    {
                        DevComponents.DotNetBar.Controls.CheckBoxX chb = (DevComponents.DotNetBar.Controls.CheckBoxX)tabPage_Settings.Controls[j];
                        chb.Checked = false;
                    }
            }
        }
        private void ribbonTabItem_Sys_CheckedChanged(object sender, EventArgs e)
        {
            if (ribbonTabItem_Sys.Checked == false )
            {
                for (int j = 0; j < tabPage_System.Controls.Count; j++)

                    if (tabPage_System.Controls[j].GetType().FullName == "DevComponents.DotNetBar.Controls.CheckBoxX")
                    {
                        DevComponents.DotNetBar.Controls.CheckBoxX chb = (DevComponents.DotNetBar.Controls.CheckBoxX)tabPage_System.Controls[j];
                        chb.Checked = false;
                    }
            }
        }
        private void ribbonTabItem_HouseFile_CheckedChanged(object sender, EventArgs e)
        {
            if (ribbonTabItem_HouseFile.Checked == false)
            {
                for (int j = 0; j < tabPage_CarFile.Controls.Count; j++)

                    if (tabPage_CarFile.Controls[j].GetType().FullName == "DevComponents.DotNetBar.Controls.CheckBoxX")
                    {
                        DevComponents.DotNetBar.Controls.CheckBoxX chb = (DevComponents.DotNetBar.Controls.CheckBoxX)tabPage_CarFile.Controls[j];
                        chb.Checked = false;
                    }
                pictureBox4.Enabled = false;

            }
        }
        private void ribbonBar_Duty_CheckedChanged(object sender, EventArgs e)
        {
            if (ribbonBar_Duty.Checked == false)
            {
                for (int j = 0; j < pictureBox_Duty.Controls.Count; j++)

                    if (pictureBox_Duty.Controls[j].GetType().FullName == "DevComponents.DotNetBar.Controls.CheckBoxX")
                    {
                        DevComponents.DotNetBar.Controls.CheckBoxX chb = (DevComponents.DotNetBar.Controls.CheckBoxX)pictureBox_Duty.Controls[j];
                        chb.Checked = false;
                    }
                pictureBox_Duty.Enabled = false;
            }
        }

       
        //private void ribbonBar_BkpRst_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (ribbonBar_BkpRst.Checked == false)
        //    {
        //        for (int j = 0; j < panel_Operate.Controls.Count; j++)

        //            if (panel_Operate.Controls[j].GetType().FullName == "DevComponents.DotNetBar.Controls.CheckBoxX")
        //            {
        //                DevComponents.DotNetBar.Controls.CheckBoxX chb = (DevComponents.DotNetBar.Controls.CheckBoxX)panel_Operate.Controls[j];
        //                chb.Checked = false;
        //            }
        //    }
        //}

        private void ribbonBar_Car_CheckedChanged(object sender, EventArgs e)
        {
            if (ribbonBar_Car.Checked == false)
            {
                for (int j = 0; j < pictureBox_Car.Controls.Count; j++)

                    if (pictureBox_Car.Controls[j].GetType().FullName == "DevComponents.DotNetBar.Controls.CheckBoxX")
                    {
                        DevComponents.DotNetBar.Controls.CheckBoxX chb = (DevComponents.DotNetBar.Controls.CheckBoxX)pictureBox_Car.Controls[j];
                        chb.Checked = false;
                    }
            }
        }

        

        //private void ribbonBar_Customer_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (ribbonBar_Customer.Checked == false)
        //    {
        //        for (int j = 0; j < panel_Persons.Controls.Count; j++)

        //            if (panel_Persons.Controls[j].GetType().FullName == "DevComponents.DotNetBar.Controls.CheckBoxX")
        //            {
        //                DevComponents.DotNetBar.Controls.CheckBoxX chb = (DevComponents.DotNetBar.Controls.CheckBoxX)panel_Persons.Controls[j];
        //                chb.Checked = false;
        //            }
        //    }
        //}

        //private void ribbonBar_Operator_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (ribbonBar_Operator.Checked == false)
        //    {
        //        for (int j = 0; j < panel_Operator.Controls.Count; j++)

        //            if (panel_Operator.Controls[j].GetType().FullName == "DevComponents.DotNetBar.Controls.CheckBoxX")
        //            {
        //                DevComponents.DotNetBar.Controls.CheckBoxX chb = (DevComponents.DotNetBar.Controls.CheckBoxX)panel_Operator.Controls[j];
        //                chb.Checked = false;
        //            }
        //    }
        //}

        //private void buttonItem_PerTelMob_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (buttonItem_PerTelMob.Checked == false)
        //    {
        //        for (int j = 0; j < panel_Tel.Controls.Count; j++)

        //            if (panel_Tel.Controls[j].GetType().FullName == "DevComponents.DotNetBar.Controls.CheckBoxX")
        //            {
        //                DevComponents.DotNetBar.Controls.CheckBoxX chb = (DevComponents.DotNetBar.Controls.CheckBoxX)panel_Tel.Controls[j];
        //                chb.Checked = false;
        //            }
        //    }
        //}

        //private void buttonItem_Users_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (buttonItem_Users.Checked == false)
        //    {
        //        for (int j = 0; j < panel_List.Controls.Count; j++)

        //            if (panel_List.Controls[j].GetType().FullName == "DevComponents.DotNetBar.Controls.CheckBoxX")
        //            {
        //                DevComponents.DotNetBar.Controls.CheckBoxX chb = (DevComponents.DotNetBar.Controls.CheckBoxX)panel_List.Controls[j];
        //                chb.Checked = false;
        //            }

        //    }
        //}

        //private void Node_FSet_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (Node_FSet.Checked == false)
        //    {
        //        for (int j = 0; j < panel_Setting.Controls.Count; j++)

        //            if (panel_Setting.Controls[j].GetType().FullName == "DevComponents.DotNetBar.Controls.CheckBoxX")
        //            {
        //                DevComponents.DotNetBar.Controls.CheckBoxX chb = (DevComponents.DotNetBar.Controls.CheckBoxX)panel_Setting.Controls[j];
        //                chb.Checked = false;
        //            }
        //    }
        //}

        //private void ribbonBar_System_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (ribbonBar_System.Checked == false)
        //    {
        //        for (int j = 0; j < panel_Sys.Controls.Count; j++)

        //            if (panel_Sys.Controls[j].GetType().FullName == "DevComponents.DotNetBar.Controls.CheckBoxX")
        //            {
        //                DevComponents.DotNetBar.Controls.CheckBoxX chb = (DevComponents.DotNetBar.Controls.CheckBoxX)panel_Sys.Controls[j];
        //                chb.Checked = false;
        //            }
        //    }
        //}

        //private void buttonItem_CustomerList_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (buttonItem_CustomerList.Checked == false)
        //    {
        //        for (int j = 0; j < panel_PersonsList.Controls.Count; j++)

        //            if (panel_PersonsList.Controls[j].GetType().FullName == "DevComponents.DotNetBar.Controls.CheckBoxX")
        //            {
        //                DevComponents.DotNetBar.Controls.CheckBoxX chb = (DevComponents.DotNetBar.Controls.CheckBoxX)panel_PersonsList.Controls[j];
        //                chb.Checked = false;
        //            }
        //    }
        //}

        //private void buttonItem_OperatorList_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (buttonItem_OperatorList.Checked == false)
        //    {
        //        for (int j = 0; j < panel_OperatorList.Controls.Count; j++)

        //            if (panel_OperatorList.Controls[j].GetType().FullName == "DevComponents.DotNetBar.Controls.CheckBoxX")
        //            {
        //                DevComponents.DotNetBar.Controls.CheckBoxX chb = (DevComponents.DotNetBar.Controls.CheckBoxX)panel_OperatorList.Controls[j];
        //                chb.Checked = false;
        //            }
        //    }
        //}

        

        

       
    }
}
