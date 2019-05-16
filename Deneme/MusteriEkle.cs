using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme
{
    public partial class MusteriEkle : Form
    {
        public Banka bank;
        public MusteriEkle(Banka bank)
        {
            this.bank = bank;
            InitializeComponent();
        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            if (txtTc.Text.Length < 11)
            { MessageBox.Show("TC Kimlik numarası 11 haneden az girilemez!"); }
            else
            {
                if (rbBireysel.Checked == true)
                {
                    Random r = new Random();
                    BireyselMusteri bm = new BireyselMusteri();
                    bm.MusteriId = r.Next(1, 100);
                    bm.MusteriTur = "Bireysel Müşteri";
                    bm.Ad = txtAd.Text;
                    bm.Soyad = txtSoyad.Text;
                    bm.TCNo = Convert.ToInt64(txtTc.Text);
                    bank.MusteriEkle(bm);
                    MessageBox.Show("EKLEME BAŞARILI");

                }
                else if (rbTicari.Checked == true)
                {
                    Random r = new Random();
                    TicariMusteri tm = new TicariMusteri();
                    tm.MusteriId = r.Next(1, 100);
                    tm.MusteriTur = "Ticari Müşteri";
                    tm.Ad = txtAd.Text;
                    tm.Soyad = txtSoyad.Text;
                    tm.TCNo = Convert.ToInt64(txtTc.Text);
                    bank.MusteriEkle(tm);
                    MessageBox.Show("EKLEME BAŞARILI");
                }
                else
                {
                    MessageBox.Show("Müşteri tipini seçiniz!");
                }

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rbTicari_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
