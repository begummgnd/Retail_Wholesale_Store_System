using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

#nullable disable

namespace BakkalUygulamasi.entity.Data
{
    public partial class Rol
    {
        public Rol()
        {
            Kullanicis = new HashSet<Kullanici>();
        }

        public int RolId { get; set; }
        public string RAdi { get; set; }

        public virtual ICollection<Kullanici> Kullanicis { get; set; }
      
     
    }
}
