





using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pa5_C00124478
{
    public partial class Form1 : Form //class Form1 inherits  Form
    {
        bool a = true;
        bool b = true;
        bool c = false;
        string input = string.Empty;
        string operand1 = "";
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //textbox text method
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "  ^ [0-9]")) //input validation created using Regex
            {
                textBox1.Text = "";
            }

        }



        private void one_Click(object sender, EventArgs e) //this is code for button 1
        {

            if (a == true)
            {
                textBox1.Text = "";
                a = false;
            }
            if (c)
            {
                c = false;
                operand1 = "";
            }
            this.textBox1.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)// this is code for button 2
        {
            if (a == true)
            {
                textBox1.Text = "";
                a = false;
            }
            if (c)
            {
                c = false;
                operand1 = "";
            }

            this.textBox1.Text += "2";

        }

        private void three_Click(object sender, EventArgs e) //this is the code for button 3
        {
            if (a == true)
            {
                textBox1.Text = "";
                a = false;
            }
            if (c)
            {
                c = false;
                operand1 = "";
            }

            this.textBox1.Text += "3";
        }

        private void minus_Click(object sender, EventArgs e) //this is the code for - sign and its functionality.
        {
            if (operand1.Length > 0 && !c)
            {
                doOp();
            }
            else if (textBox1.Text.Length == 0)
            {
                operation = '-';
                operand1 = "0";
                doOp();
            }
            c = false;
            operation = '-';
            a = true;
            b = true;
            operand1 = textBox1.Text;

        }

        private void zero_Click(object sender, EventArgs e) //this is the code for button 0
        {
            if (a == true)
            {
                textBox1.Text = "";
                a = false;
            }
            if (c)
            {
                c = false;
                operand1 = "";
            }

            this.textBox1.Text += "0";
        }

        private void dot_Click(object sender, EventArgs e) //this is the code for decimal button and its functionality.
        {
            if (a == true)
            {
                textBox1.Text = "";
                a = false;
            }
            if (c)
            {
                c = false;
                operand1 = "";
            }


            if (textBox1.Text.Contains("."))
            {
                return;
            }
            else
            {
                if (textBox1.Text.Length == 0)
                {
                    textBox1.Text += "0";
                }

                textBox1.Text += ".";
            }

        }




        private void equal_Click(object sender, EventArgs e) //code for button = and its functionality.
        {
            c = true;
            doOp();
        }
        private void doOp()
        {
            a = true;
            b = true;
            operand2 = textBox1.Text;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+') //operation for +
            {
                result = num1 + num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '-')  //operation for -
            {
                result = num1 - num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == 'x') //operation for multiply
            {
                result = num1 * num2;
                textBox1.Text = result.ToString();
            }
            else if (operation == '÷') //operation for divide
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textBox1.Text = result.ToString("0.0");
                }
                else  //when you divide by zero, it will give you the message below
                      //in textbox. if you want to run any other operation. clear the textbox by using clear or backspace button.
                {
                    textBox1.Text = "Sorry sir you cannot do it.";
                }
            }
            operand1 = textBox1.Text;
        }

        private void plus_Click(object sender, EventArgs e)//code for plus sign button and its functionality
        {
            if (operand1.Length > 0 && !c)
            {
                doOp();
            }
            c = false;
            operation = '+';
            a = true;
            b = true;
            operand1 = textBox1.Text;



        }

        private void four_Click(object sender, EventArgs e) //code for button 4
        {
            if (a == true)
            {
                textBox1.Text = "";
                a = false;
            }
            if (c)
            {
                c = false;
                operand1 = "";
            }

            this.textBox1.Text += "4";
        }

        private void five_Click(object sender, EventArgs e) //code for button 5
        {
            if (a == true)
            {
                textBox1.Text = "";
                a = false;
            }
            if (c)
            {
                c = false;
                operand1 = "";
            }

            this.textBox1.Text += "5";
        }

        private void six_Click(object sender, EventArgs e) //code for button six
        {
            if (a == true)
            {
                textBox1.Text = "";
                a = false;
            }
            if (c)
            {
                c = false;
                operand1 = "";
            }

            this.textBox1.Text += "6";
        }

        private void multiply_Click(object sender, EventArgs e) //code for button multiply and its functionality 
        {
            if (operand1.Length > 0 && !c)
            {
                doOp();
            }
            c = false;
            operation = 'x';
            a = true;
            b = true;
            operand1 = textBox1.Text;
        }

        private void seven_Click(object sender, EventArgs e) //code for button 7
        {
            if (a == true)
            {
                textBox1.Text = "";
                a = false;
            }
            if (c)
            {
                c = false;
                operand1 = "";
            }

            this.textBox1.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e) //code for button eight
        {
            if (a == true)
            {
                textBox1.Text = "";
                a = false;
            }


            this.textBox1.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e) //code for button 9
        {
            if (a == true)
            {
                textBox1.Text = "";
                a = false;
            }
            if (c)
            {
                c = false;
                operand1 = "";
            }

            this.textBox1.Text += "9";
        }

        private void divide_Click(object sender, EventArgs e) //code for button divide and its functionality
        {
            if (operand1.Length > 0 && !c)
            {
                doOp();
            }
            c = false;
            operation = '÷';
            a = true;
            b = true;
            operand1 = textBox1.Text;
        }

        private void back_Click(object sender, EventArgs e) //code for backspace button and its functionality
        {
            if (textBox1.Text.Length == 0)
            {
                return;
            }
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);

        }

        private void clear_Click(object sender, EventArgs e) //code for  clear button and its functionality
        {
            b = true;
            this.textBox1.Text = "";

            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void plusminus_Click(object sender, EventArgs e) //code for the reverse sign button
        {
            if (b == true)
            {
                textBox1.Text = "-" + textBox1.Text;
            }
            else
            {

                textBox1.Text = textBox1.Text.Substring(1);
            }
            b = !b;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //code for drop down menu using combo box.
                                                                                //it includes two options : Clear and Exit.
        {
            switch (Convert.ToString(comboBox1.SelectedItem))
            {
                case "CLEAR":

                    b = true;
                    this.textBox1.Text = "";
                    this.operand1 = string.Empty;
                    this.operand2 = string.Empty;
                    break;

                case "EXIT":
                    System.Environment.Exit(-1);
                    break;

            }


        }

        //code for keypress event for textbox so that user cannot enter characters other than 0-9 and decimal
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
