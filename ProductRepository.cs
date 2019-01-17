using System;
using System.Collections.Generic;

namespace Domain
{
    public abstract class ProductRepository
    {
        public abstract IEnumerable<Product> GetProducts();
    }
}
