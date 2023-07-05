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
    public class OrderDetailsController : Controller
    {
        //private readonly FStoreDBContext _context;

        //public OrderDetailsController(FStoreDBContext context)
        //{
        //    _context = context;
        //}
        IOrderDetailRepository od = new OrderDetailRepository();
        // GET: OrderDetails
        public async Task<IActionResult> Index(int? id)
        {
            return View(od.GetOrderDetails((int) id));
        }

        // GET: OrderDetails/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var orderDetail = od.GetOrderDetailByID((int)id);
        //    if (orderDetail == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(orderDetail);
        //}

        // GET: OrderDetails/Create
        //public IActionResult Create()
        //{
        //    ViewData["FlowerBouquetId"] = new SelectList(_context.FlowerBouquets, "FlowerBouquetId", "Description");
        //    ViewData["OrderId"] = new SelectList(_context.Orders, "OrderId", "OrderId");
        //    return View();
        //}

        //// POST: OrderDetails/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("OrderId,FlowerBouquetId,UnitPrice,Quantity,Discount")] OrderDetail orderDetail)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(orderDetail);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["FlowerBouquetId"] = new SelectList(_context.FlowerBouquets, "FlowerBouquetId", "Description", orderDetail.FlowerBouquetId);
        //    ViewData["OrderId"] = new SelectList(_context.Orders, "OrderId", "OrderId", orderDetail.OrderId);
        //    return View(orderDetail);
        //}

        //// GET: OrderDetails/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var orderDetail = await _context.OrderDetails.FindAsync(id);
        //    if (orderDetail == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["FlowerBouquetId"] = new SelectList(_context.FlowerBouquets, "FlowerBouquetId", "Description", orderDetail.FlowerBouquetId);
        //    ViewData["OrderId"] = new SelectList(_context.Orders, "OrderId", "OrderId", orderDetail.OrderId);
        //    return View(orderDetail);
        //}

        //// POST: OrderDetails/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("OrderId,FlowerBouquetId,UnitPrice,Quantity,Discount")] OrderDetail orderDetail)
        //{
        //    if (id != orderDetail.OrderId)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(orderDetail);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!OrderDetailExists(orderDetail.OrderId))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["FlowerBouquetId"] = new SelectList(_context.FlowerBouquets, "FlowerBouquetId", "Description", orderDetail.FlowerBouquetId);
        //    ViewData["OrderId"] = new SelectList(_context.Orders, "OrderId", "OrderId", orderDetail.OrderId);
        //    return View(orderDetail);
        //}

        // GET: OrderDetails/Delete/5
        //public async Task<IActionResult> Delete(OrderDetail o)
        //{
        //    if (o == null)
        //    {
        //        return NotFound();
        //    }

        //    var orderDetail = od.GetOrderDetailByID(o.OrderId,o.FlowerBouquetId);
        //    if (orderDetail == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(orderDetail);
        //}

        //// POST: OrderDetails/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var orderDetail = await _context.OrderDetails.FindAsync(id);
        //    _context.OrderDetails.Remove(orderDetail);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool OrderDetailExists(int id)
        //{
        //    return _context.OrderDetails.Any(e => e.OrderId == id);
        //}
    }
}
