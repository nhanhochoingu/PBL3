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
using static System.Net.Mime.MediaTypeNames;
using PBL3.BLL;

namespace PBL3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        
        private _BLL bll = new _BLL();



        private void butExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát ứng dụng ?", "Thông báo thoát", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            var account = bll.Login(username, password);

            if (username == "" || password == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            if (account == null) {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Chào mừng {account.DisplayName} ({account.Role})", "Đăng nhập thành công");

            switch (account.Role.ToLower())
            {
                case "admin":
                    AdminForm adminForm = new AdminForm();
                    adminForm.ShowDialog();
                    break;
                case "staff":
                    StaffForm staffForm = new StaffForm();
                    staffForm.ShowDialog();
                    break;
                case "customer":
                    CustomerForm customerForm = new CustomerForm(account);
                    customerForm.ShowDialog();
                    break;
                default:
                    MessageBox.Show("Vai trò không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }


            }

        private void bntRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registF = new RegisterForm();
            registF.ShowDialog();
        }
    }
}


