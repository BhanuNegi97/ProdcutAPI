using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductAPI.DataAccess;
using ProductAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ProductAPI.Filters;

namespace ProductAPI.Repository
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
       public ProductRepository(ProductAPIDBContext repositoryContext) : base(repositoryContext)
        {
            
        }

        public  async Task<IEnumerable<Product>> GetAllProductAsync()
        {
            return await this.GetAll().ToListAsync();
        }

        public async Task<Product> GetProductByIdAsync(int productid)
        {
            return await GetAll().Where(x => x.productId.Equals(productid)).FirstOrDefaultAsync();
        }
        public async Task<Product> GetProductByNameAsync(string prodName)
        {
            return await GetAll().Where(x => x.name.Equals(prodName)).FirstOrDefaultAsync();
        }
        public new async Task<IEnumerable<Product>> GetByCondition(string searchTerm, params Expression<Func<Product, string>>[] stringProperties)
        {
            return await GetByCondition(searchTerm, stringProperties);
        }
    }
}
