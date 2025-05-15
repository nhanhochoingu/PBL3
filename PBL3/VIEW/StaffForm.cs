using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.VIEW;

namespace PBL3
{
    public partial class StaffForm: Form
    {
        public StaffForm()
        {
            InitializeComponent();
            LoadUserControl(new UC_Customer_Admin());
        }
        private bool sidebarExpanded = false; // Xác định trạng thái mở hay đóng

        private void LoadUserControl(UserControl uc)
        {
            PanelMain.Controls.Clear();       // Xóa nội dung cũ
            uc.Dock = DockStyle.Fill;         // Tự động giãn đầy Panel
            PanelMain.Controls.Add(uc);       // Thêm UC mới vào
        }
        private void StaffForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất ?", "Thông báo đăng xuất", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private void but_Menu_Click(object sender, EventArgs e)
        {
            if (sidebarExpanded)
            {

                // Nếu đang mở thì thu nhỏ
                sidebar.Width = 45;
                but_Menu.Location = new Point(0, 0);
                but_Customer.Text = "";
                but_Sanbong.Text = "";
                but_Schedule.Text = "";
                but_personal.Text = "";
                but_Exit.Text = "";
                sidebarExpanded = false;
            }
            else
            {
                // Nếu đang thu nhỏ thì mở rộng
                sidebar.Width = 200;
                but_Menu.Location = new Point(160, 0);
                but_Customer.Width = 200;
                but_Customer.Text = "Khách Hàng";
                but_Sanbong.Width = 200;
                but_Sanbong.Text = "Sân Bóng";
                but_Schedule.Width = 200;
                but_Schedule.Text = "Đăng Kí Lịch Làm";
                but_personal.Width = 200;
                but_personal.Text = "Cá Nhân";
                but_Exit.Width = 200;
                but_Exit.Text = "Thoát";
                sidebarExpanded = true;
            }
        }

        private void but_Customer_Click(object sender, EventArgs e)
        {
            sidebar.Width = 45;
            but_Menu.Location = new Point(0, 0);
            but_Customer.Text = "";
            but_Sanbong.Text = "";
            but_Schedule.Text = "";
            but_personal.Text = "";
            but_Exit.Text = "";
            sidebarExpanded = false;
            LoadUserControl(new UC_Customer_Admin());
        }

        private void but_Sanbong_Click(object sender, EventArgs e)
        {
            sidebar.Width = 45;
            but_Menu.Location = new Point(0, 0);
            but_Customer.Text = "";
            but_Sanbong.Text = "";
            but_Schedule.Text = "";
            but_personal.Text = "";
            but_Exit.Text = "";
            sidebarExpanded = false;
            LoadUserControl(new UC_Pitchs_Admin());
        }

        private void but_personal_Click(object sender, EventArgs e)
        {
            sidebar.Width = 45;
            but_Menu.Location = new Point(0, 0);
            but_Customer.Text = "";
            but_Sanbong.Text = "";
            but_Schedule.Text = "";
            but_personal.Text = "";
            but_Exit.Text = "";
            sidebarExpanded = false;
        }

        private void but_Schedule_Click(object sender, EventArgs e)
        {
            sidebar.Width = 45;
            but_Menu.Location = new Point(0, 0);
            but_Customer.Text = "";
            but_Sanbong.Text = "";
            but_Schedule.Text = "";
            but_personal.Text = "";
            but_Exit.Text = "";
            sidebarExpanded = false;

        }

        private void but_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
