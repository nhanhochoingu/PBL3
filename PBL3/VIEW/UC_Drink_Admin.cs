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
    public partial class UC_Drink_Admin : UserControl
    {
        public UC_Drink_Admin()
        {
            InitializeComponent();
        }
        private _BLL_Drink bll = new _BLL_Drink();
        private int selectedDrinkId = -1;
        private void LoadData()
        {
            dgv.DataSource = bll.GetAll();
            HideUnnecessaryColumns();
        }

        private void but_add_Click(object sender, EventArgs e)
        {
            NewDrink f = new NewDrink();
            f.ShowDialog();
            LoadData();
            MessageBox.Show("Thêm thức uống thành công!");
            txtTenNuoc.Clear();
            txtGiaNuoc.Clear();
        }

        private void but_edit_Click(object sender, EventArgs e)
        {
            if (selectedDrinkId != -1)
            {
                Drink d = new Drink
                {
                    DrinkID = selectedDrinkId,
                    DrinkName = txtTenNuoc.Text,
                    DrinkPrice = decimal.Parse(txtGiaNuoc.Text)
                };

                bll.Update(d);
                MessageBox.Show("Cập nhật thức uống thành công!");
                LoadData();
            }
        }

        private void but_refresh_Click(object sender, EventArgs e)
        {
            selectedDrinkId = -1;
            txtTenNuoc.Clear();
            txtGiaNuoc.Clear();
            LoadData();
        }

        private void but_del_Click(object sender, EventArgs e)
        {
            if (selectedDrinkId != -1)
            {
                bll.Delete(selectedDrinkId);
                MessageBox.Show("Xoá thức uống thành công!");
                LoadData();
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedDrinkId = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["DrinkID"].Value);
                txtTenNuoc.Text = dgv.Rows[e.RowIndex].Cells["DrinkName"].Value.ToString();
                txtGiaNuoc.Text = dgv.Rows[e.RowIndex].Cells["DrinkPrice"].Value.ToString();
            }
        }
        private void HideUnnecessaryColumns()
        {
            if (dgv.Columns.Contains("BillDetails"))
                dgv.Columns["BillDetails"].Visible = false;
        }
    }
}
