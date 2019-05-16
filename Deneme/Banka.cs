using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme
{
    public  class Banka
    {
        public decimal gunlukParaCekmeLimiti = 750;
        /*musteri ekleme*/
        public  List<Musteri> Musteriler = new List<Musteri>();

        public void MusteriEkle(TicariMusteri t)
        {
            Musteriler.Add(t);
        }
        public void MusteriEkle(BireyselMusteri b)
        {
            Musteriler.Add(b);
        }

       
        public List<Musteri >Musterilistele()
        {
            return Musteriler;
        }
        public void BakiyeDegis()
        {

        }
        
        public void HavaleIslem(Hesap h)
        {

        }
        
        
        
        /*hesap acma */
        public List<Hesap> Hesaplar = new List<Hesap>();

        public void HesapAc(Hesap h)
        {
            Hesaplar.Add(h);
        }

        public List<Hesap> HesapListele()
        {
            return Hesaplar;
        }
        public void HesapSilme(Hesap h)
        {
            Hesaplar.Remove(h);
        }
    }
}
