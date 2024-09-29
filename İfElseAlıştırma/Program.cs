using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İfElseAlıştırma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("kullanıcı adı");
            string kullanici  = Console.ReadLine();


            Console.Write("Şifre");
            string şifre = Console.ReadLine();





            
            if (kullanici == "hasan" && şifre == "7687")
            {

                Console.WriteLine("Değerleriniz  alındı işlem gerçekleştiriliyor...");

            }
            else
            {

                Console.WriteLine("değerleriniz yanlış işlem yapılamıyor");

            }
            */


            Console.Write("kullanıcı değerlerini giriniz");
            string kullanici = Console.ReadLine();


            Console.Write("kullanıcı değerlerini giriniz");
            string kullanici2 = Console.ReadLine();


            if (kullanici == "ABC" && kullanici2 == "CMK")
            {
                Console.WriteLine("Değerleriniz  doğru giriş yapıldı");
            }
            else if (kullanici == "MMM" && kullanici2 == "AAA")
            {
                Console.WriteLine("Kullanıcı girişi kitlenmiş");
            }
            else
            {
                Console.WriteLine("Hatalı kullanıcı kodu");
            }


























        }
    }
}
