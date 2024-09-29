using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacenedir
{
    class ımusteri
    {
        interface Imusteri
        {
            int Id { get; set; }
            string isim { get; set; }
            string soyisim { get; set; }

            int yeniKayit(string isim, string soyisim);
            int kayitDuzenle(int id, string isim, string soyisim);
            int kayitSil(int id);
        }
    }
}