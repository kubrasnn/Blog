using Blog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL.ORM.EntityFramework.Configurations
{
    public class IletisimMap : EntityTypeConfiguration<Iletisim>
    {
        public IletisimMap()
        {
            this.HasKey<int>(x => x.MailId);

        }
    }
}
