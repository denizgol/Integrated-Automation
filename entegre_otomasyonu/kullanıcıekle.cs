using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entegre_otomasyonu
{
    public partial class kullanıcıekle : Form
    {
        public kullanıcıekle()
        {
            InitializeComponent();
        }
            SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=otomasyonEnd;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)

        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kullanıcıekle_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            int hata = 0;
            if (guna2TextBox1.Text == string.Empty)
                hata = 1;
            if (guna2TextBox2.Text == string.Empty)
                hata = 1;
            if (guna2TextBox3.Text == string.Empty)
                hata = 1;


            if (hata == 1)
            {
                MessageBox.Show("bütün alanları doldurunuz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                baglanti.Open();
                SqlCommand ekle = new SqlCommand("insert into kullanıcılar(ad,şifre,e_mail)values('" + guna2TextBox1.Text + "','" + guna2TextBox2.Text + "','" + guna2TextBox3.Text + "')", baglanti);
                int basari = ekle.ExecuteNonQuery();
                baglanti.Close();
                if (basari == 1)
                {
                    MessageBox.Show("Kayit Eklendi");
                    Close();
                }
                else
                {
                    MessageBox.Show("Kayit Eklenmedi");
                }
            }
        }
    }
}
