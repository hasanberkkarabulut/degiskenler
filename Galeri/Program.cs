using System;
using System.Collections.Generic;
using System.Linq;

class Araba
{
    public int ID { get; }
    public string Marka { get; set; }
    public string Model { get; set; }
    public double Kilometre { get; set; }
    public float Fiyat { get; set; }

    public Araba(int id, string marka, string model, double kilometre, float fiyat)
    {
        ID = id;
        Marka = marka;
        Model = model;
        Kilometre = kilometre;
        Fiyat = fiyat;
    }

    public override string ToString()
    {
        return $"ID: {ID}, Marka: {Marka}, Model: {Model}, Kilometre: {Kilometre}, Fiyat: {Fiyat}";
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Galerinizin adını giriniz:");
        string galeriAdi = Console.ReadLine();

        List<Araba> arabaListesi = new List<Araba>();
        int currentID = 1;

        while (true)
        {
            Console.WriteLine("1 - Araba ekle");
            Console.WriteLine("2 - Araba çıkart");
            Console.WriteLine("3 - Araba Sat");
            Console.WriteLine("4 - Galeri adı değiştir");
            Console.WriteLine("5 - Galerideki arabaları göster");
            Console.WriteLine("6 - Çıkış yap");
            Console.WriteLine("Bir seçenek giriniz:");

            int secim;
            if (!int.TryParse(Console.ReadLine(), out secim))
            {
                Console.WriteLine("Geçersiz değer girdiniz:");
                continue;
            }

            if (secim == 1)
            {
                Console.WriteLine("Arabanın markasını giriniz:");
                string marka = Console.ReadLine();

                Console.WriteLine("Arabanın modelini giriniz:");
                string model = Console.ReadLine();

                Console.WriteLine("Arabanın kaç kmde olduğunu giriniz:");
                double kilometre = double.Parse(Console.ReadLine());

                Console.WriteLine("Arabanın fiyatını giriniz:");
                float fiyat = float.Parse(Console.ReadLine());

                Araba yeniAraba = new Araba(currentID, marka, model, kilometre, fiyat);
                arabaListesi.Add(yeniAraba);
                currentID++;
                Console.WriteLine($"Araba galerinize eklendi. ID: {yeniAraba.ID}");
            }
            else if (secim == 2)
            {
                if (arabaListesi.Count == 0)
                {
                    Console.WriteLine("Galerinizde araba yok.");
                    continue;
                }
                else
                {
                    Console.WriteLine("Hangi arabayı çıkartmak istiyorsunuz :");
                    foreach (var araba in arabaListesi)
                    {
                        Console.WriteLine(araba);
                    }

                    string arabaMarka = Console.ReadLine();

                    if (arabaListesi.RemoveAll(a => a.Marka.Equals(arabaMarka, StringComparison.OrdinalIgnoreCase)) > 0)
                    {
                        Console.WriteLine($"{arabaMarka} galeriden çıkarıldı.");
                    }
                    else
                    {
                        Console.WriteLine("Bu marka ile bir araba bulunamadı.");
                    }
                }
            }
            else if (secim == 3)
            {
                if (arabaListesi.Count == 0)
                {
                    Console.WriteLine("Galerinizde araba yok.");
                    continue;
                }

                Console.WriteLine("Satmak istediğiniz aracı seçiniz:");
                foreach (var araba in arabaListesi)
                {
                    Console.WriteLine($"{araba.ID} - {araba.Marka} {araba.Model}");
                }

                int secimAraba;
                while (true)
                {
                    Console.WriteLine("Satmak istediğiniz aracın ID'sini giriniz:");
                    if (int.TryParse(Console.ReadLine(), out secimAraba) && arabaListesi.Any(a => a.ID == secimAraba))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz ID. Lütfen tekrar deneyiniz.");
                    }
                }

                Araba secilenAraba = arabaListesi.First(a => a.ID == secimAraba);

                Console.WriteLine("Satış fiyatını giriniz:");
                float yeniFiyat;
                while (!float.TryParse(Console.ReadLine(), out yeniFiyat) || yeniFiyat < 0)
                {
                    Console.WriteLine("Geçersiz fiyat. Lütfen tekrar giriniz:");
                }
                secilenAraba.Fiyat = yeniFiyat;

                arabaListesi.Remove(secilenAraba);
                Console.WriteLine($"{secilenAraba.Marka} {secilenAraba.Model} başarıyla satıldı.");
            }
            else if (secim == 4)
            {
                Console.WriteLine("Yeni galeri adını giriniz:");
                galeriAdi = Console.ReadLine();
                Console.WriteLine($"Galeri adı başarıyla '{galeriAdi}' olarak güncellendi.");
            }
            else if (secim == 5)
            {
                if (arabaListesi.Count == 0)
                {
                    Console.WriteLine("Galerinizde araba yok.");
                }
                else
                {
                    Console.WriteLine("Galerideki arabalar:");
                    foreach (var araba in arabaListesi)
                    {
                        Console.WriteLine(araba);
                    }
                }
            }
            else if (secim == 6)
            {
                Console.WriteLine("Programdan çıkılıyor...");
                break;
            }
            else
            {
                Console.WriteLine("Geçersiz seçenek. Lütfen 1, 2, 3, 4, 5 veya 6 giriniz.");
            }
        }
    }
}
