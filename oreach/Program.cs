using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oreach
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] Isimler = new[] { "Hasan", "Berk", };

            foreach (var item in Isimler)
            {
                Console.WriteLine(item);
            }

        }
    }
}
