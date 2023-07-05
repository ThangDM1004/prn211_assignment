using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BusinessObjects;
using Repositories;
using Microsoft.AspNetCore.Http;

namespace eStore.Controllers
{
    public class OrdersController : Controller
    {
        //private readonly FStoreDBContext _context;
		IOrderRepository o = new OrderRepository();
        ICustomerRepository customer = new CustomerRepository();
		//public OrdersController(FStoreDBContext context)
  //      {
  //          _context = context;
  //      }

        // GET: Orders
        public async Task<IActionResult> Index()
        {
			String id = HttpContext.Session.GetString("id");
			int cus_id;
			if (id == null)
			{
				cus_id = 0;
			}
			else
			{
				cus_id = int.Parse(id);
			}
			if (cus_id == 0)
			{
				return View(o.GetAllOrder());
			}
			else
			{
				return View(o.GetOrderByCustomer(cus_id));
			}
			
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = o.GetOrderByID((int)id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }



        //GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = o.GetOrderByID((int)id);
            if (order == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(customer.GetAllCustomer(), "CustomerId", "CustomerName", order.CustomerId);
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderId,CustomerId,OrderDate,ShippedDate,Total,OrderStatus")] Order order)
        {
            if (id != order.OrderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                   o.UpdateOrder(order);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!((o.GetOrderByID(order.OrderId).OrderId == id)))
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
            ViewData["CustomerId"] = new SelectList(customer.GetAllCustomer(), "CustomerId", "CustomerName", order.CustomerId);
            return View(order);
        }

        //// GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = o.GetOrderByID((int)id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        //// POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var order = o.GetOrderByID((int)id);
            o.DeleteOrder(order);
            return RedirectToAction(nameof(Index));
        }

        //private bool OrderExists(int id)
        //{
        //    return _context.Orders.Any(e => e.OrderId == id);
        //}
    }
}
