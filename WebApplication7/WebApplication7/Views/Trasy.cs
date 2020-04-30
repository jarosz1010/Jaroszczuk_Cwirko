using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication7.Models;

namespace WebApplication7.Views
{
    public class Trasy : Controller
    {
        private readonly WebApplication7Context _context;

        public Trasy(WebApplication7Context context)
        {
            _context = context;
        }

        // GET: Trasy
        public async Task<IActionResult> Index()
        {
            return View(await _context.Trasa.ToListAsync());
        }

        // GET: Trasy/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trasa = await _context.Trasa
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trasa == null)
            {
                return NotFound();
            }

            return View(trasa);
        }

        // GET: Trasy/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Trasy/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Stacja,Godzina,Ilosc_miejsc")] Polaczenie trasa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(trasa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(trasa);
        }

        // GET: Trasy/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trasa = await _context.Trasa.FindAsync(id);
            if (trasa == null)
            {
                return NotFound();
            }
            return View(trasa);
        }

        // POST: Trasy/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Stacja,Godzina,Ilosc_miejsc")] Polaczenie trasa)
        {
            if (id != trasa.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(trasa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrasaExists(trasa.Id))
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
            return View(trasa);
        }

        // GET: Trasy/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trasa = await _context.Trasa
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trasa == null)
            {
                return NotFound();
            }

            return View(trasa);
        }

        // POST: Trasy/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var trasa = await _context.Trasa.FindAsync(id);
            _context.Trasa.Remove(trasa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TrasaExists(int id)
        {
            return _context.Trasa.Any(e => e.Id == id);
        }
    }
}
