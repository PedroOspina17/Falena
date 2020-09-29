using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using falena.Data;
using falena.Models;
using falena.Models.Enums;

namespace falena.Controllers
{
    public class TransactionsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public TransactionsController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: Transactions
        public async Task<IActionResult> Sales()
        {
            return View(await _context.Transactions.ToListAsync());
        }

        public async Task<IActionResult> Purchases()
        {
            return View(await _context.Transactions.ToListAsync());
        }



        // GET: Transactions/Details/5
        public async Task<IActionResult> TransactionDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transaction = await _context.TransactionDetails.Where(m => m.TransactionHeader.Id == id).Include(x=>x.Product).ToListAsync();
            if (transaction == null)
            {
                return NotFound();
            }

            return View(transaction);
        }

        // GET: Transactions/Create
        public async Task<IActionResult> Create(int TransactionType)
        {
            ViewData["TransactionType"] = TransactionType;
            if (TransactionType == 1)
            {
                ViewData["Sellers"] =await _context.Employees.Where(x=> x.IsActive && x.EmployeeType == EmployeeEnums.EmployeeType.Seller).ToListAsync();
            }
            
            return View();
        }

        // POST: Transactions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TransactionViewModel transaction)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    var entity = _mapper.Map<Transaction>(transaction);
                    entity.Seller = await _context.Employees.FindAsync(transaction.SellerId);

                    for (var i = 0; i< transaction.Details.Count; i++)
                    {
                        var product = await _context.Products.FindAsync(transaction.Details[i].ProductId);
                        if (transaction.TransactionType == TransactionEnum.TransactionType.sales)
                        {
                            transaction.Details[i].Quantity *= -1;
                        }
                        
                        product.CurrentStock += transaction.Details[i].Quantity;
                        
                        entity.Details[i].Product = product;
                    }
                    _context.Add(entity);

                    


                    //var p = _context.Products.Find(transaction.Details[0].Id);
                    //p.Sales = 0;

                    await _context.SaveChangesAsync();
                    return Ok();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
                
            }
            return Json(transaction);
        }

        // GET: Transactions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transaction = await _context.Transactions.FindAsync(id);
            if (transaction == null)
            {
                return NotFound();
            }
            return View(transaction);
        }

        // POST: Transactions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,Date,TransactionType,Observations,TransactionStatus,Total")] TransactionViewModel transaction)
        //{
        //    if (id != transaction.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(transaction);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!TransactionExists(transaction.Id))
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
        //    return View(transaction);
        //}

        // GET: Transactions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transaction = await _context.Transactions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (transaction == null)
            {
                return NotFound();
            }

            return View(transaction);
        }

        // POST: Transactions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var transaction = await _context.Transactions.FindAsync(id);
            _context.Transactions.Remove(transaction);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransactionExists(int id)
        {
            return _context.Transactions.Any(e => e.Id == id);
        }
    }
}
