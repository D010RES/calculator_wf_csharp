using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalCulatoR
{
    public partial class Form1 : Form
    {
        double value;
        string tag;
        bool check;
        public Form1()
        {
            InitializeComponent();
        }

        public void Pnumber ( object sender,EventArgs e)
        {
            if ((tag == "+") || (tag == "-") || (tag == "*") || (tag == "/"))
            {
                if (check)
                {
                    check = false;
                    textBox1.Text = "0";
                }
            }
            Button b = sender as Button;
            if (textBox1.Text == "0")
                textBox1.Text = b.Text;
            else
                textBox1.Text += b.Text;
        }
        
        private void POperator (object sender , EventArgs e)
        {
            if (value == 0)
            {
                Button b = sender as Button;
                value = double.Parse(textBox1.Text);
                tag = b.Text;
                textBox1.Text += b.Text;
                check = true;
            }
            else
            {
                try
                {
                    switch (tag)
                    {
                        case "+":
                            textBox1.Text = (value + double.Parse(textBox1.Text)).ToString();
                            break;
                        case "-":
                            textBox1.Text = (value - double.Parse(textBox1.Text)).ToString();
                            break;
                        case "*":
                            textBox1.Text = (value * double.Parse(textBox1.Text)).ToString();
                            break;
                        case "/":
                            textBox1.Text = (value / double.Parse(textBox1.Text)).ToString();
                            break;
                    }
                    check = true;
                    value = double.Parse(textBox1.Text);
                    //re-read tag 
                    Button b = sender as Button;
                    value = double.Parse(textBox1.Text);
                    tag = b.Text;
                    textBox1.Text += b.Text;
                    check = true;
                    //
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, " Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }       
        private void label1_Click(object sender, EventArgs e)
        {
            this.Width = 711;
            this.Height = 469;
            label1.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Width = 404;
            this.Height = 469;
            label1.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Top = 10;
            this.Left = 10;
            this.Width = 404;
            this.Height = 469;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           textBox1.Text = "0";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            value = 0;
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            try
            {
                switch (tag)
                {
                    case "+":
                        textBox1.Text = (value + double.Parse(textBox1.Text)).ToString();
                        break;
                    case "-":
                        textBox1.Text = (value - double.Parse(textBox1.Text)).ToString();
                        break;
                    case "*":
                        textBox1.Text = (value * double.Parse(textBox1.Text)).ToString();
                        break;
                    case "/":
                        textBox1.Text = (value / double.Parse(textBox1.Text)).ToString();
                        break;
                    case "^":
                        textBox1.Text = (Math.Pow(value, double.Parse(textBox1.Text)).ToString());
                        break;
                }


            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message, " Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void btn_sin_Click(object sender, EventArgs e)
        {
            value = double.Parse(textBox1.Text);
            value = Math.Sin(value);
            textBox1.Text = value.ToString();
        }

        private void btn_cos_Click(object sender, EventArgs e)
        {
            value = double.Parse(textBox1.Text);
            value = Math.Cos(value);
            textBox1.Text = value.ToString();
        }

        private void btn_tan_Click(object sender, EventArgs e)
        {
            value = double.Parse(textBox1.Text);
            value = Math.Tan(value);
            textBox1.Text = value.ToString();
        }

        private void btn_sinh_Click(object sender, EventArgs e)
        {
            value = double.Parse(textBox1.Text);
            value = Math.Sinh(value);
            textBox1.Text = value.ToString();
        }

        private void btn_cosh_Click(object sender, EventArgs e)
        {
            value = double.Parse(textBox1.Text);
            value = Math.Cosh(value);
            textBox1.Text = value.ToString();
        }

        private void btn_tanh_Click(object sender, EventArgs e)
        {
            value = double.Parse(textBox1.Text);
            value = Math.Tanh(value);
            textBox1.Text = value.ToString();
        }
       
        private void btn_factoriel_Click(object sender, EventArgs e)
        {
            int f = 1;
            int a = int.Parse(textBox1.Text);
            for(int i=1;i<=a;i++)
            {
                f = f * i;
            }
            textBox1.Text = f.ToString();
        }

        private void btn_pow2_Click(object sender, EventArgs e)
        {
            value = double.Parse(textBox1.Text);
            value = Math.Pow(value,2);
            textBox1.Text = value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            value = double.Parse(textBox1.Text);
            value = Math.Pow(value, 3);
            textBox1.Text = value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            value = double.Parse(textBox1.Text);
            tag = "^";
            textBox1.Text += tag;
            textBox1.Clear();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.PI.ToString();
        }

        private void btn_10pow_Click(object sender, EventArgs e)
        {
            value = double.Parse(textBox1.Text);
            value = Math.Pow(10, value);
            textBox1.Text = value.ToString();
        }

        private void btn_zigma_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            value = double.Parse(textBox1.Text);
            if (value <= 0)
            {
                MessageBox.Show("ERROR", "Warn", MessageBoxButtons.OK);
            }
            else
            {
                value = Math.Log10(value);
            }
            textBox1.Text = value.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            value = double.Parse(textBox1.Text);
            value = Math.Asin(value);
            textBox1.Text = value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            value = double.Parse(textBox1.Text);
            value = Math.Acos(value);
            textBox1.Text = value.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            value = double.Parse(textBox1.Text);
            value = Math.Atan(value);
            textBox1.Text = value.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            value = double.Parse(textBox1.Text);
            value = Math.Sqrt(value);
            textBox1.Text = value.ToString();
        }
    }
}