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
    public partial class ürün_getir : Form
    {
        public ürün_getir()
        {
            InitializeComponent();

            Form2 form2= new Form2();


            









        }

        private void ürün_getir_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=otomasyonEnd;Integrated Security=True");
        }

        private void guna2TextBox14_TextChanged(object sender, EventArgs e)
        {

        }

        public void guna2Button1_Click(object sender, EventArgs e)
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

        private void materialButton2_Click(object sender, EventArgs e)
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

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
