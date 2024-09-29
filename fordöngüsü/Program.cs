using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fordöngüsü
{
    internal class Program
    {
        static void Main(string[] args)
        {     /*
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("ben for döngüsü");
            }
            */

            /*
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("1,2,3,4,5,6,78,9,10");
            }

            for (int i = 0; i <= 100; i ++)
            {
                if (i % 2 ==0)
                     Console.WriteLine("çift sayılar");
           
            }
            int toplam;
            for (int i = 1; i <= 100; i++)
            {
                if (i%2 ==0)
                {
                    toplam += i;
                } 
            }
            Console.WriteLine("toplu sayılar");
            {0} toplam);
            


            string kullanicigelen = string.Empty;
            int kullanıcıgelenınt = 0;
            int faktöriyelhesap = 0;
            Console.WriteLine("lütfen değerinizi giriniz");
            string kullanıcıgelen = Console.ReadLine();
            kullanıcıgelenınt = int.Parse(kullanıcıgelen);

            for (int i = kullanicigelen; i < 1;  i--)
            {
                faktöriyelhesap = faktöriyelhesap * i;
            }

            Console.WriteLine("{0} değerinin faktöriyel sonucu : {1}" , kullanıcıgelen = faktöriyelhesap);
            
            int sayac = 0;
            for (; ; )
            {


                // if (sayac == 2)
                //break;

                if (sayac == 2)
                    continue;

                Console.WriteLine("ben sonsuzum");
            }
            
            for (int i = 1; i <= 20; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();


            }
            Console.Clear();
            */


            for (int i = 1; i <= 9; i++)
            {
                
                for(int j = 1; j <= 9; j++)
                {
                    int sonuc = i * j;
                    Console.Write("{0}*{1}={2} /t",i,j, sonuc);
                }
                Console.WriteLine();
            }

            Console.Clear();














        }
    }
}
