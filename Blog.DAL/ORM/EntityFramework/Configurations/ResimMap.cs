using Blog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL.ORM.EntityFramework.Configurations
{
    public class ResimMap : EntityTypeConfiguration<Resim>
    {
        public ResimMap()
        {
            this.HasKey<int>(x => x.ResimId);
        }
    }
}
