using System;
using System.Collections.Generic;
using Domain;

namespace DataAccess
{
    public class SqlProductRepository : ProductRepository
    {
        readonly IDataStore _datastore;
        public SqlProductRepository(string sqlType) {
            _datastore = DataStoreFactory.Create(sqlType);
        }
        public override IEnumerable<Product> GetProducts()
        { 
            // Use the _datastore to query the db
            throw new NotImplementedException();
        }
    }
}
