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

namespace PBL3.VIEW
{
    public partial class UC_Invoice_Admin : UserControl
    {
        public UC_Invoice_Admin()
        {
            InitializeComponent();
        }

        private _BLL_Bill bll = new _BLL_Bill();
        private int selectedBillId = -1;
        private void LoadData()
        {
            dgv.DataSource = bll.GetAll();
            HideUnnecessaryColumns();
        }

        private void but_search_Click(object sender, EventArgs e)
        {
            DateTime from = dtpStart.Value.Date;
            DateTime to = dtpEnd.Value.Date;

            if (from > to)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgv.DataSource = bll.GetByDate(from, to);
        }

        private void but_del_Click(object sender, EventArgs e)
        {
            if (selectedBillId == -1)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc chắn muốn xoá hoá đơn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                bll.Delete(selectedBillId);
                MessageBox.Show("Xoá thành công!", "Thông báo");
                LoadData();
                selectedBillId = -1;
            }
        }
        private void but_refresh_Click(object sender, EventArgs e)
        {
            LoadData();
            dtpStart.Value = DateTime.Today.AddDays(-7);
            dtpEnd.Value = DateTime.Today;
            dgv.ClearSelection();
        }

        private void but_view_Click(object sender, EventArgs e)
        {
            if (selectedBillId == -1)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn!");
                return;
            }

            Invoice f = new Invoice(selectedBillId);
            f.ShowDialog();
        }
        private void HideUnnecessaryColumns()
        {
            if (dgv.Columns.Contains("BillDetails"))
                dgv.Columns["BillDetails"].Visible = false;
            if (dgv.Columns.Contains("Customer"))
                dgv.Columns["Customer"].Visible = false;
            if (dgv.Columns.Contains("Pitch"))
                dgv.Columns["Pitch"].Visible = false;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedBillId = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["BillID"].Value);
            }
        }
        





    }
}
