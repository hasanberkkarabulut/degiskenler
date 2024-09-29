using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashtableÖrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hashtable H1 = new Hashtable();

            //H1.Add("Car","Araba");
            //H1.Add("Number","Sayı");

            //H1.Add("Car","Arabalar");
            //H1.Add("House","Ev");

            //bool kontrol = H1.Contains("Car");
            //bool kontrol2 = H1.Contains("Sayt");

            //bool kontrol3 = H1.ContainsValue("Car");
            //bool kontrol4 = H1.ContainsKey("Sayt");


            //H1["Car1"] = "Lüks";

            //H1.Clear();


            Hashtable H1 = new Hashtable();

            do
            {
                Console.Clear();
                Console.WriteLine("Eklemek istediğiniz değeri girin");
                Console.Write("EN :");
                string eng = Console.ReadLine();

                bool kontrol = H1.ContainsKey(eng);
                if (kontrol)
                {
                    Console.WriteLine("Eklemek isteiğiniz değer {0} sözlük içerisinde bulunmaktadır.{1} değerin türkçe karşılığıdır.", eng,H1[eng].ToString());
                }
                else 
                {
                    Console.WriteLine(" {0} ingilize değerin türkçe karşılığını yazınız");
                    string tr = Console.ReadLine();
                    H1.Add(eng, tr);
                    Console.WriteLine("değer ekleme işlemi başarılı");
                }

                Console.WriteLine("Yenideğer eklemek istiyormusunuz ? (E/H)");
            }
            while (Console.ReadLine().ToUpper() != "E");

            foreach (var item in H1)
            {
                Console.WriteLine("ENG : {0} = TR : {1}", item, H1[item]);
            }

            //foreach (var item in H1)
            //{
            //    Console.WriteLine(item.GetType().Name);
            //}


            Console.ReadLine();
        }
    }
}
