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
    }
}
