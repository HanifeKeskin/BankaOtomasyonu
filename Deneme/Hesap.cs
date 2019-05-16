using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    public  class Hesap
    {
        public int HesapNo { get; set; }
        public decimal Bakiye { get; set; }
        public decimal EkHesap { get; set; }

        public Hesap()
        {
            EkHesap = 1000;
            this.Bakiye = 0;
        }

        


    }
}
