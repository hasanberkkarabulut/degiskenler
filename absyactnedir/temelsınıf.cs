using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absyactnedir
{
    public abstract class temelsınıf
    {
        public DateTime kayitTarih { get; set; }
        public DateTime guncellemeTarih { get; set; }

        public temelsınıf()
        {
            kayitTarih = DateTime.Now;
            guncellemeTarih = DateTime.Now;
        }
        public void test()
        {
            Console.WriteLine("temel sınıf => test");
        }
        public abstract void testAbstract();
    }
}