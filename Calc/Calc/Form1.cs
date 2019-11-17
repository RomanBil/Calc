using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassAnalaizer;

namespace Calc
{
    public partial class Form1 : Form
    {
        private int memory = 0;

        private globalKeyboardHook gkh = new globalKeyboardHook();

        private bool? check(string str)
        {
            bool? test = true;

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]) || str[i] == '+' || str[i] == '-' ||
                    str[i] == '*' || str[i] == '/' || str[i] == '%' || str[i] == '=')
                {

                }

                else
                {
                    test = false;
                }

                if (str[i] == '=')
                {
                    if (i == str.Length - 1)
                    {
                        test = null;
                    }

                    else
                    {
                        test = false;
                    }
                }
            }

            return test;
        }

        public Form1(string str)
        {
            InitializeComponent();

            if (str != "Error")
            {
                bool? test = check(str);

                if (test == true)
                {
                    textBox1.Text = str;
                }

                if (test == false)
                {
                    textBox2.Text = "Error!Incorrect entry";
                }

                if (test == null)
                {
                    //textBox1.Text = str;

                    for (int i = 0; i < str.Length - 1; i++)
                    {
                        textBox1.Text += str[i];
                    }

                    AnalaizerClass.expression = textBox1.Text;

                    textBox2.Text = AnalaizerClass.Estimate();
                }
            }

            gkh.HookedKeys.Add(Keys.Enter);

            gkh.HookedKeys.Add(Keys.Escape);

            gkh.KeyUp += new KeyEventHandler(gkh_KeyUp);
        }

        private void gkh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSum_Click(sender, new EventArgs());
            }

            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Tag;
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void buttonMPlus_Click(object sender, EventArgs e)
        {
            bool? test = check(textBox1.Text);

            if (test == false)
            {
                textBox2.Text = "Неможливо перетворити до числа";
            }

            else
            {
                memory += Convert.ToInt32(textBox2.Text);//suma
            }
        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void buttonMR_Click(object sender, EventArgs e)
        {
            textBox1.Text += memory;
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            AnalaizerClass.expression = textBox1.Text;

            textBox2.Text = AnalaizerClass.Estimate();
        }
    }
}
