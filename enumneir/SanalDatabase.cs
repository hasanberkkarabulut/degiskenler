using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumneir
{
    public class SanalDatabase
    {
        ArrayList sanalDB = new ArrayList();

        public musteriReturnValue2 musteriYeniKayit(musteri M)
        {

            // parametre kontrol 

            // kayıt kontrol 

            sanalDB.Add(M);
            return musteriReturnValue2.kayitBasarili;
        }
    }
}
