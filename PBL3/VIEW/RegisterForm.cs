using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class RegisterForm: Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        String cnn = @"Data Source=TIẾN-NGUYỄN\SQLEXPRESS;Initial Catalog=FootballFieldManagement;Integrated Security=True";

        private void butExit_Click(object sender, EventArgs e)
        {
           
            if (txt1.Text != "" || txt2.Text != "" || txt3.Text != "" || txt4.Text != "" || txt5.Text != "" || txt6.Text != "" || txt7.Text != "")
            {
                if (MessageBox.Show("Bạn muốn thoát khi chưa hoàn tất đăng kí ?", "Thông báo thoát", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {

                    this.Close();
                }
                else
                {
                    return;
                }
                }
                this.Close();
        }

        private void butRegister_Click(object sender, EventArgs e)
        {
            String name = txt1.Text;
            String displayName = txt2.Text;
            String userName = txt3.Text;
            String phoneNumber = txt4.Text;
            String email = txt5.Text;
            String password = txt6.Text;
            String confirmPassword = txt7.Text;
            String role = "Customer";

            if (name == "" || displayName == "" || userName == "" || phoneNumber == "" || email == "" || password == "" || confirmPassword == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu không khớp");
                return;
            }
            if (!phoneNumber.All(char.IsDigit) || phoneNumber.Length != 10 || phoneNumber[0] != '0') { 
                MessageBox.Show("Số điện thoại không hợp lệ");
                return;
            }
            if (!email.Contains("@gmail.com"))
            {
                MessageBox.Show("Email không hợp lệ");
                return;
            }
            SqlConnection connection = new SqlConnection(cnn);
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Account WHERE Username = @Username", connection);
            cmd.Parameters.AddWithValue("@Username", userName);
            int checkUser = (int)cmd.ExecuteScalar();
            if (checkUser > 0)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại");
                return;
            }
            cmd = new SqlCommand("INSERT INTO Account (DisplayName ,Username, Password, Role) " + " OUTPUT INSERTED.UserID " + "VALUES (@DisplayName, @Username, @Password, @Role)", connection);
            cmd.Parameters.AddWithValue("@DisplayName", displayName);
            cmd.Parameters.AddWithValue("@Username", userName);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@Role", role);

            int userId = (int)cmd.ExecuteScalar();

            cmd = new SqlCommand("INSERT INTO Customer (Name, PhoneNumber, Email, UserID) VALUES (@Name, @PhoneNumber, @Email, @UserID)", connection);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@UserID", userId);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đăng ký thành công");
            connection.Close();
            this.Close();
        }
    }
}
