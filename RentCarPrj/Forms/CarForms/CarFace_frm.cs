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
    public partial class CarFace_frm : Form
    {
        public int _carFaceCode;
        int _stepCode, _carID;
        bool CloseOK = false, _newOrEditCarFace, _setPrint;
        string _carName;

        //StepCode = 0:اتومبیل; 
        // 1: اتومبیل  با قرارداد
        // 2: سرویس
        // 3: تمدید سرویس
        // 4: عودت

        public CarFace_frm(bool NewOrEditCarFace, int CarFaceCode, int StepCode, int CarID, string CarName, bool SetPrint)
        {
            InitializeComponent();
            _carFaceCode = CarFaceCode;
            _newOrEditCarFace = NewOrEditCarFace;
            _stepCode = StepCode;
            _carID = CarID;
            _carName = CarName;
            _setPrint = SetPrint;
        }

        DataClasses_MainDataContext DCMD = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);


        #region Load Data
        
        private void CarFace_frm_Load(object sender, EventArgs e)
        {
            tabControlPanel_BackDuty.Visible = _stepCode == 4;
            tabItem_BackDuty.Visible = _stepCode == 4;
            
            if (_carName != "")
                textBox_CarName.Text = _carName;
            else
                try { textBox_CarName.Text = DCMD.TBL_Cars.First(ct => ct.CarID.Equals(_carID)).CarName; }
                catch { }
            
            checkBoxItem_CarFace.Visible = _setPrint;
            
            
            CheckPermission();
            SetData_CarFace();
        }

        private void CheckPermission()
        {
            ////new

            //            //Start Use Permission
            //            string UPer = Global_Cls.MainForm.UserPermission;
            //            if (UPer != "" && UPer != "admin")
            //            {
            //                if (UPer.Contains(checkBox_AddTelNotebook.Name)) checkBox_AddTelNotebook.Enabled = false;
            //                if (UPer.Contains(checkBoxItem_ListCuHouse.Name)) checkBoxItem_ListCuHouse.Enabled = false;
            //            }
            //            //End Use Permission

        }

        public void SetData_CarFace()
        {

            if (!_newOrEditCarFace) //|| (_newOrEditCarFace && (_stepCode == 3 || _stepCode == 4)))
            {
                try
                {
                    TBL_CarFace tbhf = DCMD.TBL_CarFaces.First(thfh => thfh.CarFaceID.Equals(_carFaceCode));

                    radioButton_ChairSlipOK.Checked = tbhf.ChairSlip.Value;
                    radioButton_ChairSlipNO.Checked = !tbhf.ChairSlip.Value;
                    radioButton_AntenaOK.Checked = tbhf.Antena.Value;
                    radioButton_AntenaNO.Checked = !tbhf.Antena.Value;
                    radioButton_CoolerOK.Checked = tbhf.Cooler.Value;
                    radioButton_CoolerNO.Checked = !tbhf.Cooler.Value;
                    radioButton_JackOK.Checked = tbhf.Jack.Value;
                    radioButton_JackNO.Checked = !tbhf.Jack.Value;
                    radioButton_LighterOK.Checked = tbhf.Lighter.Value;
                    radioButton_LighterNO.Checked = !tbhf.Lighter.Value;
                    radioButton_MirrorsBasamOK.Checked = tbhf.MirrorsBasam.Value;
                    radioButton_MirrorsBasamNO.Checked = !tbhf.MirrorsBasam.Value;
                    radioButton_MirrorsMiddleOK.Checked = tbhf.MirrorsMiddle.Value;
                    radioButton_MirrorsMiddleNO.Checked = !tbhf.MirrorsMiddle.Value;
                    radioButton_RingOK.Checked = tbhf.Ring.Value;
                    radioButton_RingNO.Checked = !tbhf.Ring.Value;
                    radioButton_WheelAttachOK.Checked = tbhf.WheelAttach.Value;
                    radioButton_WheelAttachNO.Checked = !tbhf.WheelAttach.Value;
                    radioButton_WheelWrenchOK.Checked = tbhf.WheelWrench.Value;
                    radioButton_WheelWrenchNO.Checked = !tbhf.WheelWrench.Value;
                    radioButton_WiperOK.Checked = tbhf.Wiper.Value;
                    radioButton_WiperNO.Checked = !tbhf.Wiper.Value;
                    radioButton_WheelFace30.Checked = tbhf.WheelFace == 0;
                    radioButton_WheelFace50.Checked = tbhf.WheelFace == 1;
                    radioButton_WheelFace80.Checked = tbhf.WheelFace == 2;
                    textBox_CarFaceDescription.Text = tbhf.CarFaceDescription;

                    if (!_newOrEditCarFace)
                    {
                        nUpDown_OilUse.Text = tbhf.OilUse.ToString();
                        nUpDown_KilometerUse.Value = tbhf.KilometerUse.Value;

                        textBox_FaceConfilictDSC.Text = tbhf.FaceConfilictDSC;
                        textBox_FaceRepairePrice.Text = Global_Cls.DigitSeparator(tbhf.FaceRepairePrice.ToString());
                        textBox_TechConfilictDSC.Text = tbhf.TechConfilictDSC;
                        textBox_TechRepairPrice.Text = Global_Cls.DigitSeparator(tbhf.TechRepairPrice.ToString());
                    }
                }
                catch (Exception ex)
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "اشکال در لود", ex.Message);
                }
                
                if (!_newOrEditCarFace)
                    //pics & films
                    LoadPics_Films(_carFaceCode);
            }
           
            if (_newOrEditCarFace)
            {
                try
                {
                    var MaxID = (from prd in DCMD.TBL_CarFaces
                                 select prd.CarFaceID).Max();

                    var DelMaxID = 0;
                    try
                    {
                        DelMaxID = (from prd in DCMD.TBL_DelCarFaces
                                    select prd.CarFaceID).Max();
                    }
                    catch { }

                    _carFaceCode = (MaxID >= DelMaxID ? MaxID : DelMaxID) + 1;
                }
                catch
                {
                    _carFaceCode = 1;
                }
            }
        }
    
        #endregion



        #region OK Data
        private void buttonItem_OK_Click(object sender, EventArgs e)
        {
            if (OkFunction())
            {
                CloseOK = true;
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool OkFunction()
        {
            if (nUpDown_KilometerUse.Value == 0)
            { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "کیلومتر را وارد نمایید"); nUpDown_KilometerUse.Focus(); return false; }
            if (nUpDown_OilUse.Text == "" || nUpDown_OilUse.Text == "0")
            { Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "مقدار بنزین را وارد نمایید"); nUpDown_OilUse.Focus(); return false; }


            DataClasses_MainDataContext DCD = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
            if (_newOrEditCarFace)
                try
                {
                    TBL_CarFace THF = new TBL_CarFace
                    {
                        CarFaceID = _carFaceCode,
                        CarID = _carID,
                        StepCode = _stepCode,
                        ChairSlip = radioButton_ChairSlipOK.Checked,
                        Lighter = radioButton_LighterOK.Checked,
                        Wiper = radioButton_WiperOK.Checked,
                        Jack = radioButton_JackOK.Checked,
                        MirrorsBasam = radioButton_MirrorsBasamOK.Checked,
                        Cooler = radioButton_CoolerOK.Checked,
                        WheelAttach = radioButton_WheelAttachOK.Checked,
                        Antena = radioButton_AntenaOK.Checked,
                        MirrorsMiddle = radioButton_MirrorsMiddleOK.Checked,
                        Ring = radioButton_RingOK.Checked,
                        WheelWrench = radioButton_WheelWrenchOK.Checked,
                        OilUse = int.Parse(nUpDown_OilUse.Text),
                        KilometerUse = int.Parse(nUpDown_KilometerUse.Text),
                        CarFaceDescription = textBox_CarFaceDescription.Text,
                        FaceConfilictDSC = textBox_FaceConfilictDSC.Text,
                        FaceRepairePrice = double.Parse((textBox_FaceRepairePrice.Text == "" ? "0" : textBox_FaceRepairePrice.Text).Replace(",", "")),
                        TechRepairPrice = double.Parse((textBox_TechRepairPrice.Text == "" ? "0" : textBox_TechRepairPrice.Text).Replace(",", "")),
                        TechConfilictDSC = textBox_TechConfilictDSC.Text,
                        WheelFace = (radioButton_WheelFace30.Checked ? 0 : radioButton_WheelFace50.Checked ? 1 : 2),
                    };

                    DCD.TBL_CarFaces.InsertOnSubmit(THF);
                    DCD.SubmitChanges();

                    //pics & films
                    SavePics_Films(_carFaceCode);
                }
                catch (Exception ex)
                {
                    Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "ثبت نشد!", ex.ToString());
                    return false;
                }
            else
                if (!_newOrEditCarFace)
                {
                    try
                    {
                        TBL_CarFace tbhf = DCD.TBL_CarFaces.First(thfh => thfh.CarFaceID.Equals(_carFaceCode));

                        tbhf.StepCode = _stepCode;
                        tbhf.ChairSlip = radioButton_ChairSlipOK.Checked;
                        tbhf.Lighter = radioButton_LighterOK.Checked;
                        tbhf.Wiper = radioButton_WiperOK.Checked;
                        tbhf.Jack = radioButton_JackOK.Checked;
                        tbhf.MirrorsBasam = radioButton_MirrorsBasamOK.Checked;
                        tbhf.Cooler = radioButton_CoolerOK.Checked;
                        tbhf.WheelAttach = radioButton_WheelAttachOK.Checked;
                        tbhf.Antena = radioButton_AntenaOK.Checked;
                        tbhf.MirrorsMiddle = radioButton_MirrorsMiddleOK.Checked;
                        tbhf.Ring = radioButton_RingOK.Checked;
                        tbhf.WheelWrench = radioButton_WheelWrenchOK.Checked;
                        tbhf.OilUse = int.Parse(nUpDown_OilUse.Text);
                        tbhf.KilometerUse = int.Parse(nUpDown_KilometerUse.Text);
                        tbhf.CarFaceDescription = textBox_CarFaceDescription.Text;
                        tbhf.FaceConfilictDSC = textBox_FaceConfilictDSC.Text;
                        tbhf.FaceRepairePrice = double.Parse((textBox_FaceRepairePrice.Text == "" ? "0" : textBox_FaceRepairePrice.Text).Replace(",", ""));
                        tbhf.TechRepairPrice = double.Parse((textBox_TechRepairPrice.Text == "" ? "0" : textBox_TechRepairPrice.Text).Replace(",", ""));
                        tbhf.TechConfilictDSC = textBox_TechConfilictDSC.Text;
                        tbhf.WheelFace = (radioButton_WheelFace30.Checked ? 0 : radioButton_WheelFace50.Checked ? 1 : 2);

                        DCD.SubmitChanges();

                        //pics & films
                        SavePics_Films(_carFaceCode);

                    }
                    catch (Exception ex)
                    {
                        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "ثبت نشد!", ex.ToString());
                        return false;
                    }
                }

            if (_setPrint && checkBoxItem_CarFace.Checked)
            {
                try
                {
                    Report.MoshakhasatZaheri RAIF = new Report.MoshakhasatZaheri(_carFaceCode);
                    RAIF.ShowPreviewDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }

            }
            return true;
        }
        

        #endregion



        #region UI Control Func
        TextBox tx = new TextBox();
        private void textBox_AHPrice_TextChanged(object sender, EventArgs e)
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

        private void textBox_HPrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox_Subbuild_KeyPress(object sender, KeyPressEventArgs e)
        {
            tx = (TextBox)sender;
            if ((tx.Text.Contains(".") && e.KeyChar == '.')
                || (!System.Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Back && e.KeyChar != '.'))
            { e.KeyChar = '\0'; return; }
        }


        private void CarFace_frm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Tab)
            {
                if (tabControl_CarFace.SelectedTabIndex == tabControl_CarFace.Tabs.Count - 1)
                    tabControl_CarFace.SelectedTabIndex = 0;
                else
                    tabControl_CarFace.SelectNextTab();
            }
        }

        private void CarFace_frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Global_Cls.MainForm.CloseAllOK && !CloseOK && !Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, "آیا از این فرم خارج می شوید؟"))
                e.Cancel = true;
        }

      #endregion



        #region Pics & Films

        private int PicCounter = 0, MaxPicIDExist = 0;
        private int FilmCounter = 0, MaxFilmIDExist = 0;
        private PictureBox ImgPic = null;

        private void LoadPics_Films(int CarFaceID)
        {
            ReadOnlyCollection<string> ROC = new ReadOnlyCollection<string>(FileSystem.GetFiles(Global_Cls.RootSaveLoad() + @"\PicsFilms\"));
            foreach (string PicFilmRoot in ROC)
            {
                //pics
                if (PicFilmRoot.Contains("PIC") && PicFilmRoot.Contains("ID" + CarFaceID.ToString()))
                {
                    string FileNameExist = PicFilmRoot.Substring(PicFilmRoot.IndexOf("\\PicsFilms\\") + 11);
                    string Maxstr = FileNameExist.Substring(3, FileNameExist.IndexOf("ID") - 3);
                    if (MaxPicIDExist < Convert.ToInt32(Maxstr)) MaxPicIDExist = Convert.ToInt32(Maxstr);

                    AddToListViewPic(FileNameExist, PicFilmRoot, PicCounter);
                    PicCounter++;
                }

                //films
                if (PicFilmRoot.Contains("FILM") && PicFilmRoot.Contains("ID" + CarFaceID.ToString()))
                {
                    string FileNameExist = PicFilmRoot.Substring(PicFilmRoot.IndexOf("\\PicsFilms\\") + 11);
                    string Maxstr = FileNameExist.Substring(4, FileNameExist.IndexOf("ID") - 4);
                    if (MaxFilmIDExist < Convert.ToInt32(Maxstr)) MaxFilmIDExist = Convert.ToInt32(Maxstr);

                    AddToListViewFilm(FileNameExist, PicFilmRoot, FilmCounter);
                    FilmCounter++;
                }

            }
        }


        private void SavePics_Films(int CarFaceID)
        {
            int i;

            ReadOnlyCollection<string> ROC = new ReadOnlyCollection<string>(FileSystem.GetFiles(Global_Cls.RootSaveLoad() + @"\PicsFilms\"));

            foreach (string PicFilmRoot in ROC)
            {
                //pics
                if (PicFilmRoot.Contains("PIC") && PicFilmRoot.Contains("ID" + CarFaceID.ToString()))
                {
                    for (i = 0; i < listView_Pic.Items.Count; i++)
                    {
                        if (PicFilmRoot == listView_Pic.Items[i].Name) break;
                        else continue;
                    }
                    if (i == listView_Pic.Items.Count)
                        FileSystem.DeleteFile(PicFilmRoot);
                }

                //films
                if (PicFilmRoot.Contains("FILM") && PicFilmRoot.Contains("ID" + CarFaceID.ToString()))
                {
                    for (i = 0; i < listView_Film.Items.Count; i++)
                    {
                        if (PicFilmRoot == listView_Film.Items[i].Name) break;
                        else continue;
                    }
                    if (i == listView_Film.Items.Count)
                        FileSystem.DeleteFile(PicFilmRoot);
                }
            }


            //pics
            for (i = 0; i < listView_Pic.Items.Count; i++)
            {
                if (FileSystem.FileExists(Global_Cls.RootSaveLoad() + @"\PicsFilms\" + listView_Pic.Items[i].Text)) continue;
                else
                {
                    MaxPicIDExist++;
                    string FileNameAdd = "PIC" + MaxPicIDExist.ToString() + "ID" + CarFaceID.ToString() + listView_Pic.Items[i].Text.Substring(listView_Pic.Items[i].Text.IndexOf("."));
                    FileSystem.CopyFile(listView_Pic.Items[i].Name, Global_Cls.RootSaveLoad() + @"\PicsFilms\" + FileNameAdd);
                }
            }


            //films
            for (i = 0; i < listView_Film.Items.Count; i++)
            {
                if (FileSystem.FileExists(Global_Cls.RootSaveLoad() + @"\PicsFilms\" + listView_Film.Items[i].Text)) continue;
                else
                {
                    MaxFilmIDExist++;
                    string FileNameAdd = "FILM" + MaxFilmIDExist.ToString() + "ID" + CarFaceID.ToString() + listView_Film.Items[i].Text.Substring(listView_Film.Items[i].Text.IndexOf("."));
                    FileSystem.CopyFile(listView_Film.Items[i].Name, Global_Cls.RootSaveLoad() + @"\PicsFilms\" + FileNameAdd);
                }
            }

        }

        //pics

        private void AddToListViewPic(string PicFileName, string ItemName, int PicCnt)
        {
            ImgPic = new PictureBox();
            ImgPic.Load(ItemName);
            imageList_LargePic.Images.Add(ImgPic.Image);
            imageList_SmallPic.Images.Add(ImgPic.Image);
            listView_Pic.Items.Add(ItemName, PicFileName, PicCnt);
        }


        private void bubbleButton_PicNew_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All image file|*.bmp;*.jpg;*.jpeg;*.gif;*.png;*.ico";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                AddToListViewPic(ofd.SafeFileName, ofd.FileName, PicCounter);

                PicCounter++;
            }
        }

        private void bubbleButton_PicDel_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            if (listView_Pic.SelectedItems.Count != 0)
                if (Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, "تصویر مورد نظر حذف شود؟"))
                    listView_Pic.SelectedItems[0].Remove();
        }

        private void bubbleButton_PicView_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            if (listView_Pic.SelectedItems.Count != 0) Process.Start(listView_Pic.SelectedItems[0].Name);
        }

        private void bubbleButton_IconPic_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            if (listView_Pic.View == View.LargeIcon)
                listView_Pic.View = View.Tile;
            else if (listView_Pic.View == View.Tile)
                listView_Pic.View = View.SmallIcon;
            else if (listView_Pic.View == View.SmallIcon)
                listView_Pic.View = View.List;
            else listView_Pic.View = View.LargeIcon;
        }

        private void listView_Pic_DoubleClick(object sender, EventArgs e)
        {
            bubbleButton_PicView_Click(this, null);
        }


        //films

        private void AddToListViewFilm(string FilmFileName, string ItemName, int FilmCnt)
        {
            ImgPic = new PictureBox();
            ImgPic.Load(Global_Cls.RootSaveLoad() + @"\PicsFilms\Templete.png");
            imageList_LargeFilm.Images.Add(ImgPic.Image);
            imageList_SmallFilm.Images.Add(ImgPic.Image);
            listView_Film.Items.Add(ItemName, FilmFileName, FilmCnt);
        }


        private void bubbleButton_FilmNew_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Video file|*.wmv;*.avi;*.mpeg;*.3gp;*.mp4;*.mp3;*.dat;*.mov;*.divx";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                AddToListViewFilm(ofd.SafeFileName, ofd.FileName, FilmCounter);

                FilmCounter++;
            }

        }

        private void bubbleButton_FilmDel_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            if (listView_Film.SelectedItems.Count != 0)
                if (Global_Cls.Message_Sara(0, Global_Cls.MessageType.SConfirmation, true, "فیلم مورد نظر حذف شود؟"))
                    listView_Film.SelectedItems[0].Remove();
        }

        private void bubbleButton_FilmView_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            try
            {
                if (listView_Film.SelectedItems.Count != 0) Process.Start(listView_Film.SelectedItems[0].Name);
            }
            catch { }
        }

        private void bubbleButton_FilmIcon_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            if (listView_Film.View == View.LargeIcon)
                listView_Film.View = View.Tile;
            else if (listView_Film.View == View.Tile)
                listView_Film.View = View.SmallIcon;
            else if (listView_Film.View == View.SmallIcon)
                listView_Film.View = View.List;
            else listView_Film.View = View.LargeIcon;
        }

        private void listView_Film_DoubleClick(object sender, EventArgs e)
        {
            bubbleButton_FilmView_Click(this, null);
        }

        #endregion

        
        private void buttonItem_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonItemPreCarFace_Click(object sender, EventArgs e)
        {
            try
            {
                int su = (from hg in DCMD.TBL_CarFaces
                          where hg.CarID == _carID && hg.CarFaceID < _carFaceCode
                          select hg.CarFaceID).Max();
                CarFace_frm cf = new CarFace_frm(false, su, 5, _carID, textBox_CarName.Text, false);
                cf.ShowDialog();
            }
            catch 
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "شکل ظاهری قبلی برای این اتومبیل وجود ندارد");
            }
        }




    }
}
