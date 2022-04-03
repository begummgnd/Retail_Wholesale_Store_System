using System;
using System.Collections.Generic;

#nullable disable

namespace BakkalUygulamasi.entity.Data
{
    public partial class KategoriLogInsDel
    {
        public int KalidId { get; set; }
        public int KategoriId { get; set; }
        public string KAdi { get; set; }
        public DateTime IslemTarihi { get; set; }
        public string IslemTuru { get; set; }
        public string IslemIp { get; set; }
    }
}
