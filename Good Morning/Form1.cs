using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Good_Morning
{
    public partial class Form1 : Form
    {
        private Rectangle button1OriginalRect;
        private Rectangle button2OriginalRect;
        private Rectangle button3OriginalRect;
        private Rectangle button4OriginalRect;
        private Rectangle button5OriginalRect;
        private Rectangle button6OriginalRect;
        private Rectangle button7OriginalRect;
        private Rectangle button8OriginalRect;
        private Rectangle button9OriginalRect;
        private Rectangle button10OriginalRect;
        private Rectangle button11OriginalRect;
        private Rectangle button12OriginalRect;
        private Rectangle button13OriginalRect;
        private Rectangle button14OriginalRect;
        private Rectangle button15OriginalRect;
        private Rectangle button16OriginalRect;
        private Rectangle button17OriginalRect;
        private Rectangle button18OriginalRect;
        private Rectangle button19OriginalRect;
        private Rectangle button20OriginalRect;
        private Rectangle button21OriginalRect;
        private Rectangle button22OriginalRect;
        private Rectangle button23OriginalRect;
        private Rectangle button24OriginalRect;
        private Rectangle button25OriginalRect;
        private Rectangle button26OriginalRect;
        private Rectangle button27OriginalRect;
        private Rectangle button28OriginalRect;
        private Rectangle button29OriginalRect;
        private Rectangle button30OriginalRect;
        private Rectangle button31OriginalRect;
        private Rectangle button32OriginalRect;
        private Rectangle button33OriginalRect;
        private Rectangle button34OriginalRect;
        private Rectangle listOriginalRect;
        private Size formOriginalSize;


        List<int> intList = new List<int>();
        public int index = 0;
        public int x;
        public decimal sum;
        public decimal totalsum1;
        public decimal totalsum2;
        public int vardia=0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            formOriginalSize = this.Size;
            button1OriginalRect = new Rectangle(button1.Location.X, button1.Location.Y, button1.Width, button1.Height);
            button2OriginalRect = new Rectangle(button2.Location.X, button2.Location.Y, button2.Width, button2.Height);
            button3OriginalRect = new Rectangle(button3.Location.X, button3.Location.Y, button3.Width, button3.Height);
            button4OriginalRect = new Rectangle(button4.Location.X, button4.Location.Y, button4.Width, button4.Height);
            button5OriginalRect = new Rectangle(button5.Location.X, button5.Location.Y, button5.Width, button5.Height);
            button6OriginalRect = new Rectangle(button6.Location.X, button6.Location.Y, button6.Width, button6.Height);
            button7OriginalRect = new Rectangle(button7.Location.X, button7.Location.Y, button7.Width, button7.Height);
            button8OriginalRect = new Rectangle(button8.Location.X, button8.Location.Y, button8.Width, button8.Height);
            button9OriginalRect = new Rectangle(button9.Location.X, button9.Location.Y, button9.Width, button9.Height);
            button10OriginalRect = new Rectangle(button10.Location.X, button10.Location.Y, button10.Width, button10.Height);
            button11OriginalRect = new Rectangle(button11.Location.X, button11.Location.Y, button11.Width, button11.Height);
            button12OriginalRect = new Rectangle(button12.Location.X, button12.Location.Y, button12.Width, button12.Height);
            button13OriginalRect = new Rectangle(button13.Location.X, button13.Location.Y, button13.Width, button13.Height);
            button14OriginalRect = new Rectangle(button14.Location.X, button14.Location.Y, button14.Width, button14.Height);
            button15OriginalRect = new Rectangle(button15.Location.X, button15.Location.Y, button15.Width, button15.Height);
            button16OriginalRect = new Rectangle(button16.Location.X, button16.Location.Y, button16.Width, button16.Height);
            button17OriginalRect = new Rectangle(button17.Location.X, button17.Location.Y, button17.Width, button17.Height);
            button18OriginalRect = new Rectangle(button18.Location.X, button18.Location.Y, button18.Width, button18.Height);
            button19OriginalRect = new Rectangle(button19.Location.X, button19.Location.Y, button19.Width, button19.Height);
            button20OriginalRect = new Rectangle(button20.Location.X, button20.Location.Y, button20.Width, button20.Height);
            button21OriginalRect = new Rectangle(button21.Location.X, button21.Location.Y, button21.Width, button21.Height);
            button22OriginalRect = new Rectangle(button22.Location.X, button22.Location.Y, button22.Width, button22.Height);
            button23OriginalRect = new Rectangle(button23.Location.X, button23.Location.Y, button23.Width, button23.Height);
            button24OriginalRect = new Rectangle(button24.Location.X, button24.Location.Y, button24.Width, button24.Height);
            button25OriginalRect = new Rectangle(button25.Location.X, button25.Location.Y, button25.Width, button25.Height);
            button26OriginalRect = new Rectangle(button26.Location.X, button26.Location.Y, button26.Width, button26.Height);
            button27OriginalRect = new Rectangle(button27.Location.X, button27.Location.Y, button27.Width, button27.Height);
            button28OriginalRect = new Rectangle(button28.Location.X, button28.Location.Y, button28.Width, button28.Height);
            button29OriginalRect = new Rectangle(button29.Location.X, button29.Location.Y, button29.Width, button29.Height);
            button30OriginalRect = new Rectangle(button30.Location.X, button30.Location.Y, button30.Width, button30.Height);
            button31OriginalRect = new Rectangle(button31.Location.X, button31.Location.Y, button31.Width, button31.Height);
            button32OriginalRect = new Rectangle(button32.Location.X, button32.Location.Y, button32.Width, button32.Height);
            button33OriginalRect = new Rectangle(button33.Location.X, button33.Location.Y, button33.Width, button33.Height);
            button34OriginalRect = new Rectangle(button34.Location.X, button34.Location.Y, button34.Width, button34.Height);
            listOriginalRect = new Rectangle(list.Location.X, list.Location.Y, list.Width, list.Height);
        }

        private void resizeChildrenControls()
        {
            resizeControl(button1OriginalRect, button1);
            resizeControl(button2OriginalRect, button2);
            resizeControl(button3OriginalRect, button3);
            resizeControl(button4OriginalRect, button4);
            resizeControl(button5OriginalRect, button5);
            resizeControl(button6OriginalRect, button6);
            resizeControl(button7OriginalRect, button7);
            resizeControl(button8OriginalRect, button8);
            resizeControl(button9OriginalRect, button9);
            resizeControl(button10OriginalRect, button10);
            resizeControl(button11OriginalRect, button11);
            resizeControl(button12OriginalRect, button12);
            resizeControl(button13OriginalRect, button13);
            resizeControl(button14OriginalRect, button14);
            resizeControl(button15OriginalRect, button15);
            resizeControl(button16OriginalRect, button16);
            resizeControl(button17OriginalRect, button17);
            resizeControl(button18OriginalRect, button18);
            resizeControl(button19OriginalRect, button19);
            resizeControl(button20OriginalRect, button20);
            resizeControl(button21OriginalRect, button21);
            resizeControl(button22OriginalRect, button22);
            resizeControl(button23OriginalRect, button23);
            resizeControl(button24OriginalRect, button24);
            resizeControl(button25OriginalRect, button25);
            resizeControl(button26OriginalRect, button26);
            resizeControl(button27OriginalRect, button27);
            resizeControl(button28OriginalRect, button28);
            resizeControl(button29OriginalRect, button29);
            resizeControl(button30OriginalRect, button30);
            resizeControl(button31OriginalRect, button31);
            resizeControl(button32OriginalRect, button32);
            resizeControl(button33OriginalRect, button33);
            resizeControl(button34OriginalRect, button34);
            resizeControl(listOriginalRect, list);
        }

        private void resizeControl(Rectangle OriginalControlRect, Control control)
        {
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);

            int newX = (int)(OriginalControlRect.X * xRatio);
            int newY = (int)(OriginalControlRect.Y * yRatio);

            int newWidth = (int)(OriginalControlRect.Width * xRatio);
            int newHeight = (int)(OriginalControlRect.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            resizeChildrenControls();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list.Items.Add(button1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (vardia == 1) { 
                MessageBox.Show(totalsum1.ToString(), "ΣΥΝΟΛΟ ΒΑΡΔΙΑΣ 1"); 
            } else
            {
                MessageBox.Show(totalsum2.ToString(), "ΣΥΝΟΛΟ ΒΑΡΔΙΑΣ 2");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sum = list.Items.OfType<object>().Sum(x => Convert.ToDecimal(x));
            if ( vardia == 1)
            {
                totalsum1 = totalsum1 + sum;
                list.Items.Clear();
            } else if (vardia ==2){
                totalsum2 = totalsum2 + sum;
                list.Items.Clear();
            } else
            {
                MessageBox.Show("Παρακαλώ επιλέξτε βάρδια.");
            }
                
            
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

        private void button25_Click_1(object sender, EventArgs e)
        {
            list.Items.Add(button25.Text);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            vardia = 1;
            Control ctrl = ((Control)sender);
            ctrl.BackColor = Color.Green;
            button33.BackColor = Color.DarkGray;

        }

        private void button33_Click(object sender, EventArgs e)
        {
            vardia = 2;
            Control ctrl = ((Control)sender);
            ctrl.BackColor = Color.Green;
            button34.BackColor = Color.DarkGray;
        }

        
    }
}
