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
using System.Net.Mail;

namespace GaleriOtomasyonu
{
    public partial class SifremiUnuttum : DevExpress.XtraEditors.XtraForm
    {

        public SifremiUnuttum()
        {
            InitializeComponent();
            
        }
        public static int kod;
        public static int dogrulamakodu;
        public static string kullanici;
        public static string mail;
        SqlConnection _Baglanti = new SqlConnection("Data Source=DESKTOP-3FNKFQ4\\SQLEXPRESS;Initial Catalog=arac;Integrated Security=True");
        SqlCommand _Komut = new SqlCommand();
        SqlDataReader _Okuyucu;


        private void SifremiUnuttum_Load(object sender, EventArgs e)
        {
            _Komut.Connection = _Baglanti;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _Baglanti.Open();
            _Komut.CommandText = "select * from Kullanici where Kullanici_Adi='" + textBox1.Text + "' and Mail='" + textBox2.Text + "'";
            _Okuyucu = _Komut.ExecuteReader();
            Random dogrulama = new Random();
            int kod = dogrulama.Next(100000, 999999);
            dogrulamakodu = kod;
            MailMessage eposta = new MailMessage();
            if (_Okuyucu.Read())
            {
                //Mail Gonderme
                eposta.From = new MailAddress("erdi.car@outlook.com");
                eposta.To.Add(textBox2.Text.ToString());
                eposta.Subject = "Şifre Değiştirme Onay Kodu";
                eposta.Body = "Doğrulama Kodunuz: " + kod;
                SmtpClient smtp = new SmtpClient();
                smtp.Credentials = new System.Net.NetworkCredential("erdi.car@outlook.com", "erdicar1903");
                smtp.Host = "smtp.live.com";
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.Send(eposta);

                Dogrulama dogrulamaekrani = new Dogrulama();
                dogrulamaekrani.Show();
                this.Hide();
                //Mail Gonderme
                kullanici = textBox1.Text;
                mail = textBox2.Text;
                MessageBox.Show("Şifre Değiştirme Onay Kodu Gonderildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı yada e posta adresi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            _Okuyucu.Close();
            _Baglanti.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}