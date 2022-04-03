

using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

#nullable disable

namespace BakkalUygulamasi.entity.Data
{
    public partial class Kullanici
    {
        public Kullanici()
        {
            Satis = new HashSet<Sati>();
        }

        public int KullaniciId { get; set; }
        public string KKullaniciadi { get; set; }
        public string KParola { get; set; }
        public string KAdi { get; set; }
        public string KSoyadi { get; set; }
        public string KEposta { get; set; }
        public string KTelefon { get; set; }
        public bool KDurum { get; set; }
        public int RolId { get; set; }

        public virtual Rol Rol { get; set; }
        public virtual ICollection<Sati> Satis { get; set; }
    }
}
