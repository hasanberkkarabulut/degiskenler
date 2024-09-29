using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReOutKullanım
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int s1 = 0;
            //değer(ref s1);

            topla(5,96,56,65,16,76);
        }

        static void değer(ref int gelen)
        {
            gelen = 10;
        }

        static void topla(params int[] sayilar)
        {
            int toplam = 0;
           for (int i = 0; i < sayilar.Length; i++)
           {
                toplam += sayilar[i];
           }
            Console.WriteLine("Toplam :{0}", toplam);


        }




    }
}
