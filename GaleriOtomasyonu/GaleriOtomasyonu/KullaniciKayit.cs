using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace GaleriOtomasyonu
{
    public partial class KullaniciKayit : DevExpress.XtraEditors.XtraForm
    {
        public KullaniciKayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dr;
            string sorgu = "SELECT * FROM Kullanici where Kullanici_Adi=@Kullanici_Adi AND Sifre=@Sifre";
            con = new SqlConnection("Data Source=DESKTOP-3FNKFQ4\\SQLEXPRESS;Initial Catalog=arac;Integrated Security=True");
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@Kullanici_Adi", textBox1.Text);
            cmd.Parameters.AddWithValue("@Sifre", textBox2.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //
                try
                {
                    SqlConnection baglanti = new SqlConnection();
                    baglanti.ConnectionString = "Data Source=DESKTOP-3FNKFQ4\\SQLEXPRESS;Initial Catalog=arac;Integrated Security=True";
                    baglanti.Open();
                    SqlCommand cmdd = new SqlCommand("insert into [Kullanici] (Kullanici_Adi, Sifre, Mail) values (@Kullanici_Adi, @Sifre, @Mail)", baglanti);
                    cmdd.Parameters.AddWithValue("@Kullanici_Adi", textBox3.Text);
                    cmdd.Parameters.AddWithValue("@Sifre", textBox4.Text);
                    cmdd.Parameters.AddWithValue("@Mail", textBox5.Text);
                    cmdd.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kullanıcı Eklendi","Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch
                {
                    MessageBox.Show("Kullanıcı Daha Onceden Zaten Eklendi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifreniz hatalı...","Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                textBox2.UseSystemPasswordChar = true;
                textBox4.UseSystemPasswordChar = true;
                checkBox1.Text = "Gizle";
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                textBox2.UseSystemPasswordChar = false;
                textBox4.UseSystemPasswordChar = false;
                checkBox1.Text = "Goster";
            }
        }
    }
}