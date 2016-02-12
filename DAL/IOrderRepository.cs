using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IOrderRepository
    {
        IList<Order> GetOrders();
        Order GetOrder(int orderID);
        bool SaveOrder(Order order);
        IList<OrderDetail> GetOrderDetails(int orderID);
    }
}
