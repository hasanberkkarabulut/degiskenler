using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciGirişUygulama
{
    public partial class anaform : Form
    {
        public anaform(kkulllanıcı bulunanKullanici)
        {
            InitializeComponent();
            txtısım.Text = bulunanKullanici.isim;
            txtsoyisim.Text = bulunanKullanici.soyisim;
            txtkullanıcıadı.Text = bulunanKullanici.kullaniciAdi;
            txtkullanıcıadı.Enabled = false;
            txtşifre.Text = bulunanKullanici.sifre;
            txtaçıklama.TexiciTablo.FindIndex(i => i.id == id);
            sanalDatabase.KullaniciTablo[index].isim = txtısım.Text;
            sanalDatabase.KullaniciTablo[index].soyisim = txtsoyisim.Text;
            sanalDatabase.KullaniciTablo[index].sifre = txtşifre.Text;
            sanalDatabase.KullaniciTablo[index].aciklama = txtaçıklama.Text;


        }
    }
}
