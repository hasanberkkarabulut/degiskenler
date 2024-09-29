using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace static_bölümsonu
{
   class program
   {
        static void Main(string[] args)
        {
            Class1 M1 = new Class1();
            M1.musteriid = 1;
            M1.isim = "Cengiz";
            M1.soyisim = "Atilla";
            M1._emailadres = "cengiz.atilla@hotmail.com";
            M1._kullanıcıadi = "cengiz.atilla";
            M1.sifre = "1";

            Class1.MusteriEkle(M1);

            Class1 M2 = new Class1()
            {
                musteriid = 2,
                isim = "Ahmet",
                soyisim = "Atilla",
                _emailadres = "ahmet.atilla@hotmail.com",
                _kullanıcıadi = "ahmet.atilla",
                sifre = "2"
            };

            Class1.MusteriEkle(M2);

            Class1 M3 = new Class1();
            M3.musteriid = 1;
            M3.isim = "Cengiz";
            M3.soyisim = "Atilla";
            M3._emailadres = "cengiz.atilla@hotmail.com";
            M3._kullanıcıadi = "cengiz.atilla";
            M3.sifre = "1";

            Class1.MusteriEkle(M3);
        }
    }
}