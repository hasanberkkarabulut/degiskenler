using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace genericinceleme
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayılarım = new List<int>();

            int[] eklenecekData1 = new int[4];
            eklenecekData1[0] = 2;
            eklenecekData1[1] = 3;
            eklenecekData1[2] = 4;

            sayılarım.AddRange(eklenecekData1);

            int Count = sayılarım.Count;
            int capacity = sayılarım.Capacity;

            sayılarım.TrimExcess();

            sayılarım.ForEach(b => Console.WriteLine(b));

            int bulunandeğer = sayılarım[3];
            Console.WriteLine("list generic");

            sayılarım.Insert(3, 100);

            bool kontrol1 = sayılarım.Any();
            bool kontrol2 = sayılarım.Any(i => i > 5);

            sayılarım.Sort();
            sayılarım.Reverse();

            int enyüksekdeğer = sayılarım.Max();
            int endüşükdeğer = sayılarım.Min();
            int toplamdeğer = sayılarım.Sum();



            bool silmeişlemi = sayılarım.Remove(100);

            sayılarım.RemoveAll(i => i > 3);
            sayılarım.RemoveAt(2);
        }
    }
}
