using System;
using System.Collections.Generic;

#nullable disable

namespace BakkalUygulamasi.entity.Data
{
    public partial class SatisLogInsDel
    {
        public int SlidId { get; set; }
        public int SatisId { get; set; }
        public DateTime? STarih { get; set; }
        public string SDurum { get; set; }
        public int? KullaniciId { get; set; }
        public DateTime IslemTarihi { get; set; }
        public string IslemTuru { get; set; }
        public string IslemIp { get; set; }
    }
}
