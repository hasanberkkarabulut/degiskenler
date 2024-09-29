using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack S1 = new Stack();

            S1.Push("bir");
            S1.Push("iki");
            S1.Push("üç");
            S1.Push("dört");
            S1.Push("beş");

            object O1 = S1.Pop();
            object O2 = S1.Peek();


        }
    }
}
