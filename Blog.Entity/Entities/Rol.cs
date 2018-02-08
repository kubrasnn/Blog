using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.Entities
{

    public class Rol 
    {
        public Rol()
        {
            KullaniciRol = new HashSet<KullaniciRol>();
        }
        
        public int RolId { get; set; }

        public string RolAdi { get; set; }

        public virtual ICollection<KullaniciRol> KullaniciRol { get; set; }
    }
}
