using ProductAPI.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductAPI.Repository;

namespace ProductAPI.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ProductAPIDBContext _productAPIDBContext;
        private IProductRepository _productRepository;

        public RepositoryWrapper(ProductAPIDBContext productAPIDBContext)
        {
            _productAPIDBContext = productAPIDBContext;
        }

        public IProductRepository Product
        {
            get
            {
                if (_productRepository == null)
                {
                    _productRepository = new ProductRepository(_productAPIDBContext);
                }
                return _productRepository;
            }
        }

        
    }
}
