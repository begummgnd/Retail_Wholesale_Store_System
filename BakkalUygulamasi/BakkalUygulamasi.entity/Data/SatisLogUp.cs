using System;
using System.Collections.Generic;

#nullable disable

namespace BakkalUygulamasi.entity.Data
{
    public partial class SatisLogUp
    {
        public int SluId { get; set; }
        public DateTime? EskiSTarih { get; set; }
        public DateTime? YeniSTarih { get; set; }
        public string EskiSDurum { get; set; }
        public string YeniSDurum { get; set; }
        public int? EskiKullaniciId { get; set; }
        public int? YeniKullaniciId { get; set; }
        public DateTime IslemTarihi { get; set; }
        public string IslemIp { get; set; }
    }
}
