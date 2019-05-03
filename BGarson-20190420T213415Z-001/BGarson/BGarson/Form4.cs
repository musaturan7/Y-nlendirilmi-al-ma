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
    public partial class Form4 : Form
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        public Form4()
        {
            InitializeComponent();
        }
        void griddoldur()
        {
          con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=PersonelTakip.accdb");
            da = new OleDbDataAdapter("Select *from Personel", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Personel");
            dataGridView1.DataSource = ds.Tables["Personel"];
            con.Close();
        }
        void griddoldur2()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=PersonelTakip.accdb");
            da = new OleDbDataAdapter("Select *from Urun", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Urun");
            dataGridView2.DataSource = ds.Tables["Urun"];
            con.Close();
        }


        private void Form4_Load(object sender, EventArgs e)
        {
            griddoldur();
            griddoldur2();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into Personel (Adi,Soyadi,Kullanici_adi,Sifre,DoğumTarihi,Tc_kimlik_no,Adres) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','"+textBox5.Text+"','"+textBox6+"','"+textBox7.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
