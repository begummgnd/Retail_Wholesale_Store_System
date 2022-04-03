using System;
using System.Collections.Generic;

#nullable disable

namespace BakkalUygulamasi.entity.Data
{
    public partial class Satisler
    {
        public int SatisId { get; set; }
        public DateTime STarih { get; set; }
        public string SDurum { get; set; }
        public int KullaniciId { get; set; }
    }
}
