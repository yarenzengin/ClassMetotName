using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Yaren";
            musteri1.Soyad = "Zengin";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Şevval";
            musteri2.Soyad = "Dönmez";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Elif";
            musteri3.Soyad = "Akyol ";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Ad = "Nejdet";
            musteri4.Soyad = "Yılmaz ";


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri4);


            Console.WriteLine("-------Müşteri Listesi--------");
            musteriManager.Listeleme(musteri1);
            Console.WriteLine("---------------------------");
            musteriManager.Listeleme(musteri2);
            Console.WriteLine("---------------------------");
            musteriManager.Listeleme(musteri3);
            Console.WriteLine("---------------------------");
            musteriManager.Listeleme(musteri4);
            Console.WriteLine("---------------------------");

            musteriManager.MusteriSilme(musteri3);








            Console.WriteLine("-----------deneme--------");
        }




    }
}
