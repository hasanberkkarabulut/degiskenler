using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alistirma
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Merhaba");
            Console.Write("İsim: ");
            string isim = Console.ReadLine();

            Console.WriteLine("Soyisim : ");
            string Soyisim = Console.ReadLine();

         
            Console.WriteLine("Şehir  : ");
            string Şehir = Console.ReadLine();


            Console.WriteLine("yaş : ");
           
            
            string  yasStr = (Console.ReadLine());

            int yasParse = int.Parse(yasStr);
            int yasConvert = Convert.ToInt32(yasStr);

            Console.Clear();


            Console.WriteLine("İsim : " + isim);
            Console.WriteLine("Soyisim : " + Soyisim);
            Console.WriteLine("Şehir : " + Şehir);
            Console.WriteLine("yaş : " + yasParse);

            Console.ReadLine();

        }
    }
}
