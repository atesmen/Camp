using System;

namespace Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety
            //kendini tekrar etme 
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalis Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artis Butonu");
            }
            else
            {
                Console.WriteLine("Degismedi Butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanici Ayarlari Butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }


            Console.WriteLine(kategoriEtiketi);

        }
    }
}
