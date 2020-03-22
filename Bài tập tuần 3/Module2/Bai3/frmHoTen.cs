using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class frmHoTen : Form
    {
        public frmHoTen()
        {
            InitializeComponent();
        }

        private void lblHoTen_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmHoTen_Load(object sender, EventArgs e)
        {
               
        }

        private void btnHo_Click(object sender, EventArgs e)
        {
            lblHovaTen.Text = txtHo.Text;
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            lblHovaTen.Text = txtTen.Text;
        }

        private void btnHoTen_Click(object sender, EventArgs e)
        {
            lblHovaTen.Text = txtHo.Text + "" + txtTen.Text;
        }

        private void lblHovaTen_Click(object sender, EventArgs e)
        {
         
        }

        private void lblHovaTen_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lblHovaTen.Text = "";
        }
    }
}
