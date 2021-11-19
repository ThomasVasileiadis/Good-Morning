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
        public int sum;
        public int totalsum;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            intList.Add(1);
            index++;
            list.Items.Add("1,00");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(totalsum.ToString(),"");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sum = intList.Sum();
            totalsum = totalsum + sum;
            MessageBox.Show(sum.ToString(),"");
            intList.Clear();
            list.Items.Clear();
        }
    }
}
