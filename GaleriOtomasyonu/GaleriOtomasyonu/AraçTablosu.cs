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

namespace GaleriOtomasyonu
{
    public partial class AraçTablosu : DevExpress.XtraEditors.XtraForm
    {
        public AraçTablosu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AraçEkle aracekle = new AraçEkle();
            aracekle.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AraçSat aracsat = new AraçSat();
            aracsat.Show();
            this.Hide();
        }

        private void AraçTablosu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aracDataSet1.AracListesi' table. You can move, or remove it, as needed.
            this.aracListesiTableAdapter.Fill(this.aracDataSet1.AracListesi);

        }
    }
}