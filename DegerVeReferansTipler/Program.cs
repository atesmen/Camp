using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ?? cevap 30 olur cunku 
            //deger tip oldugu icin 13.satirda esitledikten sonra baglantiyi keser

            int[] sayilar1 = new int[] {10,20,30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] ?? 999
            //cevap 99 cunku deger ve refarans tipler stack ve heap adi altinda 
            //2 yerde tutulur usteki ornekte deger tipler stackte tutulur ve 
            //13. satirdan sonra bagini koparir  ama referans tiplerde 
            //heap isin icine girer ve sayilar1 once stackte tutulur ve 
            //dizinin devami olan sayilar heapte tutulur ve bunlar referans numarasiyla
            //birbirine baglanir 20.satirda esitleyince sayi once 100 olur ama sonra 
            //sayilar1 in heap adresini sayilar2 ye esitledigin icin 21.satirda
            //sayilar2 nin ilk elemanini 999 yaptigin zaman sayilar1 de de bu deger gozukur
        }
    }
}
//int, decimal, float, double,bool : deger tip
//array,class,interface: referans tip
