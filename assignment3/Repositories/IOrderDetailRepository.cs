using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IOrderDetailRepository
    {
        List<OrderDetail> GetOrderDetails(int ID);
        void AddOrderDetail(OrderDetail orderDetail);
        OrderDetail GetOrderDetailByOrderIdAndProductId(Order order, FlowerBouquet flower);
        void DeleteOrder(int ID, int OrderID);
        void UpdateOrderDetail(OrderDetail orderDetail);
        public OrderDetail GetOrderDetailByID(int id, int id2);
    }
}
