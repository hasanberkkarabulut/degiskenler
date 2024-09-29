using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("1 -  Toplama");
            
            Console.WriteLine("2 -  Çıkartma");

            Console.WriteLine("3 - Çarpma");

            Console.WriteLine("4 - Bölme");
           
             string degerler = Console.ReadLine();

            Console.Write("Sayı 1 i giriniz");
            string s1 = Console.ReadLine();

            Console.Write("Sayı 2 i giriniz");
            string s2 = Console.ReadLine();


            double sayi1 = Convert.ToDouble(s1);
            double sayi2 = Convert.ToDouble(s2);


            if (degerler == "1") 
            {
                double toplam = sayi1 + sayi2;
                Console.WriteLine("Toplam : " + toplam);
            }
            else if (degerler == "2")
            {
                double çıkartma = sayi1 - sayi2;
                Console.WriteLine("çıkartma : " + çıkartma);
            }
            else if (degerler == "3")
            {
                double çarpma = sayi1 * sayi2;
                Console.WriteLine("çarpma : " + çarpma);
            }
            else if (degerler == "4")
            {
                double bölme = sayi1 / sayi2;
                Console.WriteLine("Kalan : " + bölme);
            }
            else
            {
                Console.WriteLine("Değerler dışında bir şey girdiniz");
            }    

        }
    }
}
