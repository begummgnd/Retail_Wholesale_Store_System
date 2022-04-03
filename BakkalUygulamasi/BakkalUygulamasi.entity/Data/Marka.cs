using System;
using System.Collections.Generic;

#nullable disable

namespace BakkalUygulamasi.entity.Data
{
    public partial class Marka
    {
        public Marka()
        {
            Uruns = new HashSet<Urun>();
        }

        public int MarkaId { get; set; }
        public string MAdi { get; set; }

        public virtual ICollection<Urun> Uruns { get; set; }
    }
}
