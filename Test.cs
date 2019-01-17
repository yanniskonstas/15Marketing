using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using DataAccess;
using Domain;


namespace Test
{
   static class Tests
   {
        [Test]
        public static void TestSqlEngine1(){
            // We first initialise the repository we want to use 
            // to retrieve the products data from a specific datastore
            // In this test case we select to use 'sql1' database engine
            var productRepository = new SqlProductRepository("sql1");
            // We then create the products service instance by injecting the repo
            var productService = new ProductService(productRepository);
            // We query the products from db
            var myProducts = productService.GetProducts();
            // We test if we got any products back
            Assert.AreEqual(myProducts.Any(), true);
        }
    }
}
