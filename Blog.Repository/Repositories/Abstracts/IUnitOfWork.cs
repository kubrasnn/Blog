﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Repository.Repositories.Abstracts
{
    public interface IUnitOfWork:IDisposable
    {
        bool Commit();
        IRepository<T> GetRepo<T>() where T :class, new();
            
        void Dispose(bool disposing);
    }
}
