using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Menü");
            Console.WriteLine("1 - değer ekler");
            Console.WriteLine("2 - değer listele");
            Console.WriteLine("3 - değer ara");
            Console.WriteLine("4 - değer düzenle");
            Console.WriteLine("5 - değer sil");
            Console.WriteLine("6 - Uygulama çıkış");
            Console.WriteLine("Seçiniz :");
            string seçim = Console.ReadLine();

            ArrayList değerListesi = new ArrayList();

            switch (seçim)
            {
                case "1":
                    Console.Write("Lütfen değer giriniz :");
                    string seçim2 = Console.ReadLine();
                    değerListesi.Add(seçim2);
                    Console.WriteLine("Dğer başarılı");
                    System.Threading.Thread.Sleep(2000);
                    break;
                case "2":

                    for (int i = 0; i < değerListesi.Count; i++)
                    {
                        Console.WriteLine("{0}. Deger ={1}", değerListesi[1]);
                    }
                    Console.WriteLine("Devam etmekiçin her hangi bir tuşa basınız");
                    Console.ReadLine();
                    break;
                case "3":
                    Console.WriteLine("Aramak istediğiniz değeri giriniz");
                    string kullanıcıarama = Console.ReadLine();
                    bool kontrol = değerListesi.Contains(kullanıcıarama);
                    if (kontrol)
                    {
                        int bulunanIndex = değerListesi.IndexOf(kullanıcıarama);
                        string bulunan = değerListesi[bulunanIndex].ToString();
                        Console.WriteLine("Değeriniz bulundu : index sırası :{0} Değer : {1}", bulunanIndex, bulunan);
                    }
                    else
                    {
                        Console.WriteLine("Aradığınız değer bulundu");
                    }
                    System.Threading.Thread.Sleep(2000);
                    break;
                case "4":
                    Console.WriteLine("Güncellemek istediğiniz değeri giriniz : ");
                    string kullaniciDuzenlenecekDeger = Console.ReadLine();

                    Console.WriteLine("{0} değerini hangi değer ile güncellemek istiyorsunuz", kullaniciDuzenlenecekDeger);
                    string kullaniciYeniDeger = Console.ReadLine();

                    if (değerListesi.Contains(kullaniciDuzenlenecekDeger))
                    {
                        int kullaniciHedefIndex = değerListesi.IndexOf(kullaniciDuzenlenecekDeger);
                        değerListesi[kullaniciHedefIndex] = kullaniciYeniDeger;
                        Console.WriteLine("Değeriniz güncellendi");
                    }
                    else
                    {
                        Console.WriteLine("Aradığınız değer liste içerisinde bulunamadı");
                    }

                    System.Threading.Thread.Sleep(2000);

                    break;
                case "5":
                    Console.WriteLine("Tüm değerleri mi silmek istiyorsunuz (E/H)");
                    string kullaniciSilCevap = Console.ReadLine();

                    if (kullaniciSilCevap.ToUpper() == "E")
                    {
                        değerListesi.Clear();
                        Console.WriteLine("Tüm değerler silindi");
                    }
                    else
                    {
                        Console.WriteLine("Liste içerisinde silmek istediğiniz değeri giriniz");
                        string kullaniciSilDeger = Console.ReadLine();
                        if (değerListesi.Contains(kullaniciSilDeger))
                        {
                            değerListesi.Remove(kullaniciSilDeger);
                            Console.WriteLine("Değeriniz Silindi");
                        }
                        else
                        {
                            Console.WriteLine("Silmek istediğiniz değer liste içerisinde mevcut değil.");
                        }
                    }
                    break;
                default:
                   break;

            }  while (seçim != "6") ;
        }
    }
}
