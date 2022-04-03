using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace BakkalUygulamasi.entity.Data
{
    public partial class Urun
    {
        public Urun()
        {
            SatisMaddeleris = new HashSet<SatisMaddeleri>();
        }

        public int UrunId { get; set; }
        public string UAdi { get; set; }
        public string UBarkodu { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? UUretimTarihi { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? UTuketimTarihi { get; set; }
        public double UFiyat { get; set; }
        public double? UAgirlik { get; set; }
        public string URengi { get; set; }
        public int MarkaId { get; set; }
        public int KategoriId { get; set; }
        public int StokId { get; set; }

        public virtual Kategori Kategori { get; set; }
        public virtual Marka Marka { get; set; }
        public virtual Stok Stok { get; set; }
        public virtual ICollection<SatisMaddeleri> SatisMaddeleris { get; set; }
    }
}
