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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

   

        private void Form2_Load(object sender, EventArgs e)
        {
            List<colors> mau = new List<colors>() { new colors() {Color = "Red"},
            new colors() {Color = "Blue" },
            new colors() {Color = "Green" },
            new colors() {Color = "Tomato" },
            new colors() {Color = "Oragen" },
            new colors() {Color = "DarkBlue" },
            new colors() {Color = "Gray" },
            new colors() {Color = "white" },
            new colors() {Color = "Pink" },
            };
            comboBox2.DataSource = mau;
            comboBox2.DisplayMember = "Color";
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (comboBox2.SelectedIndex==0)
            {
                BackColor = Color.Red;
            }
            if (comboBox2.SelectedIndex == 1)
            {
                BackColor = Color.Blue;
            }
            if (comboBox2.SelectedIndex == 2)
            {
                BackColor = Color.Green;
            }
            if (comboBox2.SelectedIndex == 3)
            {
                BackColor = Color.Tomato;
            }
            if (comboBox2.SelectedIndex == 4)
            {
                BackColor = Color.Orange;
            }
            if (comboBox2.SelectedIndex == 5)
            {
                BackColor = Color.DarkBlue;
            }
            if (comboBox2.SelectedIndex == 6)
            {
                BackColor = Color.Gray;
            }
            if (comboBox2.SelectedIndex == 7)
            {
                BackColor = Color.White;
            }
            if (comboBox2.SelectedIndex == 8)
            {
                BackColor = Color.Pink;
            }
            /* colors colors = comboBox2.SelectedValue as colors;
             textBox1.Text = colors.Color.ToString();*/
        }
    }
    public class colors
    {
        string color;
        public string Color { get => color; set => color = value; }
    }
}
