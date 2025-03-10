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
    public partial class frmMusteriDuzenle : Form
    {
        public int musteriID;
        public frmMusteriDuzenle()
        {
            InitializeComponent();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            DbberberContext db = new DbberberContext();
            //veritabanından ilgili kayıt bulunur.
            Musteri musteri = db.Musteris.Where(x => x.MusteriId == musteriID)
                .SingleOrDefault();

            musteri.Ad = txtAd.Text;
            musteri.Soyad = txtSoyad.Text;
            musteri.Telefon = txtTelefonNo.Text;

            db.SaveChanges();
            //Geri bildirim ekliyoruz.
            this.DialogResult = DialogResult.OK;
            // bu formu kapat
            this.Close();
        }

        private void frmMusteriDuzenle_Load(object sender, EventArgs e)
        {
            DbberberContext db = new DbberberContext();
            //Combobox veritabanından nasıl doldurulur?

            Musteri musteri = db.Musteris.Where(x => x.MusteriId == musteriID)
                .SingleOrDefault();
            txtAd.Text = musteri.Ad;
            txtSoyad.Text = musteri.Soyad;
            txtTelefonNo.Text = musteri.Telefon;
        }
    }
}
