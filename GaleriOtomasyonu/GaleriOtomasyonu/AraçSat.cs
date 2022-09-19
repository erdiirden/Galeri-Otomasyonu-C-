using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.OleDb;

namespace GaleriOtomasyonu
{
    public partial class AraçSat : DevExpress.XtraEditors.XtraForm
    {
        public AraçSat()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand komut;

        void griddoldur()
        {
            con = new SqlConnection("Data Source=DESKTOP-3FNKFQ4\\SQLEXPRESS;Initial Catalog=arac;Integrated Security=True");
            da = new SqlDataAdapter("Select *From AracListesi", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "AracListesi");
            dataGridView1.DataSource = ds.Tables["AracListesi"];
            con.Close();
        }

        void KayıtSil(string Plaka)
        {
            string sql = "DELETE FROM AracListesi WHERE Plaka=@Plaka";
            komut = new SqlCommand(sql, con);
            komut.Parameters.AddWithValue("@Plaka", Plaka);
            con.Open();
            komut.ExecuteNonQuery();
            con.Close();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AraçTablosu aractablosu = new AraçTablosu();
            aractablosu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AraçEkle aracekle = new AraçEkle();
            aracekle.Show();
            this.Hide();
        }

        private void AraçSat_Load(object sender, EventArgs e)
        {
            griddoldur();
       
            this.aracListesiTableAdapter.Fill(this.aracDataSet2.AracListesi);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            label3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            label4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            label5.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            label6.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            label7.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            label8.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            label9.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            label10.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            label11.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            label12.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            label13.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            label14.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            pictureBox1.Image = Image.FromFile(dataGridView1.CurrentRow.Cells[13].Value.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows) 
            {
                String Plaka = Convert.ToString(drow.Cells[0].Value);
                KayıtSil(Plaka);
                MessageBox.Show("Araç Satıldı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            griddoldur();
        }
    }
}