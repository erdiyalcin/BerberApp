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
    public partial class frmMusteriEkle : Form
    {
        public frmMusteriEkle()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // aynı eposta ile kaydetmek isterse?
            DbberberContext db = new DbberberContext();

            int telefonSayisi = db.Musteris
                                .Where(x => x.Telefon == txtTelefonNo.Text)
                                .Count();
            if (telefonSayisi > 0)
            {
                MessageBox.Show(txtTelefonNo.Text + " adlı eposta kayıtlıdır");
                return; // Bilgi verdikten sonra çık.
            }

            Musteri musteri = new Musteri();
            musteri.Ad = txtAd.Text;
            musteri.Soyad = txtSoyad.Text;
            musteri.Telefon = txtTelefonNo.Text;
            musteri.KayitTarihi = DateTime.Now;
            musteri.KullaniciId=Program.kullanici.KullaniciId;
            db.Musteris.Add(musteri); // sorguyu oluşturdu.
            db.SaveChanges();
            //Geri bildirim ekliyoruz.
            this.DialogResult = DialogResult.OK;
            // bu formu kapat
            this.Close();
        }

    }
}
