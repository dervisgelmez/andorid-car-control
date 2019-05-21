using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Frankenstein
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 750;
            timer1.Enabled = true;
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = "COM5";
            serialPort1.Open();
            if (serialPort1.IsOpen == true)
            {
                controlText.Text = "Frankenstein'a bağlanıldı.";
            }
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
                controlText.Text = "Bağlantı sonlandırıldı.";
            }
        }

        private void upArrow_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("ileri");
        }

        private void leftArrow_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("sol");
        }

        private void rightArrow_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("sağ");
        }

        private void downArrow_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("geri");
        }

        private void stop_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("dur");
        }

        private void reverse_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("ters");
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 119 || e.KeyChar == 87)
            {
                serialPort1.Write("1");
            }
            if (e.KeyChar == 97 || e.KeyChar == 65)
            {
                serialPort1.Write("3");
            }
            if (e.KeyChar == 100 || e.KeyChar == 68)
            {
                serialPort1.Write("4");
            }
            if (e.KeyChar == 115 || e.KeyChar == 83)
            {
                serialPort1.Write("2");
            }
            if (e.KeyChar == 113 || e.KeyChar == 81)
            {
                serialPort1.Write("5");
            }
            if (e.KeyChar == 114 || e.KeyChar == 82)
            {
                serialPort1.Write("6");
            }
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("dur");
            for (int i = 0; i <listBox1.Items.Count ; i++)
            {
                switch (listBox1.Items[i].ToString())
                {
                    case "ileri":
                        serialPort1.Write("1");
                        break;
                    case "sol":
                        serialPort1.Write("3");
                        break;
                    case "sağ":
                        serialPort1.Write("4");
                        break;
                    case "geri":
                        serialPort1.Write("2");
                        break;
                    case "dur":
                        serialPort1.Write("5");
                        break;
                    case "ters":
                        serialPort1.Write("6");
                        break;
                    default:
                        break;
                }
            }
            listBox1.Items.Clear();
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void materialFlatButton5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                materialLabel1.Text = serialPort1.ReadExisting().ToString();
            }
        }

    }
}
