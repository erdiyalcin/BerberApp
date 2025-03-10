using System;
using System.Collections.Generic;

namespace BerberApp.Models;

public partial class Randevu
{
    public int RandevuId { get; set; }

    public int? MusteriId { get; set; }

    public DateTime? RandevuTarihi { get; set; }

    public DateTime? KayitTarihi { get; set; }

    public int? KullaniciId { get; set; }

    public int? IslemId { get; set; }

    public decimal? Ucret { get; set; }

    public decimal? Bahsis { get; set; }

    public bool? GeldiMi { get; set; }

    public virtual Islem? Islem { get; set; }

    public virtual Kullanici? Kullanici { get; set; }

    public virtual Musteri? Musteri { get; set; }
}
