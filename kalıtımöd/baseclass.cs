using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalıtımöd
{
    public class baseclass
    {
        public static int sayac = 1;

        public baseclass()
        {
            _id = sayac;
            sayac = sayac + 1;
        }

        private int _id;
        public int id
        {
            get
            {
                return _id;
            }
            private set
            {          
            }
        }

        private string _barkod;
        public string barkod
        {
            get { return _barkod; }
            set
            {
                bool kontrolIslemi = Sanalatabase.dbBarkodKontrol(value);
                if (!kontrolIslemi) 
                {
                    _barkod = value;
                }
                else
                {
                    Console.WriteLine("Sanal database içerisinde bu barkod değeri daha önce girilmiştir.");
                }
            }
        } 

        public DateTime oluşrurmetarih { get; set; }
        public int oluşturenkullanıcı { get; set; }

        public DateTime güncellemetarih { get; set; }
        public int güncelleyenkullanıcı { get; set; }
        public bool silindi { get; set; }
    }
}
