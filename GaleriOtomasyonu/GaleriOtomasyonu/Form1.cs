using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GaleriOtomasyonu
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
                MessageBox.Show("Giriş Başarılı...", "Giriş", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                AraçTablosu aractablosu = new AraçTablosu();
                aractablosu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifreniz hatalı...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();

           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifremiUnuttum sifremiunuttum = new SifremiUnuttum();
            sifremiunuttum.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KullaniciKayit kullanicikayit = new KullaniciKayit();
            kullanicikayit.Show();
            this.Hide();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.CheckState==CheckState.Checked)
            {
                textBox2.UseSystemPasswordChar = true;
                checkBox1.Text = "Gizle";
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                textBox2.UseSystemPasswordChar = false;
                checkBox1.Text = "Goster";
            }
        }
    }
}
