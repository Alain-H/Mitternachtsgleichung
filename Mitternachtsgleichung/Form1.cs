using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mitternachtsgleichung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string L0 = "Es gibt keine reele Lösung!";
        string L1 = "Es gibt nur eine Lösung!";
        string L2 = "Es gibt 2 Lösungen!";
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        double x = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);
                if (a == 0)
                {
                    textBox4.Text = (-c / b).ToString();
                    label7.Text = L1;
                }
                else
                {
                    double D = b * b - 4 * a * c;
                    if(D>0)
                    {
                        textBox4.Text = (-b + Math.Sqrt(D) / (2 * a)).ToString();
                        textBox5.Text = (-b - Math.Sqrt(D) / (2 * a)).ToString();
                        label7.Text += " " + L2;
                    }
                    else if(D==0)
                    {
                        textBox4.Text = (-b / (2 * a)).ToString();
                        label7.Text += " " + L1;
                    }
                    else
                    {
                        textBox4.Text = "";
                        textBox5.Text = "";
                        label7.Text += " " + L0;
                    }
                }
                
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Fehler!!!");
            }
            
        }
    }
}
