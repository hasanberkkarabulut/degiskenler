using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKalıtım
{
    public class Ogrenci:TemalTip
    {
       public string bolum { get; set; }
       public int seviye { get; set; }

        public Ogrenci()
        {
            Console.WriteLine("Öğrenci nesnesi çalıştı");
        }
    }
}
