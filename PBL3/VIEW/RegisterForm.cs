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
using PBL3.BLL;
using PBL3.DAL;

namespace PBL3
{
    public partial class RegisterForm: Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private _BLL_Account accountBLL = new _BLL_Account();
        private _BLL_Customer customerBLL = new _BLL_Customer();

        private void butExit_Click(object sender, EventArgs e)
        {
           
            if (txtHoTen.Text != "" || txtTenHienThi.Text != "" || txtTenDangNhap.Text != "" || txtSDT.Text != "" || txtEmail.Text != "" || txtMatKhau.Text != "" || txtXacNhan.Text != "")
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
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) ||
            string.IsNullOrWhiteSpace(txtTenHienThi.Text) ||
            string.IsNullOrWhiteSpace(txtTenDangNhap.Text) ||
            string.IsNullOrWhiteSpace(txtSDT.Text) ||
            string.IsNullOrWhiteSpace(txtEmail.Text) ||
            string.IsNullOrWhiteSpace(txtMatKhau.Text) ||
            string.IsNullOrWhiteSpace(txtXacNhan.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ tất cả các trường!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Lấy dữ liệu từ form
            string hoTen = txtHoTen.Text.Trim();
            string displayName = txtTenHienThi.Text.Trim();
            string username = txtTenDangNhap.Text.Trim();
            string password = txtMatKhau.Text;
            string confirm = txtXacNhan.Text;
            string sdt = txtSDT.Text.Trim();
            string email = txtEmail.Text.Trim();

            // Kiểm tra cơ bản
            if (password != confirm)
            {
                MessageBox.Show("Xác nhận mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (accountBLL.IsUsernameTaken(username))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo account
            Account acc = new Account
            {
                DisplayName = displayName,
                Username = username,
                Password = password,  // nên mã hoá trong thực tế
                Role = "Customer"
            };
            accountBLL.RegisterAccount(acc);

            // Lấy UserID vừa thêm
            int userId = accountBLL.GetLastUserID();

            // Tạo customer
            Customer cus = new Customer
            {
                Name = hoTen,
                PhoneNumber = sdt,
                Email = email,
                UserID = userId
            };
            customerBLL.RegisterCustomer(cus);

            MessageBox.Show("Đăng ký thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
