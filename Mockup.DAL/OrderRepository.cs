using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DAL;

namespace Mockup.DAL
{
    public class OrderRepository : IOrderRepository
    {
        IList<Order> orders;
        public OrderRepository()
        {
            orders = new List<Order>();
            orders.Add(new Order() { OrderID = 1 });
            orders.Add(new Order() { OrderID = 2 });
            orders.Add(new Order() { OrderID = 3 });
            orders.Add(new Order() { OrderID = 4 });
            orders.Add(new Order() { OrderID = 5 });
            orders.Add(new Order() { OrderID = 6 });
            orders.Add(new Order() { OrderID = 7 });
            orders.Add(new Order() { OrderID = 8 });
            orders.Add(new Order() { OrderID = 9 });
            orders.Add(new Order() { OrderID = 10 });
        }

        public IList<Order> GetOrders()
        {
            return orders;
        }

        public IList<OrderDetail> GetOrderDetails(int orderID)
        {
            throw new NotImplementedException();
        }

        public Order GetOrder(int orderID)
        {
            return orders.SingleOrDefault(o => o.OrderID == orderID);
        }

        public bool SaveOrder(Order order)
        {
            orders.Add(order);

            return true;
        }
    }
}
