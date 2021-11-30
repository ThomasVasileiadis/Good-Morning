using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Good_Morning
{
    public partial class Form1 : Form
    {
        List<int> intList = new List<int>();
        public int index = 0;
        public int x;
        public decimal sum;
        public decimal totalsum1;
        public decimal totalsum2;
        public int vardia;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list.Items.Add(button1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(totalsum1.ToString(),"");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sum = list.Items.OfType<object>().Sum(x => Convert.ToDecimal(x));
            if ( vardia == 1)
            {
                totalsum1 = totalsum1 + sum;
                list.Items.Clear();
            } 
                totalsum2 = totalsum2 + sum;
                list.Items.Clear();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            list.Items.Add(button5.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            list.Items.Add(button11.Text);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            list.Items.Add(button23.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            list.Items.Add(button9.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            list.Items.Add(button10.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            list.Items.Add(button14.Text);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            list.Items.Add(button22.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            list.Items.Add(button8.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            list.Items.Add(button4.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            list.Items.Add(button13.Text);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            list.Items.Add(button21.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            list.Items.Add(button7.Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            list.Items.Add(button16.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            list.Items.Add(button12.Text);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            list.Items.Add(button20.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            list.Items.Add(button6.Text);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            list.Items.Add(button15.Text);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            list.Items.Add(button17.Text);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            list.Items.Add(button19.Text);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            list.Items.Add(button18.Text);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            list.Items.Add(button28.Text);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            list.Items.Add(button27.Text);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            list.Items.Add(button26.Text);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            list.Items.Add(button25.Text);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            list.Items.Add(button24.Text);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            list.Items.Add(button31.Text);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            list.Items.Add(button30.Text);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            list.Items.RemoveAt(list.SelectedIndex);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            list.Items.Clear();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            vardia = 1;
            Control ctrl = ((Control)sender);
            ctrl.BackColor = Color.Green;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            vardia = 2;
            Control ctrl = ((Control)sender);
            ctrl.BackColor = Color.Green;
        }
    }
}
