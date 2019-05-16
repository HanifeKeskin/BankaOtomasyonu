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
    
    public partial class Hesap_Ac : Form
    {
        public Banka bank;
        public Hesap_Ac(Banka bank)
        {
            this.bank = bank;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTc.Text.Length < 11)
            { MessageBox.Show("TC Kimlik numarası 11 haneden az girilemez!"); }
            else
            {

                foreach (var a in bank.Musteriler)
                {
                    if (Convert.ToInt64(txtTc.Text) == a.TCNo)

                    {


                        Random r = new Random();

                        Hesap h = new Hesap();
                        h.HesapNo = r.Next(10000, 99999);
                        h.Bakiye = 0;
                        bank.HesapAc(h);
                        MessageBox.Show("Hesap Eklendi");

                    }
                }
            }
            }

        private void Hesap_Ac_Load(object sender, EventArgs e)
        {

        }
    }
}
