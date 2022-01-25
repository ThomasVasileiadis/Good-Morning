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
using Microsoft.VisualBasic;
using Good_Morning.Properties;
using System.IO;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Globalization;

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
        private Rectangle button35OriginalRect;
        private Rectangle button36OriginalRect;
        private Rectangle button37OriginalRect;
        private Rectangle button38OriginalRect;
        private Rectangle button39OriginalRect;
        private Rectangle button40OriginalRect;
        private Rectangle button41OriginalRect;
        private Rectangle button42OriginalRect;
        private Rectangle button43OriginalRect;
        private Rectangle button44OriginalRect;
        private Rectangle button45OriginalRect;
        private Rectangle button46OriginalRect;
        private Rectangle button47OriginalRect;
        private Rectangle button48OriginalRect;
        private Rectangle button49OriginalRect;
        private Rectangle button50OriginalRect;
        private Rectangle button51OriginalRect;
        private Rectangle button52OriginalRect;
        private Rectangle button53OriginalRect;
        private Rectangle button54OriginalRect;
        private Rectangle button55OriginalRect;
        private Rectangle button56OriginalRect;
        private Rectangle button57OriginalRect;
        private Rectangle button58OriginalRect;
        private Rectangle listOriginalRect;
        private Size formOriginalSize;


        List<int> intList = new List<int>();
        public int index = 0;
        public int x;
        public decimal sum;
        public decimal totalsum1;
        public decimal totalsum2;
        public int vardia=0;
        public int clickCounter = 0;
        public string CurrencyDecimalSeparator { get; set; }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            

            button1.Text = Settings.Default.button1;
            //button2.Text = Settings.Default.button2;
            //button3.Text = Settings.Default.button3;
            button4.Text = Settings.Default.button4;
            button5.Text = Settings.Default.button5;
            button6.Text = Settings.Default.button6;
            button7.Text = Settings.Default.button7;
            button8.Text = Settings.Default.button8;
            button9.Text = Settings.Default.button9;
            button10.Text = Settings.Default.button10;
            button11.Text = Settings.Default.button11;
            button12.Text = Settings.Default.button12;
            button13.Text = Settings.Default.button13;
            button14.Text = Settings.Default.button14;
            button15.Text = Settings.Default.button15;
            button16.Text = Settings.Default.button16;
            button17.Text = Settings.Default.button17;
            button18.Text = Settings.Default.button18;
            button19.Text = Settings.Default.button19;
            button20.Text = Settings.Default.button20;
            button21.Text = Settings.Default.button21;
            button22.Text = Settings.Default.button22;
            button23.Text = Settings.Default.button23;
            button24.Text = Settings.Default.button24;
            button25.Text = Settings.Default.button25;
            button26.Text = Settings.Default.button26;
            button27.Text = Settings.Default.button27;
            button28.Text = Settings.Default.button28;
            //button29.Text = Settings.Default.button29;
            button30.Text = Settings.Default.button30;
            button31.Text = Settings.Default.button31;
            //button32.Text = Settings.Default.button32;
            //button33.Text = Settings.Default.button33;
            //button34.Text = Settings.Default.button34;
            button35.Text = Settings.Default.button35;
            button36.Text = Settings.Default.button36;
            button37.Text = Settings.Default.button37;
            button38.Text = Settings.Default.button38;
            button39.Text = Settings.Default.button39;
            button40.Text = Settings.Default.button40;
            button41.Text = Settings.Default.button41;
            button42.Text = Settings.Default.button42;
            button43.Text = Settings.Default.button43;
            button44.Text = Settings.Default.button44;
            button45.Text = Settings.Default.button45;
            button46.Text = Settings.Default.button46;
            button47.Text = Settings.Default.button47;
            button48.Text = Settings.Default.button48;
            button49.Text = Settings.Default.button49;
            button50.Text = Settings.Default.button50;
            button51.Text = Settings.Default.button51;
            button52.Text = Settings.Default.button52;
            button53.Text = Settings.Default.button53;
            button54.Text = Settings.Default.button54;
            button55.Text = Settings.Default.button55;
            //button56.Text = Settings.Default.button56;
            //button57.Text = Settings.Default.button57;
            //button58.Text = Settings.Default.button58;





            formOriginalSize = this.Size;
            button1OriginalRect = new Rectangle(button1.Location.X, button1.Location.Y, button1.Width, button1.Height);
            //button2OriginalRect = new Rectangle(button2.Location.X, button2.Location.Y, button2.Width, button2.Height);
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
            button35OriginalRect = new Rectangle(button35.Location.X, button35.Location.Y, button35.Width, button35.Height);
            button36OriginalRect = new Rectangle(button36.Location.X, button36.Location.Y, button36.Width, button36.Height);
            button37OriginalRect = new Rectangle(button37.Location.X, button37.Location.Y, button37.Width, button37.Height);
            button38OriginalRect = new Rectangle(button38.Location.X, button38.Location.Y, button38.Width, button38.Height);
            button39OriginalRect = new Rectangle(button39.Location.X, button39.Location.Y, button39.Width, button39.Height);
            button40OriginalRect = new Rectangle(button40.Location.X, button40.Location.Y, button40.Width, button40.Height);
            button41OriginalRect = new Rectangle(button41.Location.X, button41.Location.Y, button41.Width, button41.Height);
            button42OriginalRect = new Rectangle(button42.Location.X, button42.Location.Y, button42.Width, button42.Height);
            button43OriginalRect = new Rectangle(button43.Location.X, button43.Location.Y, button43.Width, button43.Height);
            button44OriginalRect = new Rectangle(button44.Location.X, button44.Location.Y, button44.Width, button44.Height);
            button45OriginalRect = new Rectangle(button45.Location.X, button45.Location.Y, button45.Width, button45.Height);
            button46OriginalRect = new Rectangle(button46.Location.X, button46.Location.Y, button46.Width, button46.Height);
            button47OriginalRect = new Rectangle(button47.Location.X, button47.Location.Y, button47.Width, button47.Height);
            button48OriginalRect = new Rectangle(button48.Location.X, button48.Location.Y, button48.Width, button48.Height);
            button49OriginalRect = new Rectangle(button49.Location.X, button49.Location.Y, button49.Width, button49.Height);
            button50OriginalRect = new Rectangle(button50.Location.X, button50.Location.Y, button50.Width, button50.Height);
            button51OriginalRect = new Rectangle(button51.Location.X, button51.Location.Y, button51.Width, button51.Height);
            button52OriginalRect = new Rectangle(button52.Location.X, button52.Location.Y, button52.Width, button52.Height);
            button53OriginalRect = new Rectangle(button53.Location.X, button53.Location.Y, button53.Width, button53.Height);
            button54OriginalRect = new Rectangle(button54.Location.X, button54.Location.Y, button54.Width, button54.Height);
            button55OriginalRect = new Rectangle(button55.Location.X, button55.Location.Y, button55.Width, button55.Height);
            button56OriginalRect = new Rectangle(button56.Location.X, button56.Location.Y, button56.Width, button56.Height);
            //button58OriginalRect = new Rectangle(button58.Location.X, button58.Location.Y, button58.Width, button58.Height);
            listOriginalRect = new Rectangle(list.Location.X, list.Location.Y, list.Width, list.Height);
            
    }

        

        private void resizeChildrenControls()
        {
            resizeControl(button1OriginalRect, button1);
            //resizeControl(button2OriginalRect, button2);
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
            resizeControl(button35OriginalRect, button35);
            resizeControl(button36OriginalRect, button36);
            resizeControl(button37OriginalRect, button37);
            resizeControl(button38OriginalRect, button38);
            resizeControl(button39OriginalRect, button39);
            resizeControl(button40OriginalRect, button40);
            resizeControl(button41OriginalRect, button41);
            resizeControl(button42OriginalRect, button42);
            resizeControl(button43OriginalRect, button43);
            resizeControl(button44OriginalRect, button44);
            resizeControl(button45OriginalRect, button45);
            resizeControl(button46OriginalRect, button46);
            resizeControl(button47OriginalRect, button47);
            resizeControl(button48OriginalRect, button48);
            resizeControl(button49OriginalRect, button49);
            resizeControl(button50OriginalRect, button50);
            resizeControl(button51OriginalRect, button51);
            resizeControl(button52OriginalRect, button52);
            resizeControl(button53OriginalRect, button53);
            resizeControl(button54OriginalRect, button54);
            resizeControl(button55OriginalRect, button55);
            resizeControl(button56OriginalRect, button56);
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
            string oldChar = ".";
            string newChar = ",";
            string strTotalSum1 = totalsum1.ToString();
            string strTotalSum2 = totalsum2.ToString();
            strTotalSum1 = strTotalSum1.Replace(oldChar, newChar);
            strTotalSum2 = strTotalSum2.Replace(oldChar, newChar);
            if (vardia == 1) {

                Console.WriteLine(strTotalSum1);
                MessageBox.Show(strTotalSum1 + "€", "ΣΥΝΟΛΟ ΒΑΡΔΙΑΣ 1"); 
            } else
            {
                Console.WriteLine(strTotalSum2);
                MessageBox.Show(strTotalSum2 + "€", "ΣΥΝΟΛΟ ΒΑΡΔΙΑΣ 2");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string completepath = Path.Combine(path + "\\");
            //completepath = completepath + "\\";
            Console.WriteLine(completepath);
            System.IO.Directory.CreateDirectory(completepath + "Good_Morning");
            string time = DateTime.Now.ToString("HH-mm-ss");
            string date = DateTime.Now.ToString("dd-MM-yyyy");
            string fullname1 = date + "-" + time + "-vardia1.txt";
            string fullname2 = date + "-" + time + "-vardia2.txt";

            // Gets a NumberFormatInfo associated with the en-US culture.
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;



            sum = list.Items.OfType<object>().Sum(x => Convert.ToDecimal(x));
            if ( vardia == 1)
            {
                totalsum1 = totalsum1 + sum;
                list.Items.Clear();
                string strTotalSum1 = totalsum1.ToString(new CultureInfo("gr-GR"));
                
                StreamWriter sw = new StreamWriter(completepath + "Good_Morning\\" +  fullname1);
                sw.WriteLine("Το σύνολο βάρδιας 1 είναι: " + strTotalSum1 + "€");
                sw.Close();
                string text = File.ReadAllText(completepath + "Good_Morning\\" + fullname1);
                text = text.Replace(".", ",");
                File.WriteAllText(completepath + "Good_Morning\\" + fullname1, text);
            } else if (vardia ==2){
                totalsum2 = totalsum2 + sum;
                list.Items.Clear();
                string strTotalSum2 = totalsum2.ToString();
                strTotalSum2 = strTotalSum2.Replace('.', ',');
                Console.WriteLine(strTotalSum2);
                StreamWriter sw = new StreamWriter(completepath + "Good_Morning\\" + fullname2);
                sw.WriteLine("Το σύνολο βάρδιας 2 είναι: " + strTotalSum2 + "€");
                sw.Close();
                string text = File.ReadAllText(completepath + "Good_Morning\\" + fullname2);
                text = text.Replace(".", ",");
                File.WriteAllText(completepath + "Good_Morning\\" + fullname2, text);
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

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }


        private void αλλαγήΤιμήςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message, title, defaultValue;
            object myValue;
            string ControlsName;
            object Obj1;
            ControlsName = contextMenuStrip1.SourceControl.Name.ToString();

            message = "Δώσε νέα τιμή:";

            title = "Αλλαγή τιμής";

            defaultValue = "0";

            myValue = Interaction.InputBox(message, title, defaultValue);

            Console.WriteLine(ControlsName);

            switch (ControlsName)
            {
                case "button54":
                    button54.Text = myValue.ToString();
                    Settings.Default.button54 = button54.Text;
                    Settings.Default.Save();
                    break;
                case "button53":
                    button53.Text = myValue.ToString();
                    Settings.Default.button53 = button53.Text;
                    Settings.Default.Save();
                    break;
                case "button52":
                    button52.Text = myValue.ToString();
                    Settings.Default.button52 = button52.Text;
                    Settings.Default.Save();
                    break;
                case "button51":
                    button51.Text = myValue.ToString();
                    Settings.Default.button51 = button51.Text;
                    Settings.Default.Save();
                    break;
                case "button50":
                    button50.Text = myValue.ToString();
                    Settings.Default.button50 = button50.Text;
                    Settings.Default.Save();
                    break;
                case "button49":
                    button49.Text = myValue.ToString();
                    Settings.Default.button49 = button49.Text;
                    Settings.Default.Save();
                    break;
                case "button48":
                    button48.Text = myValue.ToString();
                    Settings.Default.button48 = button48.Text;
                    Settings.Default.Save();
                    break;
                case "button47":
                    button47.Text = myValue.ToString();
                    Settings.Default.button47 = button47.Text;
                    Settings.Default.Save();
                    break;
                case "button46":
                    button46.Text = myValue.ToString();
                    Settings.Default.button46 = button46.Text;
                    Settings.Default.Save();
                    break;
                case "button45":
                    button45.Text = myValue.ToString();
                    Settings.Default.button45 = button45.Text;
                    Settings.Default.Save();
                    break;
                case "button44":
                    button44.Text = myValue.ToString();
                    Settings.Default.button44 = button44.Text;
                    Settings.Default.Save();
                    break;
                case "button43":
                    button43.Text = myValue.ToString();
                    Settings.Default.button43 = button43.Text;
                    Settings.Default.Save();
                    break;
                case "button42":
                    button42.Text = myValue.ToString();
                    Settings.Default.button42 = button42.Text;
                    Settings.Default.Save();
                    break;
                case "button41":
                    button41.Text = myValue.ToString();
                    Settings.Default.button41 = button41.Text;
                    Settings.Default.Save();
                    break;
                case "button40":
                    button40.Text = myValue.ToString();
                    Settings.Default.button40 = button40.Text;
                    Settings.Default.Save();
                    break;
                case "button39":
                    button39.Text = myValue.ToString();
                    Settings.Default.button39 = button39.Text;
                    Settings.Default.Save();
                    break;
                case "button38":
                    button38.Text = myValue.ToString();
                    Settings.Default.button38 = button38.Text;
                    Settings.Default.Save();
                    break;
                case "button37":
                    button37.Text = myValue.ToString();
                    Settings.Default.button37 = button37.Text;
                    Settings.Default.Save();
                    break;
                case "button36":
                    button36.Text = myValue.ToString();
                    Settings.Default.button36 = button36.Text;
                    Settings.Default.Save();
                    break;
                case "button35":
                    button35.Text = myValue.ToString();
                    Settings.Default.button35 = button35.Text;
                    Settings.Default.Save();
                    break;
                case "button34":
                    button34.Text = myValue.ToString();
                    Settings.Default.button34 = button34.Text;
                    Settings.Default.Save();
                    break;
                case "button33":
                    button33.Text = myValue.ToString();
                    Settings.Default.button33 = button33.Text;
                    Settings.Default.Save();
                    break;
                case "button32":
                    button32.Text = myValue.ToString();
                    Settings.Default.button32 = button32.Text;
                    Settings.Default.Save();
                    break;
                case "button31":
                    button31.Text = myValue.ToString();
                    Settings.Default.button31 = button31.Text;
                    Settings.Default.Save();
                    break;
                case "button30":
                    button30.Text = myValue.ToString();
                    Settings.Default.button30 = button30.Text;
                    Settings.Default.Save();
                    break;
                case "button29":
                    button29.Text = myValue.ToString();
                    Settings.Default.button29 = button29.Text;
                    Settings.Default.Save();
                    break;
                case "button28":
                    button28.Text = myValue.ToString();
                    Settings.Default.button28 = button28.Text;
                    Settings.Default.Save();
                    break;
                case "button27":
                    button27.Text = myValue.ToString();
                    Settings.Default.button27 = button27.Text;
                    Settings.Default.Save();
                    break;
                case "button26":
                    button26.Text = myValue.ToString();
                    Settings.Default.button26 = button26.Text;
                    Settings.Default.Save();
                    break;
                case "button25":
                    button25.Text = myValue.ToString();
                    Settings.Default.button25 = button25.Text;
                    Settings.Default.Save();
                    break;
                case "button24":
                    button24.Text = myValue.ToString();
                    Settings.Default.button24 = button24.Text;
                    Settings.Default.Save();
                    break;
                case "button23":
                    button23.Text = myValue.ToString();
                    Settings.Default.button23 = button23.Text;
                    Settings.Default.Save();
                    break;
                case "button22":
                    button22.Text = myValue.ToString();
                    Settings.Default.button22 = button22.Text;
                    Settings.Default.Save();
                    break;
                case "button21":
                    button21.Text = myValue.ToString();
                    Settings.Default.button21 = button21.Text;
                    Settings.Default.Save();
                    break;
                case "button20":
                    button20.Text = myValue.ToString();
                    Settings.Default.button20 = button20.Text;
                    Settings.Default.Save();
                    break;
                case "button19":
                    button19.Text = myValue.ToString();
                    Settings.Default.button19 = button19.Text;
                    Settings.Default.Save();
                    break;
                case "button18":
                    button18.Text = myValue.ToString();
                    Settings.Default.button18 = button18.Text;
                    Settings.Default.Save();
                    break;
                case "button17":
                    button17.Text = myValue.ToString();
                    Settings.Default.button17 = button17.Text;
                    Settings.Default.Save();
                    break;
                case "button16":
                    button16.Text = myValue.ToString();
                    Settings.Default.button16 = button16.Text;
                    Settings.Default.Save();
                    break;
                case "button15":
                    button15.Text = myValue.ToString();
                    Settings.Default.button15 = button15.Text;
                    Settings.Default.Save();
                    break;
                case "button14":
                    button14.Text = myValue.ToString();
                    Settings.Default.button14 = button14.Text;
                    Settings.Default.Save();
                    break;
                case "button13":
                    button13.Text = myValue.ToString();
                    Settings.Default.button13 = button13.Text;
                    Settings.Default.Save();
                    break;
                case "button12":
                    button12.Text = myValue.ToString();
                    Settings.Default.button12 = button12.Text;
                    Settings.Default.Save();
                    break;
                case "button11":
                    button11.Text = myValue.ToString();
                    Settings.Default.button11 = button11.Text;
                    Settings.Default.Save();
                    break;
                case "button10":
                    button10.Text = myValue.ToString();
                    Settings.Default.button10 = button10.Text;
                    Settings.Default.Save();
                    break;
                case "button9":
                    button9.Text = myValue.ToString();
                    Settings.Default.button9 = button9.Text;
                    Settings.Default.Save();
                    break;
                case "button8":
                    button8.Text = myValue.ToString();
                    Settings.Default.button8 = button8.Text;
                    Settings.Default.Save();
                    break;
                case "button7":
                    button7.Text = myValue.ToString();
                    Settings.Default.button7 = button7.Text;
                    Settings.Default.Save();
                    break;
                case "button6":
                    button6.Text = myValue.ToString();
                    Settings.Default.button6 = button6.Text;
                    Settings.Default.Save();
                    break;
                case "button5":
                    button5.Text = myValue.ToString();
                    Settings.Default.button5 = button5.Text;
                    Settings.Default.Save();
                    break;
                case "button4":
                    button4.Text = myValue.ToString();
                    Settings.Default.button4 = button4.Text;
                    Settings.Default.Save();
                    break;
                case "button3":
                    button3.Text = myValue.ToString();
                    Settings.Default.button3 = button3.Text;
                    Settings.Default.Save();
                    break;
                /*case "button2":
                    button2.Text = myValue.ToString();
                    Settings.Default.button2 = button2.Text;
                    Settings.Default.Save();
                    break;*/
                case "button1":
                    button1.Text = myValue.ToString();
                    Settings.Default.button1 = button1.Text;
                    Settings.Default.Save();
                    break;


            }

            //ControlsName.Text = myValue.ToString();

        }

        private void button35_Click(object sender, EventArgs e)
        {
            list.Items.Add(button35.Text);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            list.Items.Add(button36.Text);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            list.Items.Add(button37.Text);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            list.Items.Add(button38.Text);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            list.Items.Add(button39.Text);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            list.Items.Add(button40.Text);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            list.Items.Add(button41.Text);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            list.Items.Add(button48.Text);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            list.Items.Add(button47.Text);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            list.Items.Add(button46.Text);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            list.Items.Add(button45.Text);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            list.Items.Add(button44.Text);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            list.Items.Add(button43.Text);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            list.Items.Add(button42.Text);
        }

        private void button55_Click(object sender, EventArgs e)
        {
            list.Items.Add(button55.Text);
        }

        private void button54_Click(object sender, EventArgs e)
        {
            list.Items.Add(button54.Text);
        }

        private void button53_Click(object sender, EventArgs e)
        {
            list.Items.Add(button53.Text);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            list.Items.Add(button52.Text);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            list.Items.Add(button51.Text);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            list.Items.Add(button50.Text);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            list.Items.Add(button49.Text);
        }

        private void button56_Click(object sender, EventArgs e)
        {
            string path = System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string completepath = Path.Combine(path + "\\");
            //completepath = completepath + "\\";
            //Console.WriteLine(completepath);
            System.IO.Directory.CreateDirectory(completepath + "Good_Morning");
            string time = DateTime.Now.ToString("HH-mm-ss");
            string date = DateTime.Now.ToString("dd-MM-yyyy");
            string fullname1 = date + "-" + time + "-vardia1.txt";
            string fullname2 = date + "-" + time + "-vardia2.txt";
            Process.Start(completepath + "Good_Morning\\");
        }








        /*
        private void button58_Click(object sender, EventArgs e)
        {
            string strCmdText;
            string strCmdText2;
            strCmdText2 = "cd D:/";
            strCmdText = "./vardia2.txt";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText2);
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }*/
    }
}
