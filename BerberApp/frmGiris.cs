using BerberApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BerberApp
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            // Veritabanı ile ilgili işlem yapmak için Context sınıfından bir nesne üretiyoruz.
            DbberberContext db = new DbberberContext();
            // Dışarıdan girilen eposta ve şifre ile aynı bir kullanıcı var mı?
            string eposta = txtEposta.Text;
            string sifre = txtSifre.Text;

            // veritabanından tek bir kayıt gelmesini bekliyorsak
            // .SingleOrDefault(); kullanıyoruz.
            // Liste gelecekse .ToList();
            Kullanici kullanici = db.Kullanicis
                .Where(k => k.Eposta == eposta && k.Sifre == sifre)
                .SingleOrDefault();

            if(kullanici == null) // veritabanında kullanıcı bulunamadıysa
            {
                MessageBox.Show("Kullanıcı bulunamadı");
            }
            else
            {
                Program.kullanici = kullanici;// Giriş yapan kullanıcının bilgisini sakla
                if (kullanici.YetkiId == 1) // Yönetici mi?
                    new frmYonetici().Show();
                else
                    new frmPersonel().Show();
                //This bu class anlamında kullanılıyor.
                this.Hide();
                //MessageBox.Show("Merhaba," + kullanici.Ad + " " + kullanici.Soyad);
            }


        }
    }
}
