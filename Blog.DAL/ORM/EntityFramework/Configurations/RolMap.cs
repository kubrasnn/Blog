using Blog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL.ORM.EntityFramework.Configurations
{
    public class RolMap: EntityTypeConfiguration<Rol>
    {
        public RolMap()
        {
            this.HasKey<int>(x => x.RolId);
            this.Property(x => x.RolAdi)
                .HasMaxLength(50);
        }
    }
}
