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
            SqlCommand cmd = new SqlCommand("SELECT Role FROM Account WHERE Username = @Username AND Password = @Password", cnn);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);
            object result = cmd.ExecuteScalar();

            if (result != null)
            {
                string role = result.ToString();
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
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
                MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cnn.Close();
        }
        }
    }

