using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad = string.Empty;
            string soyad = string.Empty;
            decimal not = 0;
            decimal not2 = 0;
            decimal not3 = 0;

            Console.WriteLine("değeri hasaplamak için değerleri giriniz");

            Console.Write("ad :");
            ad = Console.ReadLine();

            Console.Write("soyad :");
            soyad = Console.ReadLine();

            Console.Write("not :");
            not = decimal.Parse (Console.ReadLine());

            Console.Write("not2 :");
            not2 = decimal.Parse(Console.ReadLine());

            //Console.Write("not3 :");
            //not3 = decimal.Parse(Console.ReadLine());

            ikincisi İ = new ikincisi();
            İ.Hesap(ad,soyad,not,not2);
        }
    }
}
