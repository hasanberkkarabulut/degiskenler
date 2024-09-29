using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericClassnedir_1
{
    public class genericRepository<B> where B : class
    {
        public genericRepository()
        {
            // context  EF DBFirst 
        }

        public virtual List<B> Getir()
        {
            // Gelen B tipini database üzerinden sorgulamak ve elde etmiş olduğum kayıtları generic koleksiyon olarak bir ust katmana dönmek 
            return null;
        }

        public virtual void yeniKayitEkle(B data)
        {
            // bize gelen B tipi içerisindeki bilgiyi B tipinin işaret etmiş olduğu tabloya ekliyoruz
        }
    }
}
