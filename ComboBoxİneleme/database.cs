using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComboBoxİneleme
{
    public static class database
    {
        public static List<urun> UrunTablo = new List<urun>()
        {
            new urun (){id = 1, UrunAdı = "Zindan Adası", StokAdet = 10, Kategori = "Macera", Açıklama = "Çok Sürükleyici bir kitaptır", Yazar = "Ahmet Baki Yerli", urunResim = "Beyin Avcısı 1.jfif"},
            new urun (){id = 2, UrunAdı = "Kurt Kapanı", StokAdet = 10, Kategori = "Macera", Açıklama = "Çok Sürükleyici bir kitaptır", Yazar = "Ahmet Baki Yerli",  urunResim = "Beyin Avcısı 2.jpg"},
            new urun (){id = 3, UrunAdı = "Sihirbaz Çırağı", StokAdet= 10, Kategori = "Macera", Açıklama = "Çok Sürükleyici bir kitaptır", Yazar = "Ahmet Baki Yerli",  urunResim = "Beyin Avcısı 3.jfif"},
            new urun (){id = 4, UrunAdı = "Ölüm Ormanı", StokAdet = 10, Kategori = "Macera", Açıklama = "Çok Sürükleyici bir kitaptır", Yazar = "Ahmet Baki Yerli",  urunResim = "Beyin Avcısı 4.jfif"},
            new urun (){id = 5, UrunAdı = "Sırlar Uçurumu", StokAdet = 10, Kategori = "Macera", Açıklama = "Çok Sürükleyici bir kitaptır", Yazar = "Ahmet Baki Yerli", urunResim = "Beyin Avcısı 5.jpg"},
        };
    }
}
