using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ProductAPI.Model;

namespace ProductAPI.Repository
{
    
        public interface IRepositoryBase<T>
        {
            IQueryable<T> GetAll();
            IQueryable<T> GetByCondition(string searchTerm, params Expression<Func<T, string>>[] stringProperties);
            
        }
   
}
