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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace entegre_otomasyonu
{
    public partial class kullanici_sil : Form
    {
        Form2 form2 = new Form2();
        public kullanici_sil()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=otomasyonEnd;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kullanici_sil_Load(object sender, EventArgs e)
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
            if (guna2TextBox1.Text == string.Empty|| guna2TextBox2.Text == string.Empty|| guna2TextBox3.Text == string.Empty)
            {
                hata = 1;
            }
            if (hata == 1)
            {
                MessageBox.Show("bütün alanları doldurunuz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "select * from kullanıcılar where ad ='" + guna2TextBox1.Text + "'";
                komut.CommandText = "select * from kullanıcılar where şifre ='" + guna2TextBox2.Text + "'";
                komut.CommandText = "select * from kullanıcılar where e_mail ='" + guna2TextBox3.Text + "'";
                komut.ExecuteNonQuery();
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand sil = new SqlCommand("delete from kullanıcılar where ad ='" + guna2TextBox1.Text + "'", baglanti);
                    SqlCommand sil2 = new SqlCommand("delete from kullanıcılar where şifre ='" + guna2TextBox2.Text + "'", baglanti);
                    SqlCommand sil3 = new SqlCommand("delete from kullanıcılar where e_mail ='" + guna2TextBox2.Text + "'", baglanti);
                    int basari = sil.ExecuteNonQuery();
                    baglanti.Close();

                    if (basari == 1)
                    {
                        MessageBox.Show("Kullanıcı başarıyla silindi");
                        guna2TextBox1.Clear();
                        guna2TextBox2.Clear();
                        guna2TextBox3.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı silinirken bir hata oluştu");
                        guna2TextBox2.Clear();
                        guna2TextBox1.Clear();
                        guna2TextBox3.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı bulunamadı");
                    guna2TextBox1.Clear();
                    guna2TextBox2.Clear();
                    guna2TextBox3.Clear();
                }
                baglanti.Close();

            }

            form2.Listele();
        }
    }
}
