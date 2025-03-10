using System;
using System.Collections.Generic;

namespace BerberApp.Models;

public partial class Kullanici
{
    public int KullaniciId { get; set; }

    public string? Ad { get; set; }

    public string? Soyad { get; set; }

    public string? Eposta { get; set; }

    public string? Sifre { get; set; }

    public int? YetkiId { get; set; }

    public virtual ICollection<Musteri> Musteris { get; set; } = new List<Musteri>();

    public virtual ICollection<Randevu> Randevus { get; set; } = new List<Randevu>();

    public virtual Yetki? Yetki { get; set; }
}
