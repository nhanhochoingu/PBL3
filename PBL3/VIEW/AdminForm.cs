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
    public partial class AdminForm: Form
    {
        public AdminForm()
        {
            InitializeComponent();
            LoadUserControl(new UC_Customer_Admin());
        }
        private bool sidebarExpanded = false; // Xác định trạng thái mở hay đóng
        private void but_Menu_Click(object sender, EventArgs e)
        {
            if (sidebarExpanded)
            {
                
                // Nếu đang mở thì thu nhỏ
                sidebar.Width = 45;
                but_Menu.Location = new Point(0, 0);
                but_Customer.Text = "";
                but_Sanbong.Text = "";
                but_Drink.Text = "";
                but_Bills.Text = "";
                but_revenue.Text = "";
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
                but_Drink.Width = 200;
                but_Drink.Text = "Đồ Uống";
                but_Bills.Width = 200;
                but_Bills.Text = "Hoá Đơn";
                but_Exit.Width = 200;
                but_Exit.Text = "Thoát";
                but_revenue.Width = 200;
                but_revenue.Text = "     Báo Cáo,Nhân Viên";
                sidebarExpanded = true; 
            }
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất ?", "Thông báo đăng xuất", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private void LoadUserControl(UserControl uc)
        {
            PanelMain.Controls.Clear();       // Xóa nội dung cũ
            uc.Dock = DockStyle.Fill;         // Tự động giãn đầy Panel
            PanelMain.Controls.Add(uc);       // Thêm UC mới vào
        }
        private void but_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_Customer_Click(object sender, EventArgs e)
        {
            sidebar.Width = 45;
            but_Menu.Location = new Point(0, 0);
            but_Customer.Text = "";
            but_Sanbong.Text = "";
            but_Drink.Text = "";
            but_Bills.Text = "";
            but_Exit.Text = "";
            but_revenue.Text = "";
            sidebarExpanded = false;
            LoadUserControl(new UC_Customer_Admin());
        }

        private void but_Sanbong_Click(object sender, EventArgs e)
        {
            sidebar.Width = 45;
            but_Menu.Location = new Point(0, 0);
            but_Customer.Text = "";
            but_Sanbong.Text = "";
            but_Drink.Text = "";
            but_Bills.Text = "";
            but_Exit.Text = "";
            but_revenue.Text = "";
            sidebarExpanded = false;
            LoadUserControl(new UC_Pitchs_Admin());

        }

        private void but_Drink_Click(object sender, EventArgs e)
        {
            sidebar.Width = 45;
            but_Menu.Location = new Point(0, 0);
            but_Customer.Text = "";
            but_Sanbong.Text = "";
            but_Drink.Text = "";
            but_Bills.Text = "";
            but_Exit.Text = "";
            but_revenue.Text = "";
            sidebarExpanded = false;
            LoadUserControl(new UC_Drink_Admin());
        }

        private void but_Bills_Click(object sender, EventArgs e)
        {
            sidebar.Width = 45;
            but_Menu.Location = new Point(0, 0);
            but_Customer.Text = "";
            but_Sanbong.Text = "";
            but_Drink.Text = "";
            but_Bills.Text = "";
            but_Exit.Text = "";
            but_revenue.Text = "";
            sidebarExpanded = false;
            LoadUserControl(new UC_Invoice_Admin());
        }

        private void but_revenue_Click(object sender, EventArgs e)
        {
            sidebar.Width = 45;
            but_Menu.Location = new Point(0, 0);
            but_Customer.Text = "";
            but_Sanbong.Text = "";
            but_Drink.Text = "";
            but_Bills.Text = "";
            but_Exit.Text = "";
            but_revenue.Text = "";
            sidebarExpanded = false;
            LoadUserControl(new UC_Revenue_Admin());
        }
    }
}
