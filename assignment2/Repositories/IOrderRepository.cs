using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IOrderRepository
    {
        List<Order> GetAllOrder();
        List<Order> GetOrderByCustomer(int ID);
        void UpdateOrder(Order ord);
        void DeleteOrder(Order ord);
        void CreateOder(Order order);
        Order GetOrderByCustomerID(int id);
    }
}
