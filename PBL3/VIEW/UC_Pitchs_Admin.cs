using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;
using PBL3.DAL;

namespace PBL3.VIEW
{
    public partial class UC_Pitchs_Admin : UserControl
    {
        
        public UC_Pitchs_Admin()
        {
            InitializeComponent();
        }

        private _BLL_PitchSchedule schedulebll = new _BLL_PitchSchedule();
        private _BLL_Pitch bll = new _BLL_Pitch();
        private int selectedPitchId = -1;
        private int selectedScheduleId = -1;

        private enum DgvMode
        {
            None,
            Pitch,
            Schedule
        }

        private DgvMode currentDgvMode = DgvMode.None;

        private void but_update_Click(object sender, EventArgs e)
        {
            if (selectedPitchId == -1)
            {
                MessageBox.Show("Vui lòng chọn sân để cập nhật");
                return;
            }

            Pitch updated = new Pitch
            {
                PitchID = selectedPitchId,
                PitchName = txt_Pitchname.Text,
                PitchType = txt_Pitchtype.Text,
                PitchStatus = txt_Pitchstatus.Text,
                PitchPrice = decimal.Parse(txt_Pitchprice.Text)
            };

            bll.UpdatePitch(updated);
            MessageBox.Show("Cập nhật thành công!");
            but_SeeAllPitch_Click(null, null); // load lại
        }

        private void but_SeeAllPitch_Click(object sender, EventArgs e)
        {
            dgv.DataSource = bll.GetAllPitch();
            dgv.ClearSelection();
            HideUnnecessaryColumns();
            currentDgvMode = DgvMode.Pitch;
        }

        private void but_del_Click(object sender, EventArgs e)
        {
            if (selectedPitchId == -1)
            {
                MessageBox.Show("Vui lòng chọn sân để xoá");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xoá sân này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bll.DeletePitch(selectedPitchId);
                MessageBox.Show("Xoá thành công!");
                but_SeeAllPitch_Click(null, null);
            }
        }

        private void but_add_Click(object sender, EventArgs e)
        {
            NewPitchForm f = new NewPitchForm();
            f.ShowDialog();
            but_SeeAllPitch_Click(null, null);
        }

        private void but_bookedpitch_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtp.Value.Date;

            
            var data = schedulebll.GetDisplayScheduleByDate(selectedDate);

            dgv.DataSource = data;
            dgv.ClearSelection();
            currentDgvMode = DgvMode.Schedule;
        }

        private void but_cancel_Click(object sender, EventArgs e)
        {
            if (selectedPitchId == -1)
            {
                MessageBox.Show("Vui lòng chọn sân để huỷ.");
                return;
            }

            if (MessageBox.Show("Xác nhận huỷ sân đã đặt?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                schedulebll.DeleteBooking(selectedPitchId);
                MessageBox.Show("Huỷ thành công!");

                // Reload dữ liệu ngày đang xem
                but_bookedpitch_Click(null, null);
                selectedPitchId = -1;
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex];
                switch (currentDgvMode)
                {
                    case DgvMode.Schedule:
                        selectedScheduleId = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["ScheduleID"].Value);
                        break;

                    case DgvMode.Pitch:
                        selectedPitchId = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["PitchID"].Value);
                        txt_Pitchname.Text = row.Cells["PitchName"].Value?.ToString();
                        txt_Pitchtype.Text = row.Cells["PitchType"].Value?.ToString();
                        txt_Pitchstatus.Text = row.Cells["PitchStatus"].Value?.ToString();
                        txt_Pitchprice.Text = row.Cells["PitchPrice"].Value?.ToString();
                        break;

                    default:
                        selectedScheduleId = -1;
                        selectedPitchId = -1;
                        break;
                }
            }
        }
        private void HideUnnecessaryColumns()
        {
            if (dgv.Columns.Contains("PitchSchedules"))
                dgv.Columns["PitchSchedules"].Visible = false;
            if (dgv.Columns.Contains("Bills"))
                dgv.Columns["Bills"].Visible = false;
        }
    }
}
