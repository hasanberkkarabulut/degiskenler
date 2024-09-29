using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalıtımöd
{
    public static class Sanalatabase
    {
        private static ArrayList db = new ArrayList();

        public static void yeniUrunEkle(baseclass data)
        {
            if (data != null && !string.IsNullOrEmpty(data.barkod))
            {
                db.Add(data);
            }
        }
        public static bool dbBarkodKontrol(string barkod)
        {
            bool kontrolIslemi = false;
            if (db != null && db.Count > 0)
            {
                for (int i = 0; i < db.Count; i++)
                {
                    baseclass bc = (baseclass)db[i];
                    if (bc.barkod == barkod)
                    {
                        kontrolIslemi = true;
                    }
                }
            }
            return kontrolIslemi;
        }
    }
}
