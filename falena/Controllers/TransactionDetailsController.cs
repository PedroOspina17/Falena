using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using falena.Data;
using falena.Models;

namespace falena.Controllers
{
    public class TransactionDetailsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TransactionDetailsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TransactionDetails
        public async Task<IActionResult> Index()
        {
            return View(await _context.TransactionDetails.ToListAsync());
        }

        // GET: TransactionDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transactionDetail = await _context.TransactionDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (transactionDetail == null)
            {
                return NotFound();
            }

            return View(transactionDetail);
        }

        // GET: TransactionDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TransactionDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Quantity,QurrentPrice,SubTotal")] TransactionDetail transactionDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transactionDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(transactionDetail);
        }

        // GET: TransactionDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transactionDetail = await _context.TransactionDetails.FindAsync(id);
            if (transactionDetail == null)
            {
                return NotFound();
            }
            return View(transactionDetail);
        }

        // POST: TransactionDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Quantity,QurrentPrice,SubTotal")] TransactionDetail transactionDetail)
        {
            if (id != transactionDetail.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transactionDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransactionDetailExists(transactionDetail.Id))
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
            return View(transactionDetail);
        }

        // GET: TransactionDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transactionDetail = await _context.TransactionDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (transactionDetail == null)
            {
                return NotFound();
            }

            return View(transactionDetail);
        }

        // POST: TransactionDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var transactionDetail = await _context.TransactionDetails.FindAsync(id);
            _context.TransactionDetails.Remove(transactionDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransactionDetailExists(int id)
        {
            return _context.TransactionDetails.Any(e => e.Id == id);
        }
    }
}
