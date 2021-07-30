using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elmasi";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakir Karpuuz";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------");
            }
            //encapsulation
            Console.WriteLine("-------------Metotlar ----------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yesil Armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yesil Elma", 12,20);
            sepetManager.Ekle2("Karpuz", "Diyarbakir Karpuzu", 12,30);
        }
    }
}


//C sarp java gibi dillerde hersey classlardan olusur 
//Metotlar bizim icin tekrar tekrar kullanilabilirligi sagliyan bloklaridir
//Clean Code- Best Practice
