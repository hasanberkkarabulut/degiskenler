using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Islemler
{
    class Program
    {
        static void Main(string[] args)
        {
            SanalDatabase sdatabase = new SanalDatabase();
            sdatabase.yeniKayit(1);
            sdatabase.yeniKayit(2);
        }
    }
}
