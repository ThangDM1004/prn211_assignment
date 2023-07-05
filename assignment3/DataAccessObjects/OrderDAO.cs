using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class OrderDAO
    {
        public static List<Order> GetAllOrder()
        {
            List<Order> list = new List<Order>();
            try
            {
                using (var context = new FStoreDBContext())
                {
                    list = context.Orders.Include(f => f.Customer ).ToList();
                }
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }
        public static List<Order> GetOrderByCustomer(int ID)
        {
            List<Order> list = new List<Order>();
            try
            {
                using (var context = new FStoreDBContext())
                {
                    list = context.Orders.Where( o => o.CustomerId == ID).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }
        public static void UpdateOrder(Order ord)
        {
            try
            {
                using (var context = new FStoreDBContext())
                {
                    context.Entry<Order>(ord).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void DeleteOrder(Order ord)
        {
            try
            {
                using (var context = new FStoreDBContext())
                {
                    var p1 = context.Orders.SingleOrDefault(m => m.OrderId == ord.OrderId);
                    List<OrderDetail> p2 = context.OrderDetails.Where(m => m.OrderId == ord.OrderId).ToList();
                    foreach (var p in p2)
                    {
                        context.OrderDetails.Remove(p);
                    }
                    context.Orders.Remove(p1);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void CreateOder(Order order)
        {
            try
            {
                using (var context = new FStoreDBContext())
                {
                    context.Orders.Add(order);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.InnerException.Message);
            }
        }

        public static Order GetOrderByCustomerID(int id)
        {
            Order order = null;
            try
            {
                using (var context = new FStoreDBContext())
                {
                    order = context.Orders.Include(o => o.OrderDetails).OrderByDescending(o => o.OrderId).FirstOrDefault(o => o.CustomerId == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return order;
        }
        public static Order GetOrderByID(int id)
        {
			Order order = null;
			try
			{
				using (var context = new FStoreDBContext())
				{
                    order = context.Orders.SingleOrDefault(o => o.OrderId == id);
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
			return order;
		}

    }
}
