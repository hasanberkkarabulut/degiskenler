using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKalıtım
{
    public sealed class öğretmen:TemalTip
    {
        public string Branş{ get; set; }
        public int Branşseviye{ get; set; }

        public DateTime IsBaslangıç { get; set; }
        public DateTime IsBıtıs { get; set; }
        public int İzinGünSayısı { get; set; }

        public öğretmen()
        {
            Console.WriteLine("öğretmen içindeki yapıvı metot  çalıştı");
        }

    }
}
