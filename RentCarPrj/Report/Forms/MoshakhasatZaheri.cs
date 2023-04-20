using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.ObjectModel;
using Microsoft.VisualBasic.FileIO;

namespace RentCarPrj.Report
{
    public partial class MoshakhasatZaheri : DevExpress.XtraReports.UI.XtraReport
    {
        public MoshakhasatZaheri(int CarFaceID)
        {
            InitializeComponent();
            sP_SetRepMoshakhasatZaheriTableAdapter.Fill(dataSetRentReport1.SP_SetRepMoshakhasatZaheri, CarFaceID);
            LoadPics_Films(CarFaceID);

            try
            {
                PictureBox10.ImageUrl = Global_Cls.RootSaveLoad() + "\\PicsFilms\\Logo.jpg";
                PictureBox20.ImageUrl = Global_Cls.RootSaveLoad() + "\\PicsFilms\\Logo.jpg";
            }
            catch { }

        }

        private void LoadPics_Films(int CarFaceID)
        {
            ReadOnlyCollection<string> ROC = new ReadOnlyCollection<string>(FileSystem.GetFiles(Global_Cls.RootSaveLoad() + @"\PicsFilms\"));
            foreach (string PicFilmRoot in ROC)
            {
                if (PicFilmRoot.Contains("PIC") && PicFilmRoot.Contains("ID" + CarFaceID.ToString()))
                {
                    if (PictureBox1.ImageUrl == "")
                        PictureBox1.ImageUrl = PicFilmRoot;
                    else if (PictureBox2.ImageUrl == "")
                        PictureBox2.ImageUrl = PicFilmRoot;
                    else if (PictureBox3.ImageUrl == "")
                        PictureBox3.ImageUrl = PicFilmRoot;
                    else if (PictureBox4.ImageUrl == "")
                        PictureBox4.ImageUrl = PicFilmRoot;
                }

            }
        }

    }
}
