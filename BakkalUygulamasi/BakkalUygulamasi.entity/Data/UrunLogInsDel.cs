using System;
using System.Collections.Generic;

#nullable disable

namespace BakkalUygulamasi.entity.Data
{
    public partial class UrunLogInsDel
    {
        public int UlidId { get; set; }
        public int UrunId { get; set; }
        public string UAdi { get; set; }
        public string UBarkodu { get; set; }
        public DateTime? UUretimTarihi { get; set; }
        public DateTime? UTuketimTarihi { get; set; }
        public double? UFiyat { get; set; }
        public double? UAgirlik { get; set; }
        public string URengi { get; set; }
        public int? MarkaId { get; set; }
        public int? KategoriId { get; set; }
        public int? StokId { get; set; }
        public DateTime IslemTarihi { get; set; }
        public string IslemTuru { get; set; }
        public string IslemIp { get; set; }
    }
}
