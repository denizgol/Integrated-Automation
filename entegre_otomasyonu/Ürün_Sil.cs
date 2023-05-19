using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace entegre_otomasyonu
{
    public partial class Ürün_Sil : Form

    {
        Form2 form2= new Form2();
        public Ürün_Sil()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=otomasyonEnd;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            int hata = 0;
            if (guna2TextBox2.Text == string.Empty)
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
                komut.CommandText = "select * from kategori where k_id ='" + guna2TextBox2.Text + "'";
                komut.ExecuteNonQuery();
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand sil = new SqlCommand("delete from kategori where k_id ='" + guna2TextBox2.Text + "'", baglanti);
                    int basari = sil.ExecuteNonQuery();
                    baglanti.Close();

                    if (basari == 1)
                    {
                        MessageBox.Show("Ürün silindi");
                        form2.Listele();
                        guna2TextBox2.Clear();
                        form2.Listele();
                    }
                    else
                    {
                        MessageBox.Show("Ürün silinmedi");

                    }
                }
                else
                {
                    MessageBox.Show("böyle bir ürün yok");
                    guna2TextBox2.Clear();
                }
                baglanti.Close();

            }
            
            form2.Listele();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Ürün_Sil_Load(object sender, EventArgs e)
        {

        }
    }
}

