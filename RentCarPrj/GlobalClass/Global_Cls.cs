using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using RentCarPrj.Properties;
using System.Runtime.InteropServices;
using System.Collections.Specialized;
using RentCarPrj.DataLinq;

namespace RentCarPrj
{
    public class Global_Cls
    {
        public enum MessageType { SError, SWarning, SConfirmation, SInformation };

        static public MainRC_frm MainForm = null;
        static public StartRC_frm StartForm = null;

        static public string SoftwareCode = "N2+S";
        //"Trial"
        //"L1";//"L2";"+S"
        //"N1";//"N2";"+S"

        static public bool ClientSoftOK = false;

        static public int UserCode_Exist = 1;
        static public string UserName_Exist = "";
        static public bool CarLayout = false;


        #region All Message Forms
        static public bool Message_Sara(int Code_Msg, MessageType TypeMsg, bool OK_Cancel, string Str_Msg)
        {
            return Message_Sara(Code_Msg, TypeMsg, OK_Cancel, Str_Msg, "");
        }

        static public bool Message_Sara(int Code_Msg, MessageType TypeMsg, bool OK_Cancel, string Str_Msg, string Str_Error)
        {
            MessageRent_Frm MSF = new MessageRent_Frm();

            MSF.label_MsgS.Text = Str_Msg;
            MSF.pictureBox_Error.Visible = (TypeMsg == MessageType.SError); MSF.pictureBox_Error.Top = 20;
            MSF.pictureBox_Warning.Visible = (TypeMsg == MessageType.SWarning); MSF.pictureBox_Warning.Top = 20;
            MSF.pictureBox_Configuration.Visible = (TypeMsg == MessageType.SConfirmation); MSF.pictureBox_Configuration.Top = 20;
            MSF.pictureBox_Information.Visible = (TypeMsg == MessageType.SInformation); MSF.pictureBox_Information.Top = 20;
            MSF.button_Cancel.Visible = OK_Cancel;

            if (Str_Error != "")
            {
                MSF.button_Details.Visible = true;
                MSF.label_Detail.Text = Str_Error;
            }

            if (!OK_Cancel) MSF.button_OK.Left = 133;

            MPG_WinShutDowm.ShowShutForm sf = new MPG_WinShutDowm.ShowShutForm(MSF);

            if (MSF.DialogResult == System.Windows.Forms.DialogResult.OK) return true;
            return false;
        }
        #endregion


        #region Send Advertisement&SMS Forms
        static public void SendSMS_Advertisment(bool SMS_Advertisment, string SendingStr, string MobTel)
        {
            SendAdverSMS_frm SA_SMS = new SendAdverSMS_frm();

            SA_SMS.buttonItem_AdverPrint.Visible = !SMS_Advertisment;
            SA_SMS.textBox_SMSText.Text = SendingStr;
            SA_SMS.MobileStr = MobTel;
            if (SMS_Advertisment) SA_SMS.Text = "SMS";
            else SA_SMS.Text = "آگهی";

            SA_SMS.buttonItem_Log.Visible = (SoftwareCode.Contains("N"));
            SA_SMS.ShowDialog();
            return;
        }
        #endregion


        #region Date Convertor & Control
        static public string MiladiDateToShamsi(DateTime MiladiDate)
        {
            if (MiladiDate == null) return "0000/00/00";
            System.Globalization.PersianCalendar farsi = new System.Globalization.PersianCalendar();
            int dd, mm, yy;
            string Ret;

            yy = farsi.GetYear(MiladiDate);
            Ret = yy.ToString() + "/";
            mm = farsi.GetMonth(MiladiDate);
            if (mm < 10) Ret = Ret + "0" + mm.ToString() + "/";
            else Ret = Ret + mm.ToString() + "/";
            dd = farsi.GetDayOfMonth(MiladiDate);
            if (dd < 10) Ret = Ret + "0" + dd.ToString();
            else Ret = Ret + dd.ToString();

            return Ret;

        }


        static public DateTime ShamsiDateToMiladi(string DateString, string year, string month, string dy)
        {

            if (DateString == "" && year == "" && month == "" && dy == "")
                return DateTime.MinValue;

            short yy, mm, dd;

            if (DateString != "")
            {
                yy = Convert.ToInt16(DateString.Substring(0, 4));
                mm = Convert.ToInt16(DateString.Substring(5, 2));
                dd = Convert.ToInt16(DateString.Substring(8, 2));
            }
            else
            {
                yy = Convert.ToInt16(year);
                mm = Convert.ToInt16(month);
                dd = Convert.ToInt16(dy);
            }

            DateTime MiladiDate;
            System.Globalization.PersianCalendar farsi = new System.Globalization.PersianCalendar();
            MiladiDate = farsi.ToDateTime(yy, mm, dd, 12, 0, 0, 0);

            return MiladiDate;


            /*DateTime MiladiDate;
            int day, x, z, i;

            if (yy < 1278)
                MiladiDate = DateTime.MinValue;
            else
            {
                i = 0;
                if (yy == 0 || mm == 0 || dd == 0)
                    return DateTime.MinValue;
                else
                {
                    x = (yy - 1276) / 33;
                    z = (yy - (x * 33 + 1276)) / 4;
                    if ((yy - (x * 33 + 1276)) % 4 != 0) z = z + 1;
                    day = (yy - 1276) * 365 + x * 8 + z;
                    while (i <= mm - 2)
                    {
                        if (i <= 5)
                            day = day + 31;
                        else
                            if (i <= 10)
                                day = day + 30;
                            else
                                day = day + 29;
                        i = i + 1;
                    }
                    day = day + dd - 1;
                    MiladiDate = DateTime.SpecifyKind(Convert.ToDateTime("3/20/1897"), DateTimeKind.Local).AddDays(day);
                }
            }
            return MiladiDate;*/
        }
        static public DateTime ShamsiDateToMiladi(string DateString) { return ShamsiDateToMiladi(DateString, "", "", ""); }

        static public DateTime ShamsiDateToMiladi(string year, string mnth, string dy) { return ShamsiDateToMiladi("", year, mnth, dy); }

        static public bool CheckShamsiDate(string DateString)
        {
            int y, m, d;
            try
            {
                y = Convert.ToInt32(DateString.Substring(0, 4));
                m = Convert.ToInt32(DateString.Substring(5, 2));
                d = Convert.ToInt32(DateString.Substring(8, 2));
            }
            catch
            { return false; }

            if ((y < 1300 | y > 1420) | ((y % 4 != 3) & (m == 12) & (d == 30))
                | ((m >= 7) & (d == 31)) | (m > 12) | (d > 31) | (m == 0) | (d == 0))
                return false;
            return true;
        }
        #endregion
     
        
        
        
        #region ConvertRaghamToHorof
        /// <summary>
        /// عدد رادریافت وبه حروف تبدیل می کند 
        /// </summary>
        /// <param name="Ragham">رقم </param>
        /// <returns>به حروف عدد را برمی گرداند</returns>
        public static string ConvertRaghamToHorof(Int64 Ragham)
        {
            return ConvertRaghamToHorof(ConvertRaghamToJodaJoda(Ragham));
        }
        /// <summary>
        /// یک عدد به صورت سه رقم جدا را دریافت وبه حروف تبدیل می کند
        /// </summary>
        /// <param name="Ragham"></param>
        /// <returns></returns>
        public static string ConvertRaghamToHorof(string Ragham)
        {
            string horof = "";

            try
            {
                string[] AddJoda = Ragham.Split(',');
                for (int i = 0; i < AddJoda.Length; i++)
                {
                    //MessageBox.Show(AddJoda[i]);
                    string strh = pishConvertRaghamToHorof3(int.Parse(AddJoda[i]), AddJoda.Length - i);
                    if (horof == "")
                    {
                        horof = horof + strh;
                    }
                    else
                    {
                        if (strh != "") horof = horof + " و " + strh;
                    }

                }
                return horof;
            }
            catch (Exception e1)
            {
                return "error";
            }
            finally
            {
            }

        }
        /// <summary>
        /// اعداد از صفر تا 19 را به حروف تبدیل میکند
        /// </summary>
        /// <param name="Ragham">عدد بین 0 تا 19</param>
        /// <returns>حروف را برمی گرداند در صورت خطا -1  و درصورت عدد نامعتبر تهی برمی گرداند</returns>
        private static string ConvertRaghamToHorof0to19(int Ragham)
        {
            try
            {
                //اعداد صفر  تا بیست
                if (Ragham > 19) return "";
                switch (Ragham)
                {
                    case 0:
                        return "صفر";
                        break;

                    case 1:
                        return "یک ";
                        break;
                    case 2:
                        return "دو";
                        break;
                    case 3:
                        return "سه ";
                        break;
                    case 4:
                        return "چهار";
                        break;
                    case 5:
                        return "پنج ";
                        break;
                    case 6:
                        return "شش ";
                        break;
                    case 7:
                        return "هفت ";
                        break;
                    case 8:
                        return "هشت ";
                        break;
                    case 9:
                        return "نه ";
                        break;
                    case 10:
                        return "ده ";
                    case 11:
                        return "یازده ";
                    case 12:
                        return "دوازده ";
                    case 13:
                        return "سیزده ";
                    case 14:
                        return "چهارده ";
                    case 15:
                        return "پانزده ";
                    case 16:
                        return "شانزده ";
                    case 17:
                        return "هیفده ";
                    case 18:
                        return "هیجده ";
                    case 19:
                        return "نوزده ";
                    //case 20:
                    //    return "بیست"; 

                }


                return "";
            }
            catch (Exception e)
            {
                return "-1";
            }
            finally
            {
            }

        }
        /// <summary>
        /// اعداد از بیست   تا نود نه را به حروف تبدیل میکند
        /// </summary>
        /// <param name="Ragham">عدد بین 20 تا 99</param>
        /// <returns>حروف را برمی گرداند در صورت خطا -1  و درصورت عدد نامعتبر تهی برمی گرداند</returns>
        private static string ConvertRaghamToHorof20to99(int Ragham)
        {
            try
            {
                //اعداد صفر  تا بیست
                if (!(Ragham > 19 && Ragham < 100)) return "";
                // برای تبدیل به حروف  رقم دوم
                string str = ConvertRaghamToHorof0to19(int.Parse(Ragham.ToString().Substring(1)));
                if (Ragham > 19 && Ragham < 30)
                {
                    if (Ragham == 20)
                    {
                        return "بیست";
                    }
                    else
                    {
                        return "بیست و" + str;
                    }

                }
                else if (Ragham > 29 && Ragham < 40)
                {
                    if (Ragham == 30)
                    {
                        return "سی";
                    }
                    else
                    {
                        //string str = ConvertRaghamToHorof0to20(Ragham.ToString().Substring(1));
                        return "سی و" + str;
                    }
                }
                else if (Ragham > 39 && Ragham < 50)
                {
                    if (Ragham == 40)
                    {
                        return "چهل";
                    }
                    else
                    {
                        //string str = ConvertRaghamToHorof0to20(Ragham.ToString().Substring(1));
                        return "چهل و" + str;
                    }
                }
                else if (Ragham > 49 && Ragham < 60)
                {
                    if (Ragham == 50)
                    {
                        return "پنجاه";
                    }
                    else
                    {
                        //string str = ConvertRaghamToHorof0to20(Ragham.ToString().Substring(1));
                        return "پنجاه و" + str;
                    }
                }
                else if (Ragham > 59 && Ragham < 70)
                {
                    if (Ragham == 60)
                    {
                        return "شصت";
                    }
                    else
                    {
                        //string str = ConvertRaghamToHorof0to20(Ragham.ToString().Substring(1));
                        return "شصت و" + str;
                    }
                }
                else if (Ragham > 69 && Ragham < 80)
                {
                    if (Ragham == 70)
                    {
                        return "هفتاد";
                    }
                    else
                    {
                        //string str = ConvertRaghamToHorof0to20(Ragham.ToString().Substring(1));
                        return "هفتادو" + str;
                    }
                }
                else if (Ragham > 79 && Ragham < 90)
                {
                    if (Ragham == 80)
                    {
                        return "هشتاد";
                    }
                    else
                    {
                        //string str = ConvertRaghamToHorof0to20(Ragham.ToString().Substring(1));
                        return "هشتادو" + str;
                    }
                }
                else if (Ragham > 89 && Ragham < 100)
                {
                    if (Ragham == 90)
                    {
                        return "نود";
                    }
                    else
                    {
                        //string str = ConvertRaghamToHorof0to20(Ragham.ToString().Substring(1));
                        return "نودو" + str;
                    }
                }
                return "";
            }
            catch (Exception e)
            {
                return "-1";
            }
            finally
            {
            }

        }
        /// <summary>
        /// اعداد از 0   تا نود نه را به حروف تبدیل میکند
        /// </summary>
        /// <param name="Ragham">عدد بین 0 تا 99</param>
        /// <returns>حروف را برمی گرداند در صورت خطا -1  و درصورت عدد نامعتبر تهی برمی گرداند</returns>
        private static string ConvertRaghamToHorof0to99(int Ragham)
        {
            try
            {
                if (Ragham > 99) return "";
                if (Ragham < 20)
                {
                    return ConvertRaghamToHorof0to19(Ragham);
                }
                else if (Ragham < 100)
                {
                    return ConvertRaghamToHorof20to99(Ragham);
                }
                return "";
            }
            catch (Exception e)
            {
                return "";
            }
            finally
            { }
        }
        /// <summary>
        /// اعداد از صد  تانهصدو نودو نه را به حروف تبدیل میکند
        /// </summary>
        /// <param name="Ragham">عدد بین 100 تا 999</param>
        /// <returns>حروف را برمی گرداند در صورت خطا -1  و درصورت عدد نامعتبر تهی برمی گرداند</returns>
        private static string ConvertRaghamToHorof100to999(int Ragham)
        {
            try
            {
                //اعداد 100  تا 999
                if (!(Ragham > 99 && Ragham < 1000)) return "";
                // برای تبدیل به حروف  رقم دوم

                string str = ConvertRaghamToHorof0to99(int.Parse(Ragham.ToString().Substring(1)));
                if (Ragham > 99 && Ragham < 200)
                {
                    if (Ragham == 100)
                    {
                        return "صد";
                    }
                    else
                    {
                        return "صدو" + str;
                    }

                }
                else if (Ragham > 199 && Ragham < 300)
                {
                    if (Ragham == 200)
                    {
                        return "دویست";
                    }
                    else
                    {
                        //string str = ConvertRaghamToHorof0to20(Ragham.ToString().Substring(1));
                        return "دویست و" + str;
                    }
                }
                else if (Ragham > 299 && Ragham < 400)
                {
                    if (Ragham == 300)
                    {
                        return "سیصد";
                    }
                    else
                    {
                        //string str = ConvertRaghamToHorof0to20(Ragham.ToString().Substring(1));
                        return "سیصدو" + str;
                    }
                }
                else if (Ragham > 399 && Ragham < 500)
                {
                    if (Ragham == 400)
                    {
                        return "چهارصد";
                    }
                    else
                    {
                        //string str = ConvertRaghamToHorof0to20(Ragham.ToString().Substring(1));
                        return "چهارصدو" + str;
                    }
                }
                else if (Ragham > 499 && Ragham < 600)
                {
                    if (Ragham == 500)
                    {
                        return "پانصد";
                    }
                    else
                    {
                        //string str = ConvertRaghamToHorof0to20(Ragham.ToString().Substring(1));
                        return "پانصدو" + str;
                    }
                }
                else if (Ragham > 599 && Ragham < 700)
                {
                    if (Ragham == 600)
                    {
                        return "ششصد";
                    }
                    else
                    {
                        //string str = ConvertRaghamToHorof0to20(Ragham.ToString().Substring(1));
                        return "ششصدو" + str;
                    }
                }
                else if (Ragham > 699 && Ragham < 800)
                {
                    if (Ragham == 700)
                    {
                        return "هفتصد";
                    }
                    else
                    {
                        //string str = ConvertRaghamToHorof0to20(Ragham.ToString().Substring(1));
                        return "هفتصدو" + str;
                    }
                }
                else if (Ragham > 799 && Ragham < 900)
                {
                    if (Ragham == 800)
                    {
                        return "هشتصد";
                    }
                    else
                    {
                        //string str = ConvertRaghamToHorof0to20(Ragham.ToString().Substring(1));
                        return "هشتصدو" + str;
                    }
                }
                else if (Ragham > 899 && Ragham < 1000)
                {
                    if (Ragham == 900)
                    {
                        return "نهصد";
                    }
                    else
                    {
                        //string str = ConvertRaghamToHorof0to20(Ragham.ToString().Substring(1));
                        return "نهصدو" + str;
                    }
                }
                return "";
            }
            catch (Exception e)
            {
                return "-1";
            }
            finally
            {
            }

        }
        /// <summary>
        /// اعداد از صفر تا 999 را به حروف تبدیل می کند
        /// </summary>
        /// <param name="Ragham"></param>
        /// <returns></returns>
        private static string ConvertRaghamToHorof0to999(int Ragham)
        {
            try
            {

                if (!(Ragham < 1000)) return "";

                if (Ragham < 20)
                {
                    return ConvertRaghamToHorof0to19(Ragham);
                }
                else if (Ragham > 19 && Ragham < 100)
                {
                    return ConvertRaghamToHorof20to99(Ragham);
                }
                else if (Ragham > 99 && Ragham < 1000)
                {
                    return ConvertRaghamToHorof100to999(Ragham);
                }
                else
                {
                    return "خطا برنامه نویسی";
                }

                return "";
            }
            catch (Exception e)
            {
                return "-1";
            }
            finally
            {
            }

        }
        /// <summary>
        /// یک عدد سه رقمی و موقعیت انرا دریافت و به حروف تبدیل می کند
        /// </summary>
        /// <param name="Ragham">عدد سه رقمی</param>
        /// <param name="LocationRagham"> موقیت عدد 2 =هزار 3== میلیون 4= میلیارد</param>
        /// <returns></returns>
        private static string pishConvertRaghamToHorof3(int Ragham, int LocationRagham)
        {
            try
            {   //اگر عدد صفر نیازبه پیش ندارد
                if (Ragham == 0) return "";
                if (Ragham > 1000) return "";

                //string str = ConvertRaghamToHorof0to999(Ragham);
                if (Ragham == 0) return "";
                switch (LocationRagham)
                {
                    case 1:
                        return ConvertRaghamToHorof0to999(Ragham);
                    case 2:
                        return ConvertRaghamToHorof0to999(Ragham) + " هزار";
                    case 3:
                        return ConvertRaghamToHorof0to999(Ragham) + " میلیون ";
                    case 4:
                        return ConvertRaghamToHorof0to999(Ragham) + " میلیارد";
                    case 5:
                        return ConvertRaghamToHorof0to999(Ragham) + "تریلیارد";
                    case 6:

                        return ConvertRaghamToHorof0to999(Ragham) + " ??? ";
                    case 7:

                        return ConvertRaghamToHorof0to999(Ragham) + " ??? ";
                    case 8:

                        return ConvertRaghamToHorof0to999(Ragham) + " ??? ";
                    case 9:

                        return ConvertRaghamToHorof0to999(Ragham) + " ??? ";
                }

                return "";
            }
            catch (Exception e)
            {
                return "error";
            }
            finally
            {
            }

        }

        /// <summary>
        /// یک رقم را سه رقم سه رقم جدا می کند
        /// </summary>
        /// <param name="Ragham">رقم که باید حداکثر دوازده رقم باشد</param>
        /// <returns>جداشده سه رقم سه رقم را برمی گرداند</returns>
        public static string ConvertRaghamToJodaJoda(Int64 Ragham)
        {

            try
            {
                string Add = Ragham.ToString();
                Add = Add.Trim(); //فقط دوازده رقم را پشتیبانی می کند
                if (Add.Length > 15) Add = Add.Substring(0, 15);
                if (Add.Trim() == "")
                {

                    return "";
                }

                string j = "";

                if ((Add.Length > 3 && Add.Length < 6) || Add.Length == 6)
                {
                    //MessageBox.Show(i.Substring(3, 1));
                    Add = Add.Substring(0, Add.Length - 3) + "," + Add.Substring(Add.Length - 3, 3);
                }
                else if ((Add.Length > 6 && Add.Length < 9) || Add.Length == 9)
                {

                    Add = Add.Substring(0, Add.Length - 6) +
                           "," + Add.Substring(Add.Length - 6, 3) +
                           "," + Add.Substring(Add.Length - 3, 3);

                }
                else if ((Add.Length > 9 && Add.Length < 12) || Add.Length == 12)
                {
                    //MessageBox.Show(i.Substring(3, 1));
                    Add = Add.Substring(0, Add.Length - 9) +
                          "," + Add.Substring(Add.Length - 9, 3) +
                          "," + Add.Substring(Add.Length - 6, 3) +
                    "," + Add.Substring(Add.Length - 3, 3);
                    //Add = Add.Substring(0, 3) +
                    //       "," + Add.Substring(3, 3) +
                    //       "," + Add.Substring(6, 3) +
                    //       "," + Add.Substring(9, Add.Length - 9);
                }
                else if (Add.Length > 12 && Add.Length < 15)
                {
                    //MessageBox.Show(i.Substring(3, 1));
                    Add = Add.Substring(0, 3) +
                           "," + Add.Substring(3, 3) +
                           "," + Add.Substring(6, 3) +
                            "," + Add.Substring(9, 3) +
                           "," + Add.Substring(12, Add.Length - 12);
                }
                else if (Add.Length < 3)
                {

                }

                return Add;
            }


            catch (Exception e)
            {
                //ClsGlobalClass.ShowMessageErrorFarsi(e, "ConvertRaghamToJodaJoda(Int64 Ragham)");
                return "";

            }
            finally
            {
                //ObjBankPatern.SqlConnection.Close();
                //cmd.Dispose();
                //dap.Dispose();
            }
        }
        #endregion ConvertRaghamToHorof



        #region Other Tools

        static public string DigitSeparator(string txt)
        {
            if (txt == null) return "";
            txt = txt.Replace(",", "");
            string stx = "";
            int i = 1;
            while (txt.Length - 3 * i > 0)
            {
                stx = "," + txt.Substring(txt.Length - i * 3, 3) + stx;
                i++;
            }
            txt = txt.Substring(0, txt.Length - (i - 1) * 3) + stx;
            return txt;
        }


        static public string DigitSeparator(string txt1, string txt2)
        {
            return DigitSeparator(txt1) + "-" + DigitSeparator(txt2);
        }
        #endregion

        
        
        
        #region Email And Telephone
        static public void SendEmail(string Text)
        {
            RegisterEmail_frm reg = new RegisterEmail_frm(Text);
            reg.ShowDialog();
        }

        static public int InsertPerTelMob(string Name, string Family, string Tel, string Mob, string EML,
            string Adrs, string Desc)
        {
            if ((Tel == "" && Mob == "") || Family == "") return 4;

            try
            {
                DataClasses_MainDataContext DCDC = new DataClasses_MainDataContext(Global_Cls.ConnectionStr);
                var prd = from p in DCDC.TBL_PersonTelMobs
                          where (p.FirstName == Name) && (p.LastName == Family)
                          select p;
                if (prd.Count() != 0)
                    return 1;

                if (Mob != "")
                {
                    var pm = from p in DCDC.TBL_PersonTelMobs
                             where (p.Mobile == Mob)
                             select p;
                    if (pm.Count() != 0)
                    {
                        Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "شماره موبایل در دفتر تلفن موجود می باشد!");
                        return 2;
                    }
                }

                TBL_PersonTelMob tptm = new TBL_PersonTelMob
                {
                    FirstName = Name,
                    LastName = Family,
                    Telephone = Tel,
                    Mobile = Mob,
                    Email = EML,
                    Address = Adrs,
                    Description = Desc,
                };
                DCDC.TBL_PersonTelMobs.InsertOnSubmit(tptm);
                DCDC.SubmitChanges();
            }
            catch (Exception ex)
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SError, false, "لطفا با کمی فاصله دوباره تایید کنید!", ex.ToString());
                return 3;
            }

            return 0;
        }
        #endregion


        #region Set language

        static public void GetFarsiOrLatinLanguage(string FaOrEn)
        {
            foreach (InputLanguage lang in InputLanguage.InstalledInputLanguages)
            {
                if (FaOrEn == "Fa")
                {
                    if ((lang.LayoutName.ToLower() == "farsi") | (lang.LayoutName == "Persian"))
                        InputLanguage.CurrentInputLanguage = lang;
                }
                else
                {
                    if ((lang.LayoutName.ToLower() == "us"))
                        InputLanguage.CurrentInputLanguage = lang;
                }
            }
        }
        
        #endregion

    
        
        #region Test Internet Connection
        [DllImport("wininet.dll", CharSet = CharSet.Auto)]

        static extern bool InternetGetConnectedState(ref ConnectionState lpdwFlags, int dwReserved);

        [Flags]
        enum ConnectionState : int
        {
            INTERNET_CONNECTION_MODEM = 0x1,
            INTERNET_CONNECTION_LAN = 0x2,
            INTERNET_CONNECTION_PROXY = 0x4,
            INTERNET_RAS_INSTALLED = 0x10,
            INTERNET_CONNECTION_OFFLINE = 0x20,
            INTERNET_CONNECTION_CONFIGURED = 0x40
        }

        static public bool SetConnection()
        {
            ConnectionState Description = 0;
            if (!InternetGetConnectedState(ref Description, 0))
            {
                Global_Cls.Message_Sara(0, Global_Cls.MessageType.SWarning, false, "اتصال به اینترنت برقرار نمی باشد!");
                return false;
            }
            return true;
        }
        #endregion




        static public string Key_Name = "912-4573723";
        static public string RootSaveLoad()
        {
            if (Global_Cls.ClientSoftOK)
                return "\\\\" + Global_Cls.ServerName + "\\RentCar";
            else
                return Application.StartupPath;
        }

        #region All Parameter Settings

        
        //LocalConfig
        
        static public int GetFinePeriod = 15;

        static public int ExpDayBodyInsu = 30;

        static public int ExpDayCarDuty = 2;

        static public int ExpDayCarEnter = 2;

        static public int ExpDayThirdInsu = 30;

        static public int ExpKMService = 100;



        static public int FreeKillometer = 250;

        static public double FineDay = 0;
        
        static public double FineTime = 0;
        
        static public double FineKillometer = 0;
        
        static public string CityLimit = "تهران";


        static public string ServerName = "LocalHost";//"127.0.0.1";

        static public string ConnectionDef = @"Data Source=" + Global_Cls.ServerName + @"\sqlexpress;";

        static public string ServerNameForLock = "127.0.0.1";
        
        static public byte ColorDisplay = 0;


        //static public bool HouseFile_Print = false;

        //static public bool HouseFile_TelNtBook = false;

        //static public bool HouseFile_DataHolder = false;


        //MainConfig
        static public string SMSPort = "COM4";

        static public int SMSBaudRate = 115200;

        static public int SMSDataBits = 8;

        static public int SMSParity = 0;

        static public int SMSStopBits = 1;

        static public int SMSFlowControl = 0;

        static public int SMSTimeOut = 400;

        static public int SMSEncoding = 2;

        static public int SMSLongMsg = 3;

        static public bool SMSDeliveryReport = false;
        
        static public int BkpExitType = 0;

        static public string BkpAutoRoot = "D:\\BackUpData";

        static public string PssRstrr = "uvwxy";

        static public bool BkpRstPicsFilms = false;

        static public bool BkpRstDesignReport = false;

        static public string ConnectionStr = "";

        static public System.Collections.Specialized.StringCollection HouseFor;

        //new 930925
        public static bool SMSSet = true;

        public static string IntUserName = "";

        public static string IntPassword = "";

        public static string IntTelNumber = "";

        public static string InitSMSMessage = "";

        //new 930925


        //Lock Parameter

        ////def mini
        //static public string Lock_UserID = "4A1427124B175EE35469B9CB9CDF49";
        //static public string Lock_SerialNo = "2009-8807-3471";

        ////teh0001
        //static public string Lock_UserID = "37EEFCA121525BC7951595B1EF78FD2A";
        //static public string Lock_SerialNo = "2019-8809-1408";


        //static public string Lock_SpecialID = "FGPCO881001SaRA";
        //static public string Lock_Data = "FGPCO2";

        #endregion


    }

}
