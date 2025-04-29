using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DAL;
using PBL3.VIEW;

namespace PBL3
{
    public partial class CustomerForm : Form
    {
        private Account currentAccount;
        public CustomerForm(Account acc)
        {
            InitializeComponent();
            LoadUserControl(new UC_Booking());
            currentAccount = acc;
        }
        private void CustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất ?", "Thông báo đăng xuất", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private bool sidebarExpanded = false; // Xác định trạng thái mở hay đóng
        private void but_Menu_Click(object sender, EventArgs e)
        {
            if (sidebarExpanded)
            {
                // Nếu đang mở thì thu nhỏ
                sidebar.Width = 45;
                but_Menu.Location = new Point(0, 0);
                but_Booking.Text = "";
                but_TaiKhoan.Text = "";
                but_DieuKhoan.Text = "";
                but_Thoat.Text = "";
                sidebarExpanded = false;
            }
            else
            {
                // Nếu đang thu nhỏ thì mở rộng
                sidebar.Width = 200;
                but_Menu.Location = new Point(160, 0);
                but_Booking.Width = 200;
                but_Booking.Text = "Đặt Sân";
                but_TaiKhoan.Width = 200;
                but_TaiKhoan.Text = "Tài Khoản";
                but_DieuKhoan.Width = 200;
                but_DieuKhoan.Text = "Điều Khoản";
                but_Thoat.Width = 200;
                but_Thoat.Text = "Thoát";
                sidebarExpanded = true;
            }
        }

        private void but_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadUserControl(UserControl uc)
        {
            PanelMain.Controls.Clear();       // Xóa nội dung cũ
            uc.Dock = DockStyle.Fill;         // Tự động giãn đầy Panel
            PanelMain.Controls.Add(uc);       // Thêm UC mới vào
        }
        private void but_DieuKhoan_Click(object sender, EventArgs e)
        {
            sidebar.Width = 45;
            but_Menu.Location = new Point(0, 0);
            but_Booking.Text = "";
            but_TaiKhoan.Text = "";
            but_DieuKhoan.Text = "";
            but_Thoat.Text = "";
            sidebarExpanded = false;
            LoadUserControl(new UC_Terms());
        }


        private void but_TaiKhoan_Click(object sender, EventArgs e)
        {
            sidebar.Width = 45;
            but_Menu.Location = new Point(0, 0);
            but_Booking.Text = "";
            but_TaiKhoan.Text = "";
            but_DieuKhoan.Text = "";
            but_Thoat.Text = "";
            sidebarExpanded = false;
            LoadUserControl(new UC_TaiKhoan());
        }

        private void but_Booking_Click(object sender, EventArgs e)
        {
            sidebar.Width = 45;
            but_Menu.Location = new Point(0, 0);
            but_Booking.Text = "";
            but_TaiKhoan.Text = "";
            but_DieuKhoan.Text = "";
            but_Thoat.Text = "";
            sidebarExpanded = false;
            LoadUserControl(new UC_Booking());
        }
    }
}
