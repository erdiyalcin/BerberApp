using System;
using System.Collections.Generic;

namespace BerberApp.Models;

public partial class Islem
{
    public int IslemId { get; set; }

    public string? Ad { get; set; }

    public decimal? Fiyat { get; set; }

    public int? Sure { get; set; }

    public virtual ICollection<Randevu> Randevus { get; set; } = new List<Randevu>();
}
