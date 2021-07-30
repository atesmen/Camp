using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri Basariyla Eklendi:" + musteri.Ad + " " + musteri.Soyadi );
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + "Id Numarali" +" "+ musteri.Ad +" "+ "Isimli Musteri Basariyla Listelendi");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Yasi +" " + "Yasindaki Musteriler Basariyla Silindi");
        }
    }
}
