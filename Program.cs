using System;
using System.Linq;
using Domain;
using DataAccess;
using static System.Console;

namespace _15Marketing
{
    class Program
    {
        static void Main(string[] args)
        {
            var productRepository = new SqlProductRepository("sql1");
            var productService = new ProductService(productRepository);
            var myProducts = productService.GetProducts();
            WriteLine($"Product found: {myProducts.Count()} using Sql engine 1");
        }
    }
}
