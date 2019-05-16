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
       


        private void Form4_Load(object sender, EventArgs e)
        {
            griddoldur();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into Personel (Adi,Soyadi,Kullanici_adi,Sifre,DoğumTarihi,Email,Tc_kimlik_no,GirişTarihi,Adres) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + dateTimePicker1.Value + "','" + textBox6.Text + "','" + textBox5.Text + "','" + dateTimePicker2.Value + "','" + textBox7.Text + "')";
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
            this.Hide();  }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update Personel set Adi='" + textBox1.Text + "',Soyadi='" + textBox2.Text + "',Sifre='" + textBox4.Text + "',DogumTarihi='" + dateTimePicker1.Value + "',Email='" + textBox6.Text + "',Tc_kimlik_no='" + textBox5.Text + "',GirişTarihi='" +dateTimePicker2.Value+ "',Adres='" +textBox7.Text+ "' where Kullanici_Adi=" + textBox3.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from Personel where Kullanici_adi=" + textBox8.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            textBox6.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }
    }
    }
    

