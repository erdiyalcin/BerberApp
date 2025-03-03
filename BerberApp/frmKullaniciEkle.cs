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
    public partial class frmKullaniciEkle : Form
    {
        public frmKullaniciEkle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // aynı eposta ile kaydetmek isterse?
            DbberberContext db = new DbberberContext();

            int epostaSayisi = db.Kullanicis
                                .Where(x=> x.Eposta == txtEposta.Text)
                                .Count();
            if(epostaSayisi>0)
            {
                MessageBox.Show(txtEposta.Text + " adlı eposta kayıtlıdır");
                return; // Bilgi verdikten sonra çık.
            }

            Kullanici kullanici = new Kullanici();
            kullanici.Ad = txtAd.Text;
            kullanici.Soyad = txtSoyad.Text;
            kullanici.Eposta = txtEposta.Text;
            kullanici.Sifre = txtSifre.Text;
            //kullanici.YetkiId = Convert.ToInt32(txtYetkiID.Text);
            kullanici.YetkiId = (int)cbYetki.SelectedValue;
            db.Kullanicis.Add(kullanici); // sorguyu oluşturdu.
            db.SaveChanges();
            //Geri bildirim ekliyoruz.
            this.DialogResult = DialogResult.OK;
            // bu formu kapat
            this.Close();
        }

        private void frmKullaniciEkle_Load(object sender, EventArgs e)
        {
            //Combobox veritabanından nasıl doldurulur?
            DbberberContext db = new DbberberContext();
            var liste  = db.Yetkis.ToList();
            cbYetki.DataSource = liste;
            cbYetki.DisplayMember = "ad";
            cbYetki.ValueMember = "yetkiID";
        }
    }
}
