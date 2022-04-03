using System;
using System.Collections.Generic;

#nullable disable

namespace BakkalUygulamasi.entity.Data
{
    public partial class MarkaLogInsDel
    {
        public int MlidId { get; set; }
        public int MarkaId { get; set; }
        public string MAdi { get; set; }
        public DateTime IslemTarihi { get; set; }
        public string IslemTuru { get; set; }
        public string IslemIp { get; set; }
    }
}
