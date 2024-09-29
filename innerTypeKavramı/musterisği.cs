using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innerTypeKavramı
{ 
    public class musterisği
    {
        public string siparisNumarasi { get; set; }

        public urun[] urunler;

        public musterisği()
        {
            urunler = new urun[2];
        }

        public void MusteriSiparisBilgisiTestMetot()
        {
            Console.WriteLine("MusteriSiparisBilgisiTestMetot");
        }

    }
}
