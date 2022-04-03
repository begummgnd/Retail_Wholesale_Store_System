using System;
using System.Collections.Generic;

#nullable disable

namespace BakkalUygulamasi.entity.Data
{
    public partial class RolLogUp
    {
        public int RluId { get; set; }
        public string EskiRAdi { get; set; }
        public string YeniRAdi { get; set; }
        public DateTime IslemTarihi { get; set; }
        public string IslemIp { get; set; }
    }
}
