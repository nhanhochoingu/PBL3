using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;
using PBL3.DAL;
using System.Xml.Linq;

namespace PBL3.VIEW
{
    public partial class NewStaffForm : Form
    {
        public NewStaffForm()
        {
            InitializeComponent();
        }
        private _BLL_Staff bll = new _BLL_Staff();
        private void butRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) ||
        string.IsNullOrWhiteSpace(txtSĐT.Text) ||
        string.IsNullOrWhiteSpace(txtEmail.Text) ||
        string.IsNullOrWhiteSpace(txtHeSo.Text) ||
        string.IsNullOrWhiteSpace(txtTime.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Staff staff = new Staff
                {
                    StaffName = txtHoTen.Text,
                    StaffSDT = txtSĐT.Text,
                    StaffEmail = txtEmail.Text,
                    Coefficient = decimal.Parse(txtHeSo.Text),
                    Worktime = int.Parse(txtTime.Text)
                };

                bool success = bll.AddStaff(staff);
                if (success)
                {
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nhập dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
