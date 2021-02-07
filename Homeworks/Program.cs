using System;

namespace Homeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.urunAdi = "Elma";
            urun1.fiyat = 10;
            urun1.seriNo = 1;

            Product urun2 = new Product();
            urun2.urunAdi = "Armut";
            urun2.fiyat = 15;
            urun2.seriNo = 2;

            Product urun3 = new Product();
            urun3.urunAdi = "Çilek";
            urun3.fiyat = 5;
            urun3.seriNo = 3;



            Product[] urunler = new Product[] { urun1, urun2, urun3};

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.urunAdi + " " + urun.fiyat + "tl " + " Seri Numarası: " + urun.seriNo);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Foreach listeleme bitti");
            Console.WriteLine(" ");
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].urunAdi + " " + urunler[i].fiyat + "tl" + " Seri Numarası: "  + urunler[i].seriNo);
            }
            Console.WriteLine(" ");
            Console.WriteLine("For ile listeleme bitti");
            Console.WriteLine(" ");

            int x = 0;
            while (x < urunler.Length)
            {
                Console.WriteLine(urunler[x].urunAdi + " " + urunler[x].fiyat + "tl" + " Seri Numarası:" + urunler[x].seriNo);
                x++;
            }
            Console.WriteLine(" ");
            Console.WriteLine("While ile listeleme bitti");


        }
    }
}
