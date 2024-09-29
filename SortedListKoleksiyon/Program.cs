using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListKoleksiyon
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable HT = new Hashtable();
            HT.Add(1, "Bir");
            HT.Add(2, "İki");
            HT.Add(3, true);

            Dictionary<int, string> DictionaryList = new Dictionary<int, string>();
            DictionaryList.Add(1, "Bir");
            DictionaryList.Add(2, "iki");
            DictionaryList.Add(3, "üç");
            DictionaryList.Add(1, "Test");

            bool silmeSonuc = DictionaryList.Remove(1);
            if (silmeSonuc)
            {
                Console.WriteLine("Silindi");
            }
            else
            {
                Console.WriteLine("Aranana değer liste içerisinde bulunamadı silme işlemi başarısız.");
            }


            bool arananDegerSonuc = DictionaryList.ContainsKey(1);
            if (arananDegerSonuc)
            {
                string gelenDeger = DictionaryList[1];
                gelenDeger = "Yenilenen Değer";
                DictionaryList[1] = gelenDeger;
            }
            else
            {
                Console.WriteLine("Aranan değer koleksiyon içerisinde bulunamadı");
            }

            bool arananDeger = DictionaryList.ContainsValue("Üç");
            if (arananDeger)
            {
                Console.WriteLine("Aranan değer bulundu");
            }
            else
            {
                Console.WriteLine("Aranan değer bulunamadı");
            }

            foreach (KeyValuePair<int, string> item in DictionaryList)
            {
                Console.WriteLine("Anahatar : {0} || Değer : {1}", item.Key, item.Value);
            }

            DictionaryList.Clear();

            SortedList<int, string> sortedListKoleksiyon = new SortedList<int, string>();

            sortedListKoleksiyon.Add(100, "Yüz");
            sortedListKoleksiyon.Add(50, "Elli");
            sortedListKoleksiyon.Add(1, "Bir");
            sortedListKoleksiyon.Add(1000, "Bin");
        }
    }
}
