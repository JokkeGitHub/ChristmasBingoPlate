using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BingoPlate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            foreach (var button in this.Controls.OfType<Button>())
            {
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;

                ExitButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
                ExitButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
                GeneratePlate.FlatAppearance.MouseOverBackColor = Color.Transparent;
                GeneratePlate.FlatAppearance.MouseDownBackColor = Color.Transparent;
            }
        }

        int currentNumber;
        List<int> pastNumber = new List<int>();
        
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GeneratePlate_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                Enumerable.Range(0, 15).ToList().ForEach(arg => GenerateNumber());
            });
            GeneratePlate.Text = "GOOD LUCK!                     ";
        }

        void GenerateNumber()
        {
            Random rnd = new Random();
            do
            {
                currentNumber = rnd.Next(1, 100);
            } while (pastNumber.Contains(currentNumber));
            pastNumber.Add(currentNumber);

            if (InvokeRequired)
            {
                this.BeginInvoke(new MethodInvoker(delegate
                {
                    GeneratePlate.Refresh();

                    if (pastNumber.Count == 15)
                    {
                        button1.Text = pastNumber[pastNumber.Count - 15].ToString();
                        button2.Text = pastNumber[pastNumber.Count - 14].ToString();
                        button3.Text = pastNumber[pastNumber.Count - 13].ToString();
                        button4.Text = pastNumber[pastNumber.Count - 12].ToString();
                        button5.Text = pastNumber[pastNumber.Count - 11].ToString();
                        button6.Text = pastNumber[pastNumber.Count - 10].ToString();
                        button7.Text = pastNumber[pastNumber.Count - 9].ToString();
                        button8.Text = pastNumber[pastNumber.Count - 8].ToString();
                        button9.Text = pastNumber[pastNumber.Count - 7].ToString();
                        button10.Text = pastNumber[pastNumber.Count - 6].ToString();
                        button11.Text = pastNumber[pastNumber.Count - 5].ToString();
                        button12.Text = pastNumber[pastNumber.Count - 4].ToString();
                        button13.Text = pastNumber[pastNumber.Count - 3].ToString();
                        button14.Text = pastNumber[pastNumber.Count - 2].ToString();
                        button15.Text = pastNumber[pastNumber.Count - 1].ToString();
                    }
                }));
            }
        }

        public System.Windows.Forms.MouseButtons Button { get; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.IndianRed)
            {
                button1.BackColor = Color.White;
                button1.FlatAppearance.BorderColor = Color.White;
            }
            else
            {
                button1.FlatAppearance.BorderSize = 3;
                button1.FlatAppearance.BorderColor = Color.Red;
                button1.BackColor = Color.IndianRed;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.IndianRed)
            {
                button2.BackColor = Color.White;
                button2.FlatAppearance.BorderColor = Color.White;
            }
            else
            {
                button2.FlatAppearance.BorderSize = 3;
                button2.FlatAppearance.BorderColor = Color.Red;
                button2.BackColor = Color.IndianRed;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.IndianRed)
            {
                button3.BackColor = Color.White;
                button3.FlatAppearance.BorderColor = Color.White;
            }
            else
            {
                button3.FlatAppearance.BorderSize = 3;
                button3.FlatAppearance.BorderColor = Color.Red;
                button3.BackColor = Color.IndianRed;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.BackColor == Color.IndianRed)
            {
                button4.BackColor = Color.White;
                button4.FlatAppearance.BorderColor = Color.White;
            }
            else
            {
                button4.FlatAppearance.BorderSize = 3;
                button4.FlatAppearance.BorderColor = Color.Red;
                button4.BackColor = Color.IndianRed;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.BackColor == Color.IndianRed)
            {
                button5.BackColor = Color.White;
                button5.FlatAppearance.BorderColor = Color.White;
            }
            else
            {
                button5.FlatAppearance.BorderSize = 3;
                button5.FlatAppearance.BorderColor = Color.Red;
                button5.BackColor = Color.IndianRed;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.BackColor == Color.IndianRed)
            {
                button6.BackColor = Color.White;
                button6.FlatAppearance.BorderColor = Color.White;
            }
            else
            {
                button6.FlatAppearance.BorderSize = 3;
                button6.FlatAppearance.BorderColor = Color.Red;
                button6.BackColor = Color.IndianRed;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.BackColor == Color.IndianRed)
            {
                button7.BackColor = Color.White;
                button7.FlatAppearance.BorderColor = Color.White;
            }
            else
            {
                button7.FlatAppearance.BorderSize = 3;
                button7.FlatAppearance.BorderColor = Color.Red;
                button7.BackColor = Color.IndianRed;
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.BackColor == Color.IndianRed)
            {
                button8.BackColor = Color.White;
                button8.FlatAppearance.BorderColor = Color.White;
            }
            else
            {
                button8.FlatAppearance.BorderSize = 3;
                button8.FlatAppearance.BorderColor = Color.Red;
                button8.BackColor = Color.IndianRed;
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.BackColor == Color.IndianRed)
            {
                button9.BackColor = Color.White;
                button9.FlatAppearance.BorderColor = Color.White;
            }
            else
            {
                button9.FlatAppearance.BorderSize = 3;
                button9.FlatAppearance.BorderColor = Color.Red;
                button9.BackColor = Color.IndianRed;
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.BackColor == Color.IndianRed)
            {
                button10.BackColor = Color.White;
                button10.FlatAppearance.BorderColor = Color.White;
            }
            else
            {
                button10.FlatAppearance.BorderSize = 3;
                button10.FlatAppearance.BorderColor = Color.Red;
                button10.BackColor = Color.IndianRed;
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.BackColor == Color.IndianRed)
            {
                button11.BackColor = Color.White;
                button11.FlatAppearance.BorderColor = Color.White;
            }
            else
            {
                button11.FlatAppearance.BorderSize = 3;
                button11.FlatAppearance.BorderColor = Color.Red;
                button11.BackColor = Color.IndianRed;
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.BackColor == Color.IndianRed)
            {
                button12.BackColor = Color.White;
                button12.FlatAppearance.BorderColor = Color.White;
            }
            else
            {
                button12.FlatAppearance.BorderSize = 3;
                button12.FlatAppearance.BorderColor = Color.Red;
                button12.BackColor = Color.IndianRed;
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (button13.BackColor == Color.IndianRed)
            {
                button13.BackColor = Color.White;
                button13.FlatAppearance.BorderColor = Color.White;
            }
            else
            {
                button13.FlatAppearance.BorderSize = 3;
                button13.FlatAppearance.BorderColor = Color.Red;
                button13.BackColor = Color.IndianRed;
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            if (button14.BackColor == Color.IndianRed)
            {
                button14.BackColor = Color.White;
                button14.FlatAppearance.BorderColor = Color.White;
            }
            else
            {
                button14.FlatAppearance.BorderSize = 3;
                button14.FlatAppearance.BorderColor = Color.Red;
                button14.BackColor = Color.IndianRed;
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            if (button15.BackColor == Color.IndianRed)
            {
                button15.BackColor = Color.White;
                button15.FlatAppearance.BorderColor = Color.White;
            }
            else
            {
                button15.FlatAppearance.BorderSize = 3;
                button15.FlatAppearance.BorderColor = Color.Red;
                button15.BackColor = Color.IndianRed;
            }
        }
        
    }
}
