using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innerTypeKavramı
{
    public class urun
    {
        public int UrunId { get; set; }
        public string Tanım { get; set; }
        public decimal fiyat { get; set; }

        public urun()
        {
            Console.WriteLine("Urun yapıcı metodu çalıştırdı");
        }
        public void uruntestmetod()
        {
            Console.WriteLine("UruntestMeto");
        }



    }
}
