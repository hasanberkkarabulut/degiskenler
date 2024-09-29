using System;

namespace Ödev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba, isminiz nedir?");
            string s1 = Console.ReadLine();

            Console.WriteLine("Doğum Tarihinizi gün/ay/yıl olarak giriniz (örneğin: 12/12/1999):");
            string s3 = Console.ReadLine();

            // Doğum tarihini alıyoruz ve DateTime türüne dönüştürüyoruz
            DateTime dogumTarihi = DateTime.Parse(s3);

            // Bugünün tarihini alıyoruz
            DateTime bugun = DateTime.Today;

            // Yaşı hesaplıyoruz
            int yil = bugun.Year - dogumTarihi.Year;
            int ay = bugun.Month - dogumTarihi.Month;
            int gun = bugun.Day - dogumTarihi.Day;

            // Eğer gün farkı negatifse, bir önceki aydan gün ekliyoruz ve ayı bir azaltıyoruz
            if (gun < 0)
            {
                ay--;
                gun += DateTime.DaysInMonth(bugun.Year, bugun.Month - 1);
            }

            // Eğer ay farkı negatifse, yılı bir azaltıyoruz ve aya 12 ekliyoruz
            if (ay < 0)
            {
                yil--;
                ay += 12;
            }

            // Konsolu temizliyoruz
            Console.Clear();

            // Kullanıcıya yaşıyla birlikte kaç yıl, ay ve gün yaşadığını gösteriyoruz
            string mesaj = s1 + ", " + yil + " yıl, " + ay + " ay, " + gun + " gündür yaşıyorsunuz.";
            Console.WriteLine(mesaj);

            // Programın kapanmasını bekliyoruz
            Console.ReadLine();
        }
    }
}
