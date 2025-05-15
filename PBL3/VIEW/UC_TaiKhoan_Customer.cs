using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using PBL3.BLL;
using PBL3.DAL;

namespace PBL3.VIEW
{
    public partial class UC_TaiKhoan_Customer : UserControl
    {
        private int selectedBillId = -1; // Biến lưu trữ ID của hóa đơn được chọn
        public UC_TaiKhoan_Customer()
        {
            InitializeComponent();
            LoadLichSuHoaDon();
        }
        private _BLL_Customer bll = new _BLL_Customer();
        private void UC_TaiKhoan_Load(object sender, EventArgs e)
        {
            int userId = UserSession.LoggedInUserID;
            Customer customer = bll.GetCustomerInfo(userId);
            if (customer != null)
            {
                txt_ID.Text = customer.CustomerID.ToString();
                txt_Ten.Text = customer.Name;
                txt_Sđt.Text = customer.PhoneNumber;
                txt_Email.Text = customer.Email;

                if (customer.Account != null)
                {
                    txt_username.Text = customer.Account.Username;
                    txt_Password.Text = customer.Account.Password;
                }
            }

        }

        private void cb_Edit_CheckedChanged(object sender, EventArgs e)
        {
            bool isEditable = cb_Edit.Checked;

            txt_Ten.ReadOnly = !isEditable;
            txt_Sđt.ReadOnly = !isEditable;
            txt_Email.ReadOnly = !isEditable;
            txt_username.ReadOnly = !isEditable;
            txt_Password.ReadOnly = !isEditable;

            txt_Ten.BorderStyle = isEditable ? BorderStyle.FixedSingle : BorderStyle.None;
            txt_Ten.BackColor = isEditable ? Color.White : this.BackColor;
            txt_Sđt.BorderStyle = isEditable ? BorderStyle.FixedSingle : BorderStyle.None;
            txt_Sđt.BackColor = isEditable ? Color.White : this.BackColor;
            txt_Email.BorderStyle = isEditable ? BorderStyle.FixedSingle : BorderStyle.None;
            txt_Email.BackColor = isEditable ? Color.White : this.BackColor;
            txt_username.BorderStyle = isEditable ? BorderStyle.FixedSingle : BorderStyle.None;
            txt_username.BackColor = isEditable ? Color.White : this.BackColor;
            txt_Password.BorderStyle = isEditable ? BorderStyle.FixedSingle : BorderStyle.None;
            txt_Password.BackColor = isEditable ? Color.White : this.BackColor;
            txt_ID.BorderStyle = isEditable ? BorderStyle.FixedSingle : BorderStyle.None;
            txt_ID.BackColor = isEditable ? Color.White : this.BackColor;

            but_Save.Enabled = isEditable;

        }

        private void but_Save_Click(object sender, EventArgs e)
        {
            int userId = UserSession.LoggedInUserID;

            string name = txt_Ten.Text.Trim();
            string phone = txt_Sđt.Text.Trim();
            string email = txt_Email.Text.Trim();
            string username = txt_username.Text.Trim();
            string password = txt_Password.Text.Trim();

            bool result = bll.UpdateCustomerInfo(userId, name, phone, email, username, password);

            if (result)
            {
                MessageBox.Show("Cập nhật thành công!");
                cb_Edit.Checked = false;
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Show.Checked)
            {
                // Hiện mật khẩu
                txt_Password.PasswordChar = '\0';
            }
            else
            {
                // Ẩn mật khẩu bằng dấu *
                txt_Password.PasswordChar = '*';
            }
        }
        private void LoadLichSuHoaDon()
        {
            int userId = UserSession.LoggedInUserID;
            var hoaDon = bll.GetBillsByCustomer(userId);
            dgvBills.DataSource = hoaDon;

            // Tùy chọn: định dạng số tiền
            dgvBills.Columns["Total"].DefaultCellStyle.Format = "N0";
            dgvBills.Columns["Total"].HeaderText = "Tổng tiền (VNĐ)";
        }

        private void but_view_invoice_Click(object sender, EventArgs e)
        {
            if (selectedBillId == -1)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn!");
                return;
            }

            Invoice f = new Invoice(selectedBillId);
            f.ShowDialog();
        }

        private void dgvBills_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedBillId = Convert.ToInt32(dgvBills.Rows[e.RowIndex].Cells["BillID"].Value);
            }
        }
    }
}
