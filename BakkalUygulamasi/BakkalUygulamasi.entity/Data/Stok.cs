using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace BakkalUygulamasi.entity.Data
{
    public partial class Stok
    {
        public Stok()
        {
            Uruns = new HashSet<Urun>();
        }

        public int StokId { get; set; }
        public int SAdedi { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime SGirisTarihi { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? SBitisTarihi { get; set; }

        public virtual ICollection<Urun> Uruns { get; set; }
    }
}
