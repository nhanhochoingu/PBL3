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
    public partial class UC_Customer_Admin : UserControl
    {
        public UC_Customer_Admin()
        {
            InitializeComponent();
        }
        private _BLL_Admin bll = new _BLL_Admin();

        private int selectedCustomerId = -1;
        private void LoadData()
        {
            dgv.DataSource = bll.GetAll();
            HideUnnecessaryColumns();
        }

        private void but_add_Click(object sender, EventArgs e)
        {
            RegisterForm f = new RegisterForm();
            f.ShowDialog(); // mở form theo dạng modal
            LoadData();
            selectedCustomerId = -1;
            txt_Name.Text = "";
            txt_Sđt.Text = "";
            txt_Email.Text = "";

        }

        private void but_edit_Click(object sender, EventArgs e)
        {
            if (selectedCustomerId != -1)
            {
                Customer update = new Customer
                {
                    CustomerID = selectedCustomerId,
                    Name = txt_Name.Text,
                    PhoneNumber = txt_Sđt.Text,
                    Email = txt_Email.Text
                };

                bll.Update(update);
                LoadData();
            }
            MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void but_refresh_Click(object sender, EventArgs e)
        {
            LoadData();
            selectedCustomerId = -1;
            txt_Name.Text = "";
            txt_Sđt.Text = "";
            txt_Email.Text = "";
        }

        private void but_del_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgv.CurrentRow.Cells["CustomerID"].Value);
                bll.Delete(id);
                LoadData();
            }
            MessageBox.Show("Xoá khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedCustomerId = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["CustomerID"].Value);
                txt_Name.Text = dgv.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                txt_Sđt.Text = dgv.Rows[e.RowIndex].Cells["PhoneNumber"].Value.ToString();
                txt_Email.Text = dgv.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            }
        }
        private void HideUnnecessaryColumns()
        {
            if (dgv.Columns.Contains("Account"))
                dgv.Columns["Account"].Visible = false;
            if (dgv.Columns.Contains("PitchSchedules"))
                dgv.Columns["PitchSchedules"].Visible = false;
            if (dgv.Columns.Contains("Bills"))
                dgv.Columns["Bills"].Visible = false;
        }

    }
}
