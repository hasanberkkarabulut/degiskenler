using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematikselİşlemler
{
    public class Matematik
    {
        public decimal toplam(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 + sayi2;
            return sonuc;
        }

        public decimal çıkartma(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 - sayi2;
            return sonuc;
        }

        public decimal bölme(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 / sayi2;
            return sonuc;
        }

        public decimal çarpma(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 * sayi2;
            return sonuc;
        }

        public void menuHazırla()
        {
            Console.Clear();
            Console.WriteLine("Menü");
            Console.WriteLine("1 - Toplama");
            Console.WriteLine("2 - Çıkartma");
            Console.WriteLine("3 - Bölme");
            Console.WriteLine("4 - Çarpama");
            Console.WriteLine("Lüten değeri seçiniz :");
        }

         public void Ekranayaz(decimal kullaniciayi1, decimal kullaniciayi2, decimal sonuc, string operatörs)
         {
            Console.WriteLine("{0} {1} {2} = {3}", kullaniciayi1,  operatörs, kullaniciayi2,sonuc);
        }


    }
}
