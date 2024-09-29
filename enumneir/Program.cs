using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumneir
{
    class Program
    {
        static void Main(string[] args)
        {

            musteri M1 = new musteri();
            M1.id = 1;
            M1.Musterinumara = "MSN001";
            M1.isim = "Cengiz";
            M1.soyisim = "Atilla";
            M1.emailadres = "cengiz.atilla@hotmail.com";

            SanalDatabase SB = new SanalDatabase();
            musteriReturnValue2 musteriKayitSonuc = SB.musteriYeniKayit(M1);

            int enumInt = (int)musteriReturnValue2.kayitBasarisiz;
            Console.WriteLine(enumInt);

            //if (musteriKayitSonuc ==  musteriReturnValue.kayitBasarili)
            //{

            //}
        }
    }
}
