using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mockup.DAL;
using DAL;

namespace BLL.TEST
{
    [TestClass]
    public class UnitTest
    {

        Product watch = new Product() { ProductID = 1, Name = "WATCH", Price = 1000 };
        Product mouse = new Product() { ProductID = 1, Name = "MOUSE", Price = 500 };

        [TestMethod]
        public void TestOrder()
        {
            Order o = new Order();
            o.AddOrderItem(watch, 1);
            o.AddOrderItem(mouse, 2);

            Assert.AreEqual(2000, o.GetTotalPrice());
        }

        [TestMethod]
        public void TestAddSameProduct()
        {
            Order o = new Order();
            o.AddOrderItem(watch, 1);
            o.AddOrderItem(watch, 1);

            Assert.AreEqual(2000, o.GetTotalPrice());
        }


        [TestMethod]
        public void TestRepository()
        {
            IOrderRepository rep = new OrderRepository();
            rep.SaveOrder(new Order() { OrderID = 11 });
            Assert.IsNotNull(rep.GetOrder(11), "GetOrder can't find data");
            Assert.AreEqual(11, rep.GetOrder(11).OrderID, "GetOrder return wrong value");
        }
    }
}
