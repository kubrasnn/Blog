using Blog.DAL.ORM.EntityFramework.Context;
using Blog.Entity.Entities;
using Blog.Repository.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Repository.Repositories.Concretes
{
    public class IletisimRepository : RepositoryBase<Iletisim>, IIletisimRepository
    {
        public IletisimRepository(BlogContext context) :base(context)
        {

        }
    }
}
