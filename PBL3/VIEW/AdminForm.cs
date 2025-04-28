using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class AdminForm: Form
    {
        public AdminForm()
        {
            InitializeComponent();
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
                sidebarExpanded = false;
            }
            else
            {
                // Nếu đang thu nhỏ thì mở rộng
                sidebar.Width = 200;
                but_Menu.Location = new Point(160,0);
                but_Booking.Width = 200;
                but_Booking.Text = "Đặt Sân";
                sidebarExpanded = true;
            }
        }

    }
}
