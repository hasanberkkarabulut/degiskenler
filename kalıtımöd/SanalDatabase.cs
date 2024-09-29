using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalıtımöd
{
    public static class SanalDatabase
    {
        private static ArrayList db = new ArrayList();

        public static void yeniUrunEkle(baseclass data)
        {
            if (data != null && !string.IsNullOrEmpty(data.barkod))
            {
                db.Add(data);
            }
        }


    }
}
