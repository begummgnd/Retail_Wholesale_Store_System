using System;
using System.Collections.Generic;

#nullable disable

namespace BakkalUygulamasi.entity.Data
{
    public partial class SmaddeleriLogInsDel
    {
        public int SmlidId { get; set; }
        public int SmId { get; set; }
        public double? SiMiktar { get; set; }
        public double? SiFiyat { get; set; }
        public double? SiIskonto { get; set; }
        public int? SatisId { get; set; }
        public int? UrunId { get; set; }
        public DateTime IslemTarihi { get; set; }
        public string IslemTuru { get; set; }
        public string IslemIp { get; set; }
    }
}
