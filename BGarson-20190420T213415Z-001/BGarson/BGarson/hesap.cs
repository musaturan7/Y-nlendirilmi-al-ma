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
    public partial class hesap : Form
    {
        public Form1 frm1;
        public hesap()
        {
            InitializeComponent();
        }

        private void hesap_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double fyt1, fyt2, fyt3, fyt4, tutar;
            fyt1 = double.Parse(textBox1.Text);

            fyt2 = double.Parse(textBox2.Text);

            fyt3 = double.Parse(textBox3.Text);

            fyt4 = double.Parse(textBox4.Text);

            tutar = fyt1 + fyt2 + fyt3 + fyt4;

            label9.Text = (tutar.ToString() + "TL");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm1.frm5.Show();
            this.Hide();
        }
    }
}
