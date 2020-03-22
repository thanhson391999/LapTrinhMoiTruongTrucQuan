using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class frmSampleEventExample : Form
    {
        public frmSampleEventExample()
        {
            InitializeComponent();        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button was Clicked");
        }

        private void frmSampleEventExample_Load(object sender, EventArgs e)
        {
            MessageBox.Show("hi, Welcome to C# 2020 programming!");
        }
        private void frmSampleEventExample_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form was Clicked");
        }
    }
}
