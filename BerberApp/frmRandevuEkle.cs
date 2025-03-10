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
    public partial class frmRandevuEkle : Form
    {
        public int musteriID;
        public string musteriAdi;
        public frmRandevuEkle()
        {
            InitializeComponent();
        }

        private void frmRandevuEkle_Load(object sender, EventArgs e)
        {
            lblMusteri.Text = musteriAdi;

            //Combobox veritabanından nasıl doldurulur?
            DbberberContext db = new DbberberContext();
            var liste = db.Islems.ToList();

            // "Tümü" seçeneğini temsil eden yeni bir nesne oluşturup listeye ekliyoruz
            liste.Insert(0, new Islem() { IslemId = 0, Ad = "Seçiniz",Fiyat=0 }); // Yetki class'ınızın property'lerine göre ayarlayın

            cbIslem.DataSource = liste;
            cbIslem.DisplayMember = "ad";
            cbIslem.ValueMember = "IslemId";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // aynı eposta ile kaydetmek isterse?
            DbberberContext db = new DbberberContext();

            Randevu randevu = new Randevu();
            randevu.MusteriId = musteriID;
            randevu.RandevuTarihi = dtpRandevuTarihi.Value;
            randevu.IslemId = (cbIslem.SelectedItem as Islem).IslemId;
            randevu.Ucret = Convert.ToDecimal(txtUcret.Text);
            randevu.Bahsis = Convert.ToDecimal(txtBahsis.Text);
            randevu.GeldiMi = chkGeldiMi.Checked;
            randevu.KayitTarihi = DateTime.Now; // Bu işlem ne zaman yapıldı.
            randevu.KullaniciId = Program.kullanici.KullaniciId; // Bu işlemi kim yaptı

            db.Randevus.Add(randevu); // sorguyu oluşturdu.
            db.SaveChanges();
            //Geri bildirim ekliyoruz.
            this.DialogResult = DialogResult.OK;
            // bu formu kapat
            this.Close();
        }

        private void cbIslem_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Combobox içerisindeki veri değiştiğinde çalışacak kodlar
            Islem islem = cbIslem.SelectedItem as Islem; // seçili olan islem bilgisini alabiliyorum.

            txtUcret.Text = $"{islem.Fiyat:F2}";//((decimal)islem.Fiyat).ToString("F2");

        }
    }
}
