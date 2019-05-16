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
    public partial class Musterilistele : Form
    {
        Banka bank;
        public Musterilistele(Banka bank)
        {
            this.bank = bank;
            InitializeComponent();
        }

        private void Listele_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource= bank.Musterilistele();
        }

    }
}
