using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Add(Urun urun)
        {
            Console.WriteLine("Ürün sepete eklendi : " + urun.Adi);

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Ürün sepete eklendi : " + urunAdi);
        }
    }
}
