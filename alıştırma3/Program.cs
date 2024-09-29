using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace alıştırma3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hoşgeldiniz");

            Console.Write("İsim Soyisim");
            string İsimSoyisim = Console.ReadLine();

            Console.Write("Not 1");
            string Not3 = Console.ReadLine();


            Console.Write("Not 2");
            string Not2 = Console.ReadLine();


            Console.Write("Not 3");
            string Not1 = Console.ReadLine();

            double not1 = Convert.ToDouble(Not1);
            double not2 = Convert.ToDouble(Not1);
            double not3 = Convert.ToDouble(Not1);

            double toplam = (not1 + not2 + not3) / 3;

            if (toplam < 45)
            {
                Console.WriteLine("Kaldınız");
            }
            else if (toplam >= 45 && toplam < 70)
            {
                Console.WriteLine("Orta ile geçtiniz");
            }
            else if (toplam >= 70  && toplam < 90)
            {
                Console.WriteLine("Geçtiniz");
            }
            else if (toplam >= 90 && toplam < 100)
            {
                Console.WriteLine("İyi ile  geçtiniz");
            }
            else
            {
                Console.WriteLine("Değerleri kontrol ediniz");
            }
        }
    }
}
