using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int deger = 1;
            //while (deger <= 10)
            //{
            //Console.WriteLine(deger);
            //}

            //Console.WriteLine("sayı gir");
            //string Kullanicigelendeger = Console.ReadLine();
            //int sayac = int.Parse(Console.ReadLine());

            //while (sayac != 0) 
            //{
            //    Console.WriteLine(sayac);
            //    sayac = sayac - 1;


            //}

            //Console.WriteLine("işlem tamam");


            //Console.WriteLine("Lütfen toplamamk istediğin,z sayıları giriniz");

            //Console.WriteLine("-1 değeriişlemi durdurur");

            //int kullanici = 0;

            //while (true)
            //{
            //    string gelendeger = Console.ReadLine();
            //    int gelen2 = int.Parse(Console.ReadLine());
            //    if (gelen2 < 0)
            //        break;
            //    else
            //         kullanici = kullanici + gelen2;



            //}


            int sayi = 0;

            int tahmin = 1;

            Random rand = new Random();

             sayi = rand.Next(1 , 10);

            while (true)
            {
                Console.WriteLine("Merhaba noldu : ");
                string rndkullanicigelen = Console.ReadLine();

                int kullanıcıgelen = int.Parse(rndkullanicigelen);

               // if (int.Parse(rndkullanicigelen) == sayi)
                if (kullanıcıgelen == sayi)
                {
                        Console.WriteLine("Tebrikler");
                        break;
                }
                else
                {
                        Console.WriteLine("tekrar");
                        break;
                } 
            }


            Console.Clear();













        }
    }
}
