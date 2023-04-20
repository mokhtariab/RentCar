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
    public partial class CarList_UC : UserControl
    {
        public CarList_UC()
        {
            InitializeComponent();
        }

        DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);



        #region Load & UI

        
        private void CarList_UC_Load(object sender, EventArgs e)
        {
            InterFaceChange();
            ShowListCar(1);
        }

        private void InterFaceChange()
        {

            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains(buttonItemCarEdit.Name)) buttonItemCarEdit.Enabled = false;
                if (UPer.Contains(buttonItemCarDel.Name)) buttonItemCarDel.Enabled = false;
                if (UPer.Contains(buttonItemCarPrintList.Name)) buttonItemCarPrintList.Enabled = false;
                if (UPer.Contains(buttonItemDutyEdit.Name)) buttonItemDutyEdit.Enabled = false;
                if (UPer.Contains(buttonItemDutyDel.Name)) buttonItemDutyDel.Enabled = false;
                if (UPer.Contains(buttonItemDutyPrintList.Name)) buttonItemDutyPrintList.Enabled = false;
                if (UPer.Contains(buttonTechnicalView.Name)) buttonTechnicalView.Enabled = false;
                if (UPer.Contains(button_Duty2Set.Name)) button_Duty2Set.Enabled = false;
                if (UPer.Contains(button_DutyBack.Name)) button_DutyBack.Enabled = false;
                if (UPer.Contains(buttonCarSMS.Name)) buttonCarSMS.Enabled = false;
                if (UPer.Contains(buttonCarEmail.Name)) buttonCarEmail.Enabled = false;
            }

            //codeing
            if (!Global_Cls.SoftwareCode.Contains("+S"))
            {
                buttonCarSMS.Enabled = false;
            }
            if (Global_Cls.SoftwareCode.Contains("L1") || Global_Cls.SoftwareCode.Contains("N1") || Global_Cls.SoftwareCode == "Trial")
            {
                buttonCarEmail.Enabled = false;
                buttonTechnicalView.Enabled = false;
                button_AlarmCar.Enabled = false;
            }
            //if (Global_Cls.SoftwareCode == "Trial")
            //{
            //    buttonItem_ieSearch.Enabled = false;
            //    buttonItem_SearchHouse.Enabled = false;
            //}
            //codeing
        }

        private void CarList_UC_Layout(object sender, LayoutEventArgs e)
        {
            try
            {
                if (Global_Cls.CarLayout)
                {
                    ShowListCar(gridView_CarList.RowCount);
                    Global_Cls.CarLayout = false;
                }
            }
            catch { }
        }

        private void SetAlarm()
        {
            DCMDC.SP_AlarmSetForTBLCar(Global_Cls.GetFinePeriod, Global_Cls.ExpDayCarEnter, Global_Cls.ExpDayCarDuty,
                                        Global_Cls.ExpDayBodyInsu, Global_Cls.ExpDayThirdInsu);
        }

        #endregion


        #region Search
        private void ShowListCar(int RowFocus)
        {
            SetAlarm();
            var SUS = from prd in DCMDC.TBL_Cars
                      select new
                      {
                          prd.CarID,
                          prd.CarNumber,
                          prd.BodyNO,
                          prd.CarName,
                          prd.CarPic,
                          prd.CarType,
                          prd.ColorSet,
                          CreateDate = Global_Cls.MiladiDateToShamsi(prd.CreateDate.Value == null ? DateTime.Now : prd.CreateDate.Value),
                          prd.DisciplineNO,
                          prd.EngineNO,
                          EnterTypeStr = (prd.EnterType == 1 ? "خرید" : prd.EnterType == 2 ? "همکار" : "شخص"),
                          prd.EnterType,
                          InsuranceBodyExpDate = Global_Cls.MiladiDateToShamsi(prd.InsuranceBodyExpDate.Value == null ? DateTime.Now : prd.InsuranceBodyExpDate.Value),
                          prd.InsuranceBodyPrice,
                          InsuranceThirdExpDate = Global_Cls.MiladiDateToShamsi(prd.InsuranceThirdExpDate.Value == null ? DateTime.Now : prd.InsuranceThirdExpDate.Value),
                          prd.InsuranceThirdPrice,
                          LordName = (DCMDC.TBL_Customers.First(Cr => Cr.CustomerID.Equals(prd.LordCode)).CustomerName),
                          prd.MadeCountry,
                          ProductDate = Global_Cls.MiladiDateToShamsi(prd.ProductDate.Value),
                          prd.RingType,
                          EndEnterDate = Global_Cls.MiladiDateToShamsi((DCMDC.TBL_CarEnters.First(Cr => Cr.CarID.Equals(prd.CarID)).EndEnterDate.Value) == null ? DateTime.Now : (DCMDC.TBL_CarEnters.First(Cr => Cr.CarID.Equals(prd.CarID)).EndEnterDate.Value)),
                          prd.Status,
                          prd.Active
                      };
            gridControl_CarList.DataSource = SUS;
            gridView_CarList.FocusedRowHandle = RowFocus;
        }

        private void gridView_CarList_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int Index = gridView_CarList.FocusedRowHandle;
            Index = Convert.ToInt32(gridView_CarList.GetRowCellValue(Index, "CarID"));
            var DUS = from prd in DCMDC.TBL_CarDuties
                      where prd.CarID == Index
                      orderby prd.DutyCode descending
                      select new
                      {
                          prd.CarID,
                          prd.DutyCode,
                          prd.DutyNumber,
                          prd.CarFaceCode,
                          prd.CertifedCode,
                          DutyDate = Global_Cls.MiladiDateToShamsi(prd.DutyDate.Value),
                          DutyTypeStr = (prd.DutyType == 0 ? "سرویس" : prd.DutyType == 1 ? "تمدید" : "عودت"),
                          prd.DutyType,
                          OperatorName = (DCMDC.TBL_Operators.First(Cr => Cr.OperatorCode.Equals(prd.OperatorCode)).OperatorName),
                          RentPersonName = (DCMDC.TBL_Customers.First(Cr => Cr.CustomerID.Equals(prd.RentPersonCode)).CustomerName),
                          DeliveryDate = Global_Cls.MiladiDateToShamsi(prd.DeliveryDate.Value),
                          RejectDate = Global_Cls.MiladiDateToShamsi(prd.RejectDate.Value),
                          RentTypeStr = (prd.RentType == 0 ? "شخص حقیقی" : prd.RentType == 1 ? "اشخاص حقوقی" : prd.RentType == 2 ? "هتل ها" : prd.RentType == 3 ? "فرودگاه ها" : prd.RentType == 4 ? "اشخاص خارجی" : prd.RentType == 5 ? "همکار" : "سایر"),
                          prd.RentType,
                          prd.TotalPrice
                      };
            gridControl_DutyList.DataSource = DUS;
        }

        #endregion



        #region Car Button

        private void buttonItemSelector_Click(object sender, EventArgs e)
        {
            gridView_CarList.ColumnsCustomization(new Point(100, 100));
        }

        private void buttonItemCarSearch_Click(object sender, EventArgs e)
        {
            gridView_CarList.OptionsView.ShowAutoFilterRow = !gridView_CarList.OptionsView.ShowAutoFilterRow;
        }

        CarNE_frm CarNE = null;
        int IndexCarNE = 0;
        private void buttonItemCarEdit_Click(object sender, EventArgs e)
        {
            if (buttonItemCarEdit.Enabled && buttonItemCarEdit.Visible)
            {
                if (gridView_CarList.RowCount == 0) return;
                if (CarNE == null)
                {
                    IndexCarNE = gridView_CarList.FocusedRowHandle;
                    CarNE = new CarNE_frm(false, Convert.ToInt32(gridView_CarList.GetRowCellValue(IndexCarNE, "EnterType")), Convert.ToInt32(gridView_CarList.GetRowCellValue(IndexCarNE, "CarID")));

                    CarNE.Disposed += new EventHandler(CarNE_Disposed);
                }
                CarNE.Show();
                CarNE.BringToFront();
                CarNE.Focus();
            }
        }
        
        void CarNE_Disposed(object sender, EventArgs e)
        {
            CarNE = null;
            ShowListCar(IndexCarNE);
        }

        private void buttonItemCarDel_Click(object sender, EventArgs e)
        {
            if (gridView_CarList.RowCount == 0) return;
            if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این اتومبیل حذف شود (به لیست حذفیات اضافه شود)؟")) return;
            int Index = gridView_CarList.FocusedRowHandle;
            
            DCMDC.SP_InsDelRecordCar(Convert.ToInt32(gridView_CarList.GetRowCellValue(Index, "CarID")), true);
            DCMDC.SubmitChanges();

            ShowListCar(Index);
        }

        private void buttonItemCarPrintList_Click(object sender, EventArgs e)
        {
            //gridView_CustomerList.FormatConditions[0].Appearance.BackColor = Color.White;
            //gridView_CustomerList.FormatConditions[1].Appearance.BackColor = Color.White;
            //gridView_CustomerList.FormatConditions[2].Appearance.BackColor = Color.White;
            //gridView_CustomerList.FormatConditions[3].Appearance.BackColor = Color.White;
            //gridView_CustomerList.FormatConditions[4].Appearance.BackColor = Color.White;

            PrintPreview_frm PP = new PrintPreview_frm(gridControl_CarList);
            PP.ShowDialog();

            //gridView_CustomerList.FormatConditions[0].Appearance.BackColor = Color.PaleGreen;
            //gridView_CustomerList.FormatConditions[1].Appearance.BackColor = Color.Bisque;
            //gridView_CustomerList.FormatConditions[2].Appearance.BackColor = Color.Pink;
            //gridView_CustomerList.FormatConditions[3].Appearance.BackColor = Color.LemonChiffon;
            //gridView_CustomerList.FormatConditions[4].Appearance.BackColor = Color.Gainsboro;
        }

        #endregion


        #region Duty Button

        DutyNE_frm DutyNE = null;
        int IndexDLNE = 0, IndexCLNE = 0;
        private void buttonItemDutyEdit_Click(object sender, EventArgs e)
        {
            if (buttonItemDutyEdit.Enabled && buttonItemDutyEdit.Visible)
            {
                if (gridView_DutyList.RowCount == 0) return;

                if (DutyNE == null)
                {
                    IndexDLNE = gridView_DutyList.FocusedRowHandle;
                    IndexCLNE = gridView_CarList.FocusedRowHandle;

                    int CarID = Convert.ToInt32(gridView_DutyList.GetRowCellValue(IndexDLNE, "CarID"));
                    int DutyCode = Convert.ToInt32(gridView_DutyList.GetRowCellValue(IndexDLNE, "DutyCode"));
                    int DutyType = Convert.ToInt32(gridView_DutyList.GetRowCellValue(IndexDLNE, "DutyType"));
                    int RentType = Convert.ToInt32(gridView_DutyList.GetRowCellValue(IndexDLNE, "RentType"));

                    DutyNE = new DutyNE_frm(false, DutyCode, CarID, DutyType, RentType);

                    DutyNE.Disposed += new EventHandler(DutyNE_Disposed);
                }
                DutyNE.Show();
                DutyNE.BringToFront();
                DutyNE.Focus();
            }
        }

        void DutyNE_Disposed(object sender, EventArgs e)
        {
            DutyNE = null;
            ShowListCar(IndexCLNE);

            gridView_CarList.FocusedRowHandle = IndexCLNE;
            gridView_DutyList.FocusedRowHandle = IndexDLNE;
        }

        private void buttonItemDutySearch_Click(object sender, EventArgs e)
        {
            gridView_DutyList.OptionsView.ShowAutoFilterRow = !gridView_DutyList.OptionsView.ShowAutoFilterRow;
        }

        private void buttonItemDutyPrintList_Click(object sender, EventArgs e)
        {
            gridView_DutyList.FormatConditions[0].Appearance.BackColor = Color.White;
            gridView_DutyList.FormatConditions[1].Appearance.BackColor = Color.White;
            gridView_DutyList.FormatConditions[2].Appearance.BackColor = Color.White;

            PrintPreview_frm PP = new PrintPreview_frm(gridControl_DutyList);
            PP.ShowDialog();

            gridView_DutyList.FormatConditions[0].Appearance.BackColor = Color.Pink;
            gridView_DutyList.FormatConditions[1].Appearance.BackColor = Color.LemonChiffon;
            gridView_DutyList.FormatConditions[2].Appearance.BackColor = Color.PaleGreen;
        }

        private void buttonItemDutySelector_Click(object sender, EventArgs e)
        {
            gridView_DutyList.ColumnsCustomization(new Point(100, 200));
        }

        private void buttonItemDutyDel_Click(object sender, EventArgs e)
        {
            if (gridView_DutyList.RowCount == 0) return;

            int Index = gridView_DutyList.FocusedRowHandle;
            int Index1 = gridView_CarList.FocusedRowHandle;

            int CarID = Convert.ToInt32(gridView_DutyList.GetRowCellValue(Index, "CarID"));
            int DutyCode = Convert.ToInt32(gridView_DutyList.GetRowCellValue(Index, "DutyCode"));
            int CarFaceCode = Convert.ToInt32(gridView_DutyList.GetRowCellValue(Index, "CarFaceCode"));
            int CertifedCode = Convert.ToInt32(gridView_DutyList.GetRowCellValue(Index, "CertifedCode"));

            if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این سرویس حذف شود؟")) return;

            try
            {
                TBL_Certificate tc = DCMDC.TBL_Certificates.First(hf => hf.CertificateCode.Equals(CertifedCode));
                DCMDC.TBL_Certificates.DeleteOnSubmit(tc);
                DCMDC.SubmitChanges();
            }
            catch { }

            try
            {
                TBL_CarFace tf = DCMDC.TBL_CarFaces.First(hf => hf.CarFaceID.Equals(CarFaceCode));
                DCMDC.TBL_CarFaces.DeleteOnSubmit(tf);
                DCMDC.SubmitChanges();
            }
            catch { }

            TBL_CarDuty thsf = DCMDC.TBL_CarDuties.First(hf => hf.CarID.Equals(CarID) && hf.DutyCode.Equals(DutyCode));
            DCMDC.TBL_CarDuties.DeleteOnSubmit(thsf);
            DCMDC.SubmitChanges();

            ShowListCar(Index1);
            gridView_DutyList.FocusedRowHandle = Index - 1;
        }

        #endregion

        ActionCarList_frm Acl = null;
        int IndexAcl = 0;
        private void buttonTechnicalView_Click(object sender, EventArgs e)
        {
            if (gridView_CarList.RowCount == 0) return;

            if (Acl == null)
            {
                IndexAcl = gridView_CarList.FocusedRowHandle;

                Acl = new ActionCarList_frm(Convert.ToInt32(gridView_CarList.GetRowCellValue(IndexAcl, "CarID")));
                Acl.Disposed += new EventHandler(Acl_Disposed);
            }
            Acl.Show();
            Acl.BringToFront();
            Acl.Focus();
        }

        void Acl_Disposed(object sender, EventArgs e)
        {
            Acl = null;
        }


        private void button_AlarmCar_Click(object sender, EventArgs e)
        {
            Setting_frm Sf = new Setting_frm();
            Sf.treeView_Setting.SelectedNode = Sf.treeView_Setting.Nodes["Node_SetAlarms"];
            Sf.ShowDialog();
        }

        DutyNE_frm D2Set = null;
        int IndexDL2Set = 0, IndexCL2Set = 0;
        private void button_Duty2Set_Click(object sender, EventArgs e)
        {
            if (gridView_DutyList.RowCount == 0) return;

            if (D2Set == null)
            {
                IndexDL2Set = gridView_DutyList.FocusedRowHandle;
                IndexCL2Set = gridView_CarList.FocusedRowHandle;

                int CarID = Convert.ToInt32(gridView_DutyList.GetRowCellValue(IndexDL2Set, "CarID"));
                int DutyType = Convert.ToInt32(gridView_DutyList.GetRowCellValue(IndexDL2Set, "DutyType"));


                var DUS = (from prd in DCMDC.TBL_CarDuties
                           where prd.CarID == CarID
                           select prd.DutyCode).Max();
                try
                {
                    if (DCMDC.TBL_CarDuties.First(cr => cr.DutyCode == DUS && cr.CarID == CarID).RentType.Value == 2)
                    {
                        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, " سرویسی جهت تمدید ثبت نشده است");
                        return;
                    }

                    D2Set = new DutyNE_frm(true, DUS, CarID, DutyType, 1);
                    D2Set.Disposed += new EventHandler(D2Set_Disposed);
                    
                }
                catch
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, " سرویسی جهت تمدید ثبت نشده است");
                }
            }

            D2Set.Show();
            D2Set.BringToFront();
            D2Set.Focus();
        }

        void D2Set_Disposed(object sender, EventArgs e)
        {
            D2Set = null;

            ShowListCar(IndexCL2Set);
            gridView_DutyList.FocusedRowHandle = IndexDL2Set;
        }




        DutyNE_frm DBack = null;
        int IndexDLBack = 0, IndexCLBack = 0;
        private void button_DutyBack_Click(object sender, EventArgs e)
        {
            if (gridView_DutyList.RowCount == 0) return;


            if (DBack == null)
            {
                IndexDLBack = gridView_DutyList.FocusedRowHandle;
                IndexCLBack = gridView_CarList.FocusedRowHandle;

                int CarID = Convert.ToInt32(gridView_DutyList.GetRowCellValue(IndexDLBack, "CarID"));
                int DutyType = Convert.ToInt32(gridView_DutyList.GetRowCellValue(IndexDLBack, "DutyType"));

                var DUS = (from prd in DCMDC.TBL_CarDuties
                           where prd.CarID == CarID
                           select prd.DutyCode).Max();
                if (DCMDC.TBL_CarDuties.First(cr => cr.DutyCode == DUS && cr.CarID == CarID).RentType.Value == 2)
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, " سرویسی جهت عودت ثبت نشده است");
                    return;
                }
                
                DBack = new DutyNE_frm(true, DUS, CarID, DutyType, 2);
                DBack.Disposed += new EventHandler(DBack_Disposed);
            }
            DBack.Show();
            DBack.BringToFront();
            DBack.Focus();
        }

        void DBack_Disposed(object sender, EventArgs e)
        {
            DBack = null;

            ShowListCar(IndexCLBack);
            gridView_DutyList.FocusedRowHandle = IndexDLBack;
        }


        private void buttonItemDutyFaceCar_Click(object sender, EventArgs e)
        {
            if (gridView_DutyList.RowCount == 0) return;
            int Index = gridView_DutyList.FocusedRowHandle;
            int Index1 = gridView_CarList.FocusedRowHandle;

            int CarID = Convert.ToInt32(gridView_DutyList.GetRowCellValue(Index, "CarID"));
            int RentType = Convert.ToInt32(gridView_DutyList.GetRowCellValue(Index, "RentType"));
            int CarFaceCode = Convert.ToInt32(gridView_DutyList.GetRowCellValue(Index, "CarFaceCode"));

            CarFace_frm Cf = new CarFace_frm(false, CarFaceCode, RentType + 2, CarID, "", true);
            Cf.ShowDialog();

            ShowListCar(Index1);

            gridView_DutyList.FocusedRowHandle = Index;

        }

        private void buttonItemDutyCertif_Click(object sender, EventArgs e)
        {
            if (gridView_DutyList.RowCount == 0) return;
            int Index = gridView_DutyList.FocusedRowHandle;
            int Index1 = gridView_CarList.FocusedRowHandle;

            int CarID = Convert.ToInt32(gridView_DutyList.GetRowCellValue(Index, "CarID"));
            int DutyType = Convert.ToInt32(gridView_DutyList.GetRowCellValue(Index, "DutyType"));
            int RentType = Convert.ToInt32(gridView_DutyList.GetRowCellValue(Index, "RentType"));
            int CertifedCode = Convert.ToInt32(gridView_DutyList.GetRowCellValue(Index, "CertifedCode"));

            Certicate_frm Cf = new Certicate_frm(false, CertifedCode, DutyType, RentType + 2, CarID);
            Cf.ShowDialog();

            ShowListCar(Index1);

            gridView_DutyList.FocusedRowHandle = Index;
        }

        private void buttonItemTable_Click(object sender, EventArgs e)
        {
            //gridControl_CarList.MainView = cardView1;
        }

        private void buttonItemCardView_Click(object sender, EventArgs e)
        {
            //gridControl_CarList.MainView = gridView_CarList;
        }

        private void checkBoxCarFree_CheckedChanged(object sender, DevComponents.DotNetBar.CheckBoxChangeEventArgs e)
        {
            //int[] str = (from prd in DCMDC.TBL_Cars join k in DCMDC.TBL_CarDuties on prd.CarID equals k.CarID into j1 from j2 in j1.DefaultIfEmpty() where (j2.RentType == 2 && j2.DutyCode == (from h in DCMDC.TBL_CarDuties where h.CarID == prd.CarID select h.DutyCode).Max()) || j2.RentType == null select prd.CarID).ToArray();
            
            //string ActiveFilterString = "  ";
            //if (checkBoxCarFree.Checked)
            //    ActiveFilterString += " CarID in (" + str.ToString() +") or ";
            //ActiveFilterString += " 1<>1 ";

            //gridView_CarList.ActiveFilterString = ActiveFilterString;
            //gridView_CarList.ApplyColumnsFilter();
        }

        private void chkService_CheckedChanged(object sender, EventArgs e)
        {
            string ActiveFilterString = "  ";
            if (chkService.Checked)
                ActiveFilterString = " Status is null ";
            else if (chkDeActive.Checked)
                ActiveFilterString = " Active = 0 ";
            else if (chkServiceUse.Checked)
                ActiveFilterString = " Status like '%7;%' ";
            else if (chkKhalafi.Checked)
                ActiveFilterString = " Status like '%1;%' ";
            else if (chkCarEnter.Checked)
                ActiveFilterString = " Status like '%2;%' ";
            else if (chkCarDuty.Checked)
                ActiveFilterString = " Status like '%3;%' ";
            else if (chkInsuBody.Checked)
                ActiveFilterString = " Status like '%4;%' ";
            else if (chkInsuThird.Checked)
                ActiveFilterString = " Status like '%5;%' ";
            else if (chkAction.Checked)
                ActiveFilterString = " Status like '%6;%' ";
            //ActiveFilterString += " 1<>1 ";

            gridView_CarList.ActiveFilterString = ActiveFilterString;
            gridView_CarList.ApplyColumnsFilter();
        }

        private void button_SendSMS_Click(object sender, EventArgs e)
        {
            Global_Cls.SendSMS_Advertisment(true, "", "");
        }

        private void button_SendEmail_Click(object sender, EventArgs e)
        {
            Global_Cls.SendEmail("");
        }

        private void buttonItemRefresh_Click(object sender, EventArgs e)
        {
            ShowListCar(1);
        }

        

    }
}
