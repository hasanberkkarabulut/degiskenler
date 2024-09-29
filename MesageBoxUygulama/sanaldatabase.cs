using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesageBoxUygulama
{
    public static class sanalDatabase
    {
        public static List<Musteri> musteriler { get; set; }

        static sanalDatabase()
        {
            musteriler = new List<Musteri>();
        }
    }
}