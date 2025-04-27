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

namespace PBL3
{
    public partial class CustomerForm : Form
    {
        private Account currentAccount;
        public CustomerForm(Account acc)
        {
            InitializeComponent();
            currentAccount = acc;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void CustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất ?", "Thông báo đăng xuất", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoPersonelForm infoPersonelForm = new InfoPersonelForm();
            this.Hide();
            infoPersonelForm.ShowDialog();
            this.Show();
        }
    }
}
