using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication7.Models;
using Microsoft.Extensions.Logging;
using WebApplication7.Controllers;



namespace WebApplication7.Controllers
{
    public class Pracownicy : Controller
    {
        private readonly WebApplication7Context _context;
        private readonly ILogger _logger;
        public Pracownicy(WebApplication7Context context, ILogger<Pracownicy> logger)
        {
            _context = context;
            _logger = logger;
        }


        // GET: Pracownicy
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pracownik.ToListAsync());
        }


        public async Task<IActionResult> Zaloguj_admin(string login, string haslo)
        {
            
            if (login == null || haslo == null)
            {
                return NotFound();
            }
           
                var pracownik = await _context.Pracownik
                    .FirstOrDefaultAsync(m => m.Login == login);

                if (pracownik == null)
                {
                    return NotFound();
                }
                // Sprawdzamy poprawnosc hasla
                if (pracownik.Haslo != haslo)
                {
                   return View("Halo");
                }
                if(pracownik.Stanowisko == "Dyrektor")
                {
                return View("Zaloguj_dyrektor");
                }
            else if (pracownik.Stanowisko == "Kierownik")
            {
                return View("Zaloguj_kierownik");
            }
            else if (pracownik.Stanowisko == "Kasjer")
            {
                return View("Zaloguj_kasjer");
            }
            _logger.LogDebug("DEBUG: użytkownik przeszedł na ekran admina!");
            return View(); 
        }

       
        // GET: Pracownicy/Details/5

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pracownik = await _context.Pracownik
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pracownik == null)
            {
                return NotFound();
            }

            return View(pracownik);
        }

        // GET: Pracownicy/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pracownicy/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Imie,Nazwisko,Login,Haslo,Stanowisko")] Pracownik pracownik)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pracownik);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pracownik);
        }

        // GET: Pracownicy/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pracownik = await _context.Pracownik.FindAsync(id);
            if (pracownik == null)
            {
                return NotFound();
            }
            return View(pracownik);
        }

        // POST: Pracownicy/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Imie,Nazwisko,Login,Haslo,Stanowisko")] Pracownik pracownik)
        {
            if (id != pracownik.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pracownik);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PracownikExists(pracownik.Id))
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
            return View(pracownik);
        }

        // GET: Pracownicy/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pracownik = await _context.Pracownik
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pracownik == null)
            {
                return NotFound();
            }

            return View(pracownik);
        }

        // POST: Pracownicy/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pracownik = await _context.Pracownik.FindAsync(id);
            _context.Pracownik.Remove(pracownik);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PracownikExists(int id)
        {
            return _context.Pracownik.Any(e => e.Id == id);
        }
    }
}
