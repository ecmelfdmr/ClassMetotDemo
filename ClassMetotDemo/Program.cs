using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 3698;
            musteri1.MusterininAdi = "Selin";
            musteri1.MusterininSoyadi = "Kaya";
            musteri1.MusterininYasi = 20;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 4568;
            musteri2.MusterininAdi = "Ada";
            musteri2.MusterininSoyadi = "Gül";
            musteri2.MusterininYasi = 27;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 1235;
            musteri3.MusterininAdi = "Efe";
            musteri3.MusterininSoyadi = "Demir";
            musteri3.MusterininYasi = 18;


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Id Numarası : " + musteri.Id);
                Console.WriteLine("Ad : " + musteri.MusterininAdi);
                Console.WriteLine("Soyad : " + musteri.MusterininSoyadi);
                Console.WriteLine("Yaş : " + musteri.MusterininYasi);
                Console.WriteLine("------------");

            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri3);

            MusteriManager musteriManager1 = new MusteriManager();
            musteriManager1.Sil(musteri2);
        }
    }
}
