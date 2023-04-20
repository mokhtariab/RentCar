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
    public partial class SelectPerson_frm: Form
    {

        int _type = 0, _code = 0;
        bool _free = false;
        public SelectPerson_frm(int Type)
        {
            InitializeComponent();
            _type = Type;
        }
        
        public SelectPerson_frm(int Type, int Code)
        {
            InitializeComponent();
            _type = Type;
            _code = Code;
        }

        public SelectPerson_frm(int Type, bool Free)
        {
            InitializeComponent();
            _type = Type;
            _free = Free;
        }

        public void DataBind()
        {
            var SU = from prd in DCDC.TBL_Customers
                     where prd.IsParent == false && prd.Active == true 
                     select new
                     {
                         Code = prd.CustomerID,
                         Name = prd.CustomerName,
                         Other = prd.Mobile
                     };
            if (_code != 0)
            {
                SU = from prd in DCDC.TBL_Customers
                     where prd.IsParent == false && prd.CustomerType == _code && prd.Active == true 
                     select new
                     {
                         Code = prd.CustomerID,
                         Name = prd.CustomerName,
                         Other = prd.Mobile
                     };

            }
            if (_type == 1)
            {
                if (!_free)
                {
                    SU = from prd in DCDC.TBL_Operators
                         join k in DCDC.TBL_CarDuties on prd.OperatorCode equals k.DriverCode into h1
                         from h2 in h1.DefaultIfEmpty()
                         where (h2.RentType == 2 && h2.DutyDate == (from l in DCDC.TBL_CarDuties where l.DriverCode == prd.OperatorCode select l.DutyDate).Max() &&
                                                    h2.DutyNumber == (from l in DCDC.TBL_CarDuties where l.DriverCode == prd.OperatorCode select l.DutyNumber).Max())
                                                    || h2.RentType == null

                         select new
                         {
                             Code = prd.OperatorCode,
                             Name = prd.OperatorName,
                             Other = prd.Mobile
                         };
                }
                else
                {
                    SU = from prd in DCDC.TBL_Operators
                         select new
                         {
                             Code = prd.OperatorCode,
                             Name = prd.OperatorName,
                             Other = prd.Mobile
                         };
                }

            }
            if (_type == 2)
            {
                if (!_free)
                {
                    SU = from prd in DCDC.TBL_Cars
                         //join k in DCDC.TBL_CarDuties on prd.CarID equals k.CarID into j1
                         //from j2 in j1.DefaultIfEmpty()
                         //where (j2.RentType == 2 && j2.DutyCode == (from h in DCDC.TBL_CarDuties
                         //                                           where h.CarID == prd.CarID
                         //                                           select h.DutyCode).Max()) || j2.RentType == null
                         where prd.Active == true || prd.Active == null
                         select new
                         {
                             Code = prd.CarID,
                             Name = prd.CarName,
                             Other = prd.DisciplineNO
                         };
                }
                else
                {
                    SU = from prd in DCDC.TBL_Cars
                         select new
                         {
                             Code = prd.CarID,
                             Name = prd.CarName,
                             Other = prd.DisciplineNO
                         };
                }


                dataGridView_SelectPerson.Columns["Other"].HeaderText = "شماره پلاک";
            }

            try
            {
                if (textBoxName.Text != "")
                    SU = SU.Where(i => i.Name.Contains(textBoxName.Text));

                if (textBoxOther.Text != "")
                    SU = SU.Where(i => i.Other.Contains(textBoxOther.Text));
            }
            catch { }
            dataGridView_SelectPerson.DataSource = SU;
        }
        
        
        DataClasses_MainDataContext DCDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
        private void textBox_Code_TextChanged(object sender, EventArgs e)
        {
            DataBind();
        }


        public int CodeC = 0;
        public string NameC = "";

        private void dataGridView_SelectPerson_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                CodeC = int.Parse(dataGridView_SelectPerson.CurrentRow.Cells["CCode"].Value.ToString());
                NameC = dataGridView_SelectPerson.CurrentRow.Cells["CName"].Value.ToString();
                Close();
            }
            catch { }
        }

        private void SelectPerson_frm_Load(object sender, EventArgs e)
        {
            DataBind();
            errorProvider.SetError(dataGridView_SelectPerson, "جهت انتخاب بر روی ردیف مورد نظر دوبار کلیک نمایید");
            errorProvider.SetIconAlignment(dataGridView_SelectPerson, ErrorIconAlignment.TopRight);
            textBoxOther.Focus();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            
            if (_type == 0)
            {
                CustomerNE_frm Cu = new CustomerNE_frm(true, 4, 0);
                Cu.ShowDialog();
            }
            if (_type == 1)
            {
                OperatorNE_frm Cu = new OperatorNE_frm();
                Cu.ShowDialog();
            }
            if (_type == 2)
            {
                CarNE_frm Cu = new CarNE_frm(true, 2, 0);
                Cu.ShowDialog();
            }
            DataBind();
        }

        private void dataGridView_SelectPerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == Convert.ToChar(Keys.Enter))
            //    dataGridView_SelectPerson_DoubleClick(this, null);
        }

    }
}
