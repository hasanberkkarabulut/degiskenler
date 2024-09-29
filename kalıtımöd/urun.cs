using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalıtımöd
{
    public class urun : baseclass
    {
        public string marka { get; set; }
        public string model { get; set; }

        public decimal _alisFiyat;
        public decimal alışfiyat
        {
            get { return _alisFiyat; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Alis fiyatı 0 dan küçük veya eşit olamaz...");
                }
                else
                {
                    _alisFiyat = value;
                }
            }
        }

        private decimal _satisFiyat;
        public decimal satisFiyat
        { 
            get { return _satisFiyat; }
            set
            {
                if (value<_alisFiyat)
                {
                    Console.WriteLine("Ürünnün satış fiyatı alış fiyatından küçük olamaz...");
                }
                else
                {
                  _satisFiyat = value;
                }
            }
        }
        private decimal _kampanyaFiyat;
        public decimal kampanyaFiyat
        {
            get { return _kampanyaFiyat; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Kampanya fiyatı 0 dan küçük veya eşit olamaz...");
                }
            }
        }
    }
}
