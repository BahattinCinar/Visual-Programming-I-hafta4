using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace hafta3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double boy, kilo, bki;
            
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Lutfen Deger giriniz");
            }

            else if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("lutfen cinsiyet belirtiniz");
            }

            else 
            {

                boy = Convert.ToDouble(textBox1.Text);
                kilo = Convert.ToDouble(textBox2.Text);

                boy = boy / 100;
                bki = kilo / (boy * boy);

                label5.Text = Convert.ToString(bki);

                if (radioButton1.Checked == true)
                {
                    if (bki <= 18.5)
                    {
                        label8.Text = "zayif";
                    }

                    else if (bki > 18.5 && bki <= 25)
                    {
                        label8.Text = "Ideal";
                    }

                    else if (bki > 25 && bki <= 30)
                    {
                        label8.Text = "Ideal kilonun biraz uzerinde";
                    }
                    else
                    {
                        label8.Text = "Ideal kilonun cok uzerinde";
                    }
                }

                else
                {
                    if (bki <= 18.5)
                    {
                        label8.Text = "zayif";
                    }

                    else if (bki > 18.5 && bki <= 25)
                    {
                        label8.Text = "Ideal";
                    }

                    else if (bki > 25 && bki <= 30)
                    {
                        label8.Text = "Ideal kilonun biraz uzerinde";
                    }
                    else
                    {
                        label8.Text = "Ideal kilonun cok uzerinde";
                    }
                }

            }
            

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
