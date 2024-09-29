using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innerTypeKavramı
{
    public class Class1
    {
        public int MüşteriID { get; set; }
        public string tckimlik { get; set; }
        public string İsim { get; set; }
        public string Soyİsim { get; set; }
        public DateTime oluşturmaTarih { get; set; }
        public int kullaniciıd { get; set; }

        public adres[]  adrestip;
        public mussteriietişimbilgisi[] Musteriletişimbilgisileri;
        public musterisği[] sipariş;
        public Class1()
        {
            adrestip = new adres[5];
            Musteriletişimbilgisileri = new mussteriietişimbilgisi[2];
            sipariş = new musterisği[5];
        }
    }
}