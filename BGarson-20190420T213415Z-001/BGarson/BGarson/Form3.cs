using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BGarson
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string sifre = textBox2.Text;
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=PersonelTakip.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Personel where Kullanici_Adi='" + textBox1.Text + "' AND Sifre='" + textBox2.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                groupBox2.Visible = true;
                textBox1.Clear();
                textBox2.Clear();
                label5.Text = textBox1.Text;



            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
                textBox1.Clear();
                textBox2.Clear();

            }

            con.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            label5.Text = textBox1.Text;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
