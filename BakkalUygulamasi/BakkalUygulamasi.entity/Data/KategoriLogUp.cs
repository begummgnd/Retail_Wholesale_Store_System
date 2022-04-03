using System;
using System.Collections.Generic;

#nullable disable

namespace BakkalUygulamasi.entity.Data
{
    public partial class KategoriLogUp
    {
        public int KaluIp { get; set; }
        public string EskiKAdi { get; set; }
        public string YeniKAdi { get; set; }
        public DateTime IslemTarihi { get; set; }
        public string IslemIp { get; set; }
    }
}
