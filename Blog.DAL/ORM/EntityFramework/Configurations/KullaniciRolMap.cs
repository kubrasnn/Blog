using Blog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL.ORM.EntityFramework.Configurations
{
    public class KullaniciRolMap : EntityTypeConfiguration<KullaniciRol>
    {
        public KullaniciRolMap()
        {
            HasKey<int>(x => x.KullaniciRolId);

            HasOptional(x => x.Kullanici)
                .WithMany(x => x.KullaniciRol)
                .HasForeignKey(x => x.KullaniciId);

            HasOptional(x => x.Rol)
                .WithMany(x => x.KullaniciRol)
                .HasForeignKey(x => x.RolId);

            Property(x => x.KullaniciRolId)
                .HasColumnName("KullaniciRolId")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.RolId)
                .HasColumnName("RolId")
                .HasDatabaseGeneratedOption
                (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.KullaniciId)
                .HasColumnName("KullaniciId")
                .HasDatabaseGeneratedOption
                (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);


        }
    }
}
