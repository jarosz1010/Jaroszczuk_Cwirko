﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class Polaczenia : Controller
    {
        private readonly WebApplication7Context _context;
        private readonly ILogger _logger;
        public Polaczenia(WebApplication7Context context, ILogger<Polaczenia> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: Polaczenia
        public async Task<IActionResult> Index()
        {
            return View(await _context.Trasa.ToListAsync());
        }
        // Do zwracania danych stacji
        public async Task<IActionResult> Zwroc_stacje(string stacja_p, string stacja_k, string data)
        {
            var sp = await _context.Trasa
                  .FirstOrDefaultAsync(m => m.Stacja == stacja_p);

            var sk = await _context.Trasa
                 .FirstOrDefaultAsync(m => m.Stacja == stacja_k);
            //int sk_kol = sk.Kolejnosc;

            // tutaj poprawic
            _logger.LogInformation("Znaleziono szukane stacje!");
            return View(await _context.Trasa
        .Where(e =>  e.Godzina == data)
        .ToListAsync());
        
        }

        public async Task<IActionResult> Mapy()
        {
            _logger.LogInformation("Ktos otworzyl mapy");
            return View();
        }

        // GET: Polaczenia/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var polaczenie = await _context.Trasa
                .FirstOrDefaultAsync(m => m.Id == id);
            if (polaczenie == null)
            {
                return NotFound();
            }

            return View(polaczenie);
        }

        // GET: Polaczenia/Create
        public IActionResult Create()
        {
            return View();
        }

   
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Stacja,E,N,Godzina,Ilosc_miejsc")] Polaczenie polaczenie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(polaczenie);
                await _context.SaveChangesAsync();
                _logger.LogInformation("Utworzono nowa stacje");
                return RedirectToAction(nameof(Index));
            }

            return View(polaczenie);
        }

        // GET: Polaczenia/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var polaczenie = await _context.Trasa.FindAsync(id);
            if (polaczenie == null)
            {
                return NotFound();
            }
            return View(polaczenie);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Stacja,N,E,Godzina,Ilosc_miejsc")] Polaczenie polaczenie)
        {
            if (id != polaczenie.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(polaczenie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PolaczenieExists(polaczenie.Id))
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
            return View(polaczenie);
        }

        // GET: Polaczenia/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var polaczenie = await _context.Trasa
                .FirstOrDefaultAsync(m => m.Id == id);
            if (polaczenie == null)
            {
                return NotFound();
            }

            return View(polaczenie);
        }

        // POST: Polaczenia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var polaczenie = await _context.Trasa.FindAsync(id);
            _context.Trasa.Remove(polaczenie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PolaczenieExists(int id)
        {
            return _context.Trasa.Any(e => e.Id == id);
        }
    }
}
