using System;

namespace ArabaUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Araba araba = new Araba();

            araba.Marka = "Bmw";
            araba.Model = "320i";
            araba.Renk = "kırmızı";
            araba.Yil = 2020;
            araba.Hiz = "330 km/h";
            araba.Fiyat = "120.000 Euro";

            Console.WriteLine("Araba Markası: " + araba.Marka);
            Console.WriteLine("Araba Modeli: " + araba.Model);
            Console.WriteLine("Araba Rengi: " + araba.Renk);
            Console.WriteLine("Araba Yılı: " + araba.Yil);
            Console.WriteLine("Araba Hızı: " + araba.Hiz);
            Console.WriteLine("Araba Fiyatı: " + araba.Fiyat);

            Console.ReadLine();
        }
    }

    class Araba
    {
        public int Yil { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public string Hiz { get; set; }
        public string Fiyat { get; set; }
    }
}