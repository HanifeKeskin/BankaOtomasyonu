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
    public partial class Form1 : Form
    {
        Hesap h = new Hesap();
        Banka bank = new Banka();
        public Form1()
        {
            InitializeComponent();
        }

        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriEkle frm = new MusteriEkle(bank);
            frm.Show();
        }

        private void müşteriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Musterilistele frm = new Musterilistele(bank);
            frm.Show();

        }

        private void hesapAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hesap_Ac frm = new Hesap_Ac(bank);
            frm.Show();
        }



        private void hesaplarıGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HesapGoruntule frm = new HesapGoruntule(bank);
            frm.Show();
        }

        private void paraİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParaIslemForm frm = new ParaIslemForm(bank);
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void musteri_islemToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void banka_islemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hesapAçToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Hesap_Ac frm = new Hesap_Ac(bank);
            frm.Show();

        }

        private void hesaplarıGörüntüleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            HesapGoruntule frm = new HesapGoruntule(bank);
            frm.Show();
        }

        private void paraİşlemleriToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            ParaIslemForm frm = new ParaIslemForm(bank);
            frm.Show();

        }

        private void müşteriEkleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MusteriEkle frm = new MusteriEkle(bank);
            frm.Show();

        }

        private void müşteriListeleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Musterilistele frm = new Musterilistele(bank);
            frm.Show();

        }

        private void müşteriSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void hesapSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HesapSilme frm = new HesapSilme(bank);
            frm.Show();

        }

        private void havaleİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HavaleIslem frm = new HavaleIslem(bank);
            frm.Show();
            
        }
    }
}
    