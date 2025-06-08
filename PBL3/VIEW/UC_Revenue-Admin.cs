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
    public partial class UC_Revenue_Admin : UserControl
    {
        public UC_Revenue_Admin()
        {
            InitializeComponent();
        }
        private _BLL_Statistic bll = new _BLL_Statistic();
        private _BLL_PitchSchedule bllpitchschedule = new _BLL_PitchSchedule();
        private _BLL_BillDetail bllBillDetail = new _BLL_BillDetail();
        private _BLL_Staff bllStaff= new _BLL_Staff();
        private int selectedStaffID = -1;
        private DgvMode currentDgvMode = DgvMode.None;
        public enum DgvMode
        {
            None,
            Staff,
            Statistic
        }
        private void but_revenue_Click(object sender, EventArgs e)
        {
            DateTime start = dtpStart.Value.Date;
            DateTime end = dtpEnd.Value.Date;

            if (start > end)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (start == end)
            {
                start = end.AddDays(-7);
            }

            var data = bll.GetFormattedStatistic(start, end);
            dgv.DataSource = data;
            currentDgvMode = DgvMode.Statistic;
            dgv.ClearSelection();

            dgv.Columns["StartTime"].HeaderText = "Bắt Đầu";
            dgv.Columns["EndTime"].HeaderText = "Kết Thúc";
            dgv.Columns["TotalRevenue"].HeaderText = "Doanh Thu";
            dgv.Columns["TotalBookings"].HeaderText = "Tiền Sân";
            dgv.Columns["TotalDrinksSold"].HeaderText = "Tiền Nước";
            dgv.Columns["TotalBookedPitch"].HeaderText = "Hoá Đơn";
        }

        private void but_pitch_Click(object sender, EventArgs e)
        {
            var data = bllpitchschedule.GetPitchBookingStats();
            dgv.Columns.Clear(); // Xóa cột cũ

            dgv.DataSource = data;
            currentDgvMode = DgvMode.Statistic;
            // Định dạng tên cột thủ công nếu muốn
            dgv.Columns["TenSan"].HeaderText = "Tên Sân";
            dgv.Columns["LoaiSan"].HeaderText = "Loại Sân";
            dgv.Columns["SoLuotDat"].HeaderText = "Số lượt đặt";
        }

        private void but_drink_Click(object sender, EventArgs e)
        {
            var data = bllBillDetail.GetDrinkStats();
            dgv.Columns.Clear(); // Xóa cũ nếu cần

            dgv.DataSource = data;
            currentDgvMode = DgvMode.Statistic;

            dgv.Columns["TenNuoc"].HeaderText = "Tên Nước";
            dgv.Columns["SoLuongBan"].HeaderText = "Số lượng đã bán";
        }

        private void but_refresh_Click(object sender, EventArgs e)
        {
            dgv.DataSource = bllStaff.GetFormattedStaffList();
            dgv.ClearSelection();
            selectedStaffID = -1;
            currentDgvMode = DgvMode.Staff;
        }

        private void but_add_Click(object sender, EventArgs e)
        {
            NewStaffForm form = new NewStaffForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                // Sau khi thêm thành công, làm mới lại danh sách
                but_refresh_Click(null, null);
            }
            selectedStaffID = -1;
            txt_Staffname.Text = "";
            txt_Staffphone.Text = "";
            txt_Staffemail.Text = "";
            txt_Staffcoeff.Text = "";
            txt_Stafftime.Text = "";
        }

        private void but_edit_Click(object sender, EventArgs e)
        {
            if (selectedStaffID == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần thay đổi!", "Thông báo");
                return;
            }

            // Validate đơn giản
            if (string.IsNullOrWhiteSpace(txt_Staffname.Text) ||
                string.IsNullOrWhiteSpace(txt_Staffphone.Text) ||
                string.IsNullOrWhiteSpace(txt_Staffemail.Text) ||
                string.IsNullOrWhiteSpace(txt_Staffcoeff.Text) ||
                string.IsNullOrWhiteSpace(txt_Stafftime.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi");
                return;
            }

            Staff s = new Staff
            {
                StaffID = selectedStaffID,
                StaffName = txt_Staffname.Text.Trim(),
                StaffSDT = txt_Staffphone.Text.Trim(),
                StaffEmail = txt_Staffemail.Text.Trim(),
                Coefficient = decimal.Parse((txt_Staffcoeff.Text)),
                Worktime = int.Parse(txt_Stafftime.Text)
            };

            if (bllStaff.UpdateStaff(s))
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo");
                but_refresh_Click(null, null);
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Lỗi");
            }
        }

        private void but_del_Click(object sender, EventArgs e)
        {
            if (selectedStaffID == -1)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xoá nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (bllStaff.DeleteStaff(selectedStaffID))
                {
                    MessageBox.Show("Xoá thành công!");
                    but_refresh_Click(null, null); // làm mới lại bảng
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên để xoá!", "Lỗi");
                }
            }

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (currentDgvMode == DgvMode.Staff)
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex];
                selectedStaffID = Convert.ToInt32(row.Cells["StaffID"].Value);
                txt_Staffname.Text = row.Cells["StaffName"].Value?.ToString();
                txt_Staffphone.Text = row.Cells["StaffSDT"].Value?.ToString();
                txt_Staffemail.Text = row.Cells["StaffEmail"].Value?.ToString();
                txt_Staffcoeff.Text = row.Cells["Coefficient"].Value?.ToString();
                txt_Stafftime.Text = row.Cells["Worktime"].Value?.ToString();
            }
            else if (currentDgvMode == DgvMode.Statistic)
            {
                // Không xử lý gì ở đây
            }
        }
    }
}
