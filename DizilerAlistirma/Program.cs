using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizilerAlistirma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();

            int[] diziler = new int[10];
            
            for (int i = 0; i < diziler.Length; i++)
            {
                diziler [i] = rnd.Next(1 - 10);
            }

            int int2 = 0;

            foreach (int item in diziler)
            {
                Console.WriteLine(item);
                if (item == 4)
                    int2++;
            }











            
        }
    }
}
