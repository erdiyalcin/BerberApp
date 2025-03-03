using System;
using System.Collections.Generic;

namespace BerberApp.Models;

public partial class Yetki
{
    public int YetkiId { get; set; }

    public string? Ad { get; set; }

    public virtual ICollection<Kullanici> Kullanicis { get; set; } = new List<Kullanici>();
}
