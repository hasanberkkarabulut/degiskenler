using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesageBoxUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            int islemSonuc = yeniMusteriEkle(new Musteri()
            {
                id = Guid.NewGuid(),
                isim = txtisim.Text,
                soyisim = txtSoyisimisim.Text,
                emailAdres = txtEmailAdres.Text,
                telefonNumarasi = txtTelefonNumarası.Text
            });

            if (islemSonuc > 0)
            {
                DialogResult res = MessageBox.Show("Müşteri ekleme işlemi başarılı , yeni müşteri kaydı eklemek " +
                "ister "+"misiniz", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    bildirimCubugu = new NotifyIcon();
                    bildirimCubugu.BalloonTipText = "Toplam müşteri kayıt adedi : " 
                    + sanalDatabase.musteriler.Count.ToString();
                    bildirimCubugu.BalloonTipTitle = "Müşteri Adet bilgisi";
                    bildirimCubugu.Visible = true;
                    bildirimCubugu.Icon = SystemIcons.Information;
                    bildirimCubugu.ShowBalloonTip(2000);
                }
                else if (res == DialogResult.No)
                {

                }

                EkranTemizle();
                EkranListele();


            }
            else
            {
                MessageBox.Show("Hata : Kayıt ekleme işlemi yapılamadı");
            }

        }

        private void EkranListele()
        {
            listBox1.DataSource = sanalDatabase.musteriler;
        }

        private void EkranTemizle()
        {
            txtisim.Text = string.Empty;
            txtSoyisimisim.Text = string.Empty;
            txtEmailAdres.Text = string.Empty;
            txtTelefonNumarası.Text = string.Empty;
        }

        private int yeniMusteriEkle(Musteri data)
        {
            sanalDatabase.musteriler.Add(data);
            return 1;
        }

      
    }
}