using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I8086sim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Ax1.Text = Ax2.Text;
            Ax2.MaxLength = 4;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Bx1.Text = Bx2.Text;
            Bx2.MaxLength = 4;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Cx1.Text = Cx2.Text;
            Cx2.MaxLength = 4;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Dx1.Text = Dx2.Text;
            Dx2.MaxLength = 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ax2.Text = "0000";
            Bx2.Text = "0000";
            Cx2.Text = "0000";
            Dx2.Text = "0000";
            Ax1.Text = "0000";
            Bx1.Text = "0000";
            Cx1.Text = "0000";
            Dx1.Text = "0000";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string AXRejestr = "";
            string BXRejestr = "";
            string CXRejestr = "";
            string DXRejestr = "";
            int liczbaHeksa = rnd.Next(0, 65535);
            AXRejestr = liczbaHeksa.ToString("X");
            Ax2.Text = AXRejestr;
            Ax1.Text = AXRejestr;
            int liczbaHeksa2 = rnd.Next(0, 65535);
            BXRejestr = liczbaHeksa2.ToString("X");
            Bx2.Text = BXRejestr;
            Bx1.Text = BXRejestr;
            int liczbaHeksa3 = rnd.Next(0, 65535);
            CXRejestr = liczbaHeksa3.ToString("X");
            Cx2.Text = CXRejestr;
            Cx1.Text = CXRejestr;
            int liczbaHeksa4 = rnd.Next(0, 65535);
            DXRejestr = liczbaHeksa4.ToString("X");
            Dx2.Text = DXRejestr;
            Dx1.Text = DXRejestr;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ax1.Text = Bx1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string xchg = Bx1.Text;
            Bx1.Text = Ax1.Text;
            Ax1.Text = xchg;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ax1.Text = Cx1.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Ax1.Text = Dx1.Text;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Bx1.Text = Ax1.Text;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Bx1.Text = Cx1.Text;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Bx1.Text = Dx1.Text;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Cx1.Text = Ax1.Text;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Cx1.Text = Bx1.Text;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Cx1.Text = Dx1.Text;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            Dx1.Text = Ax1.Text;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            Dx1.Text = Bx1.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Dx1.Text = Cx1.Text;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string xchg = Cx1.Text;
            Cx1.Text = Ax1.Text;
            Ax1.Text = xchg;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string xchg = Dx1.Text;
            Dx1.Text = Ax1.Text;
            Ax1.Text = xchg;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            string xchg = Ax1.Text;
            Ax1.Text = Bx1.Text;
            Bx1.Text = xchg;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            string xchg = Cx1.Text;
            Cx1.Text = Bx1.Text;
            Bx1.Text = xchg;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            string xchg = Dx1.Text;
            Dx1.Text = Bx1.Text;
            Bx1.Text = xchg;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string xchg = Ax1.Text;
            Ax1.Text = Cx1.Text;
            Cx1.Text = xchg;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            string xchg = Bx1.Text;
            Bx1.Text = Cx1.Text;
            Cx1.Text = xchg;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string xchg = Dx1.Text;
            Dx1.Text = Cx1.Text;
            Cx1.Text = xchg;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string xchg = Ax1.Text;
            Ax1.Text = Dx1.Text;
            Dx1.Text = xchg;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string xchg = Bx1.Text;
            Bx1.Text = Dx1.Text;
            Dx1.Text = xchg;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string xchg = Cx1.Text;
            Cx1.Text = Dx1.Text;
            Dx1.Text = xchg;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
