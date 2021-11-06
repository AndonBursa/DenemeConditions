using System;

namespace SwitchCaseStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Switch Case!");

            Console.WriteLine("1.Sayıyı Giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            switch (sayi1%2)
            {
                case 0:
                    Console.WriteLine("Çift Sayı");
                    break;
                case 1:
                    Console.WriteLine("Tek Sayı");
                    break;

                default:
                    break;
            }
            Console.ReadKey();

        }
    }
}
