using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel
{
    public class giriş
    {
        public static string domainAdres = "firmam.com";

        public string İsim { get; set; }
        public string Soyisim { get; set; }

        private string _emailadres;
        public string EmailAdres
        {
            get;
            {
                return this._emailadres;
            }
            set;
            {
                this._emailadres = value.ToLower() + "@" + giriş.domainAdres;
            }
        }

         public string Cinsiyet { get; set; }
    }
}
