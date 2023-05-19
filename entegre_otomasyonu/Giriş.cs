using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using ServiceStack;
using System.Data.SqlTypes;
using Google.Protobuf.WellKnownTypes;
using System.Data.Common;
using MySqlX.XDevAPI.Common;
using Kimtoo.DbContext;
using System.Security.Cryptography.X509Certificates;

namespace entegre_otomasyonu
{

    public partial class Giriş : Form
    {
        Form2 f2 = new Form2();

        int girisbasari = 1;

        
    
        public Giriş()
        {
            InitializeComponent();
            Init_Data();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=otomasyonEnd;Integrated Security=True");
       
        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Giriş_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
            
        {
            

            string adi = guna2TextBox1.Text;
            string şifree = guna2TextBox2.Text;
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM kullanıcılar WHERE ad = '" + adi + "' AND şifre ='" + şifree  + "'";
            
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            
            if (dr.Read())
            {
                Save_Data();
                f2.guna2Button2.Hide();
                f2.guna2Button3.Hide();

                if (adi == "admin" && şifree == "admin") {
                    f2.guna2Button2.Show();
                    f2.guna2Button3.Show();
                    
                }


               


                this.Hide();
                    
                    f2.Show();
                


            }
            else
            {
                MessageBox.Show("Hatali giris yaptiniz ");
                girisbasari = 0;

            }
            baglanti.Close();
            
        }
        public void Init_Data() {
            if (Properties.Settings.Default.userName!= string.Empty)
            {

                if (Properties.Settings.Default.Remember == true)
                {
                    guna2TextBox1.Text = Properties.Settings.Default.userName;
                    guna2TextBox2.Text = Properties.Settings.Default.Password;
                    guna2ToggleSwitch1.Checked = true;

                }
                else {

                    guna2TextBox1.Text = Properties.Settings.Default.userName;


                }

            } 
            


        }
        public void Save_Data() {

            if (guna2ToggleSwitch1.Checked)
            {
                Properties.Settings.Default.userName = guna2TextBox1.Text;
                Properties.Settings.Default.Password = guna2TextBox2.Text;
                Properties.Settings.Default.Remember = true;
                Properties.Settings.Default.Save();

            }
            else {
                Properties.Settings.Default.userName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Remember = false;
                Properties.Settings.Default.Save();



            }
        
        
        
        
        
        }





        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            pn_regis.Visible = true;
            guna2Transition1.ShowSync(pn_regis);
          
           
        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            pn_regis.Visible = false;
            guna2Transition1.HideSync(pn_regis);
            
        }

        public void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            int hata = 0;
            SqlCommand komut1 = new SqlCommand();         
            komut1.Connection = baglanti;
           
            komut1.CommandText = "SELECT * FROM kullanıcılar WHERE ad = '" + guna2TextBox4.Text + "' OR e_mail ='" + guna2TextBox7.Text + "'";
            komut1.ExecuteNonQuery();
            SqlDataReader drr = komut1.ExecuteReader();
            if (drr.Read())
            {
                hata = 3;

            }
            baglanti.Close();
            

            if (guna2TextBox4.Text == string.Empty)
                hata = 1;

            if (guna2TextBox3.Text == string.Empty)
                hata = 1;
            if (guna2TextBox5.Text == string.Empty)
                hata = 1;
            if (guna2TextBox6.Text == string.Empty)
                hata = 1;
            if (guna2TextBox7.Text == string.Empty)
                hata = 1;
            if (guna2TextBox3.Text != guna2TextBox5.Text)
                hata = 2;
            if (hata==0) {
                           
            }


           

            if (hata == 1)
            {
                MessageBox.Show("bütün alanları doldurunuz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                hata = 0;
                
            }
            else if (hata == 2)
            {
                MessageBox.Show("şifreler uyuşmuyor lütfen kontrol ediniz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                hata = 0;
               
            }

            else if (hata == 3) {

                
               MessageBox.Show("kullanıcı adı veya e_mail daha önce kullanılmış", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                hata = 0;
                
            }

            else
            {
                baglanti.Open();
                SqlCommand ekle = new SqlCommand("insert into kullanıcılar(ad,şifre,şifre_ipucu,e_mail)values('" + guna2TextBox4.Text + "','" + guna2TextBox3.Text + "','" + guna2TextBox6.Text + "','" + guna2TextBox7.Text + "')", baglanti);
                int basari = ekle.ExecuteNonQuery();             
                baglanti.Close();
                

                if (basari == 1)
                {
                    
                    MessageBox.Show("Kayit Eklendi");
                    
                 
                    pn_regis.Visible = false;
                    guna2Transition1.HideSync(pn_regis);
                    baglanti.Close();
                    



                }
                else
                {
                    MessageBox.Show("Kayit Eklenmedi");
                    
                    baglanti.Close();

                }
            }
            baglanti.Close();
           
        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

            if (guna2TextBox2.PasswordChar == '\0')
            {
                guna2ImageButton2.BringToFront();

                guna2TextBox2.PasswordChar = '*';

            }
        }
            private void guna2ImageButton2_Click(object sender, EventArgs e)
        {

                if (guna2TextBox2.PasswordChar == '*')
                {
                    guna2ImageButton1.BringToFront();

                    guna2TextBox2.PasswordChar = '\0';



                

            }
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            if (guna2TextBox3.PasswordChar == '\0' && guna2TextBox5.PasswordChar == '\0')
            {
                guna2ImageButton4.BringToFront();
                guna2TextBox3.PasswordChar = '*';
                guna2TextBox5.PasswordChar = '*';
            }
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            if (guna2TextBox3.PasswordChar == '*' && guna2TextBox5.PasswordChar == '*')
            {
                guna2ImageButton3.BringToFront();

                guna2TextBox3.PasswordChar = '\0';
                guna2TextBox5.PasswordChar = '\0';



            }
        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void pn_regis_VisibleChanged(object sender, EventArgs e)
        {
           
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pn_regis_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            
               

                
            
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            unuttum ut = new unuttum();
            ut.Show();
        }
    }
}
