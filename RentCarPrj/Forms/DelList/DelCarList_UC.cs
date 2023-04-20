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
    public partial class DelCarList_UC : UserControl
    {
        public DelCarList_UC()
        {
            InitializeComponent();
        }

        DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);



        #region Load & UI

        private void DelCarList_UC_Load(object sender, EventArgs e)
        {
            InterFaceChange();
            ShowDelListCar(1);
        }

        private void InterFaceChange()
        {

            string UPer = Global_Cls.MainForm.UserPermission;
            if (UPer != "" && UPer != "admin")
            {
                if (UPer.Contains(buttonItemCarDelet.Name)) buttonItemCarDelet.Enabled = false;
                if (UPer.Contains(buttonItemCarPrintListDel.Name)) buttonItemCarPrintListDel.Enabled = false;
                if (UPer.Contains(buttonItemDutyDelet.Name)) buttonItemDutyDelet.Enabled = false;
                if (UPer.Contains(buttonItemDutyPrintListDel.Name)) buttonItemDutyPrintListDel.Enabled = false;
                if (UPer.Contains(buttonTechnicalViewDel.Name)) buttonTechnicalViewDel.Enabled = false;
                if (UPer.Contains(buttonSetMyCarList.Name)) buttonSetMyCarList.Enabled = false;
            }

            //codeing
            if (Global_Cls.SoftwareCode.Contains("L1") || Global_Cls.SoftwareCode.Contains("N1") || Global_Cls.SoftwareCode == "Trial")
            {
                buttonTechnicalViewDel.Enabled = false;
            }
            //codeing
        }

        private void DelCarList_UC_Layout(object sender, LayoutEventArgs e)
        {
            try
            {
                ShowDelListCar(gridView_CarList.RowCount);
            }
            catch { }

        }

        #endregion


        #region Search
        private void ShowDelListCar(int RowFocus)
        {
            var SUS = from prd in DCMDC.TBL_DelCars
                      select new
                      {
                          prd.CarID,
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
                          EndEnterDate = Global_Cls.MiladiDateToShamsi((DCMDC.TBL_DelCarEnters.First(Cr => Cr.CarID.Equals(prd.CarID)).EndEnterDate.Value) == null ? DateTime.Now : (DCMDC.TBL_DelCarEnters.First(Cr => Cr.CarID.Equals(prd.CarID)).EndEnterDate.Value))
                      };
            gridControl_CarList.DataSource = SUS;
            gridView_CarList.FocusedRowHandle = RowFocus;
        }

        private void gridView_DelCarList_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int Index = gridView_CarList.FocusedRowHandle;
            Index = Convert.ToInt32(gridView_CarList.GetRowCellValue(Index, "CarID"));
            var DUS = from prd in DCMDC.TBL_DelCarDuties
                      where prd.CarID == Index
                      orderby prd.DutyCode descending
                      select new
                      {
                          prd.CarID,
                          prd.DutyCode,
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

        private void buttonItemCarDel_Click(object sender, EventArgs e)
        {
            if (gridView_CarList.RowCount == 0) return;
            if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این اتومبیل از سیستم به طور کلی و با جزییات حذف شود؟")) return;
            int Index = gridView_CarList.FocusedRowHandle;

            var fg = (from gf in DCMDC.TBL_DelCarFaces
                      where gf.CarID==Convert.ToInt32(gridView_CarList.GetRowCellValue(Index, "CarID"))
                      select new{gf.CarFaceID}).ToArray();
            
            for(int i=0;i<fg.Count();i++)
                DeletePics_Films(fg[i].CarFaceID);

            
            DCMDC.SP_DeleteCar(Convert.ToInt32(gridView_CarList.GetRowCellValue(Index, "CarID")));
            DCMDC.SubmitChanges(); 
            
            
            ShowDelListCar(Index);
        }
        
        private void DeletePics_Films(int CarFaceID)
        {
            System.Collections.ObjectModel.ReadOnlyCollection<string> ROC = new System.Collections.ObjectModel.ReadOnlyCollection<string>(Microsoft.VisualBasic.FileIO.FileSystem.GetFiles(Global_Cls.RootSaveLoad() + @"\PicsFilms\"));
            foreach (string PicFilmRoot in ROC)
            {
                //pics
                if (PicFilmRoot.Contains("PIC") && PicFilmRoot.Contains("ID" + CarFaceID.ToString()))
                {
                    string FileNameExist = PicFilmRoot.Substring(PicFilmRoot.IndexOf("\\PicsFilms\\") + 11);
                    Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(FileNameExist);
                }

                //films
                if (PicFilmRoot.Contains("FILM") && PicFilmRoot.Contains("ID" + CarFaceID.ToString()))
                {
                    string FileNameExist = PicFilmRoot.Substring(PicFilmRoot.IndexOf("\\PicsFilms\\") + 11);
                    Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(FileNameExist);
                }

            }
        }

        private void buttonItemCarPrintList_Click(object sender, EventArgs e)
        {
            PrintPreview_frm PP = new PrintPreview_frm(gridControl_CarList);
            PP.ShowDialog();
        }

        #endregion


        #region Duty Button

        private void buttonItemDutySearch_Click(object sender, EventArgs e)
        {
            gridView_DutyList.OptionsView.ShowAutoFilterRow = !gridView_DutyList.OptionsView.ShowAutoFilterRow;
        }

        private void buttonItemDutyPrintList_Click(object sender, EventArgs e)
        {
            PrintPreview_frm PP = new PrintPreview_frm(gridControl_DutyList);
            PP.ShowDialog();
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

            TBL_DelCertificate tc = DCMDC.TBL_DelCertificates.First(hf => hf.CertificateCode.Equals(CertifedCode));
            DCMDC.TBL_DelCertificates.DeleteOnSubmit(tc);
            DCMDC.SubmitChanges();

            TBL_DelCarFace tf = DCMDC.TBL_DelCarFaces.First(hf => hf.CarFaceID.Equals(CarFaceCode));
            DCMDC.TBL_DelCarFaces.DeleteOnSubmit(tf);
            DCMDC.SubmitChanges();

            TBL_DelCarDuty thsf = DCMDC.TBL_DelCarDuties.First(hf => hf.CarID.Equals(CarID) && hf.DutyCode.Equals(DutyCode));
            DCMDC.TBL_DelCarDuties.DeleteOnSubmit(thsf);
            DCMDC.SubmitChanges();

            ShowDelListCar(Index1);
            gridView_DutyList.FocusedRowHandle = Index - 1;
        }

        #endregion


        private void buttonTechnicalView_Click(object sender, EventArgs e)
        {
            //int Index = gridView_CarList.FocusedRowHandle;

            //ActionCarList_frm Acl = new ActionCarList_frm(Convert.ToInt32(gridView_CarList.GetRowCellValue(Index, "CarID")), 0);
            //Acl.ShowDialog();
        }

        
        private void buttonItemDutyFaceCar_Click(object sender, EventArgs e)
        {
            //if (gridView_DutyList.RowCount == 0) return;
            //int Index = gridView_DutyList.FocusedRowHandle;
            //int Index1 = gridView_CarList.FocusedRowHandle;

            //int CarID = Convert.ToInt32(gridView_DutyList.GetRowCellValue(Index, "CarID"));
            //int RentType = Convert.ToInt32(gridView_DutyList.GetRowCellValue(Index, "RentType"));
            //int CarFaceCode = Convert.ToInt32(gridView_DutyList.GetRowCellValue(Index, "CarFaceCode"));

            //CarFace_frm Cf = new CarFace_frm(false, CarFaceCode, RentType + 2, CarID, "", true);
            //Cf.ShowDialog();

            //ShowDelListCar(Index1);

            //gridView_DutyList.FocusedRowHandle = Index;

        }

        private void buttonItemDutyCertif_Click(object sender, EventArgs e)
        {
            //if (gridView_DutyList.RowCount == 0) return;
            //int Index = gridView_DutyList.FocusedRowHandle;
            //int Index1 = gridView_CarList.FocusedRowHandle;

            //int CarID = Convert.ToInt32(gridView_DutyList.GetRowCellValue(Index, "CarID"));
            //int DutyType = Convert.ToInt32(gridView_DutyList.GetRowCellValue(Index, "DutyType"));
            //int RentType = Convert.ToInt32(gridView_DutyList.GetRowCellValue(Index, "RentType"));
            //int CertifedCode = Convert.ToInt32(gridView_DutyList.GetRowCellValue(Index, "CertifedCode"));

            //Certicate_frm Cf = new Certicate_frm(false, CertifedCode, DutyType, RentType + 2, CarID);
            //Cf.ShowDialog();

            //ShowDelListCar(Index1);

            //gridView_DutyList.FocusedRowHandle = Index;
        }

        private void buttonItemTable_Click(object sender, EventArgs e)
        {
            //gridControl_CarList.MainView = cardView1;
        }

        private void buttonItemCardView_Click(object sender, EventArgs e)
        {
            //gridControl_CarList.MainView = gridView_CarList;
        }

        private void buttonSetMyCarList_Click(object sender, EventArgs e)
        {
            if (gridView_CarList.RowCount == 0) return;
            if (!Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, " آیا مایلید این اتومبیل به لیست اصلی برگردد؟")) return;
            int Index = gridView_CarList.FocusedRowHandle;

            DCMDC.SP_InsDelRecordCar(Convert.ToInt32(gridView_CarList.GetRowCellValue(Index, "CarID")), false);
            DCMDC.SubmitChanges();

            ShowDelListCar(Index);

        }

    }
}
