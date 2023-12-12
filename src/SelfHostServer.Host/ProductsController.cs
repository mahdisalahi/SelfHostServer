using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SelfHostServer.Host
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product {Id =  1, Name = "BMW"},
            new Product {Id =  2, Name = "Benz"},
            new Product {Id =  3, Name = "Rolls Royce"},
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }
    }
}
