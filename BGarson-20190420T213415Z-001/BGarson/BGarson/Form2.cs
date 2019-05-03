using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BGarson
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string ad = "musaturan";
        string sifre = "tmusa551";
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==ad && textBox2.Text==sifre)
            {
                Form4 f4 = new Form4();
                f4.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("hata");
            }
         
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
