using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class Transakcje : Controller
    {
        private readonly WebApplication7Context _context;

        public Transakcje(WebApplication7Context context)
        {
            _context = context;
        }

        // GET: Transakcje
        public async Task<IActionResult> Index()
        {
            return View(await _context.Transakcja.ToListAsync());
        }

        public async Task<IActionResult> Dodaj()
       
        {
            return View();
        }
            // GET: Transakcje/Details/5
            public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transakcja = await _context.Transakcja
                .FirstOrDefaultAsync(m => m.Id == id);
            if (transakcja == null)
            {
                return NotFound();
            }

            return View(transakcja);
        }

        // GET: Transakcje/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Transakcje/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Klient,Polaczenie,Pracownik")] Transakcja transakcja)
        {
            if (ModelState.IsValid)
            {
                _context.Add(transakcja);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(transakcja);
        }

        // GET: Transakcje/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transakcja = await _context.Transakcja.FindAsync(id);
            if (transakcja == null)
            {
                return NotFound();
            }
            return View(transakcja);
        }

        // POST: Transakcje/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] Transakcja transakcja)
        {
            if (id != transakcja.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(transakcja);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TransakcjaExists(transakcja.Id))
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
            return View(transakcja);
        }

        // GET: Transakcje/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var transakcja = await _context.Transakcja
                .FirstOrDefaultAsync(m => m.Id == id);
            if (transakcja == null)
            {
                return NotFound();
            }

            return View(transakcja);
        }

        // POST: Transakcje/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var transakcja = await _context.Transakcja.FindAsync(id);
            _context.Transakcja.Remove(transakcja);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TransakcjaExists(int id)
        {
            return _context.Transakcja.Any(e => e.Id == id);
        }
    }
}
