using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
	public class OrderDetailRepository : IOrderDetailRepository
	{
		public List<OrderDetail> GetOrderDetails(int ID) => OrderDetailDAO.GetOrderDetails(ID);
		public void AddOrderDetail(OrderDetail orderDetail) => OrderDetailDAO.AddOrderDetail(orderDetail);
		public OrderDetail GetOrderDetailByOrderIdAndProductId(Order order, FlowerBouquet flower) => OrderDetailDAO.GetOrderDetailByOrderIdAndProductId(order, flower);
		public void DeleteOrder(int ID, int OrderID) => OrderDetailDAO.DeleteOrder(ID, OrderID);
		public void UpdateOrderDetail(OrderDetail orderDetail) => OrderDetailDAO.UpdateOrderDetail(orderDetail);

		public OrderDetail GetOrderDetailByID(int id, int id2) => OrderDetailDAO.GetOrderDetailByID(id,id2);
	}
}
