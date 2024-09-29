using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKalıtım
{
    public class TemalTip
    {
        public int id { get; set; }
        public string referansKod { get; set; }
        public string tcKimlikNumarasi { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public int cinsiyet { get; set; }
        public DateTime kayitTarih { get; set; }
        public int kayitKullanici { get; set; }
        public DateTime guncellemeTarih { get; set; }
        public int guncellemeKullanici { get; set; }
        public bool silindi { get; set; }

        public TemalTip()
        {
            Console.WriteLine("TemelTip içindeki Metot Çalıştı");
            ıdArtamaİşlemi();
        }

        private void ıdArtamaİşlemi()
        {
            Random rnd = new Random();
            this.id = rnd.Next(1000, 2043);
        }

        public void TemelTipMetot1()
        {
            Console.WriteLine("Temel Tip => Metot 1");
        }

        protected void TemelTipMetot2()
        {
            Console.WriteLine("Temel Tip => Metot 2");
        }


    }
}
