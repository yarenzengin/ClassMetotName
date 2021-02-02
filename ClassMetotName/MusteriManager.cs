using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteriler)
        {

            Console.WriteLine("Müşteri ID sisteme eklendi : " + musteriler.Id);
            Console.WriteLine("Müşteri adı sisteme eklendi: " + musteriler.Ad);
            Console.WriteLine("Müşteri soyadı sisteme eklendi: " + musteriler.Soyad);
        }
        public void Listeleme(Musteri musteriler)
        {

            Console.WriteLine("Müşteri ID :" + musteriler.Id);
            Console.WriteLine("Müşteri adı:" + musteriler.Ad);
            Console.WriteLine("Müşteri soyadı:" + musteriler.Soyad);

        }
        public void MusteriSilme(Musteri musteriler)
        {
            Console.WriteLine("Id : " + musteriler.Id + " Ad : " + musteriler.Ad + " Soyad : " + musteriler.Soyad + "Sistemden silindi");
        }

    }
}