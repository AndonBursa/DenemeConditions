using System;

namespace ifStatment4Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi1, sayi2, sonuc = 0;
            char islem;

            Console.WriteLine("1.Sayıyı Giriniz");
            sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("2.Sayıyı Giriniz");
            sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Aritmetik işlemi seçiniz ( +,-,*,/ )");
            islem = Convert.ToChar(Console.ReadLine());


            if( islem == '+' )
            {
                sonuc = sayi1 + sayi2;
            }
            else if (islem == '*' )
            {
                sonuc = sayi1 * sayi2;
            }
            else if (islem == '/')
            {
                sonuc = sayi1 / sayi2;
            }
            else if (islem == '-')
            {
                sonuc = sayi1 - sayi2;
            }
            else
            {
                Console.WriteLine("Geçersiz işlem");
            }

            Console.WriteLine($"İşlem sonucunuz = {sonuc}");

            Console.ReadKey();

        }
    }
}
