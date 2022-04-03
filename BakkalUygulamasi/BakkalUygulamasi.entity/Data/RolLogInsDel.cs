using System;
using System.Collections.Generic;

#nullable disable

namespace BakkalUygulamasi.entity.Data
{
    public partial class RolLogInsDel
    {
        public int RlidId { get; set; }
        public int RolId { get; set; }
        public string RAdi { get; set; }
        public DateTime IslemTarihi { get; set; }
        public string IslemTuru { get; set; }
        public string IslemIp { get; set; }
    }
}
