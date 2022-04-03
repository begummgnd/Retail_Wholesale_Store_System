using System;
using System.Collections.Generic;

#nullable disable

namespace BakkalUygulamasi.entity.Data
{
    public partial class Urunler
    {
        public int UrunId { get; set; }
        public string UAdi { get; set; }
        public string UBarkodu { get; set; }
        public DateTime UUretimTarihi { get; set; }
        public DateTime UTuketimTarihi { get; set; }
        public float UFiyat { get; set; }
        public float UAgirlik { get; set; }
        public string URengi { get; set; }
        public int MarkaId { get; set; }
        public int KategoriId { get; set; }
        public int StokId { get; set; }
    }
}
