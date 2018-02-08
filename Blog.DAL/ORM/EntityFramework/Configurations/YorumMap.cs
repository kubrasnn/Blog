using Blog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL.ORM.EntityFramework.Configurations
{
    public class YorumMap : EntityTypeConfiguration<Yorum>
    {
        public YorumMap()
        {
            this.HasKey<int>(x => x.YorumId);
            HasOptional(x => x.Makale)
                .WithMany(x => x.Yorum)
                .HasForeignKey(x => x.MakaleId);
            this.Property(x => x.AdSoyad)
                .HasMaxLength(50);
        }
    }
}
