using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullaniciGirişUygulama
{
   
    public class sanalDatabase
    {
        public static List<kkulllanıcı> KullaniciTablo = new List<kkulllanıcı>();

        static sanalDatabase()
        {
            KullaniciTablo.Add(new kkulllanıcı()
            {
                id = 1,
                isim = "Hasan",
                soyisim = "Karabulut",
                kullaniciAdi = "hasan.karaulut",
                sifre = "2",
                aciklama = "hasan karabulut Kullanıcı profil bilgisi"
            });

            KullaniciTablo.Add(new kkulllanıcı()
            {
                id = 2,
                isim = "berk",
                soyisim = "karabulut",
                kullaniciAdi = "berk.karabulut",
                sifre = "2",
                aciklama = "berk karabulut Kullanıcı profil bilgisi"
            });
        }
    }
}