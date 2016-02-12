using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double  Price { get; set; }
    }

    public class OrderDetail
    {
        public Order Order { get; set; }
        public Product Product { get; set; }
        public int Qty { get; set; }
    }

    public class Order
    {
        public Order()
        {
            Items = new List<OrderDetail>();
        }
        public int OrderID { get; set; }

        public double GetTotalPrice()
        {
            double total = 0;
            foreach (OrderDetail item in Items)
            {
                total += item.Qty * item.Product.Price;
            }

            return total;
        }

        public IList<OrderDetail> Items { get; }

        public void AddOrderItem(Product product, int qty)
        {
            OrderDetail od = Items.SingleOrDefault<OrderDetail>(d => d.Product == product);
            if(od== null)
            {
                od = new OrderDetail() { Order = this, Product = product, Qty = qty };
                this.Items.Add(od);
            }
            else
            {
                od.Qty += qty;
            }
        }
    }

}
