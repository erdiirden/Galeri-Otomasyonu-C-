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
    public partial class Dogrulama : DevExpress.XtraEditors.XtraForm
    {
        public Dogrulama()
        {
            InitializeComponent();
        }

        SqlConnection _Baglanti = new SqlConnection("Data Source=DESKTOP-3FNKFQ4\\SQLEXPRESS;Initial Catalog=arac;Integrated Security=True");
        SqlCommand _Komut = new SqlCommand();
        SqlDataReader _Okuyucu;

        private void Dogrulama_Load(object sender, EventArgs e)
        {
            _Komut.Connection = _Baglanti;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == SifremiUnuttum.dogrulamakodu.ToString())
            {
                _Baglanti.Open();
                _Komut.CommandText = "select * from Kullanici where Kullanici_Adi=@Kullanici_Adi and Mail=@Mail";
                _Komut.Parameters.AddWithValue("@Kullanici_Adi", SifremiUnuttum.kullanici);
                _Komut.Parameters.AddWithValue("@Mail", SifremiUnuttum.mail);
                _Okuyucu = _Komut.ExecuteReader();
                MailMessage eposta = new MailMessage();
                if (_Okuyucu.Read())
                {
                    //
                    
                    MailMessage epostaa = new MailMessage();


                    epostaa.From = new MailAddress("erdi.car@outlook.com");
                    epostaa.To.Add(_Okuyucu["Mail"].ToString());
                    epostaa.Subject = "Şifre Hatırlatma";
                    epostaa.Body = "Şifreniz: " + _Okuyucu["Sifre"].ToString();
                    SmtpClient smtp = new SmtpClient();
                    smtp.Credentials = new System.Net.NetworkCredential("erdi.car@outlook.com", "erdicar1903");
                    smtp.Host = "smtp.live.com";
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.Send(epostaa);
                    MessageBox.Show("Şifreniz mail adresinize gonderildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    _Baglanti.Close();
                    Form1 frm1 = new Form1();
                    frm1.Show();
                    this.Hide();

                }
                
            }
            else
            {
                MessageBox.Show("Doğrulama Başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}