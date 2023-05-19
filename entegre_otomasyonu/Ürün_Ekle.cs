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
using System.IO;
using Bunifu.UI.WinForms;
using Guna.UI2.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace entegre_otomasyonu
{
    public partial class Ürün_Ekle : Form
    {
        Form2 form2 = new Form2();
        public Ürün_Ekle()
        {
            InitializeComponent();

        }
        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=otomasyonEnd;Integrated Security=True");
        SqlCommand ekle;




        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {






        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {


        }

        public void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Ürün_Ekle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'otomasyonEndDataSet.Marketler' table. You can move, or remove it, as needed.
            this.marketlerTableAdapter.Fill(this.otomasyonEndDataSet.Marketler);

        }


        public void materialButton2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Select image(*.Jpg; *.png;*.Gif)|*.Jpg;.png;*.Gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                guna2TextBox12.Text = openFileDialog1.FileName;




            }
        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {



            ekle = new SqlCommand("INSERT INTO kategori (k_ürünadı,k_marka,k_ürünkategorisi,k_montajtipi,k_kılıf,k_regülatörtipi,k_çıkışakımı,k_girişgerilimi,k_çıkışgerilimi,k_çalışmasıcaklığı,k_rohs,k_imagefile,k_altkategori,k_kategori,k_fiyat,k_market) VALUES(@k_ürünadı,@k_marka,@k_ürünkategorisi,@k_montajtipi,@k_kılıf,@k_regülatörtipi,@k_çıkışakımı,@k_girişgerilimi,@k_çıkışgerilimi,@k_çalışmasıcaklığı,@k_rohs,@k_imagefile,@k_altkategori,@k_kategori,@k_fiyat,@k_market)", baglanti);
            ekle.Parameters.AddWithValue("@k_ürünadı", guna2TextBox1.Text);
            ekle.Parameters.AddWithValue("@k_marka", guna2TextBox2.Text);
            ekle.Parameters.AddWithValue("@k_ürünkategorisi", guna2TextBox3.Text);
            ekle.Parameters.AddWithValue("@k_montajtipi", guna2TextBox4.Text);
            ekle.Parameters.AddWithValue("@k_kılıf", guna2TextBox5.Text);
            ekle.Parameters.AddWithValue("@k_regülatörtipi", guna2TextBox6.Text);
            ekle.Parameters.AddWithValue("@k_çıkışakımı", guna2TextBox7.Text);
            ekle.Parameters.AddWithValue("@k_girişgerilimi", guna2TextBox8.Text);
            ekle.Parameters.AddWithValue("@k_çıkışgerilimi", guna2TextBox9.Text);
            ekle.Parameters.AddWithValue("@k_çalışmasıcaklığı", guna2TextBox10.Text);
            ekle.Parameters.AddWithValue("@k_rohs", guna2TextBox11.Text);
            ekle.Parameters.AddWithValue("@k_imagefile", guna2TextBox12.Text);
            ekle.Parameters.AddWithValue("@k_fiyat", guna2TextBox13.Text);
            ekle.Parameters.AddWithValue("@k_kategori", guna2ComboBox2.Text);
            ekle.Parameters.AddWithValue("@k_altkategori", guna2ComboBox1.Text);
            ekle.Parameters.AddWithValue("@k_market", guna2ComboBox3.Text);






            baglanti.Open();
            ekle.ExecuteNonQuery();



            baglanti.Close();
            MessageBox.Show("Ürün eklendi");
            form2.Listele();
            form2.load_data();
            form2.guna2DataGridView1.Update();
            form2.guna2DataGridView1.Refresh();




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (guna2ComboBox2.Text)
            {
                case "Güç Entegreleri":
                    guna2ComboBox1.Items.Add("Lineer Voltaj Regülatörleri Dip");
                    guna2ComboBox1.Items.Add("Lineer Voltaj Regülatörleri Smd");
                    guna2ComboBox1.Items.Add("DC DC Voltaj Regülatörleri Dip");
                    guna2ComboBox1.Items.Add("DC DC Voltaj_Regülatörleri Smd");
                    guna2ComboBox1.Items.Add("Güç Sürücü Entegreleri Dip");
                    guna2ComboBox1.Items.Add("Güç Sürücü Entegreleri Smd");
                    guna2ComboBox1.Items.Add("AC DC Çevirici ve Offline Switch Entegreleri");
                    guna2ComboBox1.Items.Add("DC DC Voltaj Kontrolörleri");
                    guna2ComboBox1.Items.Add("Voltage Reference Entegreleri");
                    guna2ComboBox1.Items.Add("Power Switch Entegreleri");
                    guna2ComboBox1.Items.Add("LED Display Sürücü Entegreleri");
                    guna2ComboBox1.Items.Add("Batarya Yönetimi Entegreler");
                    guna2ComboBox1.Items.Add("Akım Yönetimi Entegreleri");
                    guna2ComboBox1.Items.Add("DC DC Çevirici Entegreler");
                    guna2ComboBox1.Items.Add("Diğer Güç Yönetimi Entegreleri");
                    break;
                case "Logic Entegreler":
                    guna2ComboBox1.Items.Clear();
                    guna2ComboBox1.Items.Add("Hafıza Entegreleri Dip");
                    guna2ComboBox1.Items.Add("Hafıza Entegreleri Smd");
                    break;
                case "İnterface Entegreler":
                    guna2ComboBox1.Items.Clear();
                    guna2ComboBox1.Items.Add("Driver Reciever ve Transceiver Entegreleri Dip");
                    guna2ComboBox1.Items.Add("Driver Reciever ve Transceiver Entegreleri Smd");
                    guna2ComboBox1.Items.Add("Switch Entegreleri");

                    guna2ComboBox1.Items.Add("Analogtan Dijitale Dönüştürücü Entegreler");
                    guna2ComboBox1.Items.Add("Dijitalden Analoga Dönüştürücü Entegreler");
                    guna2ComboBox1.Items.Add("Arayüz Kontrolör Entegreleri");
                    guna2ComboBox1.Items.Add("Sensör ve Dönüştürücü Entegreler");
                    guna2ComboBox1.Items.Add("Sıra Transistör Entegreler");
                    guna2ComboBox1.Items.Add("Dijital İzolatör Entegreler");
                    guna2ComboBox1.Items.Add("IO_Expander Entegreler");
                    guna2ComboBox1.Items.Add("Dekoder Entegreleri");
                    guna2ComboBox1.Items.Add("Enkoder Entegreleri");
                    guna2ComboBox1.Items.Add("Telecom Entegreleri");
                    guna2ComboBox1.Items.Add("Dijital Potansiyometre_Entegreleri");
                    break;
                case "Lineer Entegreler":
                    guna2ComboBox1.Items.Clear();
                    guna2ComboBox1.Items.Add("Amplifikatör Entegreleri Dip");
                    guna2ComboBox1.Items.Add("Amplifikatör Entegreleri Smd");
                    guna2ComboBox1.Items.Add("Amplifikatör Ses Entegreleri");
                    guna2ComboBox1.Items.Add("Analog Komparatörler");


                    break;
                case "Optocoupler Entegreleri":
                    guna2ComboBox1.Items.Clear();

                    guna2ComboBox1.Items.Add("Logic Kapı ve Çevirici Entegreleri Dip");
                    guna2ComboBox1.Items.Add("Logic Kapı ve Çevirici Entegreleri Smd");
                    guna2ComboBox1.Items.Add("Buffer Driver Receiver ve Transceiver");
                    guna2ComboBox1.Items.Add("Signal Multiplexer Decoder Encoder");
                    guna2ComboBox1.Items.Add("Counter ve Dividers Entegreleri\r\n");
                    guna2ComboBox1.Items.Add("Shift Register Entegreleri");
                    guna2ComboBox1.Items.Add("Flip FlopEntegreleri");
                    guna2ComboBox1.Items.Add("Mandal Entegreleri");
                    guna2ComboBox1.Items.Add("Multivibratörler");
                    guna2ComboBox1.Items.Add("Translator Entegreleri");
                    break;
                case "Hafıza Entegreleri":
                    guna2ComboBox1.Items.Clear();

                    guna2ComboBox1.Items.Add("Transistör Çıkışlı Optokuplörler Dip");
                    guna2ComboBox1.Items.Add("Transistör Çıkışlı Optokuplörler Smd");
                    guna2ComboBox1.Items.Add("Triyak SCR Çıkışlı Optokuplörler");
                    guna2ComboBox1.Items.Add("Gate Sürücü_Optokuplörleri");
                    guna2ComboBox1.Items.Add("Logic Çıkışlı Optokuplörler");

                    break;
                case "Ses ve Video_Entegreleri":
                    guna2ComboBox1.Items.Clear();

                    guna2ComboBox1.Items.Add("Sıcaklık Sensörleri");
                    guna2ComboBox1.Items.Add("RF entegreleri");
                    guna2ComboBox1.Items.Add("Infrared Sensörleri");
                    guna2ComboBox1.Items.Add("Manyetik Sensörler");
                    guna2ComboBox1.Items.Add("Diğer Sensörler");

                    break;
                case "Zamanlama Entegreleri":
                    guna2ComboBox1.Items.Clear();

                    guna2ComboBox1.Items.Add("Ses Entegreleri");
                    guna2ComboBox1.Items.Add("Bir Defa_Programlanabilir Ses Entegreleri");
                    guna2ComboBox1.Items.Add("Ses Kayıt Entegreleri");
                    guna2ComboBox1.Items.Add("Video Entegreleri");

                    break;
                case "Entegre Sensörleri":
                    guna2ComboBox1.Items.Clear();

                    guna2ComboBox1.Items.Add("Programlanabilir Zamanlayıcı ve Osilatör Entegreleri");
                    guna2ComboBox1.Items.Add("Gerçek Zamanlı Saat Entegreleri");
                    guna2ComboBox1.Items.Add("Diğer Zaman Entegreleri");

                    break;
                case "Entegre Soketleri":
                    guna2ComboBox1.Items.Clear();


                    break;
                case "Diğer Entegreler":
                    guna2ComboBox1.Items.Clear();


                    break;

                default:
                    break;
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
