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

namespace PBL3.VIEW
{
    public partial class UC_Booking : UserControl
    {
        public UC_Booking()
        {
            InitializeComponent();
        }
        private _BLL bll = new _BLL();
        private void but_SeeAllPitch_Click(object sender, EventArgs e)
        {
            dgv.DataSource = bll.GetAllPitch();
        }

        private void but_Book_Click(object sender, EventArgs e)
        {
            if (cb_PitchType.SelectedIndex == -1 || cb_StartTime.SelectedIndex == -1 || cb_Minutes.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
