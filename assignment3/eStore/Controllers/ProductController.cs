﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BusinessObjects;
using Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.IO;
using static System.Collections.Specialized.BitVector32;

namespace eStore.Controllers
{
	public class ProductController : Controller
	{
		IProductRepository repo = new ProductRepository();
		IOrderRepository o = new OrderRepository();
		IOrderDetailRepository odRep = new OrderDetailRepository();
		ICustomerRepository cus = new CustomerRepository();
		// GET: Product
		public async Task<IActionResult> Index()
		{

			return View(repo.GetAllProduct());
		}
		public async Task<IActionResult> Search()
		{
			return View(repo.GetAllProduct());

		}
		public ActionResult SearchCheck(string name, int price)
		{
			decimal min = 0;
			decimal max = 0;
			if (price == 1)
			{
				min = decimal.Parse("0");
				max = decimal.Parse("100");
			}
			else if (price == 2)
			{
				min = decimal.Parse("101");
				max = decimal.Parse("200");
			}

			return View(repo.SearchProduct(name, min, max));
		}
		public int CreateOrderID()
		{
			int id = 0;
			var order = o.GetAllOrder().OrderByDescending(o => o.OrderId).FirstOrDefault();
			id = order.OrderId + 1;
			return id;
		}
		public OrderDetail GetNewOrderDetails(Order order, FlowerBouquet flowerBouquet)
		{
			OrderDetail orderDetail = odRep.GetOrderDetailByOrderIdAndProductId(order, flowerBouquet);
			if (orderDetail == null)
			{
				orderDetail = new OrderDetail
				{
					OrderId = order.OrderId,
					FlowerBouquetId = flowerBouquet.FlowerBouquetId,
					UnitPrice = flowerBouquet.UnitPrice,
					Quantity = 1,
					Discount = 0
				};
			}
			else { 
				orderDetail.Quantity += 1; 
			}
			return orderDetail;
		}
		public void AddOrUpdateOrderDetail(Order order, FlowerBouquet flowerBouquet, OrderDetail orderDetail)
		{
			OrderDetail orderDetail1 = odRep.GetOrderDetailByOrderIdAndProductId(order, flowerBouquet);
			if (orderDetail1 == null) { odRep.AddOrderDetail(orderDetail); }
			else odRep.UpdateOrderDetail(orderDetail);
		}
		public ActionResult Order(int? id)
		{
			String cus_id = HttpContext.Session.GetString("id");
			int int_id = int.Parse(cus_id);
			Order order = o.GetOrderByCustomerID(int_id);
			if (order == null || order.OrderStatus.Trim() == "Done")
			{
				order = new Order
				{
					OrderId = CreateOrderID(),
					CustomerId = int_id,
					OrderDate = DateTime.Now,
					OrderStatus = "Not Done",
					Total = 0
				};


				OrderDetail orderDetail = GetNewOrderDetails(order, repo.GetProductById(int_id));
				order.Total += orderDetail.UnitPrice * (100 - (decimal)orderDetail.Discount) / 100;
				o.CreateOder(order);
				AddOrUpdateOrderDetail(order, repo.GetProductById(int_id), orderDetail);
				return View();
			}
			else
			{
				OrderDetail orderDetail = GetNewOrderDetails(order, repo.GetProductById(int_id));
				order.Total += orderDetail.UnitPrice * (100 - (decimal)orderDetail.Discount) / 100;
				o.UpdateOrder(order);
				AddOrUpdateOrderDetail(order, repo.GetProductById(int_id), orderDetail);
				return View();
			}


		}
		// GET: Product/Details/5
		public async Task<IActionResult> Details(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var flowerBouquet = repo.GetProductById((int)id);

			if (flowerBouquet == null)
			{
				return NotFound();
			}
			return View(flowerBouquet);
		}

		// GET: Product/Create
		public IActionResult Create()
		{
			ViewData["CategoryId"] = new SelectList(repo.GetCategories(), "CategoryId", "CategoryName");
			ViewData["SupplierId"] = new SelectList(repo.GetSupplier(), "SupplierId", "SupplierId");
			return View();
		}

		// POST: Product/Create
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("FlowerBouquetId,CategoryId,FlowerBouquetName,Description,UnitPrice,UnitsInStock,FlowerBouquetStatus,SupplierId")] FlowerBouquet flowerBouquet)
		{
			if (ModelState.IsValid)
			{
				repo.SaveProduct(flowerBouquet);
				return RedirectToAction(nameof(Index));
			}
			ViewData["CategoryId"] = new SelectList(repo.GetCategories(), "CategoryId", "CategoryName", flowerBouquet.CategoryId);
			ViewData["SupplierId"] = new SelectList(repo.GetSupplier(), "SupplierId", "SupplierId", flowerBouquet.SupplierId);
			return View(flowerBouquet);
		}

		// GET: Product/Edit/5
		public async Task<IActionResult> Edit(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var flowerBouquet = repo.GetProductById((int)id);
			if (flowerBouquet == null)
			{
				return NotFound();
			}
			ViewData["CategoryId"] = new SelectList(repo.GetCategories(), "CategoryId", "CategoryName", flowerBouquet.CategoryId);
			ViewData["SupplierId"] = new SelectList(repo.GetSupplier(), "SupplierId", "SupplierId", flowerBouquet.SupplierId);
			return View(flowerBouquet);
		}

		// POST: Product/Edit/5
		// To protect from overposting attacks, enable the specific properties you want to bind to.
		// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit(int id, [Bind("FlowerBouquetId,CategoryId,FlowerBouquetName,Description,UnitPrice,UnitsInStock,FlowerBouquetStatus,SupplierId")] FlowerBouquet flowerBouquet)
		{
			if (id != flowerBouquet.FlowerBouquetId)
			{
				return NotFound();
			}

			if (ModelState.IsValid)
			{
				try
				{
					repo.UpdateProduct(flowerBouquet);
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!(repo.GetProductById(flowerBouquet.FlowerBouquetId).FlowerBouquetId == id))
					{
						return NotFound();
					}
					else
					{
						throw;
					}
				}
				return RedirectToAction(nameof(Index));
			}
			ViewData["CategoryId"] = new SelectList(repo.GetCategories(), "CategoryId", "CategoryName", flowerBouquet.CategoryId);
			ViewData["SupplierId"] = new SelectList(repo.GetSupplier(), "SupplierId", "SupplierId", flowerBouquet.SupplierId);
			return View(flowerBouquet);
		}

		// GET: Product/Delete/5
		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var flowerBouquet = repo.GetProductById((int)id);
			if (flowerBouquet == null)
			{
				return NotFound();
			}

			return View(flowerBouquet);
		}

		// POST: Product/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			var flowerBouquet = repo.GetProductById((int)id);
			repo.DeleteProduct(flowerBouquet);
			return RedirectToAction(nameof(Index));
		}

		//private bool FlowerBouquetExists(int id)
		//{
		//    return _context.FlowerBouquets.Any(e => e.FlowerBouquetId == id);
		//}
	}
}
