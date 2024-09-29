using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalıtımöd
{
    public class Program
    {
        static void Main(string[] args)
        {
            bilgisayar B1 = new bilgisayar();
            B1.marka = "Lenovo";
            B1.model = "z50";
            B1.islemci = "I5";
            B1._alisFiyat = 1000;
            B1.satisFiyat = 1500;
            B1.kampanyaFiyat = 1000;
            B1.barkod = "1234567890";

            Sanalatabase.yeniUrunEkle(B1);

            bilgisayar B2 = new bilgisayar();
            B2.marka = "Lenovo";
            B2.model = "z50";
            B2.islemci = "I5";
            B2._alisFiyat = 1000;
            B2.satisFiyat = 1500;
            B2.kampanyaFiyat = 1000;
            B2.barkod = "1234567890";

            Sanalatabase.yeniUrunEkle(B2);
        }
    }
}
