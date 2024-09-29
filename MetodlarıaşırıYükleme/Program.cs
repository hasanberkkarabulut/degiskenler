using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodlarıaşırıYükleme
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("MERHABA VENÜS");
            //Console.WriteLine(true);

            decimal toplam = topla(4, 65);
            göster(toplam);

            göster(topla(4, 11));
        }

        static void göster(object o)
        {
            Console.WriteLine(o.ToString());
        }
        static void topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
        }

        static void topla(decimal sayi1, decimal sayi2)
        {
            decimal toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
        }

        static void topla(double sayi1, double sayi2)
        {
            double toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
        }
    }
}
