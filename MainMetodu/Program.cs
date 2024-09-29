using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMetodu
{
    internal class Program
    {
         static void Main(string[] args)
         {

           //System.Console.WriteLine("Merhaba");

            // Console.WriteLine("Merhaba");

            Ogrenci O1 = new Ogrenci();
            O1.Ogretmen("Hasan","Berk");
         }
        static void Selamlar()
        {
            Console.WriteLine("Merhaba");
        }
    }
}
