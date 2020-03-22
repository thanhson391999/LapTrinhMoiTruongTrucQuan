using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class frmSuDungLabelVaTextBox : Form
    {
        public frmSuDungLabelVaTextBox()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = txtPassword.Text;
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = "";
            txtPassword.Clear();
            txtPassword.Focus();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
