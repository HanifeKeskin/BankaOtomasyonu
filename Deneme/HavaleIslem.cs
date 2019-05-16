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
    public partial class HavaleIslem : Form
    {
        public Banka bank;
       

        public HavaleIslem(Banka bank)
        {
            this.bank = bank;
            InitializeComponent();
        }

        

        private void HavaleIslem_Load(object sender, EventArgs e)
        {

        }

        public decimal GonderenHesap { get; set; }
        public decimal AliciHesap { get; set; }
        
        long GondericiTC, AliciTc ;
        private void btnGonder_Click(object sender, EventArgs e)
        {
            decimal tutar = Convert.ToDecimal(txtTutar.Text);
            decimal gonderen = Convert.ToDecimal(txtGonderen.Text);
            decimal alici = Convert.ToDecimal(txtAlici.Text);

            int sayac = 0;
            foreach (var item in bank.Musteriler)
            {
                foreach (var d in bank.Hesaplar)
                {
                    if(d.HesapNo == gonderen)
                    {
                        sayac += 1;
                        GondericiTC = item.TCNo;
                    }
                    else if (d.HesapNo == alici)
                    {
                        sayac += 1;
                        AliciTc = item.TCNo;
                    }

               }
                    if ( AliciTc == GondericiTC && sayac == 2)
                {

                    foreach (var b in bank.Hesaplar)
                    {
                        if (b.HesapNo == gonderen)
                        {
                            b.Bakiye -= Convert.ToInt32(txtTutar.Text);
                        }
                        else if  (b.HesapNo == alici)
                        {
                            b.Bakiye += Convert.ToInt32(txtTutar.Text);
                        }
                        MessageBox.Show("İŞLEM BAŞARIYLA GERÇEKLEŞTİ !!!");
                    }
                    sayac = 3;
                }

            }
                    if (sayac == 2 && GondericiTC != AliciTc)
            {
                foreach ( var item2 in bank.Musteriler)
                {
                    foreach (var b in bank.Hesaplar )
                    {
                        if(b.HesapNo == gonderen)
                        {
                            b.Bakiye -= Convert.ToInt32(txtTutar.Text);
                        }
                        else if (b.HesapNo == alici)
                        {
                            b.Bakiye += Convert.ToInt32(txtTutar.Text);
                        }
                        MessageBox.Show("İŞLEMİNİZ BAŞARIYLA GERÇEKLEŞTİ !!!");
                        break;

                    }
                }
            }
        }

    }
}
