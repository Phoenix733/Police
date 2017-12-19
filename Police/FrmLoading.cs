using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Police
{
    public partial class FrmLoading : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmLoading()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }
        double Op = 0.85;
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity = Op;
            Op -= 0.14;
            progressBarX1.PerformStep();
            if (progressBarX1.Value == progressBarX1.Maximum)
            {
                timer1.Enabled = false;
                this.Hide();
                FrmLogin FormLogin = new FrmLogin();
                FormLogin.ShowDialog();
            }
        }
    }
}
