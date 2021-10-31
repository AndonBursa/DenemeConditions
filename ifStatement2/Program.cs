using System;

namespace ifStatement2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kullanıcı Adı Giriniz");
            string kullanıcıAdi = Console.ReadLine();

            Console.WriteLine("Şifreyi Giriniz");
            string sifre = Console.ReadLine();

            if(kullanıcıAdi == "admin" && sifre == "123" )
            {
                Console.WriteLine("HoşGeldin admin");
            }
            else
            {
                Console.WriteLine("Hatalı kullanıcı / şifre girdiniz");
            }

            Console.WriteLine("Kapatmak için bir tuşa basınız");
            Console.ReadKey();
        }
    }
}
