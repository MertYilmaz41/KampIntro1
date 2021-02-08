﻿using System;

namespace Donguler1
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C++";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);
            Console.WriteLine("------------------------");


            //array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", 
             "Programlamaya başlangıç için temel kurs",
             "Java","Python","C#"};

            
            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
           
            Console.WriteLine("For bitti");
            Console.WriteLine("--------------------------");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Foreach bitti");
            Console.WriteLine("--------------------------");

            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}
