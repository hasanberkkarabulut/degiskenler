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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullanıcıadı = txtkullanıcıadı.Text;
            string sifre = txtSifre.Text;

            kkulllanıcı bulunanKullanici = sanalDatabase.KullaniciTablo.Find
            (i => i.kullaniciAdi == kullanıcıadı && i.sifre == sifre);

            if (kullanıcıadı == "admin" && sifre == "123")
            {
                anaform _anaform = new anaform(bulunanKullanici);
                _anaform.Show();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı bilgileri", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtKullaniciAdi_Enter(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.Yellow;
        }

        private void txtKullaniciAdi_Leave(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.White;
        }
    }
}