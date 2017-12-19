using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        MaftooxCalendar.MaftooxPersianCalendar.TimeWork prdTime = new MaftooxCalendar.MaftooxPersianCalendar.TimeWork();
        MaftooxCalendar.MaftooxPersianCalendar.DateWork prd = new MaftooxCalendar.MaftooxPersianCalendar.DateWork();
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            timer1.Start();
            if (Permissions.Permission == 1)
            {
               // TypeOfUser.Text = "متصدی";
            }
            else
            {
               // TypeOfUser.Text = "متقاضی";
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime DT = DateTime.Now;
            circularProgressBar2.Text = DT.Hour.ToString("00") + ":" + DT.Minute.ToString("00");
            labelX1.Text = DT.Second.ToString("00");
            circularProgressBar2.Value = DT.Second;
            prdTime.Upate();
            String stry = prd.GetNameMonth() + prd.GetNameDayInMonth();
            if (prd.GetNameDayInMonth() == "سه شبه")
                labelX2.Text = "سه شنبه"; 
            else
                labelX2.Text = prd.GetNameDayInMonth();
            labelX3.Text = prd.GetNumberDayInMonth().ToString() + "  " + prd.GetNameMonth() + "  " + prd.GetNumberYear().ToString();
        }

        private void circularProgressBar2_Click(object sender, EventArgs e)
        {

        }

        private void applicationButton1_Click(object sender, EventArgs e)
        {

        }
        private void ribbonPanel2_Click(object sender, EventArgs e)
        {

        }

        private void ribbonPanel1_Click(object sender, EventArgs e)
        {

        }

        private void ribbonTabItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
