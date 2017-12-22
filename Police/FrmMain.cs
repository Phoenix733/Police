using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DA_Layer;
using BL_Layer;
using TMS.Class;
namespace Police
{
    public partial class FrmMain : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        MaftooxCalendar.MaftooxPersianCalendar.TimeWork PersianTime = new MaftooxCalendar.MaftooxPersianCalendar.TimeWork();
        MaftooxCalendar.MaftooxPersianCalendar.DateWork PersianDate = new MaftooxCalendar.MaftooxPersianCalendar.DateWork();
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            timer1.Start();
            LblCode.Text = "کد" + LoginHistory.UserCode.ToString();
            LblUser.Text = LoginHistory.Username;
            LblName.Text = LoginHistory.Name;
            if (LoginHistory.Permission == true)
                LblPermission.Text = "متصدی";
            else
                LblPermission.Text = "متقاضی";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime DT = DateTime.Now;
            circularProgressBar2.Text = DT.Hour.ToString("00") + ":" + DT.Minute.ToString("00");
            LblSec.Text = DT.Second.ToString("00");
            circularProgressBar2.Value = DT.Second;
            PersianTime.Upate();
            if (PersianDate.GetNameDayInMonth() == "سه شبه")
                LblDay.Text = "سه شنبه"; 
            else
                LblDay.Text = PersianDate.GetNameDayInMonth();
            LblDate.Text = PersianDate.GetNumberDayInMonth().ToString() + "  " + PersianDate.GetNameMonth() + "  " + PersianDate.GetNumberYear().ToString();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
