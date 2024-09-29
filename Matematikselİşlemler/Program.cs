using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematikselİşlemler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matematik M = new Matematik();
            YenidenİşlemYap:

            M.menuHazırla();
            int kullaniciseçim = int.Parse(Console.ReadLine());

            Console.WriteLine("Sayi 1 i gir");
            decimal ks1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Sayi 2 i gir");
            decimal ks2 = decimal.Parse(Console.ReadLine());

            decimal sonuc = 0;

            switch (kullaniciseçim)
            {

                case 1:
                    sonuc = M.toplam(ks1, ks2);
                    M.Ekranayaz(ks1, ks2, sonuc, "+");
                    break;

                case 2:
                    sonuc = M.çıkartma(ks1, ks2);
                    M.Ekranayaz(ks1, ks2, sonuc, "+");
                    break;

                case 3:
                    sonuc = M.çarpma(ks1, ks2);
                    M.Ekranayaz(ks1, ks2, sonuc, "+");
                    break;

                case 4:
                    sonuc = M.bölme(ks1, ks2);
                    M.Ekranayaz(ks1, ks2, sonuc, "+");
                    break;

                default:
                    Console.WriteLine("beliirtmiş olduğun değer bulunamadı.");
                    Console.WriteLine("Lütfen yeniden deneyiniz.");
                    System.Threading.Thread.Sleep(2000);
                    goto YenidenİşlemYap;                   
            }
            Console.WriteLine("Yeniden işlem yap [EH]");
            string EH = Console.ReadLine();
            if (EH == "E")
            {
                goto YenidenİşlemYap;
            }
        }
    }
}
