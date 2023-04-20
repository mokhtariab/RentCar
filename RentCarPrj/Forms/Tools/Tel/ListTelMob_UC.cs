using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RentCarPrj.Properties;
using RentCarPrj.DataLinq;

namespace RentCarPrj
{
    public partial class ListTelMob_UC : UserControl
    {
        public ListTelMob_UC()
        {
            InitializeComponent();
        }

        DataClasses_MainDataContext DCDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
        private void ShowTelGroup(int RowFocus)
        {
            var PT = from prd in DCDC.TBL_GroupTelMobs
                     select new { prd.GroupID, prd.GroupName };
            dataGridView_GroupMob.DataSource = PT;

            try
            {
                dataGridView_GroupMob.CurrentCell = dataGridView_GroupMob.Rows[RowFocus].Cells[dataGridView_GroupMob.CurrentCell.ColumnIndex];
            }
            catch
            {
                try { dataGridView_GroupMob.CurrentCell = dataGridView_GroupMob.Rows[0].Cells[0]; }
                catch { }
            }
        }


        private void ShowTelMob(int RowFocus, int GroupRow)
        {
            DataClasses_MainDataContext DCDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            var SU = from prd in DCDC.TBL_PersonTelMobs
                     select prd;
            if (GroupRow != 0)
                SU = from prd in DCDC.TBL_PersonTelMobs
                     join k in DCDC.TBL_GroupPersons on prd.PersonID equals k.PersonID //into h1 
                     where k.GroupID == GroupRow
                     select prd;

            ListWhereSearch = " Where (1=1) ";

            try
            {
                if (textBox_TPCode.Text != "")
                {
                    SU = SU.Where(i => i.PersonID.Equals(Convert.ToInt32(textBox_TPCode.Text)));
                    ListWhereSearch += " And (PersonID = " + textBox_TPCode.Text + ")";
                }
            }
            catch { }

            if (textBox_TPName.Text != "")
            {
                SU = SU.Where(i => i.FirstName.Contains(textBox_TPName.Text));
                ListWhereSearch += " And (FirstName like N'%" + textBox_TPName.Text + "%')";
            }

            if (textBox_TPFamily.Text != "")
            {
                SU = SU.Where(i => i.LastName.Contains(textBox_TPFamily.Text));
                ListWhereSearch += " And (LastName like N'%" + textBox_TPFamily.Text + "%')";
            }

            if (textBox_TPTel.Text != "")
            {
                SU = SU.Where(i => i.Telephone.Contains(textBox_TPTel.Text));
                ListWhereSearch += " And (Telephone like '%" + textBox_TPTel.Text + "%')";
            }

            if (textBox_TPMobile.Text != "")
            {
                SU = SU.Where(i => i.Mobile.Contains(textBox_TPMobile.Text));
                ListWhereSearch += " And (Mobile like '%" + textBox_TPMobile.Text + "%')";
            }


            var SU1 = SU.AsEnumerable()  // Moving to linq-to-objects 
                        .Select((r, j) => new
                        {
                            RowNo = j + 1,
                            r.FirstName,
                            r.LastName,
                            r.Mobile,
                            r.PersonID,
                            r.Telephone,
                            r.Email,
                            r.Address,
                            r.Description
                        }).ToList();

            dataGridView_TelMobList.DataSource = SU1;
            gridControlTelMpbList.DataSource = SU1;

            try
            {
                dataGridView_TelMobList.CurrentCell = dataGridView_TelMobList.Rows[RowFocus].Cells[dataGridView_TelMobList.CurrentCell.ColumnIndex];
            }
            catch
            {
                try { dataGridView_TelMobList.CurrentCell = dataGridView_TelMobList.Rows[0].Cells[1]; }
                catch { }
            }
        }

        private void ListTelMob_UC_Load(object sender, EventArgs e)
        {
            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains(bubbleButton_TMNew.Name)) bubbleButton_TMNew.Enabled = false;
                if (UPer.Contains(bubbleButton_TMEdit.Name)) bubbleButton_TMEdit.Enabled = false;
                if (UPer.Contains(bubbleButton_TMDel.Name)) bubbleButton_TMDel.Enabled = false;
                if (UPer.Contains(bubbleButton_CreateGroup.Name)) bubbleButton_CreateGroup.Enabled = false;
                if (UPer.Contains(bubbleButton_EditGroup.Name)) bubbleButton_EditGroup.Enabled = false;
                if (UPer.Contains(bubbleButton_DelGroup.Name)) bubbleButton_DelGroup.Enabled = false;
                if (UPer.Contains(bubbleButton_TMSMS.Name)) bubbleButton_TMSMS.Enabled = false;
                if (UPer.Contains(bubbleButton_TMRepTel.Name)) bubbleButton_TMRepTel.Enabled = false;
            }

            //codeing
            if (!Global_Cls.SoftwareCode.Contains("+S"))
                bubbleButton_TMSMS.Enabled = false;
            //codeing

            ShowTelGroup(0);
            ShowTelMob(0, Convert.ToInt32(dataGridView_GroupMob.CurrentRow.Cells["GroupID"].Value));
            try
            {
                dataGridView_TelMobList.CurrentCell = dataGridView_TelMobList.Rows[dataGridView_TelMobList.RowCount - 1].Cells[dataGridView_TelMobList.CurrentCell.ColumnIndex];
            }
            catch { }

        }

        private void bubbleButton_TMNew_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            NETelMob_frm TMf = new NETelMob_frm();
            TMf.PersonID = 0;
            //try
            //{
            //    TMf.PersonID = Convert.ToInt32(dataGridView_TelMobList.CurrentRow.Cells[0].Value);
            //}
            //catch
            //{
            //    TMf.PersonID = 0;
            //}

            int rowcnt = dataGridView_TelMobList.Rows.Count;
            int RFocus = 0;
            if (rowcnt != 0) RFocus = dataGridView_TelMobList.CurrentRow.Index;
            TMf.UseFormInInsertOrEditMode(1);

            ShowTelMob(RFocus, Convert.ToInt32(dataGridView_GroupMob.CurrentRow.Cells["GroupID"].Value));
            if (dataGridView_TelMobList.Rows.Count > rowcnt)
                dataGridView_TelMobList.CurrentCell = dataGridView_TelMobList.Rows[rowcnt].Cells[dataGridView_TelMobList.CurrentCell.ColumnIndex];
        }

        private void EditTelMobFunc()
        {
            if (dataGridView_TelMobList.RowCount == 0) return;
            int RFocus = dataGridView_TelMobList.CurrentRow.Index;
            try
            {
                NETelMob_frm TMf = new NETelMob_frm();

                TMf.PersonID = Convert.ToInt32(dataGridView_TelMobList.CurrentRow.Cells["PersonID"].Value);
                TMf.textBox_Name.Text = Convert.ToString(dataGridView_TelMobList.CurrentRow.Cells["FirstName"].Value);
                TMf.textBox_Family.Text = Convert.ToString(dataGridView_TelMobList.CurrentRow.Cells["LastName"].Value);
                TMf.textBox_Tel.Text = Convert.ToString(dataGridView_TelMobList.CurrentRow.Cells["Telephone"].Value);
                TMf.textBox_Mobile.Text = Convert.ToString(dataGridView_TelMobList.CurrentRow.Cells["Mobile"].Value);
                TMf.textBox_Email.Text = Convert.ToString(dataGridView_TelMobList.CurrentRow.Cells["Email"].Value);
                TMf.textBox_Address.Text = Convert.ToString(dataGridView_TelMobList.CurrentRow.Cells["Address"].Value);
                TMf.textBox_Desc.Text = Convert.ToString(dataGridView_TelMobList.CurrentRow.Cells["Description"].Value);

                TMf.UseFormInInsertOrEditMode(2);

                ShowTelMob(RFocus, Convert.ToInt32(dataGridView_GroupMob.CurrentRow.Cells["GroupID"].Value));
            }
            catch { }
        }

        private void bubbleButton_TMEdit_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            EditTelMobFunc();
        }

        private void dataGridView_TelMobList_DoubleClick(object sender, EventArgs e)
        {
            if (bubbleButton_TMEdit.Enabled) EditTelMobFunc();
        }

        private void bubbleButton_TMDel_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            try
            {
                if (dataGridView_TelMobList.RowCount == 0) return;

                int RFocus = dataGridView_TelMobList.CurrentRow.Index;

                DataClasses_MainDataContext DCDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
                TBL_PersonTelMob tptm = DCDC.TBL_PersonTelMobs.First(tp => tp.PersonID.Equals(Convert.ToInt32(dataGridView_TelMobList.CurrentRow.Cells["PersonID"].Value)));
                if (Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, "آیا به حذف این شخص از دفتر تلفن اطمینان دارید؟"))
                {
                    DCDC.TBL_PersonTelMobs.DeleteOnSubmit(tptm);
                    DCDC.SubmitChanges();

                    try
                    {
                        TBL_GroupPerson tgp = DCDC.TBL_GroupPersons.First(th => th.PersonID == Convert.ToInt32(dataGridView_TelMobList.CurrentRow.Cells["PersonID"].Value));
                        DCDC.TBL_GroupPersons.DeleteOnSubmit(tgp);
                        DCDC.SubmitChanges();
                    }
                    catch { }

                    ShowTelMob(RFocus - 1, Convert.ToInt32(dataGridView_GroupMob.CurrentRow.Cells["GroupID"].Value));
                }
            }
            catch { }
        }

        private void bubbleButton_TMSMS_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            if (dataGridView_TelMobList.RowCount != 0)
                Global_Cls.SendSMS_Advertisment(true, "", dataGridView_TelMobList.CurrentRow.Index.ToString());
        }

        DevComponents.DotNetBar.Controls.TextBoxX tbx = null;
        string ListWhereSearch = "";
        private void textBox_TPCode_TextChanged(object sender, EventArgs e)
        {
            DataClasses_MainDataContext DCDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            tbx = (DevComponents.DotNetBar.Controls.TextBoxX)sender;
            try
            {
                var SU = from prd in DCDC.TBL_PersonTelMobs
                         select prd;

                ListWhereSearch = " Where (1=1) ";
                //try
                //{
                //    if (textBox_TPCode.Text != "")
                //    {
                //        SU = SU.Where(i => i.PersonID == Convert.ToInt32(textBox_TPCode.Text));
                //        ListWhereSearch += " And (PersonID = " + textBox_TPCode.Text + ")";
                //    }
                //}
                //catch { }

                if (textBox_TPName.Text != "")
                {
                    SU = SU.Where(i => i.FirstName.Contains(textBox_TPName.Text));
                    ListWhereSearch += " And (FirstName like N'%" + textBox_TPName.Text + "%')";
                }

                if (textBox_TPFamily.Text != "")
                {
                    SU = SU.Where(i => i.LastName.Contains(textBox_TPFamily.Text));
                    ListWhereSearch += " And (LastName like N'%" + textBox_TPFamily.Text + "%')";
                }

                if (textBox_TPTel.Text != "")
                {
                    SU = SU.Where(i => i.Telephone.Contains(textBox_TPTel.Text));
                    ListWhereSearch += " And (Telephone like '%" + textBox_TPTel.Text + "%')";
                }

                if (textBox_TPMobile.Text != "")
                {
                    SU = SU.Where(i => i.Mobile.Contains(textBox_TPMobile.Text));
                    ListWhereSearch += " And (Mobile like '%" + textBox_TPMobile.Text + "%')";
                }


                var SU1 = SU.AsEnumerable()  // Moving to linq-to-objects 
                        .Select((r, j) => new
                        {
                            RowNo = j + 1,
                            r.FirstName,
                            r.LastName,
                            r.Mobile,
                            r.PersonID,
                            r.Telephone,
                            r.Email,
                            r.Address,
                            r.Description
                        }).ToList();

                dataGridView_TelMobList.DataSource = SU1;
                gridControlTelMpbList.DataSource = SU1;

            }
            catch { }

        }

        private void bubbleButton_TMRepTel_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            //string WhereList = " Where (1=1) ";
            //if (dataGridView_TelMobList.RowCount > 0)
            //{
            //    WhereList += " and PersonID in (0";
            //    for (int i = 0; i < dataGridView_TelMobList.RowCount; i++)
            //        WhereList += "," + dataGridView_TelMobList.Rows[i].Cells["PersonID"].Value.ToString();
            //    WhereList += ")";
            //}

            //ReportClass_Cls.FileReportCreate_Rep(true, ReportClass_Cls.TableCreatePerTelMobTbl_Report("دفترتلفن", false) + WhereList,//ListWhereSearch,// " SELECT * FROM TBL_PersonTelMob " + ListWhereSearch,
            //    "دفترتلفن", Global_Cls.ReportDesignAddress[14]);
            
            PrintPreview_frm PP = new PrintPreview_frm(gridControlTelMpbList);
            PP.ShowDialog();
        }

        private void dataGridView_TelMobList_Paint(object sender, PaintEventArgs e)
        {
            textBox_TPCode.Width = dataGridView_TelMobList.Columns["RowNo"].Width - 2;
            textBox_TPName.Width = dataGridView_TelMobList.Columns["FirstName"].Width - 2;
            textBox_TPFamily.Width = dataGridView_TelMobList.Columns["LastName"].Width - 2;
            textBox_TPTel.Width = dataGridView_TelMobList.Columns["Telephone"].Width - 2;
            textBox_TPMobile.Width = dataGridView_TelMobList.Columns["Mobile"].Width - 2;

            textBox_TPCode.Left = dataGridView_TelMobList.Left + 40;
            textBox_TPName.Left = textBox_TPCode.Left + dataGridView_TelMobList.Columns["Mobile"].Width;
            textBox_TPFamily.Left = textBox_TPName.Left + dataGridView_TelMobList.Columns["Telephone"].Width;
            textBox_TPTel.Left = textBox_TPFamily.Left + dataGridView_TelMobList.Columns["LastName"].Width;
            textBox_TPMobile.Left = textBox_TPTel.Left + dataGridView_TelMobList.Columns["FirstName"].Width;
        }

        private void bubbleButton_CreateGroup_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            NEMobGroup_frm nemg = new NEMobGroup_frm(true);
            nemg.ShowDialog();
            ShowTelGroup(dataGridView_GroupMob.Rows.Count);
        }

        private void bubbleButton_EditGroup_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            int RFocus = dataGridView_GroupMob.CurrentRow.Index;
            NEMobGroup_frm nemg = new NEMobGroup_frm(false, Convert.ToInt32(dataGridView_GroupMob.CurrentRow.Cells["GroupID"].Value),
                dataGridView_GroupMob.CurrentRow.Cells["GroupName"].Value.ToString());
            nemg.ShowDialog();

            ShowTelGroup(RFocus);
            ShowTelMob(RFocus, Convert.ToInt32(dataGridView_GroupMob.CurrentRow.Cells["GroupID"].Value));
        }

        private void dataGridView_GroupMob_SelectionChanged(object sender, EventArgs e)
        {
            ShowTelMob(0, Convert.ToInt32(dataGridView_GroupMob.CurrentRow.Cells["GroupID"].Value));
        }

        private void bubbleButton_DelGroup_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            try
            {
                if (dataGridView_GroupMob.RowCount == 0) return;
                if (Convert.ToInt32(dataGridView_GroupMob.CurrentRow.Cells["GroupID"].Value) == 0) return;

                int RFocus = dataGridView_GroupMob.CurrentRow.Index;

                DataClasses_MainDataContext DCDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
                try
                {
                    DCDC.TBL_GroupPersons.First(gg => gg.GroupID == Convert.ToInt32(dataGridView_GroupMob.CurrentRow.Cells["GroupID"].Value));
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, false, "امکان حذف این گروه به دلیل وجود زیرمجموعه وجود ندارد");
                    return;
                }
                catch { }

                TBL_GroupTelMob tptm = DCDC.TBL_GroupTelMobs.First(tp => tp.GroupID == Convert.ToInt32(dataGridView_GroupMob.CurrentRow.Cells["GroupID"].Value));

                if (Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, "آیا به حذف این گروه از دفتر تلفن اطمینان دارید؟"))
                {
                    DCDC.TBL_GroupTelMobs.DeleteOnSubmit(tptm);
                    DCDC.SubmitChanges();
                    ShowTelGroup(RFocus - 1);
                }
            }
            catch { }
        }


    }
}
