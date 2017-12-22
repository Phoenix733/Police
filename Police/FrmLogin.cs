using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FMessegeBox;
using DA_Layer;
using BL_Layer;
namespace Police
{
    public partial class FrmLogin : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public BusinessLogicLayer Log = new BusinessLogicLayer();
        private void btnLogin_Click(object sender, EventArgs e)
        {

           // BusinessLogicLayer Log = new BusinessLogicLayer();
            if (txtUser.Text == "" && txtPass.Text == "" && comboBoxEx1.SelectedIndex == -1)
            {
                FarsiMessegeBox.Show("لطفا نام کاربری و کلمه عبور را وارد کنید و همچنین سطح دسترسی خود را مشخص کنید", "خطا ورود اطلاعات");
                txtUser.BackColor = Color.Yellow;
                Star1.ForeColor = Color.Red;
                Star1.Visible = true;
                txtPass.BackColor = Color.Yellow;
                Star2.ForeColor = Color.Red;
                Star2.Visible = true;
                Star3.ForeColor = Color.Red;
                Star3.Visible = true;
            }
            else if (txtUser.Text == "" && txtPass.Text == "")
            {
                FarsiMessegeBox.Show("لطفا نام کاربری و کلمه عبور را وارد کنید!!", "خطا ورود اطلاعات");
                txtUser.BackColor = Color.Yellow;
                Star1.ForeColor = Color.Red;
                Star1.Visible = true;
                txtPass.BackColor = Color.Yellow;
                Star2.ForeColor = Color.Red;
                Star2.Visible = true;
            }
            else if (txtUser.Text == "")
            {
                FarsiMessegeBox.Show("لطفا نام کاربری را وارد کنید!!", "خطا ورود اطلاعات");
                txtUser.BackColor = Color.Yellow;
                Star1.ForeColor = Color.Red;
                Star1.Visible = true;
            }
            else if (txtPass.Text == "")
            {
                FarsiMessegeBox.Show("لطفا کلمه عبور را وارد کنید!!", "خطا ورود اطلاعات");
                txtPass.BackColor = Color.Yellow;
                Star2.ForeColor = Color.Red;
                Star2.Visible = true;
            }
            else if (comboBoxEx1.SelectedIndex == -1)
            {
                FarsiMessegeBox.Show("لطفا سطح دسترسی خود را مشخص کنید!!", "خطا ورود اطلاعات");
                Star3.ForeColor = Color.Red;
                Star3.Visible = true;
            }
            else if (comboBoxEx1.SelectedIndex == 0)
            {
                LoginHistory.Permission = true;
                Log.Login(LoginHistory.Permission, txtUser.Text, txtPass.Text);
                if (Log.DT.Rows.Count > 0)
                {
                    LoginHistory.UserCode = Convert.ToInt32(Log.DT.Rows[0][1].ToString());
                    LoginHistory.Username = Log.DT.Rows[0][3].ToString();
                    LoginHistory.Name = Log.DT.Rows[0][5].ToString();
                    this.Hide();
                    FrmMain FormMain = new FrmMain();
                    FormMain.ShowDialog();
                }
                else
                {
                    FarsiMessegeBox.Show("نام کاربری یا کلمه عبور اشتباه است!!", "خطا ورود اطلاعات");
                    txtUser.Text = txtPass.Text = "";
                    comboBoxEx1.SelectedIndex = -1;
                }
            }
            else
            {
                LoginHistory.Permission = false;
                Log.Login(LoginHistory.Permission, txtUser.Text, txtPass.Text);
                if (Log.DT.Rows.Count > 0)
                {
                    LoginHistory.UserCode = Convert.ToInt32(Log.DT.Rows[0][1].ToString());
                    LoginHistory.Username = Log.DT.Rows[0][3].ToString();
                    LoginHistory.Name = Log.DT.Rows[0][5].ToString();
                    this.Hide();
                    FrmMain FormMain = new FrmMain();
                    FormMain.ShowDialog();
                }
                else
                {
                    FarsiMessegeBox.Show("نام کاربری یا کلمه عبور اشتباه است!!", "خطا ورود اطلاعات");
                    txtUser.Text = txtPass.Text = "";
                    comboBoxEx1.SelectedIndex = -1;
                }
            }
        }
        private void txtUser_MouseClick(object sender, MouseEventArgs e)
        {
            txtUser.BackColor = Color.White;
            Star1.Visible = false;
        }
        private void txtPass_MouseClick(object sender, MouseEventArgs e)
        {
            txtPass.BackColor = Color.White;
            Star2.Visible = false;
        }
        private void comboBoxEx1_MouseClick(object sender, MouseEventArgs e)
        {
            Star3.Visible = false;
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}