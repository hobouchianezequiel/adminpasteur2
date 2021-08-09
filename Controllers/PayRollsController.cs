using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AdminPasteur.Data;
using delSur_Solutions.Models;

namespace AdminPasteur.Controllers
{
    public class PayRollsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PayRollsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PayRolls
        public async Task<IActionResult> Index()
        {
            return View(await _context.PayRoll.ToListAsync());
        }

        // GET: PayRolls/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var payRoll = await _context.PayRoll
                .FirstOrDefaultAsync(m => m.Id == id);
            if (payRoll == null)
            {
                return NotFound();
            }

            return View(payRoll);
        }

        // GET: PayRolls/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PayRolls/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Date,CodPrest,Trans,AuthorizationNumber,Diagnosis,Coseg,InvoicedPeriod,ConsultingRoom,Observations,Amount,TotalAmount")] PayRoll payRoll)
        {
            if (ModelState.IsValid)
            {
                _context.Add(payRoll);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(payRoll);
        }

        // GET: PayRolls/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var payRoll = await _context.PayRoll.FindAsync(id);
            if (payRoll == null)
            {
                return NotFound();
            }
            return View(payRoll);
        }

        // POST: PayRolls/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Date,CodPrest,Trans,AuthorizationNumber,Diagnosis,Coseg,InvoicedPeriod,ConsultingRoom,Observations,Amount,TotalAmount")] PayRoll payRoll)
        {
            if (id != payRoll.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(payRoll);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PayRollExists(payRoll.Id))
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
            return View(payRoll);
        }

        // GET: PayRolls/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var payRoll = await _context.PayRoll
                .FirstOrDefaultAsync(m => m.Id == id);
            if (payRoll == null)
            {
                return NotFound();
            }

            return View(payRoll);
        }

        // POST: PayRolls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var payRoll = await _context.PayRoll.FindAsync(id);
            _context.PayRoll.Remove(payRoll);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PayRollExists(int id)
        {
            return _context.PayRoll.Any(e => e.Id == id);
        }
    }
}
