using System;
using System.Collections.Generic;

#nullable disable

namespace BakkalUygulamasi.entity.Data
{
    public partial class UrunLogUp
    {
        public int UluId { get; set; }
        public string EskiUAdi { get; set; }
        public string YeniUAdi { get; set; }
        public string EskiUBarkodu { get; set; }
        public string YeniUBarkodu { get; set; }
        public DateTime? EskiUUretimTarihi { get; set; }
        public DateTime? YeniUUretimTarihi { get; set; }
        public DateTime? EskiUTuketimTarihi { get; set; }
        public DateTime? YeniUTuketimTarihi { get; set; }
        public double? EskiUFiyat { get; set; }
        public double? YeniUFiyat { get; set; }
        public double? EskiUAgirlik { get; set; }
        public double? YeniUAgirlik { get; set; }
        public string EskiURengi { get; set; }
        public string YeniURengi { get; set; }
        public int? EskiMarkaId { get; set; }
        public int? YeniMarkaId { get; set; }
        public int? EskiKategoriId { get; set; }
        public int? YeniKategoriId { get; set; }
        public int? EskiStokId { get; set; }
        public int? YeniStokId { get; set; }
        public DateTime IslemTarihi { get; set; }
        public string IslemIp { get; set; }
    }
}
