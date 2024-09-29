using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericClassNedir
{
    public class musteriGeneric<B>
    {
        public B id { get; set; }
        public B musteriNumara { get; set; }
        public string TcKimlikNumarasi { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime DogumTarih { get; set; }

        public B musteriNumarasiAl()
        {
            return musteriNumara;
        }
    }
}