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
    public partial class AraçEkle : DevExpress.XtraEditors.XtraForm
    {
        public AraçEkle()
        {
            InitializeComponent();
        }
        
        




        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AraçTablosu aractablosu = new AraçTablosu();
            aractablosu.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AraçSat aracsat = new AraçSat();
            aracsat.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //başlangıç
            try
            {
                comboBox2.Items.Clear();
                if(comboBox1.SelectedIndex==0)
                {
                    comboBox2.Items.Add("Giulietta / 1.4 TB / MultiAir Distinctive");
                    comboBox2.Items.Add("Giulietta / 1.4 TB / Progression Plus");
                    comboBox2.Items.Add("Giulietta / 1.6 JTD / Distinctive");
                    comboBox2.Items.Add("Giulietta / 1.6 JTD / Progression Plus");
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    comboBox2.Items.Add("A3 / A3 Hatchback / 1.4 TFSI");
                    comboBox2.Items.Add("A3 / A3 Hatchback / 1.6");
                    comboBox2.Items.Add("A3 / A3 Hatchback / 1.6 TDI");
                    comboBox2.Items.Add("A3 / A3 Sedan / 35 TFSI");
                    comboBox2.Items.Add("A3 / A3 Sedan / 1.6 TDI");
                    comboBox2.Items.Add("A3 / A3 Sportback / 35 TFSI");
                    comboBox2.Items.Add("A3 / A3 Sportback / 1.4 TFSI");
                    comboBox2.Items.Add("A3 / A3 Sportback / 1.6");
                    comboBox2.Items.Add("A3 / A3 Sportback / 1.6 TDI");
                    comboBox2.Items.Add("A4 / A4 Sedan / 40 TDI");
                    comboBox2.Items.Add("A4 / A4 Sedan / 1.4 TFSI Design");
                    comboBox2.Items.Add("A4 / A4 Sedan / 1.6");
                    comboBox2.Items.Add("A4 / A4 Avant / 2.0 TDI");
                    comboBox2.Items.Add("A6 / A6 Sedan / 40 TDI");
                    comboBox2.Items.Add("A6 / A6 Sedan / 1.8 T");
                    comboBox2.Items.Add("A6 / A6 Sedan / 2.0 TDI");
                    comboBox2.Items.Add("A6 / A6 Sedan / 2.0 TDI Quattro");
                    comboBox2.Items.Add("A6 / A6 Avant / 2.5 TDI ");
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    comboBox2.Items.Add("3 Serisi / 316i / Standart");
                    comboBox2.Items.Add("3 Serisi / 316i / Comfort");
                    comboBox2.Items.Add("3 Serisi / 316i / M Sport");
                    comboBox2.Items.Add("3 Serisi / 320d / Standart");
                    comboBox2.Items.Add("3 Serisi / 320d / Comfort");
                    comboBox2.Items.Add("3 Serisi / 320d / Edition Comfort");
                    comboBox2.Items.Add("3 Serisi / 320d / M Sport");
                    comboBox2.Items.Add("3 Serisi / 320d / Premium");
                    comboBox2.Items.Add("3 Serisi / 320d / Techno Plus");
                    comboBox2.Items.Add("5 Serisi / 520d / Standart");
                    comboBox2.Items.Add("5 Serisi / 520d / Comfort");
                    comboBox2.Items.Add("5 Serisi / 520d / Exclusive");
                    comboBox2.Items.Add("5 Serisi / 520d / M Sport");
                    comboBox2.Items.Add("5 Serisi / 520d / Premium");
                    comboBox2.Items.Add("5 Serisi / 520i / Comfort");
                    comboBox2.Items.Add("5 Serisi / 520i / Executive");
                    comboBox2.Items.Add("5 Serisi / 520i / Executive M Sport");
                    comboBox2.Items.Add("5 Serisi / 520i / M Sport");
                    comboBox2.Items.Add("5 Serisi / 520i / Premium");
                    comboBox2.Items.Add("5 Serisi / 520i / Standart");
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    comboBox2.Items.Add("Aveo / 1.2 / LS");
                    comboBox2.Items.Add("Aveo / 1.2 / S");
                    comboBox2.Items.Add("Aveo / 1.2 / SE");
                    comboBox2.Items.Add("Aveo / 1.3 D / LS");
                    comboBox2.Items.Add("Aveo / 1.3 D / LT");
                    comboBox2.Items.Add("Aveo / 1.3 D / LTZ");
                    comboBox2.Items.Add("Aveo / 1.4 / LT");
                    comboBox2.Items.Add("Aveo / 1.4 / SE");
                    comboBox2.Items.Add("Aveo / 1.4 / LS");
                    comboBox2.Items.Add("Cruze / 1.6 / LS");
                    comboBox2.Items.Add("Cruze / 1.6 / LS PLUS");
                    comboBox2.Items.Add("Cruze / 1.6 / LT");
                    comboBox2.Items.Add("Cruze / 2.0 D / LT");
                    comboBox2.Items.Add("Cruze / 2.0 D / LTZ");
                }
                else if (comboBox1.SelectedIndex == 4)
                {
                    comboBox2.Items.Add("C3 / 1.4 HDi / Attraction");
                    comboBox2.Items.Add("C3 / 1.4 HDi / Confort");
                    comboBox2.Items.Add("C3 / 1.4 HDi / SX");
                    comboBox2.Items.Add("C3 / 1.2 PureTech / Feel");
                    comboBox2.Items.Add("C3 / 1.2 PureTech / Feel Bold");
                    comboBox2.Items.Add("C4 / 1.4 / SX");
                    comboBox2.Items.Add("C4 / 1.6 / SX");
                    comboBox2.Items.Add("C4 / 1.6 / SX PK");
                    comboBox2.Items.Add("C4 / 1.6 e-HDi / Confort");
                    comboBox2.Items.Add("C4 / 1.6 e-HDi / Confort Plus");
                    comboBox2.Items.Add("C4 / 1.6 HDi / Attraction");
                    comboBox2.Items.Add("C4 / 1.6 HDi / Confort");
                    comboBox2.Items.Add("C4 / 1.6 HDi / SX");
                }
                else if (comboBox1.SelectedIndex == 5)
                {
                    comboBox2.Items.Add("Sandero / 0.9 TCe / Stepway");
                    comboBox2.Items.Add("Sandero / 0.9 TCe / Stepway Easy-R");
                    comboBox2.Items.Add("Sandero / 1.5 dCi / Ambiance");
                    comboBox2.Items.Add("Sandero / 1.5 dCi / Stepway");
                }
                else if (comboBox1.SelectedIndex == 6)
                {
                    comboBox2.Items.Add("Egea / 1.3 Multijet / Easy");
                    comboBox2.Items.Add("Egea / 1.3 Multijet / Urban");
                    comboBox2.Items.Add("Egea / 1.3 Multijet / Urban Plus");
                    comboBox2.Items.Add("Egea / 1.4 Fire / Easy");
                    comboBox2.Items.Add("Egea / 1.4 Fire / Easy Plus");
                    comboBox2.Items.Add("Egea / 1.4 Fire / Urban");
                    comboBox2.Items.Add("Egea / 1.4 Fire / Urban Plus");
                    comboBox2.Items.Add("Egea / 1.6 Multijet / Comfort");
                    comboBox2.Items.Add("Egea / 1.6 Multijet / Easy");
                    comboBox2.Items.Add("Egea / 1.6 Multijet / Lounge");
                    comboBox2.Items.Add("Egea / 1.6 Multijet / Lounge Plus");
                    comboBox2.Items.Add("Egea / 1.6 Multijet / Urban");
                    comboBox2.Items.Add("Linea / 1.3 Multijet / Active Plus");
                    comboBox2.Items.Add("Linea / 1.3 Multijet / Pop");
                    comboBox2.Items.Add("Linea / 1.3 Multijet / Urban");
                    comboBox2.Items.Add("Linea / 1.4 Fire / Active Plus");
                    comboBox2.Items.Add("Linea / 1.4 Fire / Pop");
                    comboBox2.Items.Add("Linea / 1.6 Multijet / Emotion Plus");
                    comboBox2.Items.Add("Linea / 1.6 Multijet / Lounge");
                }
                else if (comboBox1.SelectedIndex == 7)
                {
                    comboBox2.Items.Add("Fiesta / 1.4 TDCi / Comfort");
                    comboBox2.Items.Add("Fiesta / 1.4 TDCi / Titanium X");
                    comboBox2.Items.Add("Fiesta / 1.4 / Comfort");
                    comboBox2.Items.Add("Fiesta / 1.4 / Titanium");
                    comboBox2.Items.Add("Fiesta / 1.5 TDCi / Trend");
                    comboBox2.Items.Add("Fiesta / 1.5 TDCi / Titanium X");
                    comboBox2.Items.Add("Focus / 1.6 / Ghia");
                    comboBox2.Items.Add("Focus / 1.6 / Comfort");
                    comboBox2.Items.Add("Focus / 1.6 / Ambiente");
                    comboBox2.Items.Add("Focus / 1.6 TDCi / Collection");
                    comboBox2.Items.Add("Focus / 1.6 TDCi / Ghia");
                    comboBox2.Items.Add("Focus / 1.6 TDCi / Titanium");
                    comboBox2.Items.Add("Focus / 1.6 TDCi / Trend");
                    comboBox2.Items.Add("Focus / 1.6 TDCi / Trend X");
                    comboBox2.Items.Add("Mondeo / 1.6 TDCi / Titanium");
                    comboBox2.Items.Add("Mondeo / 2.0 / Ghia");
                    comboBox2.Items.Add("Mondeo / 2.0 / GLX");
                    comboBox2.Items.Add("Mondeo / 2.0 TDCi / Titanium");
                    comboBox2.Items.Add("Mondeo / 2.0 TDCi / Trend");
                }
                else if (comboBox1.SelectedIndex == 8)
                {
                    comboBox2.Items.Add("Accord / 2.0 / Executive");
                    comboBox2.Items.Add("Civic / 1.6 / Elegance");
                    comboBox2.Items.Add("Civic / 1.6i VTEC / Elegance");
                    comboBox2.Items.Add("Civic / 1.6i VTEC / Eco Elegance");
                    comboBox2.Items.Add("Civic / 1.6i VTEC / Eco Executive");
                    comboBox2.Items.Add("Civic / 1.6 VTEC / Elegance");
                    comboBox2.Items.Add("Civic / 1.6 VTEC / Eco Elegance");
                    comboBox2.Items.Add("Civic / 1.6 VTEC / Eco Executive");
                    comboBox2.Items.Add("Jazz / 1.4 / Fun");
                    comboBox2.Items.Add("Jazz / 1.4 / ES");
                }
                else if (comboBox1.SelectedIndex == 9)
                {
                    comboBox2.Items.Add("i20 / 1.4 CRDi / Jump");
                    comboBox2.Items.Add("i20 / 1.4 CRDi / Style");
                    comboBox2.Items.Add("i20 / 1.4 MPI / Jump");
                    comboBox2.Items.Add("i20 / 1.4 MPI / Style");
                    comboBox2.Items.Add("i30 / 1.6 CRDi / Elite");
                }
                else if (comboBox1.SelectedIndex == 10)
                {
                    comboBox2.Items.Add("Rio / 1.4 CRDi / Fancy");
                    comboBox2.Items.Add("Rio / 1.5 CRDi / EX Comfort");
                }
                else if (comboBox1.SelectedIndex == 11)
                {
                    comboBox2.Items.Add("A Serisi / A 180 CDI / BlueEfficiency AMG");
                    comboBox2.Items.Add("A Serisi / A 180 d / AMG");
                    comboBox2.Items.Add("B Serisi / B 150 / Prestige");
                    comboBox2.Items.Add("CLA / 180 d / AMG");
                    comboBox2.Items.Add("CLA / 200 / AMG");
                    comboBox2.Items.Add("CLK / CLK 200 / Komp. Avantgarde");
                    comboBox2.Items.Add("C Serisi / C 180 / AMG 7G-Tronic");
                    comboBox2.Items.Add("C Serisi / C 180 / BlueEfficiency AMG");
                    comboBox2.Items.Add("C Serisi / C 200 d BlueTEC / AMG");
                    comboBox2.Items.Add("E Serisi / E 200 / Avantgarde");
                    comboBox2.Items.Add("S Serisi / S 400 / 400 d");
                    comboBox2.Items.Add("S Serisi / S 350 / BlueTEC 4Matic 7G-Tronic");
                }
                else if (comboBox1.SelectedIndex == 12)
                {
                    comboBox2.Items.Add("Cooper / 1.6 / Türkiye Paketi");
                    comboBox2.Items.Add("Cooper / 1.5 D / Chili");
                }
                else if (comboBox1.SelectedIndex == 13)
                {
                    comboBox2.Items.Add("Micra / 1.2 / Match");
                    comboBox2.Items.Add("Micra / 1.2 / Passion");
                }
                else if (comboBox1.SelectedIndex == 14)
                {
                    comboBox2.Items.Add("Astra / 1.3 CDTI / Cosmo");
                    comboBox2.Items.Add("Astra / 1.3 CDTI / Enjoy");
                    comboBox2.Items.Add("Astra / 1.6 / CD");
                    comboBox2.Items.Add("Astra / 1.6 / Edition");
                    comboBox2.Items.Add("Corsa / 1.3 CDTI / Essentia");
                    comboBox2.Items.Add("Corsa / 1.4 / GLS");
                    comboBox2.Items.Add("Insignia / 1.6 CDTI / Cosmo");
                    comboBox2.Items.Add("Insignia / 2.0 CDTI / Edition");
                }
                else if (comboBox1.SelectedIndex == 15)
                {
                    comboBox2.Items.Add("206 / 1.4 / Comfort");
                    comboBox2.Items.Add("206 / 1.4 / X-Line");
                    comboBox2.Items.Add("206 / 1.4 / XR");
                    comboBox2.Items.Add("206 / 1.4 HDi / X-Design");
                    comboBox2.Items.Add("206 / 1.4 HDi / X-Line");
                    comboBox2.Items.Add("207 / 1.4 / Trendy");
                    comboBox2.Items.Add("207 / 1.4 HDi  / Trendy");
                    comboBox2.Items.Add("307 / 1.4 HDi / XR");
                    comboBox2.Items.Add("307 / 1.6 / XR");
                }
                else if (comboBox1.SelectedIndex == 16)
                {
                    comboBox2.Items.Add("Clio / 1.2 / Authentique");
                    comboBox2.Items.Add("Clio / 1.5 dCi / Authentique");
                    comboBox2.Items.Add("Clio / 1.5 dCi / Touch");
                    comboBox2.Items.Add("Fluence / 1.5 dCi / Business");
                    comboBox2.Items.Add("Fluence / 1.5 dCi / Touch");
                    comboBox2.Items.Add("Megane / 1.5 dCi / Dynamique");
                    comboBox2.Items.Add("Megane / 1.5 dCi / Dynamique");
                    comboBox2.Items.Add("Megane / 1.6 / Dynamique");
                    comboBox2.Items.Add("Symbol / 1.2 / Authentique");
                    comboBox2.Items.Add("Symbol / 1.5 DCI / Authentique");
                    comboBox2.Items.Add("Symbol / 1.5 DCI / Joy");
                }
                else if (comboBox1.SelectedIndex == 17)
                {
                    comboBox2.Items.Add("Ibiza / 1.4 / Reference");
                    comboBox2.Items.Add("Leon / 1.4 TSI / FR");
                    comboBox2.Items.Add("Leon / 1.6 / Stylance");
                }
                else if (comboBox1.SelectedIndex == 18)
                {
                    comboBox2.Items.Add("Octavia / 1.6 TDI / Optimal");
                }
                else if (comboBox1.SelectedIndex == 19)
                {
                    comboBox2.Items.Add("Corolla / 1.4 D-4D / Elegant");
                    comboBox2.Items.Add("Corolla / 1.4 D-4D / Touch");
                    comboBox2.Items.Add("Corolla / 1.6 / XL");
                    comboBox2.Items.Add("Corolla / 1.6 / XLi");
                    comboBox2.Items.Add("Yaris / 1.0 / Terra");
                }
                else if (comboBox1.SelectedIndex == 20)
                {
                    comboBox2.Items.Add("Golf / 1.4 TSI / Comfortline");
                    comboBox2.Items.Add("Golf / 1.6 TDI / BlueMotion Comfortline");
                    comboBox2.Items.Add("Golf / 1.6 TDI / BlueMotion Highline");
                    comboBox2.Items.Add("Golf / 1.6 TDI / BlueMotion Midline Plus");
                    comboBox2.Items.Add("Polo / 1.2 TSI / Comfortline");
                    comboBox2.Items.Add("Polo / 1.4 TDI / Comfortline");
                    comboBox2.Items.Add("Polo / 1.4 TDI / Trendline");
                    comboBox2.Items.Add("Polo / 1.6 TDI / Comfortline");
                    comboBox2.Items.Add("Jetta / 1.4 TSI BlueMotion / Comfortline");
                    comboBox2.Items.Add("Jetta / 1.6 TDI / Comfortline");
                    comboBox2.Items.Add("Jetta / 1.6 TDI / Trendline");
                    comboBox2.Items.Add("Passat / 1.4 TSI BlueMotion / Comfortline");
                    comboBox2.Items.Add("Passat / 1.4 TSI BlueMotion / Trendline");
                    comboBox2.Items.Add("Passat / 1.6 TDI BlueMotion / Comfortline");
                    comboBox2.Items.Add("Passat / 1.6 TDI BlueMotion / Highline");
                }
                else if (comboBox1.SelectedIndex == 21)
                {
                    comboBox2.Items.Add("S40 / 1.6 D / Dynamic");
                    comboBox2.Items.Add("S60 / 1.6 D / Advance");
                    comboBox2.Items.Add("S60 / 1.6 D / Premium");
                }
                

            }
            catch { }
            //bitiş




        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            textBox5.Text = openFileDialog1.FileName;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection baglanti = new SqlConnection();
                baglanti.ConnectionString = "Data Source=DESKTOP-3FNKFQ4\\SQLEXPRESS;Initial Catalog=arac;Integrated Security=True";
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("insert into [AracListesi] (Plaka, Marka, Model, Yil, Yakit, Vites, KM, HpKw, Cekis, KasaTipi, Kapi, Renk, Hasar, Fotograf) values (@Plaka, @Marka, @Model, @Yil, @Yakit, @Vites, @KM, @HpKw, @Cekis, @KasaTipi, @Kapi, @Renk, @Hasar, @Fotograf)", baglanti);
                cmd.Parameters.AddWithValue("@Plaka", textBox1.Text);
                cmd.Parameters.AddWithValue("@Marka", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Model", comboBox2.Text);
                cmd.Parameters.AddWithValue("@Yil", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@Yakit", comboBox3.Text);
                cmd.Parameters.AddWithValue("@Vites", comboBox4.Text);
                cmd.Parameters.AddWithValue("@KM", textBox2.Text);
                cmd.Parameters.AddWithValue("@HpKw", textBox3.Text);
                cmd.Parameters.AddWithValue("@Cekis", comboBox5.Text);
                cmd.Parameters.AddWithValue("@KasaTipi", comboBox6.Text);
                cmd.Parameters.AddWithValue("@Kapi", comboBox7.Text);
                cmd.Parameters.AddWithValue("@Renk", comboBox8.Text);
                cmd.Parameters.AddWithValue("@Hasar", textBox4.Text);
                cmd.Parameters.AddWithValue("@Fotograf", textBox5.Text);
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Araç Listeye Eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch
            {
                MessageBox.Show("Araç Zaten Listeye Eklendi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}