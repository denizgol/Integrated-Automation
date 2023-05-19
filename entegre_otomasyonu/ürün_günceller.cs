using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace entegre_otomasyonu
{
    public partial class ürün_güncelle : Form                //text13 ürünid diğerleri 1 den 12 ye sıralı
    {
        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=otomasyonEnd;Integrated Security=True");

        public ürün_güncelle()
        {
            InitializeComponent();
        }

        public void materialButton1_Click(object sender, EventArgs e)

        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Select image(*.Jpg; *.png;*.Gif)|*.Jpg;.png;*.Gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                guna2TextBox12.Text = openFileDialog1.FileName;



            }



        }
        private void materialButton2_Click(object sender, EventArgs e)  //güncelleme butonu
        {
            int hata = 0;

            if (guna2TextBox1.Text == string.Empty)
            {
                hata = 1;
            }
            if (guna2TextBox2.Text == string.Empty)
            {
                hata = 1;
            }
            if (guna2TextBox3.Text == string.Empty)
            {
                hata = 1;
            }
            if (guna2TextBox4.Text == string.Empty)
            {
                hata = 1;
            }
            if (guna2TextBox5.Text == string.Empty)
            {
                hata = 1;
            }
            if (guna2TextBox6.Text == string.Empty)
            {
                hata = 1;
            }
            if (guna2TextBox7.Text == string.Empty)
            {
                hata = 1;
            }
            if (guna2TextBox8.Text == string.Empty)
            {
                hata = 1;
            }
            if (guna2TextBox9.Text == string.Empty)
            {
                hata = 1;
            }
            if (guna2TextBox10.Text == string.Empty)
            {
                hata = 1;
            }
            if (guna2TextBox11.Text == string.Empty)
            {
                hata = 1;
            }
            if (guna2TextBox12.Text == string.Empty)
            {
                hata = 1;
            }
            if (hata == 1)
            {
                MessageBox.Show("alanları doldurun", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("update kategori set k_ürünadı ='"+ guna2TextBox1.Text+ "',k_marka ='"+ guna2TextBox1.Text+"' where k_id = @k_id",baglanti);
                cmd.Parameters.AddWithValue("@k_id", int.Parse(guna2TextBox14.Text));
                //cmd.Parameters.AddWithValue("@k_ürünadı", guna2TextBox1.Text);
                //cmd.Parameters.AddWithValue("@k_marka", guna2TextBox2.Text);
                //cmd.Parameters.AddWithValue("@k_ürünkategorisi", guna2TextBox3.Text);
                //cmd.Parameters.AddWithValue("@k_montajtipi", guna2TextBox4.Text);
                //cmd.Parameters.AddWithValue("@k_kılıf", guna2TextBox5.Text);
                //cmd.Parameters.AddWithValue("@k_regülatörtipi", guna2TextBox6.Text);
                //cmd.Parameters.AddWithValue("@k_çıkışakımı", guna2TextBox7.Text);
                //cmd.Parameters.AddWithValue("@k_girişgerilimi", guna2TextBox8.Text);
                //cmd.Parameters.AddWithValue("@k_çıkışgerilimi", guna2TextBox9.Text);
                //cmd.Parameters.AddWithValue("@k_çalışmasıcaklığı", guna2TextBox10.Text);
                //cmd.Parameters.AddWithValue("@k_rohs", guna2TextBox11.Text);
                //cmd.Parameters.AddWithValue("@k_imagefile", guna2TextBox12.Text);
                //cmd.Parameters.AddWithValue("@k_fiyat", guna2TextBox13.Text);
                //cmd.Parameters.AddWithValue("@k_altkategori", guna2TextBox15.Text);
                //cmd.Parameters.AddWithValue("@k_kategori", guna2TextBox16.Text);
                //cmd.Parameters.AddWithValue("@k_market", guna2TextBox17.Text);



                 int basari = cmd.ExecuteNonQuery();
               
                baglanti.Close();
                if (basari == 1)
                {
                    MessageBox.Show("kayit güncellendi");
                    Form2 f2 = new Form2();
                    f2.Listele();
                    guna2TextBox1.Clear();
                    guna2TextBox2.Clear();
                    guna2TextBox3.Clear();
                    guna2TextBox4.Clear();
                    guna2TextBox5.Clear();
                    guna2TextBox6.Clear();
                    guna2TextBox7.Clear();
                    guna2TextBox8.Clear();
                    guna2TextBox9.Clear();
                    guna2TextBox10.Clear();
                    guna2TextBox11.Clear();
                    guna2TextBox12.Clear();
                    guna2TextBox13.Clear();
                    guna2TextBox14.Clear();
                    guna2TextBox15.Clear();
                    guna2TextBox16.Clear();
                    guna2TextBox17.Clear();
                }
                else
                {
                    MessageBox.Show("kayit güncellenmedi");
                    guna2TextBox1.Clear();
                    guna2TextBox2.Clear();
                    guna2TextBox3.Clear();
                    guna2TextBox4.Clear();
                    guna2TextBox5.Clear();
                    guna2TextBox6.Clear();
                    guna2TextBox7.Clear();
                    guna2TextBox8.Clear();
                    guna2TextBox9.Clear();
                    guna2TextBox10.Clear();
                    guna2TextBox11.Clear();
                    guna2TextBox12.Clear();
                    guna2TextBox13.Clear();
                    guna2TextBox14.Clear();
                    guna2TextBox15.Clear();
                    guna2TextBox16.Clear();
                    guna2TextBox17.Clear();
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void ürün_günceller_Load(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)   //arama butonu
        {




            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=otomasyonEnd;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string selectSql = "select * from kategori where k_id like '%" + guna2TextBox14.Text + "%' ";
                using (SqlCommand command = new SqlCommand(selectSql, connection))
                {
                    command.Parameters.AddWithValue("@k_id", "k_id");

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {



                            guna2TextBox1.Text = reader.GetValue(1).ToString();
                            guna2TextBox2.Text = reader.GetValue(2).ToString();
                            guna2TextBox3.Text = reader.GetValue(3).ToString();

                            guna2TextBox4.Text = reader.GetValue(4).ToString();
                            guna2TextBox5.Text = reader.GetValue(5).ToString();
                            guna2TextBox6.Text = reader.GetValue(6).ToString();
                            guna2TextBox7.Text = reader.GetValue(7).ToString();
                            guna2TextBox8.Text = reader.GetValue(8).ToString();
                            guna2TextBox9.Text = reader.GetValue(9).ToString();
                            guna2TextBox10.Text = reader.GetValue(10).ToString();
                            guna2TextBox11.Text = reader.GetValue(11).ToString();
                            guna2TextBox15.Text = reader.GetValue(12).ToString();
                            guna2TextBox16.Text = reader.GetValue(13).ToString();
                            guna2TextBox12.Text = reader.GetValue(16).ToString();
                            guna2TextBox13.Text = reader.GetValue(15).ToString();
                            guna2TextBox17.Text = reader.GetValue(14).ToString();












                        }


                    }
                }

            }






        }

        private void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Clear();
            guna2TextBox2.Clear();
            guna2TextBox3.Clear();
            guna2TextBox4.Clear();
            guna2TextBox5.Clear();
            guna2TextBox6.Clear();
            guna2TextBox7.Clear();
            guna2TextBox8.Clear();
            guna2TextBox9.Clear();
            guna2TextBox10.Clear();
            guna2TextBox11.Clear();
            guna2TextBox12.Clear();
            guna2TextBox13.Clear();
            guna2TextBox14.Clear();
            guna2TextBox15.Clear();
            guna2TextBox16.Clear();
            guna2TextBox17.Clear();
        }

        private void guna2TextBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

