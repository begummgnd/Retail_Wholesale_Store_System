using EntityFrameworkCore.Triggers;
using System;
using System.Collections.Generic;

#nullable disable

namespace BakkalUygulamasi.entity.Data
{
    public partial class Kategori
    {
        public Kategori()
        {
            Uruns = new HashSet<Urun>();
        }

        public int KategoriId { get; set; }
        public string KAdi { get; set; }

        public virtual ICollection<Urun> Uruns { get; set; }
       
    }
}
