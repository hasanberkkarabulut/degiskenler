using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ikincisi
    {
        public void Hesap(string ad, string soyad, decimal not, decimal not2, decimal not3 = 4)
        {
            Console.WriteLine("Öğrencinin bilgileri aşağıdaki gibidir");
            Console.WriteLine("Ad Soyad  : {0} {1}", ad, soyad);

            decimal ortalama = /*Hesap3*/(not + not2 + not3);
            değerlenir(ortalama);

            değerlenir(Hesap3(not, not2, not3));
        }
        void değerlenir(decimal ortalama)
        {
            if (ortalama < 45)
            {
                Console.WriteLine("ortalma değer : {0} kaldınız",ortalama);
            }
            else
            {
                Console.WriteLine("Ortalama değeriniz : {0} geçtiniz", ortalama);
            }

        }

        private decimal Hesap3(decimal not,decimal not2,decimal not3)
        {
            //decimal ortalama = (not + not2 + not3)/3;
            return (not + not + not3) /3;
        }



    }
}
