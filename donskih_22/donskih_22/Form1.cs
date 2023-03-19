namespace donskih_22
{
    public partial class Form1 : Form
    {
        double FirstValue;
        double SecondValue;
        double currentValue;
        string operation;
        double result;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            FirstValue = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "+";
        }
        private void button_minus_Click(object sender, EventArgs e)
        {
            FirstValue = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "-";
        }

        private void button_umnoj_Click(object sender, EventArgs e)
        {
            FirstValue = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "*";
        }

        private void button_delenie_Click(object sender, EventArgs e)
        {
            FirstValue = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "/";
        }
        private void button_dot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";

        }
        private void button_reverse_Click(object sender, EventArgs e)
        {

             currentValue = Convert.ToDouble(textBox1.Text);
            if (currentValue == 0)
            {
                textBox1.Text = "0";
                
            }
            else
            {
                currentValue = -currentValue;
                textBox1.Text = Convert.ToString(currentValue);

            }

        }
        private void button_delete_Click(object sender, EventArgs e)
        {
            string currentValue = textBox1.Text;
            if (currentValue.Length > 1)
            {
                currentValue = currentValue.Substring(0, currentValue.Length - 1);
            }
            else
            {
                currentValue = "0";
            }
            textBox1.Text = currentValue;
        }
        private void button_result_Click(object sender, EventArgs e)
        {
            SecondValue = Convert.ToDouble(textBox1.Text);
            
            if (operation == "+")
            {
                result = (FirstValue + SecondValue);
                textBox1.Text = Convert.ToString(result);
                FirstValue = result;
            }
            if (operation == "-")
            {
                result = (FirstValue - SecondValue);
                textBox1.Text = Convert.ToString(result);
                FirstValue = result;
            }
            if (operation == "*")
            {
                result = (FirstValue * SecondValue);
                textBox1.Text = Convert.ToString(result);
                FirstValue = result;
            }
            if (operation == "/")
            {
                if (SecondValue == 0)
                {
                    textBox1.Text = "Œÿ»¡ ¿!";
                }
                else
                {
                    result = FirstValue / SecondValue;
                    textBox1.Text = Convert.ToString(result);
                    FirstValue = result;
                }
            }
        }

       
    }
}
    