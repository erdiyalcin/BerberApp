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
    public partial class frmMusteriler : Form
    {
        public frmMusteriler()
        {
            InitializeComponent();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            frmMusteriEkle frm = new frmMusteriEkle();
            DialogResult sonuc = frm.ShowDialog();

            if (sonuc == DialogResult.OK)
            {
                Guncelle(); // datagridview güncellensin.
            }
        }

        private void Guncelle()
        {
            // veritabanı işlemleri için bir nesne oluştur.
            DbberberContext veritabani = new DbberberContext();

            // Hangi tablo üzerinde çalışıyoruz.
            IQueryable<Musteri> sorgu = veritabani.Musteris;

            // Arama filtresi
            if (!string.IsNullOrEmpty(txtArama.Text))
            {
                sorgu = sorgu.Where(x => x.Ad.Contains(txtArama.Text) || x.Soyad.Contains(txtArama.Text) || x.Telefon.Contains(txtArama.Text));
            }


            // Sonuçları al
            var sorguSon = sorgu.Select(x => new
            {
                x.MusteriId,
                x.Ad,
                x.Soyad,
                x.Telefon
            });
            // Tolist -> oluşturduğum sorguyu çalıştır ve liste şeklinde getir.
            var Musteriler = sorguSon.ToList();

            // verileri datagridview de göster
            dgvKullanicilar.DataSource = Musteriler;
        }

        private void frmMusteriler_Load(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void menuDuzenle_Click(object sender, EventArgs e)
        {
            // seçili olan satırdaki kullaniciID nin değerini ver
            int musteriID = (int)dgvKullanicilar.SelectedRows[0].Cells["musteriID"].Value;

            frmMusteriDuzenle frm = new frmMusteriDuzenle();
            frm.musteriID = musteriID;
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
            DialogResult sonuc = MessageBox.Show("Müşteriyi silmek istediğinize emin misiniz?",
                  "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.No)
            {
                MessageBox.Show("İptal edildi");
                return; // fonksiyondan çık aşağıdaki kodları çalıştırma
            }

            // seçili olan satırdaki kullaniciID nin değerini ver
            int musteriID = (int)dgvKullanicilar.SelectedRows[0].Cells["musteriID"].Value;
            // id bilgisi olan bir nesneyi nasıl sileriz.
            // veritabanından o nesne bulunur.
            DbberberContext db = new DbberberContext();
            Musteri musteri = db.Musteris
                                .Where(x => x.MusteriId == musteriID)
                                .SingleOrDefault();
            db.Musteris.Remove(musteri); // Burada sorgu oluşturulur. veritabanından silmedi
            db.SaveChanges();
            MessageBox.Show("Müşteri silindi");
            Guncelle();
        }

        private void menuRandevuEkle_Click(object sender, EventArgs e)
        {
            frmRandevuEkle frm = new frmRandevuEkle();

            DataGridViewRow satir = dgvKullanicilar.SelectedRows[0];

            frm.musteriID =  (int)satir.Cells["musteriID"].Value;
            frm.musteriAdi = satir.Cells["Ad"].Value.ToString() + " " + satir.Cells["Soyad"].Value.ToString();
            DialogResult sonuc = frm.ShowDialog();

            if (sonuc == DialogResult.OK)
            {
                // TODO : ok gelince yapılacakları düzenle
                //Guncelle(); // datagridview güncellensin.
            }
        }

        private void menuRandevuListele_Click(object sender, EventArgs e)
        {

        }
    }
}
