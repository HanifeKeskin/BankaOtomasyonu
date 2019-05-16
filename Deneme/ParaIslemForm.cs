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
    public partial class ParaIslemForm : Form
    {
        public static long HesapNo;
        public static decimal Bakiye=0;

        Banka bank = new Banka();
        Hesap h = new Hesap();
        public ParaIslemForm(Banka bank)
        {
            this.bank = bank;
            InitializeComponent();
        }
        private void btnİslemYap_Click(object sender, EventArgs e)
        { HesapNo = h.HesapNo;
            Bakiye = h.Bakiye;
            decimal tutar = Convert.ToInt32(txtTutar.Text);
            DialogResult x = new DialogResult();
            decimal dusulenTutar;


           {
                
                foreach (var a in bank.Hesaplar)
                {
                    if (Convert.ToInt32(txtHesapNo.Text) == a.HesapNo)
                    {
                        if (rbParaYatırma.Checked == true)
                        {                          
                            a.Bakiye += tutar;

                            MessageBox.Show("Mevcut Bakiyeniz :" + a.Bakiye);
                        }
                        else if (rbParaCekme.Checked == true)
                        {
                            if ( tutar<= bank.gunlukParaCekmeLimiti)
                            {
                                if (a.Bakiye>=tutar)
                                {
                                    a.Bakiye -= tutar;
                                    bank.gunlukParaCekmeLimiti -= tutar;
                                    MessageBox.Show("Mevcut Bakiyeniz :" + a.Bakiye);
                                    
                                }
                                if (a.Bakiye<tutar)
                                {
                                    x = MessageBox.Show("Yeterli Para Bulunamadı Ek Hesaptan Çekilsin mi?","DİKKAT",MessageBoxButtons.YesNo);
                                    if (x==DialogResult.Yes)
                                    {
                                        dusulenTutar = tutar - a.Bakiye;
                                        bank.gunlukParaCekmeLimiti -= tutar;
                                        a.EkHesap -= dusulenTutar;
                                        a.Bakiye = 0;
                                    }
                                    else if (x==DialogResult.No)
                                    {
                                        break;
                                    }

                                }


                            }
               
                            else 
                            {
                                MessageBox.Show("Günlük para çekme limiti olan '750' TL aşıldı !!!");
                            }
                           




                        }
                    }
                }
            }

            MessageBox.Show("İŞLEM BAŞARIYLA GERÇEKLEŞTİ");
            
            

        }

        private void ParaIslemForm_Load(object sender, EventArgs e)
        {

        }

        private void rbParaCekme_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbParaYatırma_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtTarih_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTutar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHesapNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
    }
}
