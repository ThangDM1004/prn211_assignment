using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public List<Order> GetAllOrder() => OrderDAO.GetAllOrder();
        public  List<Order> GetOrderByCustomer(int ID) => OrderDAO.GetOrderByCustomer(ID);
        public void UpdateOrder(Order ord) => OrderDAO.UpdateOrder(ord);
        public  void DeleteOrder(Order ord) => OrderDAO.DeleteOrder(ord);
        public void CreateOder(Order order) => OrderDAO.CreateOder(order);
        public Order GetOrderByCustomerID(int id) => OrderDAO.GetOrderByCustomerID(id);
    }
}
