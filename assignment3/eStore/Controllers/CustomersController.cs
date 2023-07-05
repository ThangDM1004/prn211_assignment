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
    public class CustomersController : Controller
    {
        //private readonly FStoreDBContext _context;

        //public CustomersController(FStoreDBContext context)
        //{
        //    _context = context;
        //}
        ICustomerRepository cus = new CustomerRepository();
        // GET: Customers
        public async Task<IActionResult> Index()
        {
			String id  = HttpContext.Session.GetString("id");
			int cus_id;
			if (id == null)
            {
                cus_id = 0;
            }
            else
            {
                cus_id = int.Parse(id);
            }
            if(cus_id == 0)
            {
				return View(cus.GetAllCustomer());
            }
            else
            {
				return View(cus.GetAllCustomerByID(cus_id));
			}
			
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = cus.getMemberByID((int)id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerId,Email,CustomerName,City,Country,Password,Birthday")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                cus.SaveCustomer(customer);
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = cus.getMemberByID((int) id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerId,Email,CustomerName,City,Country,Password,Birthday")] Customer customer)
        {
            if (id != customer.CustomerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    cus.UpdateCustomer(customer);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!(cus.getMemberByID(customer.CustomerId).CustomerId == id))
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
            return View(customer);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = cus.getMemberByID((int)id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = cus.getMemberByID((int)id);
            cus.DeleteCustomer(customer);
			return RedirectToAction(nameof(Index));
        }

       
    }
}
