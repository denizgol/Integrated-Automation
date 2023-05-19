using Bunifu.UI.WinForms;
using FontAwesome.WinForms;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static ServiceStack.Script.Lisp;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace entegre_otomasyonu
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();

        }


        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=otomasyonEnd;Integrated Security=True");
        //SqlCommand ekle;




        public void load_data() { }



        private void Form2_Load(object sender, EventArgs e)
        {

            Listele();




        }




        public void Listele()
        {
            try
            {

                DataSet ds = new DataSet();
                SqlDataAdapter ad = new SqlDataAdapter("select * from kategori", baglanti);
                ad.Fill(ds);
                guna2DataGridView1.DataSource = ds.Tables[0];

                guna2DataGridView1.Columns[0].Visible = true;
                guna2DataGridView1.Columns[4].Visible = false;
                guna2DataGridView1.Columns[5].Visible = false;
                guna2DataGridView1.Columns[6].Visible = false;
                guna2DataGridView1.Columns[7].Visible = false;
                guna2DataGridView1.Columns[8].Visible = false;
                guna2DataGridView1.Columns[9].Visible = false;
                guna2DataGridView1.Columns[10].Visible = false;
                guna2DataGridView1.Columns[11].Visible = false;
                guna2DataGridView1.Columns[12].Visible = false;

                
                guna2DataGridView1.Columns[1].HeaderText = "id";
                guna2DataGridView1.Columns[2].HeaderText = "ürünadı";
                guna2DataGridView1.Columns[3].HeaderText = "marka";
                guna2DataGridView1.Columns[4].HeaderText = "ürünkategorisi";
                guna2DataGridView1.Columns[5].HeaderText = "montajtipi";
                guna2DataGridView1.Columns[6].HeaderText = "kılıf";
                guna2DataGridView1.Columns[7].HeaderText = "regülatörtipi";
                guna2DataGridView1.Columns[8].HeaderText = "çıkışakımı";
                guna2DataGridView1.Columns[9].HeaderText = "girişgerilimi";
                guna2DataGridView1.Columns[10].HeaderText = "çıkışgerilimi";
                guna2DataGridView1.Columns[11].HeaderText = "çalışmasıcaklığı";
                guna2DataGridView1.Columns[12].HeaderText = "rohs";
                guna2DataGridView1.Columns[13].HeaderText = "altkategori";
                guna2DataGridView1.Columns[14].HeaderText = "kategori";
                guna2DataGridView1.Columns[15].HeaderText = "market";
                guna2DataGridView1.Columns[16].HeaderText = "fiyat";
                guna2DataGridView1.Columns[17].HeaderText = "imagefile";



            }
            catch (SqlException edf)
            {
                MessageBox.Show("Hata oluştu=>" + edf.Message, "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                baglanti.Close();

            }





        }

        private void side1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sidetimer1_Tick(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {

            Ürün_Ekle üe = new Ürün_Ekle();
            üe.Show();

        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            Ürün_Sil üs = new Ürün_Sil();
            üs.Show();
        }

        private void guna2ImageButton6_Click(object sender, EventArgs e)
        {
            kullanıcıekle ke = new kullanıcıekle();
            ke.Show();
        }

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {
            kullanici_sil ks = new kullanici_sil();
            ks.Show();
        }



        public void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton7_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    int hata = 0;
                    if (guna2TextBox1.Text == string.Empty)
                        hata = 1;
                    if (guna2TextBox1.Text == string.Empty)
                        hata = 1;

                    if (hata == 1)
                    {
                        MessageBox.Show("bütün alanları doldurunuz", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        baglanti.Open();
                       SqlCommand komut = new SqlCommand("select * from kategori where k_id like '%" + guna2TextBox1.Text + "%' OR k_ürünadı like '%" + guna2TextBox1.Text + "%' ", baglanti);
                        
                        SqlDataAdapter da = new SqlDataAdapter(komut);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                       

                       
                        guna2DataGridView1.DataSource = ds.Tables[0];
                        baglanti.Close();
                        guna2TextBox1.Clear();
                    }

                }


            }
            catch
            {

                Listele();

            }
        }

        public void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2ImageButton8_Click(object sender, EventArgs e)
        {

            Listele();



        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        public void guna2Button2_Click_2(object sender, EventArgs e)
        {
            Ürün_Ekle üe = new Ürün_Ekle();
            üe.Show();
        }

        public void guna2Button3_Click(object sender, EventArgs e)
        {
            Ürün_Sil üs = new Ürün_Sil();
            üs.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            Giriş gr = new Giriş();
            gr.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            kullanici_sil ks = new kullanici_sil();
            ks.Show();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {


            guna2DataGridView1.Show();
            guna2Button1.SendToBack();
            guna2Button7.BringToFront();


        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            guna2DataGridView1.Hide();
            guna2Button1.BringToFront();
            guna2Button7.SendToBack();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            ürün_güncelle üg = new ürün_güncelle();
            üg.Show();
        }









        private void guna2DataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            ürün_getir üg = new ürün_getir();

            Int32 selectedColumnCount = guna2DataGridView1.Columns.GetColumnCount(DataGridViewElementStates.Selected);
            foreach (DataGridViewCell cell in guna2DataGridView1.SelectedCells)
            {
                String a = cell.ToString();
            }

            if (true)
            {

                üg.Show();




                if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {

                    String id_tutucu = guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    üg.guna2TextBox14.Text = id_tutucu;
                }
            }


        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (guna2ComboBox1.Text)
            {
                case "Fiyata göre artan":

                    guna2DataGridView1.Sort(guna2DataGridView1.Columns[16], ListSortDirection.Ascending);
                    break;


                case "Fiyata göre azalan":
                    guna2DataGridView1.Sort(guna2DataGridView1.Columns[16], ListSortDirection.Descending);
                    
                    break;

                default:
                    break;
            }
        }
    }
}
