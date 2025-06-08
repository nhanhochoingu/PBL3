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
    public partial class UC_Booking_Customer : UserControl
    {
        public UC_Booking_Customer()
        {
            InitializeComponent();
        }
        private _BLL_Customer bll = new _BLL_Customer();
        private void but_SeeAllPitch_Click(object sender, EventArgs e)
        {

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true; // Khi không cần chỉnh sửa


            // Xóa cột "Số lượng" và "Thành tiền" nếu đã tồn tại
            if (dgv.Columns.Contains("SoLuong"))
                dgv.Columns.Remove("SoLuong");
            if (dgv.Columns.Contains("ThanhTien"))
                dgv.Columns.Remove("ThanhTien");

            if (cb_PitchType.SelectedIndex == -1 || cb_StartTime.SelectedIndex == -1 || cb_Minutes.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string pitchType = cb_PitchType.SelectedItem.ToString();
            DateTime date = dtp.Value.Date;
            TimeSpan start = TimeSpan.Parse(cb_StartTime.SelectedItem.ToString());
            int duration = int.Parse(cb_Minutes.Text);
            TimeSpan end = start.Add(TimeSpan.FromMinutes(duration));

            // Lấy tất cả sân cùng loại
            List<Pitch> allPitches = bll.GetAllPitchesByType(pitchType);

            // Lấy danh sách sân đã được đặt
            List<Pitch> bookedPitches = bll.GetBookedPitches(pitchType, date, start, end);
                

            var data = bll.GetDisplayPitches(allPitches, bookedPitches, duration);

            dgv.DataSource = data;

            //Không hiển thị navigation property
            dgv.Columns["Bills"].Visible = false;
            dgv.Columns["PitchSchedules"].Visible = false;
        }

        private void but_Book_Click(object sender, EventArgs e)
        {

            if (cb_PitchType.SelectedIndex == -1 || cb_StartTime.SelectedIndex == -1 || cb_Minutes.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy thông tin từ giao diện
            string pitchType = cb_PitchType.SelectedItem.ToString();
            DateTime date = dtp.Value.Date;
            TimeSpan start = TimeSpan.Parse(cb_StartTime.SelectedItem.ToString());
            int duration = int.Parse(cb_Minutes.Text);
            TimeSpan end = start.Add(TimeSpan.FromMinutes(duration));
            int userId = UserSession.LoggedInUserID;



            // Lấy nước được chọn từ dgvDrink
            List<(int drinkId, int quantity, decimal price)> drinkList = new List<(int, int, decimal)>();
            decimal totalDrink = 0;

            // Nếu dgvDrink chưa có dữ liệu hoặc chưa đặt nước
            if (dgv.DataSource == null || !dgv.Columns.Contains("SoLuong"))
            {
                DialogResult result = MessageBox.Show("Xác nhận số lượng nước của bạn ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                but_Service_Click(null, null);
                if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
            else
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.IsNewRow) continue;

                    if (row.Cells["SoLuong"].Value != null &&
                        int.TryParse(row.Cells["SoLuong"].Value.ToString(), out int sl) &&
                        sl > 0)
                    {
                        int drinkId = Convert.ToInt32(row.Cells["DrinkID"].Value);
                        decimal price = Convert.ToDecimal(row.Cells["DrinkPrice"].Value);
                        drinkList.Add((drinkId, sl, price));
                        totalDrink += sl * price;
                    }
                }
            }

            // Lấy danh sách sân trống
            List<Pitch> availablePitches = bll.GetAvailablePitches(pitchType, date, start, end);
            Pitch selectedPitch = null;
            if (availablePitches.Count == 0)
            {
                MessageBox.Show("Không có sân trống trong thời gian này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                
                // Hiển thị form chọn sân
                SelectPitchForm pitchForm = new SelectPitchForm(availablePitches);
                if (pitchForm.ShowDialog() != DialogResult.OK)
                    return;

                selectedPitch = pitchForm.SelectedPitch;

                // Đặt sân
                bool success = bll.BookSpecificPitch(selectedPitch.PitchID, userId, date, start, end);
                if (!success)
                {
                    MessageBox.Show("Đặt sân thất bại!", "Lỗi");
                    return;
                }
                else
                {
                    MessageBox.Show("Đặt sân thành công!", "Thông báo");
                }


            }
            // Tổng tiền
            if(duration == 60)
            {
                decimal total = (decimal)selectedPitch.PitchPrice + totalDrink;
            // Lưu hóa đơn vào database
            bll.CreateBillWithDetails(userId, selectedPitch.PitchID, DateTime.Now, total, drinkList);

            // Hiển thị hóa đơn đơn giản
            HienHoaDon(selectedPitch.PitchName, date, start, end, (decimal)selectedPitch.PitchPrice);
            }
            else
            {
                decimal total = (decimal)selectedPitch.PitchPrice * 1.75m + totalDrink;
                // Lưu hóa đơn vào database
                bll.CreateBillWithDetails(userId, selectedPitch.PitchID, DateTime.Now, total, drinkList);
                // Hiển thị hóa đơn đơn giản
                HienHoaDon(selectedPitch.PitchName, date, start, end, (decimal)selectedPitch.PitchPrice * 1.75m);
            }    

                MessageBox.Show("Đặt sân và lưu hóa đơn thành công!", "Thành công");


        }

        private void but_YourPitch_Click(object sender, EventArgs e)
        {
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true; 

            int userId = UserSession.LoggedInUserID;
            var lichSu = bll.GetLichSanDaDat(userId);

            //var data = bll.GetSchedulesOfCustomer(userId);
            dgv.DataSource = lichSu;
            // Xóa cột "Số lượng" và "Thành tiền" nếu đã tồn tại
            if (dgv.Columns.Contains("SoLuong"))
                dgv.Columns.Remove("SoLuong");
            if (dgv.Columns.Contains("ThanhTien"))
                dgv.Columns.Remove("ThanhTien");
        }

        private void but_Service_Click(object sender, EventArgs e)
        {
            dgv.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgv.ReadOnly = false; // Cho phép nhập số lượng


            dgv.DataSource = bll.GetDrinksForDisplay();

            dgv.Columns["BillDetails"].Visible = false;

            // Thêm cột nhập số lượng nếu chưa có
            if (!dgv.Columns.Contains("SoLuong"))
            {
                DataGridViewTextBoxColumn soLuongColumn = new DataGridViewTextBoxColumn
                {
                    Name = "SoLuong",
                    HeaderText = "Số lượng",
                    ValueType = typeof(int),
                    DefaultCellStyle = { NullValue = "0" }
                };
                dgv.Columns.Add(soLuongColumn);
            }

            if (!dgv.Columns.Contains("ThanhTien"))
            {
                DataGridViewTextBoxColumn thanhTienCol = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Thành tiền",
                    Name = "ThanhTien",
                    ReadOnly = true,
                    ValueType = typeof(decimal),
                    DefaultCellStyle = { Format = "N0" }
                };
                dgv.Columns.Add(thanhTienCol);
            }


            TinhTongTienNuoc();
        }
        private void TinhTongTienNuoc()
        {
            decimal tong = 0;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells["SoLuong"].Value != null &&
                    int.TryParse(row.Cells["SoLuong"].Value.ToString(), out int sl) &&
                    sl > 0)
                {
                    decimal gia = Convert.ToDecimal(row.Cells["DrinkPrice"].Value);
                    decimal tien = gia * sl;
                    row.Cells["ThanhTien"].Value = tien;
                    tong += tien;
                }
                else
                {
                    row.Cells["ThanhTien"].Value = 0;
                }

            }

        }

        // Tính "Thành Tiền" khi nhập số lượng nước
        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv.Columns[e.ColumnIndex].Name == "SoLuong")
            {
                TinhTongTienNuoc();
            }
        }
        
        private void HienHoaDon(string pitchName, DateTime date, TimeSpan start, TimeSpan end, decimal pitchPrice)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("====== HÓA ĐƠN ĐẶT SÂN ======\n");

            // Thông tin sân
            sb.AppendLine($"Sân: {pitchName}");
            sb.AppendLine($"Ngày: {date:dd/MM/yyyy}");
            sb.AppendLine($"Giờ: {start:hh\\:mm} - {end:hh\\:mm}");
            sb.AppendLine($"Giá sân: {pitchPrice:N0} VNĐ");

            //  Thông tin nước
            decimal tongTienNuoc = 0;

            if (dgv.DataSource != null || dgv.Columns.Contains("SoLuong"))
            {
                sb.AppendLine("\n--- Nước đã chọn ---");
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.IsNewRow) continue;

                    if (row.Cells["SoLuong"].Value != null &&
                        int.TryParse(row.Cells["SoLuong"].Value.ToString(), out int sl) &&
                        sl > 0)
                    {
                        string drinkName = row.Cells["DrinkName"].Value.ToString();
                        decimal drinkPrice = Convert.ToDecimal(row.Cells["DrinkPrice"].Value);
                        decimal thanhTien = drinkPrice * sl;

                        tongTienNuoc += thanhTien;
                        sb.AppendLine($"{drinkName} × {sl} = {thanhTien:N0} VNĐ");
                    }
                }
            }

            // Tổng tiền
            decimal tong = pitchPrice + tongTienNuoc;
            sb.AppendLine($"\nTỔNG CỘNG: {tong:N0} VNĐ");

            MessageBox.Show(sb.ToString(), "HÓA ĐƠN CHI TIẾT");
        }
    }
}
