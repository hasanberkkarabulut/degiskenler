using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalFong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LocalFunction(12, 22);
        }
        static void LocalFunction(int sayi, int sayi2) 
        {
            int topla(int g1, int g2)
            {
                return g1 + g2;
            }

            int değer = topla(sayi, sayi2);

            Console.WriteLine(değer);
        }
    }
}
