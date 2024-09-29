using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamsayilar
{
    internal class Program
    {
        static void Main(string[] args)
        {


            byte deger1 = 10;
            byte deger2 = 100;

            byte byteMinVal = byte.MinValue;
            byte byteMaxVal = byte.MaxValue;

            int intMinVal = int.MinValue;
            int intMaxVal = int.MaxValue;

            Console.WriteLine(byteMinVal);
            Console.WriteLine(byteMaxVal);

            Console.WriteLine(intMinVal);
            Console.WriteLine(intMaxVal);

            Console.ReadLine();
        }
    }
}
