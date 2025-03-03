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
    public partial class frmKullaniciDuzenle : Form
    {
        public int kullaniciID;
        public frmKullaniciDuzenle()
        {
            InitializeComponent();
        }

        private void frmKullaniciDuzenle_Load(object sender, EventArgs e)
        {
            DbberberContext db = new DbberberContext();
            //Combobox veritabanından nasıl doldurulur?
            var liste = db.Yetkis.ToList();
            cbYetki.DataSource = liste;
            cbYetki.DisplayMember = "ad";
            cbYetki.ValueMember = "yetkiID";

            Kullanici kullanici = db.Kullanicis.Where(x => x.KullaniciId == kullaniciID)
                .SingleOrDefault();
            txtAd.Text = kullanici.Ad;
            txtSoyad.Text = kullanici.Soyad;
            txtEposta.Text = kullanici.Eposta;
            txtSifre.Text = kullanici.Sifre;
            cbYetki.SelectedIndex = (int)kullanici.YetkiId;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DbberberContext db = new DbberberContext();
            //veritabanından ilgili kayıt bulunur.
            Kullanici kullanici = db.Kullanicis.Where(x => x.KullaniciId == kullaniciID)
                .SingleOrDefault();

            kullanici.Ad = txtAd.Text;
            kullanici.Soyad = txtSoyad.Text;
            kullanici.Eposta = txtEposta.Text;
            kullanici.Sifre = txtSifre.Text;
            kullanici.YetkiId = (int)cbYetki.SelectedValue;

            db.SaveChanges();
            //Geri bildirim ekliyoruz.
            this.DialogResult = DialogResult.OK;
            // bu formu kapat
            this.Close();
        }
    }
}
