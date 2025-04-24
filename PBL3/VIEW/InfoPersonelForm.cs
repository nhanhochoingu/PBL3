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
    public partial class InfoPersonelForm: Form
    {
        public InfoPersonelForm()
        {
            InitializeComponent();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            if(txtTenkhach.Text != "" || txtTenhienthi.Text != "" || txtSDT.Text != "" || txtEmail.Text != "")
            {
                if (MessageBox.Show("Bạn muốn thoát khi chưa hoàn tất cập nhật ?", "Thông báo thoát", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    this.Close();
                }
                else
                {
                    return;
                }
                this.Close();
            }
        }
    }
}
