using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DealerKendaraanMVC.Data;
using DealerKendaraanMVC.Models;

namespace DealerKendaraanMVC.Controllers
{
    public class KasirController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KasirController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Kasir
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Pesanans.Include(p => p.Kasir);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Kasir/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pesanan = await _context.Pesanans
                .Include(p => p.Kasir)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pesanan == null)
            {
                return NotFound();
            }

            return View(pesanan);
        }

        // GET: Kasir/Create
        public IActionResult Create()
        {
            ViewData["KasirId"] = new SelectList(_context.Kasirs, "Id", "NamaBelakang");
            return View();
        }

        // POST: Kasir/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TanggalPesan,TanggalTiba,TanggalPengiriman,NamaPelanggan,AlamatPelanggan,KotaPelanggan,KasirId")] Pesanan pesanan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pesanan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["KasirId"] = new SelectList(_context.Kasirs, "Id", "NamaBelakang", pesanan.KasirId);
            return View(pesanan);
        }

        // GET: Kasir/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pesanan = await _context.Pesanans.FindAsync(id);
            if (pesanan == null)
            {
                return NotFound();
            }
            ViewData["KasirId"] = new SelectList(_context.Kasirs, "Id", "NamaBelakang", pesanan.KasirId);
            return View(pesanan);
        }

        // POST: Kasir/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TanggalPesan,TanggalTiba,TanggalPengiriman,NamaPelanggan,AlamatPelanggan,KotaPelanggan,KasirId")] Pesanan pesanan)
        {
            if (id != pesanan.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pesanan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PesananExists(pesanan.Id))
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
            ViewData["KasirId"] = new SelectList(_context.Kasirs, "Id", "NamaBelakang", pesanan.KasirId);
            return View(pesanan);
        }

        // GET: Kasir/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pesanan = await _context.Pesanans
                .Include(p => p.Kasir)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pesanan == null)
            {
                return NotFound();
            }

            return View(pesanan);
        }

        // POST: Kasir/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pesanan = await _context.Pesanans.FindAsync(id);
            _context.Pesanans.Remove(pesanan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PesananExists(int id)
        {
            return _context.Pesanans.Any(e => e.Id == id);
        }
    }
}
