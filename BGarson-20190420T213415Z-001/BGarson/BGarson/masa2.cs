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
    public partial class masa2 : Form
    {
        public Form1 frm1;
        public masa2()
        {
            InitializeComponent();
        }

        private void masa2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm1.frm5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm1.bag.Open();
            frm1.kmt.Connection = frm1.bag;
            frm1.kmt.CommandText = "INSERT INTO Siparis(MasaNo,Çorba,Pide,Kebap,Tatli) VALUES ('" + label1.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "')";
            frm1.kmt.ExecuteNonQuery();
            frm1.kmt.Dispose();
            frm1.bag.Close();
            frm1.dtst.Clear();
            frm1.frm5.button2.BackColor = System.Drawing.Color.Red;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm1.bag.Open();
            frm1.kmt.Connection = frm1.bag;
            frm1.kmt.CommandText = "UPDATE siparis SET corba='" + comboBox1.Text + "',Pide='" + comboBox2.Text + "',Kebap='" + comboBox3.Text + "',Tatli='" + comboBox4.Text + "' WHERE masano='" + label1.Text + "'";
            frm1.kmt.ExecuteNonQuery();
            frm1.bag.Close();
            frm1.kmt.Dispose();
            frm1.dtst.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm1.bag.Open();
            frm1.kmt.Connection = frm1.bag;
            frm1.kmt.CommandText = "DELETE FROM siparis WHERE masano='" + label1.Text + "'";
            frm1.kmt.ExecuteNonQuery();
            frm1.bag.Close();
            frm1.kmt.Dispose();
            frm1.dtst.Clear();
            frm1.frm5.button2.BackColor = System.Drawing.Color.Green;
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm1.hesap.label3.Text = frm1.ms1.comboBox1.Text;
            frm1.hesap.label4.Text = frm1.ms1.comboBox2.Text;
            frm1.hesap.label5.Text = frm1.ms1.comboBox3.Text;
            frm1.hesap.label6.Text = frm1.ms1.comboBox4.Text;
            frm1.hesap.Show();
            this.Hide();
            frm1.hesap.label1.Text = "2";
        }
    }
}
