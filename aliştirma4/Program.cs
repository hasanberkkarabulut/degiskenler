using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aliştirma4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kodu giriniz");
            string kod = Console.ReadLine();

           
            switch (kod)
            {
                case "AA":
                case "BB":
                case "CC":
                    Console.WriteLine("Admin yetkisine sahipsiniz");
                    break;

                case "DD":
                    Console.WriteLine("Sistem Yöneticisi");
                 break;

                case "FF":
                case "EE":
                case "GG":
                    Console.WriteLine("Standart üye girişi yaptınız");
                    break;

                default:
                    Console.WriteLine("Hatalı kullanıcı kodu");
                    break;
            }









        }
    }
}
