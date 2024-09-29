using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2Kapsülleme
{
    class Program
    {
        static void Main(string[] args)
        {
           Musteri M1 = new Musteri();
            //M1.id = 1;
            //M1.isim = "Berk";
            //M1.soyisim = "Karabulut";
            //M1.email = "tgvbhhotgmail.commmmkkdos";
            //M1.EmailAdres = "tgvbhhotgmail.commmmkkdos";
            //Console.Write(M1.EmailAdres);


           // Console.WriteLine("ıd değer :" + M1.ID.ToString());

            M1.isim = "Berk";
            M1.Soyisim = "Karabulut";
            Console.WriteLine(M1.EmailAdres);
        }
    }
}
