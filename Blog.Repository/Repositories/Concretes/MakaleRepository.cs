using Blog.DAL.ORM.EntityFramework.Context;
using Blog.Entity.Entities;
using Blog.Repository.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Repository.Repositories.Concretes
{
    public class MakaleRepository : RepositoryBase<Makale> , IMakaleRepository
    {
        public MakaleRepository(BlogContext dbContext) :base(dbContext)
        {

        }
        public List<Makale> KategoriyeGoreMakaleGetir(int Id)
        {
            return _dbSet.Where(x => x.KategoriId == Id).ToList();
        }

        public List<Makale> KullaniciyaAitMakaleGetir(int Id)
        {
            return _dbSet.Where(x => x.KullaniciId == Id).ToList();
        }
    }
}
