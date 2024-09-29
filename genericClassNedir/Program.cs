using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericClassNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            musteri M1 = new musteri();
            M1.id = 1;
            M1.TcKimlikNumarasi = "12345678910";
            M1.musteriNumara = "MS123";
            M1.isim = "Berk";
            M1.soyisim = "Karabulut";
            M1.DogumTarih = DateTime.Parse("12.16.2011");

            musteriGeneric<int> MusteriGeneric1 = new musteriGeneric<int>();
            MusteriGeneric1.id = 1;
            MusteriGeneric1.musteriNumarasiAl();

            musteriGeneric<Guid> MusteriGeneric2 = new musteriGeneric<Guid>();
            MusteriGeneric2.musteriNumarasiAl();
        }
    }
}
