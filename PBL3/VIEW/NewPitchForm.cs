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
    public partial class NewPitchForm : Form
    {
        public NewPitchForm()
        {
            InitializeComponent();
        }
        private _BLL_Pitch bll = new _BLL_Pitch();
        private void but_add_Click(object sender, EventArgs e)
        {
            try
            {
                Pitch newPitch = new Pitch
                {
                    PitchName = txt_Pitchname.Text.Trim(),
                    PitchStatus = txt_Pitchstatus.Text.Trim(),
                    PitchPrice = decimal.Parse(txt_Pitchprice.Text),
                    PitchType = cbb_Pitchtype.SelectedItem.ToString()
                };

                bll.AddPitch(newPitch);

                MessageBox.Show("Thêm sân mới thành công!", "Thông báo");
                this.Close(); // đóng form sau khi thêm xong
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
            }
        }

        private void but_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
