using System;

namespace SwitchCaseStatement3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir karakter giriniz: ");

            char karakter = Char.ToUpper(Convert.ToChar(Console.ReadLine()));

            switch (karakter)
            {
                case 'A':
                case 'I':
                case 'İ':
                case 'O':
                case 'Ö':
                case 'U':
                case 'Ü':
                case 'E':
                    Console.WriteLine("gİRİLEN kARAKTER sESLİ");
                    break;
                default:
                    Console.WriteLine("gİRİLEN kARAKTER sessiz");
                    break;
            }

            Console.ReadKey();

            if(karakter=='A' || karakter == 'I' || karakter == 'İ' || karakter == 'O' || karakter == 'Ö' || karakter == 'U' || karakter == 'Ü' || karakter == 'E')
            {
                Console.WriteLine("İF YAPISINA GÖRE gİRİLEN kAREKTER sESLİ");

            }
            else
            {
                Console.WriteLine("İF YAPISINA GÖRE gİRİLEN kAREKTER SESSİZ");
            }
            Console.WriteLine("ÇIKIŞ İÇİN BİR TUŞA BASINIZ");
            Console.ReadKey();


        }
    }
}
