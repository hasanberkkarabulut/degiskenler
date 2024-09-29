using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPNedir
{
    public class Musteri
    {
        public Musteri()
        {
            isim = "Alp";
        }

        public Musteri(string _tckimlik)
        {
            TCkimliknumara = _tckimlik;
        }

        public Musteri(string _tckimlik, string _isim)
        {
            TCkimliknumara = _tckimlik;
            isim = _isim;
        }

        public Musteri(string _tckimlik, string _isim, string _Soyad)
        {
            TCkimliknumara = _tckimlik;
            isim = _isim;
            Soyad = _Soyad;
        }

        public string TCkimliknumara;
        public string isim;
        public string Soyad;
        public int Cinsiyet;


        public bool MusteriKontrol()
        {
            bool kontrol = KontrolDataBase(TCkimliknumara);
            return kontrol;
        }

        private bool KontrolDataBase(string tckimlikNumarası)
        {
            return true;
        }







    }
}
