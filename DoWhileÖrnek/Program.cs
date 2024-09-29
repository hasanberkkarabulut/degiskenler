using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileÖrnek
{
    internal class Program
    {
        static void Main(string[] args)

        {
           string kullaniciadi = string.Empty;
            string sifre = string.Empty;
            int i = 0;



            do
            {
                Console.WriteLine("Adınızı giriniz");
                string ad = Console.ReadLine();

                Console.WriteLine("Şifre gir");
                string şifre = Console.ReadLine();


                if (i > 0)

                    Console.WriteLine("ad veya şifre yanlış");

                i++;






            } while (kullaniciadi.ToLower() != "hasan" || sifre.ToLower() != "123");

        }
    }
}
