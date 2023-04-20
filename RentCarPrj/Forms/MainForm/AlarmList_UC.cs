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
    public partial class AlarmList_UC : UserControl
    {
        public AlarmList_UC()
        {
            //CreateWaitDialog();
            InitializeComponent();
           // gridControl_AlarmList.ForceInitialize();
        }
        
        DataClasses_MainDataContext DCMDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);


        #region Load & UI
        private void AlarmList_UC_Load(object sender, EventArgs e)
        {
            tBL_CarTableAdapter.Fill(dataSetRentReport.TBL_Car);

            sP_AlarmViewForDefinitionTableAdapter.Fill(dataSetRentReport.SP_AlarmViewForDefinition,
                Global_Cls.GetFinePeriod, Global_Cls.ExpDayCarEnter, Global_Cls.ExpDayCarDuty,
                Global_Cls.ExpDayBodyInsu, Global_Cls.ExpDayThirdInsu);
        }

        private void AlarmList_UC_Layout(object sender, LayoutEventArgs e)
        {
            try 
            {
                //ShowListAlarm(gridView_AlarmList.RowCount); 
            }
            catch { }
        }

        #endregion


        #region All Buttons

        private void buttonItemAlarmSearch_Click(object sender, EventArgs e)
        {
            gridView_AlarmList.OptionsView.ShowAutoFilterRow = !gridView_AlarmList.OptionsView.ShowAutoFilterRow;
        }

        private void buttonItemSelector_Click(object sender, EventArgs e)
        {
            gridView_AlarmList.ColumnsCustomization(new Point(100, 100));
        }

        private void buttonItemAlarmPrintList_Click(object sender, EventArgs e)
        {
            PrintPreview_frm PP = new PrintPreview_frm(gridControl_AlarmList);
            PP.ShowDialog();
        }

        #endregion




    }
}
