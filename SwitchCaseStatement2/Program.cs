using System;

namespace SwitchCaseStatement2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 ile 5 arasında bir değer Giriniz");
            int deger = Convert.ToInt32(Console.ReadLine());

            switch (deger)
            {
                case 1:
                    Console.WriteLine("Bir");
                    break;
                case 2:
                    Console.WriteLine("İki");
                    break;
                case 3:
                    Console.WriteLine("Üç");
                    break;
                case 4:
                    Console.WriteLine("Dört");
                    break;
                case 5:
                    Console.WriteLine("Beş");
                    break;


                default:
                    Console.WriteLine("Geçersiz bir Rakam");
                    break;
            }
            Console.ReadKey();
        }
    }
}
