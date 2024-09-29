using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("sayi giriniz");
            string sStr = Console.ReadLine();

            Console.Write("sayi 2yi giriniz");
            string sStr2 = Console.ReadLine();

            decimal sayi = Convert.ToDecimal(sStr2);
            decimal sayi2 = Convert.ToDecimal(sStr2);
            decimal toplam = sayi + sayi2;

            bool toplam2 = toplam > 50;

            if (toplam > 50)
            {
                Console.WriteLine("geirmiş olduğunuz deger 50den büyük");
            }
            else if (toplam > 100)
            {
                Console.WriteLine("girmiş olduğunuz değerler 100 den büyük");
            }
            else
            {
                Console.WriteLine("girmiş olduğunuz değerler 50 denküçük");
            }


            Console.ReadLine();




        }
    }
}
