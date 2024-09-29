using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace static_bölümsonu
{
    public class Class1
    {
        static ArrayList MusteriDataBase;

        static Class1()
        {
            MusteriDataBase = new ArrayList();
        }

        public int musteriid { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string _emailadres { get; set; }
        public string _kullanıcıadi;
        public string sifre { get; set; }

        public string kullaniciad
        {
            get { return this._kullanıcıadi; }
            set
            {
                bool kullanıcıkontrol = müşteri(value);
                if (kullanıcıkontrol)
                {
                    Console.WriteLine("Eklemek istediğiniz kullanıcı adı sistemde ekli");
                    this.kullaniciad = string.Empty;
                }
                else
                {
                    this.kullaniciad = value;
                }
            }
        }

        static bool müşteri(string _kullanıcıadi)
        {
            bool Kontrol = false;

            for (int i = 0; i < MusteriDataBase.Count; i++)
            {
                Class1 C2 = (Class1)MusteriDataBase[i];
                if (C2.kullaniciad == _kullanıcıadi)
                {
                    Kontrol = true;
                    break;
                }
            }

            return Kontrol;

        }

        public static void MusteriEkle(Class1 M)
        {
            #region Parametre Kontrol 
            if (M != null && !string.IsNullOrEmpty(M._kullanıcıadi) && !string.IsNullOrEmpty(M._emailadres))
            {
                bool emailAdresKontrol = musteriEmailAdresKontrol(M._emailadres);
                if (emailAdresKontrol)
                {
                    Console.WriteLine("Eklemek istediğiniz kullanıcı sistemde kayıtlı");
                }
                else
                {
                    MusteriDataBase.Add(M);
                    Console.WriteLine("Yeni kayıt işlemi başarılı");
                }
            }
        }

        static bool musteriEmailAdresKontrol(string _emailAdres)
        {
            bool Kontrol = false;
            for (int i = 0; i < MusteriDataBase.Count; i++)
            {
                Class1 Temp = (Class1)MusteriDataBase[i];
                if (Temp._emailadres == _emailAdres)
                {
                    Kontrol = true;
                    break;
                }
            }
            return Kontrol;
        }
    }
}