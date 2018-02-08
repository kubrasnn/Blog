using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.Entities
{
    
    public class KullaniciRol 
    {
 
        public int KullaniciRolId { get; set; }

        public int? RolId { get; set; }

        public int? KullaniciId { get; set; }

        public virtual Kullanici Kullanici { get; set; }

        public virtual Rol Rol { get; set; }
    }
}
