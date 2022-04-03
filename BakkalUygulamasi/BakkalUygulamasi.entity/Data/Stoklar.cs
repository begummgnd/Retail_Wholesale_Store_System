using System;
using System.Collections.Generic;

#nullable disable

namespace BakkalUygulamasi.entity.Data
{
    public partial class Stoklar
    {
        public int StokId { get; set; }
        public int SAdedi { get; set; }
        public DateTime SId { get; set; }
        public DateTime SBitisTarihi { get; set; }
    }
}
