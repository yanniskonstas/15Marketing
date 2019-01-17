using System;
using System.Collections.Generic;

namespace Domain
{
    public class ProductService
    {
        private readonly ProductRepository _repository;
        public ProductService(ProductRepository repository)
        {
            if (repository == null)            
                throw new ArgumentNullException("Repository not found");
            _repository = repository;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _repository.GetProducts();            
        }
    }
}
