using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SelfHostServer.Host
{
    public class OrdersController : ApiController
    {
        Order[] orders = new Order[]
        {
            new Order { Id = 1, Name = "BMW 730li", Category = "Car", Price = 125},
            new Order { Id = 2, Name = "BMW M8 Competition", Category = "Car", Price = 126},
            new Order { Id = 3, Name = "BMW M5", Category = "Car", Price = 127},
        };

        public IEnumerable<Order> GetAllOrders()
        {
            return orders;
        }
    }
}
