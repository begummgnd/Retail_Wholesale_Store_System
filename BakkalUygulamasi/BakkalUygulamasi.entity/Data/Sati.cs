using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace BakkalUygulamasi.entity.Data
{
    public partial class Sati
    {
        public Sati()
        {
            SatisMaddeleris = new HashSet<SatisMaddeleri>();
        }

        public int SatisId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime STarih { get; set; }

        [Display(Name = "Satış Durumu", Prompt = "Ürünün mevcut satış durumunu 0:Başarısız 1:Başarılı biçiminde giriniz.")]
        public string SDurum { get; set; }
        public int KullaniciId { get; set; }

        public virtual Kullanici Kullanici { get; set; }
        public virtual ICollection<SatisMaddeleri> SatisMaddeleris { get; set; }
    }
}
