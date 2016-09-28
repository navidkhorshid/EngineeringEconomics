using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            
            if (listBox1.SelectedItem.ToString() == "F/P")
            {
                label1.Text = "Future :";
                label3.Text = "Present :";
            }
            if (listBox1.SelectedItem.ToString() == "P/F")
            {
                label1.Text = "Present :";
                label3.Text = "Future :";
            }
            if (listBox1.SelectedItem.ToString() == "A/F")
            {
                label1.Text = "Annual :";
                label3.Text = "Future :";
            }
            if (listBox1.SelectedItem.ToString() == "F/A")
            {
                label1.Text = "Future :";
                label3.Text = "Annual :";
            }
            if (listBox1.SelectedItem.ToString() == "A/P")
            {
                label1.Text = "Annual :";
                label3.Text = "Present :";
            }
            if (listBox1.SelectedItem.ToString() == "P/A")
            {
                label1.Text = "Present :";
                label3.Text = "Annual :";
            }
            if (listBox1.SelectedItem.ToString() == "P/G")
            {
                label1.Text = "Present :";
                label3.Text = "G :";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //////////////////////////////////////////////
            if (listBox1.SelectedItem.ToString() == "F/P")
            {
                try
                {
                    double p = Convert.ToDouble(textBox1.Text);
                    double i = Convert.ToDouble(textBox2.Text);
                    double n = Convert.ToDouble(textBox4.Text);
                    textBox3.Text = Convert.ToString((p * Math.Pow((1 + i / 100), n)));
                }
                catch
                {
                    MessageBox.Show("Please Enter Correct Numbers.");
                }
            
            }
            //////////////////////////////////////////////
            if (listBox1.SelectedItem.ToString() == "P/F")
            {
                try
                {
                    double f = Convert.ToDouble(textBox1.Text);
                    double i = Convert.ToDouble(textBox2.Text);
                    double n = Convert.ToDouble(textBox4.Text);
                    textBox3.Text = Convert.ToString((f * 1 / Math.Pow((1 + i / 100), n)));
                }
                catch
                {
                    MessageBox.Show("Please Enter Correct Numbers.");
                }
            }
            //////////////////////////////////////////////
            if (listBox1.SelectedItem.ToString() == "A/F")
            {
                try
                {
                    double f = Convert.ToDouble(textBox1.Text);
                    double i = Convert.ToDouble(textBox2.Text);
                    double n = Convert.ToDouble(textBox4.Text);
                    textBox3.Text = Convert.ToString((f * (i / 100) / (Math.Pow((1 + i / 100), n) - 1)));
                }
                catch
                {
                    MessageBox.Show("Please Enter Correct Numbers.");
                }
            }
            //////////////////////////////////////////////
            if (listBox1.SelectedItem.ToString() == "F/A")
            {
                try
                {
                    double a = Convert.ToDouble(textBox1.Text);
                    double i = Convert.ToDouble(textBox2.Text);
                    double n = Convert.ToDouble(textBox4.Text);
                    textBox3.Text = Convert.ToString((a * (Math.Pow((1 + i / 100), n) - 1) / (i / 100)));
                }
                catch
                {
                    MessageBox.Show("Please Enter Correct Numbers.");
                }
            }
            //////////////////////////////////////////////
            if (listBox1.SelectedItem.ToString() == "A/P")
            {
                try
                {
                    double p = Convert.ToDouble(textBox1.Text);
                    double i = Convert.ToDouble(textBox2.Text);
                    double n = Convert.ToDouble(textBox4.Text);
                    textBox3.Text = Convert.ToString((p * (i / 100) * Math.Pow((1 + i / 100), n) / (Math.Pow((1 + i / 100), n) - 1)));
                }
                catch
                {
                    MessageBox.Show("Please Enter Correct Numbers.");
                }
            }
            //////////////////////////////////////////////
            if (listBox1.SelectedItem.ToString() == "P/A")
            {
                try
                {
                    double a = Convert.ToDouble(textBox1.Text);
                    double i = Convert.ToDouble(textBox2.Text);
                    double n = Convert.ToDouble(textBox4.Text);
                    textBox3.Text = Convert.ToString((a * (Math.Pow((1 + i / 100), n) - 1) / ((i / 100) * Math.Pow((1 + i / 100), n))));
                }
                catch
                {
                    MessageBox.Show("Please Enter Correct Numbers.");
                }
            }
            //////////////////////////////////////////////
            if (listBox1.SelectedItem.ToString() == "P/G")
            {
                try
                {
                    double g = Convert.ToDouble(textBox1.Text);
                    double i = Convert.ToDouble(textBox2.Text);
                    double n = Convert.ToDouble(textBox4.Text);
                    textBox3.Text = Convert.ToString((g / (i / 100)) * (((Math.Pow(1 + i / 100, n - 1) - 1) / ((i / 100) * Math.Pow(1 + i / 100, n - 1))) - ((n - 1) / Math.Pow(1 + i / 100, n))));
                }
                catch
                {
                    MessageBox.Show("Please Enter Correct Numbers.");
                }
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

          

    }
}