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
    public partial class frmYonetici : Form
    {
        public frmYonetici()
        {
            InitializeComponent();
        }

        private void frmYonetici_FormClosed(object sender, FormClosedEventArgs e)
        {
            // form kapanırken çalışacak kodlar
            Application.Exit(); // uygulamayı kapat
        }

        private void frmYonetici_Load(object sender, EventArgs e)
        {
            //Combobox veritabanından nasıl doldurulur?
            DbberberContext db = new DbberberContext();
            var liste = db.Yetkis.ToList();

            // "Tümü" seçeneğini temsil eden yeni bir nesne oluşturup listeye ekliyoruz
            liste.Insert(0, new Yetki() { YetkiId = 0, Ad = "Tümü" }); // Yetki class'ınızın property'lerine göre ayarlayın

            cbYetki.DataSource = liste;
            cbYetki.DisplayMember = "ad";
            cbYetki.ValueMember = "yetkiID";
            Guncelle();
        }

        private void menuDuzenle_Click(object sender, EventArgs e)
        {
            // seçili olan satırdaki kullaniciID nin değerini ver
            int kullaniciID = (int)dgvKullanicilar.SelectedRows[0].Cells["kullaniciID"].Value;

            frmKullaniciDuzenle frm = new frmKullaniciDuzenle();
            frm.kullaniciID = kullaniciID;
            DialogResult sonuc = frm.ShowDialog();

            if (sonuc == DialogResult.OK)
            {
                //kaydedilmiştir.
                Guncelle(); // datagridview güncellensin.
            }


        }

        private void menuSil_Click(object sender, EventArgs e)
        {
            // Emin misiniz?
            DialogResult sonuc = MessageBox.Show("Kullanıcıyı silmek istediğinize emin misiniz?",
                  "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.No)
            {
                MessageBox.Show("İptal edildi");
                return; // fonksiyondan çık aşağıdaki kodları çalıştırma
            }

            // seçili olan satırdaki kullaniciID nin değerini ver
            int kullaniciID = (int)dgvKullanicilar.SelectedRows[0].Cells["kullaniciID"].Value;
            // id bilgisi olan bir nesneyi nasıl sileriz.
            // veritabanından o nesne bulunur.
            DbberberContext db = new DbberberContext();
            Kullanici kullanici = db.Kullanicis
                                .Where(x => x.KullaniciId == kullaniciID)
                                .SingleOrDefault();
            db.Kullanicis.Remove(kullanici); // Burada sorgu oluşturulur. veritabanından silmedi
            db.SaveChanges();
            MessageBox.Show("Kullanıcı silindi");
            Guncelle();
        }

        private void Guncelle()
        {
            // veritabanı işlemleri için bir nesne oluştur.
            DbberberContext veritabani = new DbberberContext();
            // veritabanındaki kullanıcıların hepsi gelsin.
            //List<Kullanici> kullanicilar = veritabani.Kullanicis.ToList();

            //var kullanicilar = veritabani.Kullanicis
            //    .Where(x => x.Ad.Contains(txtArama.Text) || x.Soyad.Contains(txtArama.Text))
            //    .Select(x => new
            //    {
            //        x.KullaniciId,
            //        x.Ad,
            //        x.Soyad,
            //        YetkiAd = x.Yetki.Ad
            //    })
            //    .ToList();

            // Hangi tablo üzerinde çalışıyoruz.
            IQueryable<Kullanici> sorgu = veritabani.Kullanicis;

            // Arama filtresi
            if (!string.IsNullOrEmpty(txtArama.Text))
            {
                sorgu = sorgu.Where(x => x.Ad.Contains(txtArama.Text) || x.Soyad.Contains(txtArama.Text));
            }

            // Yetki bazlı filtre
            // Seçili olan yetki ((Yetki)cbYetki.SelectedItem)
            if (((Yetki)cbYetki.SelectedItem).YetkiId != 0)
            {
                sorgu = sorgu.Where(x => x.YetkiId == ((Yetki)cbYetki.SelectedItem).YetkiId);
            }

            // Sonuçları al
            var sorguSon = sorgu.Select(x => new
            {
                x.KullaniciId,
                x.Ad,
                x.Soyad,
                YetkiAd = x.Yetki.Ad
            });
            // Tolist -> oluşturduğum sorguyu çalıştır ve liste şeklinde getir.
            var kullanicilar = sorguSon.ToList();

            // verileri datagridview de göster
            dgvKullanicilar.DataSource = kullanicilar;
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            frmKullaniciEkle frm = new frmKullaniciEkle();
            DialogResult sonuc = frm.ShowDialog();

            if (sonuc == DialogResult.OK)
            {
                //kaydedilmiştir.
                Guncelle(); // datagridview güncellensin.
            }
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            if (txtArama.Text.Length > 2)
                Guncelle();
        }

        private void cbYetki_SelectedIndexChanged(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            frmMusteriler frm = new frmMusteriler();
            frm.Show();
        }
    }
}
