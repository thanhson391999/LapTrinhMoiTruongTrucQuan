using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6
{
    public partial class frmMessageFormater : Form
    {
        public frmMessageFormater()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void grbInput_Enter(object sender, EventArgs e)

        {



        }



        private void btnDisplay_Click(object sender, EventArgs e)

        {

            txtMessage1.Text = txtName.Text + " " + txtMessage.Text;

        }



        private void btnExit_Click(object sender, EventArgs e)

        {

            this.Close();

        }



        private void btnClear_Click(object sender, EventArgs e)

        {

            txtName.Clear();

            txtMessage.Clear();

            txtMessage1.Clear();

        }



        private void rdbRed_CheckedChanged(object sender, EventArgs e)

        {

            txtMessage1.ForeColor = Color.Red;

        }



        private void rdbGreen_CheckedChanged(object sender, EventArgs e)

        {

            txtMessage1.ForeColor = Color.Green;

        }



        private void rdbBlack_CheckedChanged(object sender, EventArgs e)

        {

            txtMessage1.ForeColor = Color.Black;

        }



        private void rdbBlue_CheckedChanged(object sender, EventArgs e)

        {

            txtMessage1.ForeColor = Color.Blue;

        }



        private void chkMessage_CheckedChanged(object sender, EventArgs e)

        {

            txtMessage1.Visible = chkMessage.Checked;



        }



        private void picBig_Click(object sender, EventArgs e)

        {

            picBig.Visible = false;
            
            picSmall.Visible = true;

        }

        private void x(object sender, EventArgs e)
        {

        }
    }
}
