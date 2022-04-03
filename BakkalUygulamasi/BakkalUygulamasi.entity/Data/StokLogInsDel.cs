using System;
using System.Collections.Generic;

#nullable disable

namespace BakkalUygulamasi.entity.Data
{
    public partial class StokLogInsDel
    {
        public int StlidId { get; set; }
        public int StokId { get; set; }
        public int? SAdedi { get; set; }
        public DateTime? SGirisTarihi { get; set; }
        public DateTime? SBitisTarihi { get; set; }
        public DateTime IslemTarihi { get; set; }
        public string IslemTuru { get; set; }
        public string IslemIp { get; set; }
    }
}
