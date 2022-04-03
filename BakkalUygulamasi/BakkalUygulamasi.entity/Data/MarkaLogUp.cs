using System;
using System.Collections.Generic;

#nullable disable

namespace BakkalUygulamasi.entity.Data
{
    public partial class MarkaLogUp
    {
        public int MluId { get; set; }
        public string EskiMAdi { get; set; }
        public string YeniMAdi { get; set; }
        public DateTime IslemTarihi { get; set; }
        public string IslemIp { get; set; }
    }
}
