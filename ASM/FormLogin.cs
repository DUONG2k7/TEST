using BUS_QL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM
{
    public partial class FormLogin : Form
    {
        BUS_GUI Qlgiaodien = new BUS_GUI();
        private bool isPasswordVisible = false;
        public FormLogin()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
            txtUsername.Focus();

            if (Properties.Settings.Default.RememberMe)
            {
                txtUsername.Text = Properties.Settings.Default.Username;
                txtPassword.Text = Properties.Settings.Default.Password;
                cbLuuMK.Checked = true;
            }
        }
        public bool KTdauvao()
        {
            if(string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Thông tin đăng nhập không hợp lệ", "Message");
                return false;
            }
            return true;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cbLuuMK.Checked)
            {
                Properties.Settings.Default.Username = txtUsername.Text;
                Properties.Settings.Default.Password = txtPassword.Text;
                Properties.Settings.Default.RememberMe = true;
            }
            else
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.RememberMe = false;
            }
            Properties.Settings.Default.Save();

            if (!KTdauvao())
            {
                return;
            }

            string idAcc = Qlgiaodien.GetIdAccFormUsernameAndPassWord(txtUsername.Text, txtPassword.Text);
            if (idAcc != null)
            {
                string role = Qlgiaodien.GetIDRole(idAcc);
                if (role == "R06")
                {
                    MessageBox.Show("Tài khoản này đã bị khóa! Vui lòng liên hệ phòng Admin");
                }
                else
                {
                    MessageBox.Show("Đăng nhập thành công!", "Message");
                    Qlgiaodien.SaveLoginHistory(idAcc);

                    this.Hide();
                    Form form = null;
                    switch (role)
                    {
                        case "R04":
                            form = new FormGV(txtUsername.Text, role, idAcc);
                            break;
                        case "R02":
                            form = new FormCBDT(txtUsername.Text, role);
                            break;
                        case "R01":
                            form = new FormADMIN(txtUsername.Text, role);
                            break;
                    }
                    if (form != null)
                    {
                        form.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập không tồn tại", "Message");
            }
        }
        private void pbHienMk_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.UseSystemPasswordChar = false;
                pbHienMk.Image = Properties.Resources.eye;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                pbHienMk.Image = Properties.Resources.hidden;
            }
        }
    }
}
