using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace BakkalUygulamasi.entity.Data
{
    public partial class SatisMaddeleri
    {
        public int SmId { get; set; }
        public double SiMiktar { get; set; }
        public double SiFiyat { get; set; }

        [Display(Name = "İskonto", Prompt = "%")]
        public double? SiIskonto { get; set; }
        public int SatisId { get; set; }
        public int UrunId { get; set; }

        public virtual Sati Satis { get; set; }
        public virtual Urun Urun { get; set; }

        public double? TotalFiyat()
        {
            return (SiFiyat - ((SiFiyat * SiIskonto) / 100)) * SiMiktar;
               
        }
    }
}
