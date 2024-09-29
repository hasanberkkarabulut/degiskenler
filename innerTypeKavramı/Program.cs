using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innerTypeKavramı
{
    public class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();

            c1.MüşteriID = 1;
            c1.tckimlik = "12345678910";
            c1.İsim = "berk";
            c1.Soyİsim = "Karabulut";
            c1.oluşturmaTarih = DateTime.Now;

            // c1.adrestip = new adres[5];

            c1.adrestip[0] = new adres()
            {
                Il = "İstanbul",
                Ilce = "K.Çekmece",
                Adres = "Adres ... ",
                adresTip = "İş Yeri"
            };

            c1.adrestip[0].MusteriAdresTestMetot();

            c1.sipariş[0] = new musterisği()
            {
                siparisNumarasi = "SIP0001"
            };

            c1.sipariş[0].urunler[0] = new urun()
            {
                UrunId = 1,
                Tanım = "Telefon",
                fiyat = 1500
            };




        }
    }
}
