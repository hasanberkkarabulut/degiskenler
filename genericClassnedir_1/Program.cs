using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericClassnedir_1
{
    class Program
    {
        static void Main(string[] args)
        {
            genericRepository<Musteri> repositoryMusteri = new genericRepository<Musteri>();


            List<Musteri> musterilerim = repositoryMusteri.Getir();

            repositoryMusteri.yeniKayitEkle(null);

            genericRepository<Urun> repositoryUrun = new genericRepository<Urun>();
            repositoryUrun.Getir();
            repositoryUrun.yeniKayitEkle(null);
        }
    }
}
