using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticNedir
{
    public class Ogrenci
    {
        public string Isım { get; set; }
        public string Soyısım { get; set; }
        public string EmailAdres { get; set; }

        public void Test1()
        {
            Console.WriteLine("nesne örneği alındıktan sonra çalışan metot");
        }
  
         public static void Test2()
        {
            Console.WriteLine("nesne örneği ALINMADAN çalışan metot");
        }

    }
}
