using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 01;
            musteri1.Ad = "Enver";
            musteri1.Soyadi = "Ecesoy";
            musteri1.Yasi = 24;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 02;
            musteri2.Ad = "Onur";
            musteri2.Soyadi = "Yilmaz";
            musteri2.Yasi = 23;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 03;
            musteri3.Ad = "Ozan";
            musteri3.Soyadi = "Atesmen";
            musteri3.Yasi = 22;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri3);

            musteriManager.Sil(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri3);
        }
    }
}
