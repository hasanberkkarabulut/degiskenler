using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Araç B1 = new Araç("Bmw","M5",2018,50000);
            B1.AlışFiiyat = 5000000;
            B1.SatışFiyat = 5500000;
            B1.MaxİndirimTutarı  = 200000;
            B1.FiyatAta(5000000);
            B1.BilgileriGörüntüle();
            // Musteri M1 = new Musteri();
            //Musteri M1 = new Musteri("12345678910","Berk");
            //M1.TCkimliknumara = "12345678910";
            //M1.isim = "Hasan Berk";
            //M1.Soyad = "Karabulut";
            //M1.Cinsiyet = 12345678;

            //Musteri M2 = M1;

            //M2.TCkimliknumara = "865431";
            //M2.isim = "Berk";

            //bool musteri = M1.MusteriKontrol();

            //M1 = null;
            //M2 = null;

            //string isim = M2.isim;



        }
    }
}
