using System;
using System.Collections.Generic;

#nullable disable

namespace BakkalUygulamasi.entity.Data
{
    public partial class StokLogUp
    {
        public int StluIp { get; set; }
        public int? EskiSAdedi { get; set; }
        public int? YeniSAdedi { get; set; }
        public DateTime? EskiSGirisTarihi { get; set; }
        public DateTime? YeniSGirisTarihi { get; set; }
        public DateTime? EskiSBitisTarihi { get; set; }
        public DateTime? YeniSBitisTarihi { get; set; }
        public DateTime IslemTarihi { get; set; }
        public string IslemIp { get; set; }
    }
}
