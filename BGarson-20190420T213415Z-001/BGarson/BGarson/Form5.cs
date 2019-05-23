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
    public partial class Form5 : Form
    {
        public Form1 frm1;
        OleDbConnection con;
        OleDbDataAdapter da;
        
        DataSet ds;
        void griddoldur()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=PersonelTakip.accdb");
            da = new OleDbDataAdapter("Select *from Siparis", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Siparis");
            dataGridView1.DataSource = ds.Tables["Siparis"];
            con.Close();
        }
        public Form5()
        {
            InitializeComponent();
        }

        void islem(Object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            frm1.frm5.button2.BackColor = System.Drawing.Color.Green;//butonun arkaplan renginin yeşil olmasını sağlıyoruz
            frm1.frm5.button3.BackColor = System.Drawing.Color.Green;
            frm1.frm5.button4.BackColor = System.Drawing.Color.Green;
            frm1.frm5.button5.BackColor = System.Drawing.Color.Green;
            frm1.frm5.button6.BackColor = System.Drawing.Color.Green;
            frm1.frm5.button7.BackColor = System.Drawing.Color.Green;
            frm1.frm5.button8.BackColor = System.Drawing.Color.Green;
            frm1.frm5.button9.BackColor = System.Drawing.Color.Green;
            frm1.frm5.button10.BackColor = System.Drawing.Color.Green;
            frm1.frm5.button11.BackColor = System.Drawing.Color.Green;
            frm1.frm5.button1.BackColor = System.Drawing.Color.DarkOrange;
            griddoldur();
            frm1.corba1();
            frm1.tatli1();
            frm1.pide1();
            frm1.kebap1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            masa1 masa1 = new masa1();
            //this.Hide();
            masa1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm1.ms2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm1.ms3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm1.ms4.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm1.ms5.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frm1.ms6.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frm1.ms7.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frm1.ms8.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frm1.ms9.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frm1.ms10.Show();
        }
    }
}
