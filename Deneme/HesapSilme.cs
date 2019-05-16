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
    public partial class HesapSilme : Form
    {
        public Banka banka;
        public HesapSilme(Banka banka)
        {
            InitializeComponent();
            this.banka = banka;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var b in banka.Hesaplar)
            {


               
                    
                    if (Convert.ToInt32(txtHesapNo.Text) == b.HesapNo)
                    {
                        
                        
                        if(b.Bakiye==0)
                        {
                        banka.HesapSilme(b);
                        MessageBox.Show("HESAP SİLME İŞLEMİ BAŞARILI !!!");
                        break;
                        }
                        else
                        {
                            MessageBox.Show("Bakiyeniz '0' olmadığı için hesap silinemedi...");
                        break;
                        }

                    
                }
            }
            
        }

        private void HesapSilme_Load(object sender, EventArgs e)
        {

        }
    }
}
