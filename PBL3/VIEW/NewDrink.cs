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
    public partial class NewDrink : Form
    {
        public NewDrink()
        {
            InitializeComponent();
        }
        private _BLL_Drink bll = new _BLL_Drink();

        private void but_OK_Click(object sender, EventArgs e)
        {
            string tenNuoc = txtTenNuoc.Text.Trim();
            string giaText = txtGiaNuoc.Text.Trim();
            decimal gia;

            // Kiểm tra đầu vào
            if (string.IsNullOrEmpty(tenNuoc) || string.IsNullOrEmpty(giaText))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(giaText, out gia))
            {
                MessageBox.Show("Giá phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tạo đối tượng Drink
            Drink d = new Drink
            {
                DrinkName = tenNuoc,
                DrinkPrice = gia
            };

            // Gọi BLL để thêm
            bll.Add(d);
            MessageBox.Show("Thêm thức uống thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close(); // Đóng form sau khi thêm
        }

        private void but_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
