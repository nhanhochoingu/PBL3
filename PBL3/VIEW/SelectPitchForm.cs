using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DAL;

namespace PBL3.VIEW
{
    public partial class SelectPitchForm : Form
    {
        public Pitch SelectedPitch { get; private set; }

        private List<Pitch> pitchList;
        public SelectPitchForm(List<Pitch> availablePitches)
        {
            InitializeComponent();

            pitchList = availablePitches;

            cbPitchList.DataSource = pitchList;
            cbPitchList.DisplayMember = "PitchName";
            cbPitchList.ValueMember = "PitchID";
        }

        private void but_Chon_Click(object sender, EventArgs e)
        {
            SelectedPitch = cbPitchList.SelectedItem as Pitch;
            if (SelectedPitch != null)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void but_Huy_Click(object sender, EventArgs e)
        {
            
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
