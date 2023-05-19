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
    public partial class unuttum : Form
    {
        Form2 form2 = new Form2();
        public unuttum()
        {
            InitializeComponent();
            
        }

        private void unuttum_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=otomasyonEnd;Integrated Security=True");
            int hata = 0;
            if (guna2TextBox1.Text == string.Empty || guna2TextBox2.Text == string.Empty || guna2TextBox3.Text == string.Empty)
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
                komut.CommandText = "select * from kullanıcılar where şifre_ipucu ='" + guna2TextBox4.Text + "'";
                komut.CommandText = "select * from kullanıcılar where e_mail ='" + guna2TextBox3.Text + "'";
                komut.CommandText = "select * from kullanıcılar where şifre ='" + guna2TextBox2.Text + "'";
                komut.ExecuteNonQuery();
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    baglanti.Close();
                    baglanti.Open();
                   
                    SqlCommand sil = new SqlCommand("update kullanıcılar set şifre ='" + guna2TextBox2.Text + "'", baglanti);
                    int basari = sil.ExecuteNonQuery();
                    baglanti.Close();

                    if (basari == 1)
                    {
                        MessageBox.Show("Kullanıcı başarıyla güncellendi");
                        guna2TextBox1.Clear();
                        guna2TextBox2.Clear();
                        guna2TextBox3.Clear();
                        guna2TextBox4.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı güncellenirken bir hata oluştu");
                        guna2TextBox2.Clear();
                        guna2TextBox1.Clear();
                        guna2TextBox3.Clear();
                        guna2TextBox4.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı bulunamadı");
                    guna2TextBox1.Clear();
                    guna2TextBox2.Clear();
                    guna2TextBox3.Clear();
                    guna2TextBox4.Clear();
                }
                baglanti.Close();

            }

            form2.Listele();
        }
    }
}
