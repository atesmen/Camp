using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazilim Gelistirme Kampi";
            string kurs2 = "Programlamaya giris Kursu";
            string kurs3 = "java";

            //array- dizi dinamik olarak listeleme yap amele olma

            string[] kurslar = new string[] { "Yazilim Gelistirme Kampi",
                "Programlamaya giris Kursu","java","python" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for Bitti");
            //foreach dizi temelli yapilari tek tek donmeye yariyor
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }



            Console.WriteLine("Sayfa Sonu - Footer");
        }
    }
}
