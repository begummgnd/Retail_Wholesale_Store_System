using System;
using System.Collections.Generic;

#nullable disable

namespace BakkalUygulamasi.entity.Data
{
    public partial class SmaddeleriLogUp
    {
        public int SmluId { get; set; }
        public double? EskiSiMiktar { get; set; }
        public double? YeniSiMiktar { get; set; }
        public double? EskiSiFiyat { get; set; }
        public double? YeniSiFiyat { get; set; }
        public double? EskiSiIskonto { get; set; }
        public double? YeniSiIskonto { get; set; }
        public int? EskiSatisId { get; set; }
        public int YeniSatisId { get; set; }
        public int? EskiUrunId { get; set; }
        public int? YeniUrunId { get; set; }


        public DateTime IslemTarihi { get; set; }
        public string IslemIp { get; set; }
    }
}
