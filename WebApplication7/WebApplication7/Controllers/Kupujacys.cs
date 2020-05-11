using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class Kupujacys : Controller
    {
        private readonly WebApplication7Context _context;
        private readonly ILogger _logger;
        public Kupujacys(WebApplication7Context context, ILogger<Kupujacys> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: Kupujacys
        public async Task<IActionResult> Index()
        {
            return View(await _context.Kupujacys.ToListAsync());
        }

        // GET: Kupujacys/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kupujacy = await _context.Kupujacys
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kupujacy == null)
            {
                _logger.LogInformation("Nie ma takiego kupujacego");
                return NotFound();
            }

            return View(kupujacy);
        }

        
        public async Task<IActionResult> Znajdz_klienta(string klient)
        {

            return View(await _context.Kupujacys
        .Where(e => e.Nazwisko == klient)
        .ToListAsync());

        }
        // GET: Kupujacys/Create
        public IActionResult Create()
        {
            return View();
        }

  
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Imie,Nazwisko,Znizka")] Kupujacy kupujacy)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kupujacy);
                await _context.SaveChangesAsync();
                _logger.LogInformation("Stworzono klienta");
                return RedirectToAction(nameof(Index));
            }
            return View(kupujacy);
        }

        // GET: Kupujacys/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kupujacy = await _context.Kupujacys.FindAsync(id);
            if (kupujacy == null)
            {
                _logger.LogInformation("Nie ma takiego kupujacego");
                return NotFound();
            }
            return View(kupujacy);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Imie,Nazwisko,Znizka")] Kupujacy kupujacy)
        {
            if (id != kupujacy.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kupujacy);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KupujacyExists(kupujacy.Id))
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
            return View(kupujacy);
        }

        // GET: Kupujacys/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kupujacy = await _context.Kupujacys
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kupujacy == null)
            {
                return NotFound();
            }

            return View(kupujacy);
        }

        // POST: Kupujacys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var kupujacy = await _context.Kupujacys.FindAsync(id);
            _context.Kupujacys.Remove(kupujacy);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KupujacyExists(int id)
        {
            return _context.Kupujacys.Any(e => e.Id == id);
        }
    }
}
