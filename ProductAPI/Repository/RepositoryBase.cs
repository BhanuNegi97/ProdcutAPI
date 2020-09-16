using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductAPI.DataAccess;
using ProductAPI.Filters;

namespace ProductAPI.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected ProductAPIDBContext _ProductAPIDBContext { get; set; }
        public RepositoryBase(ProductAPIDBContext repositoryContext)
        {
            this._ProductAPIDBContext = repositoryContext;
        }
        public IQueryable<T> GetAll()
        {
            return this._ProductAPIDBContext.Set<T>().AsNoTracking();
        }
        public  IQueryable<T> GetByCondition(string searchTerm, params Expression<Func<T, string>>[] stringProperties)
        {
            return this._ProductAPIDBContext.Set<T>().Search(searchTerm, stringProperties).AsNoTracking().AsQueryable();
        }

      
    }
}
