using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class OrderDetailDAO
    {
        public static List<OrderDetail> GetOrderDetails(int ID)
        {
            List<OrderDetail> orderDetails = new List<OrderDetail>();
            try
            {
                using(var context = new FStoreDBContext())
                {
                    orderDetails = context.OrderDetails.Where(o => o.OrderId == ID).ToList();
                }
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orderDetails;
        }
        public static void DeleteOrder(int ID, int OrderID)
        {
            try
            {
                using (var context = new FStoreDBContext())
                {
                    var p1 = context.OrderDetails.SingleOrDefault(m => (m.FlowerBouquetId == ID && m.OrderId == OrderID));
                    context.OrderDetails.Remove(p1);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void AddOrderDetail(OrderDetail orderDetail)
        {
            try
            {
                using (var context = new FStoreDBContext())
                {
                    context.OrderDetails.Add(orderDetail);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static OrderDetail GetOrderDetailByOrderIdAndProductId(Order order, FlowerBouquet flower)
        {
            OrderDetail orderDetail = null;
            try
            {
                using (var context = new FStoreDBContext())
                {
                    orderDetail = context.OrderDetails.SingleOrDefault(o => o.OrderId == order.OrderId && o.FlowerBouquetId == flower.FlowerBouquetId);

                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return orderDetail;
        }
        public static void UpdateOrderDetail(OrderDetail orderDetail)
        {
            try
            {
                using (var context = new FStoreDBContext())
                {
                    context.Entry<OrderDetail>(orderDetail).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
