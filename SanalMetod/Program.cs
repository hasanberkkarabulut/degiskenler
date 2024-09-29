using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanalMetod
{
    public class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.isim = "Cengiz";
            M1.soyisim = "Atilla";
            string toStringMesaj = M1.ToString();
            Console.WriteLine(toStringMesaj);
        }
    }
}
