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
    public partial class Form1 : Form
    {
        public Form2 frm2;
        public Form3 frm3;
        public Form4 frm4;
        public Form5 frm5;
        public masa1 ms1;
        public masa2 ms2;
        public masa3 ms3;
        public masa4 ms4;
        public masa5 ms5;
        public masa6 ms6;
        public masa7 ms7;
        public masa8 ms8;
        public masa9 ms9;
        public masa10 ms10;
        public hesap hesap;
        public OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=PersonelTakip.accdb");
        public OleDbCommand kmt = new OleDbCommand();
        public OleDbDataAdapter adtr = new OleDbDataAdapter();
        public DataSet dtst = new DataSet();
        public void corba1()
        {
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select * from corba";
            OleDbDataReader oku;
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {

                ms1.comboBox1.Items.Add(oku[0].ToString());
                ms2.comboBox1.Items.Add(oku[0].ToString());
                ms3.comboBox1.Items.Add(oku[0].ToString());
                ms4.comboBox1.Items.Add(oku[0].ToString());
                ms5.comboBox1.Items.Add(oku[0].ToString());
                ms6.comboBox1.Items.Add(oku[0].ToString());
                ms7.comboBox1.Items.Add(oku[0].ToString());
                ms8.comboBox1.Items.Add(oku[0].ToString());
                ms9.comboBox1.Items.Add(oku[0].ToString());
                ms10.comboBox1.Items.Add(oku[0].ToString());
            }
            bag.Close();
            oku.Dispose();
            ms1.comboBox1.Sorted = true;
        }
        public void tatli1()
        {
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select * from Pide";
            OleDbDataReader oku;
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                ms1.comboBox2.Items.Add(oku[0].ToString());
                ms2.comboBox2.Items.Add(oku[0].ToString());
                ms3.comboBox2.Items.Add(oku[0].ToString());
                ms4.comboBox2.Items.Add(oku[0].ToString());
                ms5.comboBox2.Items.Add(oku[0].ToString());
                ms6.comboBox2.Items.Add(oku[0].ToString());
                ms7.comboBox2.Items.Add(oku[0].ToString());
                ms8.comboBox2.Items.Add(oku[0].ToString());
                ms9.comboBox2.Items.Add(oku[0].ToString());
                ms10.comboBox2.Items.Add(oku[0].ToString());
            }
            bag.Close();
            oku.Dispose();
            ms1.comboBox2.Sorted = true;
        }
        public void pide1()
        {
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select * from Kebap";
            OleDbDataReader oku;
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                ms1.comboBox3.Items.Add(oku[0].ToString());
                ms2.comboBox3.Items.Add(oku[0].ToString());
                ms3.comboBox3.Items.Add(oku[0].ToString());
                ms4.comboBox3.Items.Add(oku[0].ToString());
                ms5.comboBox3.Items.Add(oku[0].ToString());
                ms6.comboBox3.Items.Add(oku[0].ToString());
                ms7.comboBox3.Items.Add(oku[0].ToString());
                ms8.comboBox3.Items.Add(oku[0].ToString());
                ms9.comboBox3.Items.Add(oku[0].ToString());
                ms10.comboBox3.Items.Add(oku[0].ToString());
            }
            bag.Close();
            oku.Dispose();
            ms1.comboBox3.Sorted = true;
        }
        public void kebap1()
        {
            bag.Open();
            kmt.Connection = bag;
            kmt.CommandText = "Select * from Tatlı";
            OleDbDataReader oku;
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                ms1.comboBox4.Items.Add(oku[0].ToString());
                ms2.comboBox4.Items.Add(oku[0].ToString());
                ms3.comboBox4.Items.Add(oku[0].ToString());
                ms4.comboBox4.Items.Add(oku[0].ToString());
                ms5.comboBox4.Items.Add(oku[0].ToString());
                ms6.comboBox4.Items.Add(oku[0].ToString());
                ms7.comboBox4.Items.Add(oku[0].ToString());
                ms8.comboBox4.Items.Add(oku[0].ToString());
                ms9.comboBox4.Items.Add(oku[0].ToString());
                ms10.comboBox4.Items.Add(oku[0].ToString());
            }
            bag.Close();
            oku.Dispose();
            ms1.comboBox4.Sorted = true;
        }



        public Form1()
        {
            InitializeComponent();
            frm2 = new Form2();
            frm3 = new Form3();
            frm4 = new Form4();
            frm5 = new Form5();
            ms1 = new masa1();
            ms2 = new masa2();
            ms3 = new masa3();
            ms4 = new masa4();
            ms5 = new masa5();
            ms6 = new masa6();
            ms7 = new masa7();
            ms8 = new masa8();
            ms9 = new masa9();
            ms10 = new masa10();
            hesap = new hesap();
            frm2.frm1 = this;
            frm3.frm1 = this;
            frm4.frm1 = this;
            frm5.frm1 = this;
            ms1.frm1 = this;
            ms2.frm1 = this;
            ms3.frm1 = this;
            ms4.frm1 = this;
            ms5.frm1 = this;
            ms6.frm1 = this;
            ms7.frm1 = this;
            ms8.frm1 = this;
            ms9.frm1 = this;
            ms10.frm1 = this;
            hesap.frm1 = this;
        }

       
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 yeni = new Form2();
            yeni.Show();
            this.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();


        }
    }
}
