using System;
using System.Collections.Generic;

#nullable disable

namespace BakkalUygulamasi.entity.Data
{
    public partial class KullaniciLogUp
    {
        public int KluId { get; set; }
        public string EskiKKullaniciadi { get; set; }
        public string YeniKKullaniciadi { get; set; }
        public string EskiKParola { get; set; }
        public string YeniKParola { get; set; }
        public string EskiKAdi { get; set; }
        public string YeniKAdi { get; set; }
        public string EskiKSoyadi { get; set; }
        public string YeniKSoyadi { get; set; }
        public string EskiKEposta { get; set; }
        public string YeniKEposta { get; set; }
        public string EskiKTelefon { get; set; }
        public string YeniKTelefon { get; set; }
        public bool? EskiKDurum { get; set; }
        public bool? YeniKDurum { get; set; }
        public int? EskiRolId { get; set; }
        public int? YeniRolId { get; set; }
        public DateTime IslemTarihi { get; set; }
        public string IslemIp { get; set; }
    }
}
