using System;
using System.Collections.Generic;

namespace BerberApp.Models;

public partial class Musteri
{
    public int MusteriId { get; set; }

    public string? Ad { get; set; }

    public string? Soyad { get; set; }

    public string? Telefon { get; set; }

    public DateTime? KayitTarihi { get; set; }

    public int? KullaniciId { get; set; }

    public virtual Kullanici? Kullanici { get; set; }

    public virtual ICollection<Randevu> Randevus { get; set; } = new List<Randevu>();
}
