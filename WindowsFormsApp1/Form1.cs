using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            frm2 = new Form2();
            frm3 = new Form3();
            frm4 = new Form4();
            frm5 = new Form5();

        }
        Form2 frm2;
        Form3 frm3;
        Form4 frm4;
        Form5 frm5;

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm3.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frm4.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frm5.Show();
        }
    }
}
