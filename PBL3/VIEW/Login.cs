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

namespace PBL3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private string connect = @"Data Source=THITKHOMAMRUOC;Initial Catalog=FootballFieldManagement;Integrated Security=True";
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
            String username = txtUsername.Text;
            String password = txtPassword.Text;
            if (username == "" || password == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            SqlConnection cnn = new SqlConnection(connect);
            cnn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Username, Password, Role FROM Account WHERE Username = @Username ", cnn);
            cmd.Parameters.AddWithValue("@Username", username);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string dbUsername = reader["Username"].ToString();
                string dbPassword = reader["Password"].ToString();
                string role = reader["Role"].ToString();

                if (String.Equals(username, dbUsername, StringComparison.Ordinal) &&
                                String.Equals(password, dbPassword, StringComparison.Ordinal))
                {
                    if (role.ToLower() == "admin")
                    {
                        AdminForm adminForm = new AdminForm();
                        this.Hide();
                        adminForm.ShowDialog();
                        this.Show();
                    }
                    else if (role.ToLower() == "staff")
                    {
                        StaffForm staffForm = new StaffForm();
                        this.Hide();
                        staffForm.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        CustomerForm customerForm = new CustomerForm();
                        this.Hide();
                        customerForm.ShowDialog();
                        this.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu hoặc tài khoản không đúng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
           
                
            }
            cnn.Close();
        }

        private void bntRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registF = new RegisterForm();
            registF.ShowDialog();
        }
    }
}


