using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Hangi ay : ");
            string kullanicigelen = Console.ReadLine();

            switch (kullanicigelen)
            {
                case "Ocak":                   
                    Console.WriteLine("01");
                    break;

                case "Şubat":
                    Console.WriteLine("02");
                    break;

                case "Mart":
                    Console.WriteLine("03");
                    break;

                default:

                    Console.WriteLine("Değerler yanlış");
                    break;
            }





        }
    }
}
