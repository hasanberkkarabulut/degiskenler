
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            giriş P1 = new giriş();
            P1.İsim = "berk";
            P1.Soyisim = "karabulut";
            P1.EmailAdres = "12345678.12345678" + giriş.domainAdres;
            P1.Cinsiyet = "Erkek";

            giriş P2 = new giriş();
            P2.İsim = "berk";
            P2.Soyisim = "karabulut";
            P2.EmailAdres = "12345678.12345678" + giriş.domainAdres;
            P2.Cinsiyet = "Erkek";

            Class1.emailgönder("ikQfirmam.com", "Yeni personel Bilgilendirme", P1.İsim + P1.Soyisim);
            Class1.emailgönder("ikQfirmam.com", "Yeni personel Bilgilendirme", P1.İsim + P1.Soyisim);
        }
    }
}
