using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karşılaştırmaoperatörleri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int deger1 = 8;

            int deger2 = 29;


            string isimSoyiyim = "Hasan Berk";
            object objectString = isimSoyiyim;
            string sonucStr = objectString as string;  



            object obj = deger1;
            Console.WriteLine(obj);
            deger1 = (int)obj;
            //deger1 = (byte)obj;


            bool kontrol = obj is int;
            bool kontrol2 = obj is byte;


            //bool deger = deger1 >= deger2;

            //bool  deger3 = deger1 <= deger2;



            // bool deger = deger1 == deger2;  

            // bool deger3 = deger2 != deger1;

            // bool deger3 = deger1 > deger2;


            // bool deger4 = deger1 < deger2;


        }
    }
}
