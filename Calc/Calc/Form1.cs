using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1(string str)
        {
            InitializeComponent();

            if (str != "Error")
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

                if (test == true)
                {
                    textBox1.Text = str;
                }

                if (test == false)
                {
                    MessageBox.Show("Error!Incorrect entry");
                }

                if (test == null)
                {
                    textBox1.Text = str;

                    //=
                }
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
    }
}
