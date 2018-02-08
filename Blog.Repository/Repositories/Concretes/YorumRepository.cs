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
    public class YorumRepository : RepositoryBase<Yorum>, IYorumRepository
    {
        public YorumRepository(BlogContext dbContext) :base(dbContext)
        {

        }

        public List<Yorum> MakaleyeGoreYorumGetir(int Id)
        {
            return _dbSet.Where(x => x.MakaleId == Id).ToList();
        }
    }
}
