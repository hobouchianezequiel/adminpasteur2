using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AdminPasteur.Data;
using delSur_Solutions.Models.admin_pasteur;

namespace AdminPasteur.Controllers
{
    public class AffiliatesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AffiliatesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Affiliates
        public async Task<IActionResult> Index()
        {
            return View(await _context.Affiliate.ToListAsync());
        }

        // GET: Affiliates/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var affiliate = await _context.Affiliate
                .FirstOrDefaultAsync(m => m.Id == id);
            if (affiliate == null)
            {
                return NotFound();
            }

            return View(affiliate);
        }

        // GET: Affiliates/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Affiliates/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,LastName,FullName,CredentialNumber,Plan")] Affiliate affiliate)
        {
            if (ModelState.IsValid)
            {
                _context.Add(affiliate);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(affiliate);
        }

        // GET: Affiliates/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var affiliate = await _context.Affiliate.FindAsync(id);
            if (affiliate == null)
            {
                return NotFound();
            }
            return View(affiliate);
        }

        // POST: Affiliates/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,LastName,FullName,CredentialNumber,Plan")] Affiliate affiliate)
        {
            if (id != affiliate.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(affiliate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AffiliateExists(affiliate.Id))
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
            return View(affiliate);
        }

        // GET: Affiliates/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var affiliate = await _context.Affiliate
                .FirstOrDefaultAsync(m => m.Id == id);
            if (affiliate == null)
            {
                return NotFound();
            }

            return View(affiliate);
        }

        // POST: Affiliates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var affiliate = await _context.Affiliate.FindAsync(id);
            _context.Affiliate.Remove(affiliate);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AffiliateExists(int id)
        {
            return _context.Affiliate.Any(e => e.Id == id);
        }
    }
}
