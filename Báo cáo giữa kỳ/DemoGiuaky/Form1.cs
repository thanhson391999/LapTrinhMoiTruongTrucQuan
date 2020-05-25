using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoGiuaky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }


        private void Form1_Load(object sender, EventArgs e)
        {
/*            var item2 = new ToolStripTextBox() { Text = "this is textbox" };
            statusStrip1.Items.Add(item2);*/

            //Tạo ra các item như label hiển thị thời gian hay 1 text box hiển thị nội dung văn bản 

            tslDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

            // tạo 1 item label show time hiện tại
            notifyIcon1.ShowBalloonTip(5000);
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Symbols: " + richTextBox1.TextLength.ToString();
            toolStripStatusLabel2.Text = "Lines: " + richTextBox1.Lines.Length.ToString();

            //Symbols and lines trong word và powpoin
        }



        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) this.WindowState = FormWindowState.Normal;
            else this.Show();
        }

        private void closeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hideFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 0;
            tslDate.Text = dateTimePicker1.Text.Trim();
            toolStripProgressBar1.Value = 100;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(numericUpDown1.Value == 1 || numericUpDown1.Value == 2 || numericUpDown1.Value == 3)
            {
                Bitmap bm = new Bitmap(Application.StartupPath + "\\Resources\\" + numericUpDown1.Value + ".png");
                pictureBox1.Image = bm;
            }
            else if (numericUpDown1.Value == 0)
            {
                pictureBox1.Image = null;
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = 0.5f;

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = 1;

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            richTextBox1.ZoomFactor = 1.5f;

        }

        private void tslDate_Click(object sender, EventArgs e)
        {

        }
    }
}
