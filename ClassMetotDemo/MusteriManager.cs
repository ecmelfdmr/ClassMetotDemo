using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Sisteme Müşteri Eklendi.");
            Console.WriteLine(musteri.Id + " " + musteri.MusterininAdi + " " + musteri.MusterininSoyadi + " " + musteri.MusterininYasi + " ");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Sistemden Müşteri Silindi.");
            Console.WriteLine(musteri.Id + " " + musteri.MusterininAdi + " " + musteri.MusterininSoyadi + " " + musteri.MusterininYasi + " ");
        }
    }
}
