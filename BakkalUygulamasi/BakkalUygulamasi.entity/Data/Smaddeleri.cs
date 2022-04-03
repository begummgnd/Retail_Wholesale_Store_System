using System;
using System.Collections.Generic;

#nullable disable

namespace BakkalUygulamasi.entity.Data
{
    public partial class Smaddeleri
    {
        public int SmId { get; set; }
        public float SiMiktar { get; set; }
        public float SiFiyat { get; set; }
        public float SiIskonto { get; set; }
        public int SatisId { get; set; }
        public int UrunId { get; set; }
    }
}
