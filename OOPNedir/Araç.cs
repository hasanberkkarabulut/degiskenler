using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPNedir
{
    public class Araç
    {
        public string Marka;
        public string Model;
        public int ModelYil;
        public decimal Km;
        public int YakıtTipi;
        public int VitesTipi;
        public decimal AlışFiiyat;
        public decimal SatışFiyat;
        public decimal MaxİndirimTutarı;
        public decimal Fiyat;

        public Araç()
        { }

        public Araç(string _Marka, string _Model)
        {
            Marka = _Marka;
            Model = _Model;
        }

        public Araç(string _Marka, string _Model, int _ModelYil)
        {
            Marka = _Marka;
            Model = _Model;
            ModelYil = _ModelYil;
        }

        public Araç(string _Marka, string _Model, int _ModelYil, decimal _km)
        {
            Marka = _Marka;
            Model = _Model;
            ModelYil = _ModelYil;
            this.Km = _km;
        }

        public void BilgileriGörüntüle()
        {
            Console.WriteLine("Marka {0} - Model {1} - ModelYil {2}", Marka, Model, ModelYil);
        }

        public void FiyatAta(decimal _Fiyat)
        {
            decimal fiyatHesap = SatışFiyat - MaxİndirimTutarı;
            if (_Fiyat<fiyatHesap)
            {
                Console.WriteLine("Geçersiz fiyat girişi");
            }
            else
            {
                this.Fiyat = _Fiyat;
                Console.WriteLine("Fiyat güncellendi");
            }
        }
    }
}
