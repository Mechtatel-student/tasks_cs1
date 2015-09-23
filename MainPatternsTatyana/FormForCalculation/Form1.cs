using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormForCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = 1, b = 1;
            double r = 1;
            bool isCorrect = true;
            isCorrect = double.TryParse(textBox1.Text, out a) &&
                 double.TryParse(textBox2.Text, out b);
            int op = (radioButton1.Checked ? 1 : 0) + (radioButton2.Checked ? 2 : 0) +
                (radioButton3.Checked ? 3 : 0) + (radioButton4.Checked ? 4 : 0);
            textBox3.Text = "";
            if (isCorrect && (op != 4 || b != 0))
            {
                switch (op)
                {
                    case 1:
                        r = a + b;
                        break;
                    case 2:
                        r = a - b;
                        break;
                    case 3:
                        r = a * b;
                        break;
                    case 4:
                        r = a / b;
                        break;
                    default:
                        r = 1;
                        break;
                }
                textBox3.Text = r.ToString();
            }
            else
            {
                if (!isCorrect)
                {
                    textBox3.Text += "некорректные аргументы ";
                }
                if (op == 4 && b == 0)
                {
                    textBox3.Text += "деление на 0";
                }
            }
        }
    }
}
