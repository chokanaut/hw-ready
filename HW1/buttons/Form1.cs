using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buttons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("От -2 147 483 648 до 2 147 483 647");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("От 0 до 4 294 967 295");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("От 0 до 255");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("От -128 до 127");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("От -32768 до 32767");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("От 0 до 65535");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("От –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("От 0 до 18 446 744 073 709 551 615");
        }
    }
}
