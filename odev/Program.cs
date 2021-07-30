using System;

namespace odev
{
    class Program
    {
        static void Main(string[] args)
        {
            EkranKarti Kart1 = new EkranKarti();
            Kart1.KartAdi = "Nvidia";
            Kart1.Modeli = "Rtx3080";
            Kart1.Fiyati = 10000;

            EkranKarti kart2 = new EkranKarti();
            kart2.KartAdi = "AMD";
            kart2.Modeli = "Rx580";
            kart2.Fiyati = 8000;

            EkranKarti kart3 = new EkranKarti();
            kart3.KartAdi = "Nvidia";
            kart3.Modeli = "Rtx2060";
            kart3.Fiyati = 5000;

            EkranKarti[] EK = new EkranKarti[] {Kart1,kart2,kart3};

            Console.WriteLine("Foreach dongusu");
            foreach (EkranKarti ekranKarti in EK)
            {
                Console.WriteLine(ekranKarti.KartAdi+ " "+ ekranKarti.Modeli +" "+ ekranKarti.Fiyati );
            }
            Console.WriteLine("For dongusu");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(EK[i].KartAdi +" "+ EK[i].Modeli +" "+ EK[i].Fiyati);
            }

            Console.WriteLine("While dongusu");

            int x = 0;
            while (x < EK.Length)
            {
                Console.WriteLine(EK[x].KartAdi +" "+ EK[x].Modeli +" "+ EK[x].Fiyati);
                x++;
            }
    
        }
    }
    class EkranKarti
    {
        public string KartAdi { get; set; }
        public string Modeli { get; set; }
        public int Fiyati { get; set; }
    }
}
