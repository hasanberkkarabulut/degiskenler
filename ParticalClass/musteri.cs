using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticalClass
{
    public class musteri
    {
        public int id{ get; set; }
        public string isim  { get; set; }
        public string soyisim { get; set; }
        public string emailadres { get; set; }

        public int yenikayıt(musteri m)
        {
            Console.WriteLine("yrni kayıt işlemi başarılı");
            return 1;
        }

        public int kayıtgüncelle(musteri m)
        {
            Console.WriteLine("kayıt güncellendi");
            return 1;
        }

        public int kayıtsil(musteri m)
        {
            Console.WriteLine("kayıt silinddi");
            return 1;
        }
    }
}
