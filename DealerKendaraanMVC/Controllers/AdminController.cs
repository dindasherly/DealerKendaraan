using DealerKendaraanMVC.Data;
using DealerKendaraanMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DealerKendaraanMVC.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        // GET: Produks
        public async Task<IActionResult> Kendaraan()
        {
            var applicationDbContext = _context.Produks.Include(p => p.Merk);
            return View(await applicationDbContext.ToListAsync());
        }
        public IActionResult KendaraanTambah()
        {
            ViewData["MerkId"] = new SelectList(_context.Merks, "Id", "Nama");
            ViewData["PemasokId"] = new SelectList(_context.Pemasoks, "Id", "NamaPerusahaaan");
            return View();
        }


        // POST: Produks/MerkTambah
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> KendaraanTambah(IFormFile image, [Bind("Id,Nama,Warna,HargaSatuan,StokBarang,Gambar,MerkId,PemasokId")] Produk produk)
        {
            //check file length just in case of null
            if (image != null)  if (image.Length > 0)
            {
                //converting the image(file) to a byte array(MemoryStream)
                using (MemoryStream mStream = new MemoryStream())
                {
                    image.CopyTo(mStream);
                    produk.Gambar = mStream.ToArray();
                }
            }
            if (ModelState.IsValid)
            {
                _context.Add(produk);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Kendaraan));
            }
            ViewData["MerkId"] = new SelectList(_context.Merks, "Id", "Nama", produk.MerkId);
            ViewData["PemasokId"] = new SelectList(_context.Pemasoks, "Id", "NamaPerusahaaan", produk.PemasokId);
            return View(produk);
        }
        
        // GET: Produks/MerkDetails/5
        public async Task<IActionResult> KendaraanDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produk = await _context.Produks
                .Include(p => p.Merk)
                .Include(p => p.Pemasok)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produk == null)
            {
                return NotFound();
            }

            return View(produk);
        }


        // GET: Produks/MerkEdit/5
        public async Task<IActionResult> KendaraanEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produk = await _context.Produks.FindAsync(id);
            if (produk == null)
            {
                return NotFound();
            }
            ViewData["MerkId"] = new SelectList(_context.Merks, "Id", "Nama", produk.MerkId);
            ViewData["PemasokId"] = new SelectList(_context.Pemasoks, "Id", "Alamat", produk.PemasokId);
            return View(produk);
        }

        // POST: Produks/MerkEdit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> KendaraanEdit(IFormFile image, int id, [Bind("Id,Nama,Warna,HargaSatuan,StokBarang,Gambar,MerkId,PemasokId")] Produk produk)
        {
            if (id != produk.Id)
            {
                return NotFound();
            }

            //check file length just in case of null
            if (image != null) if (image.Length > 0)
            {
                //converting the image(file) to a byte array(MemoryStream)
                using (MemoryStream mStream = new MemoryStream())
                {
                    image.CopyTo(mStream);
                    produk.Gambar = mStream.ToArray();
                }
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(produk);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdukExists(produk.Id))
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
            ViewData["MerkId"] = new SelectList(_context.Merks, "Id", "Nama", produk.MerkId);
            ViewData["PemasokId"] = new SelectList(_context.Pemasoks, "Id", "Alamat", produk.PemasokId);
            return View(produk);
        }

        // GET: Produks/MerkDelete/5
        public async Task<IActionResult> KendaraanDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var produk = await _context.Produks
                .Include(p => p.Merk)
                .Include(p => p.Pemasok)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produk == null)
            {
                return NotFound();
            }

            return View(produk);
        }

        // POST: Produks/MerkDelete/5
        [HttpPost, ActionName("KendaraanDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var produk = await _context.Produks.FindAsync(id);
            _context.Produks.Remove(produk);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Kendaraan));
        }

        private bool ProdukExists(int id)
        {
            return _context.Produks.Any(e => e.Id == id);
        }



        // GET: Merks
        public async Task<IActionResult> Merk()
        {
            return View(await _context.Merks.ToListAsync());
        }

        // GET: Merks/MerkDetails/5
        public async Task<IActionResult> MerkDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var merk = await _context.Merks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (merk == null)
            {
                return NotFound();
            }

            return View(merk);
        }

        // GET: Merks/MerkTambah
        public IActionResult MerkTambah()
        {
            return View();
        }

        // POST: Merks/MerkTambah
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MerkTambah([Bind("Id,Nama,Description")] Merk merk)
        {
            if (ModelState.IsValid)
            {
                _context.Add(merk);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Merk));
            }
            return View(merk);
        }

        // GET: Merks/MerkEdit/5
        public async Task<IActionResult> MerkEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var merk = await _context.Merks.FindAsync(id);
            if (merk == null)
            {
                return NotFound();
            }
            return View(merk);
        }

        // POST: Merks/MerkEdit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MerkEdit(int id, [Bind("Id,Nama,Description")] Merk merk)
        {
            if (id != merk.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(merk);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MerkExists(merk.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Merk));
            }
            return View(merk);
        }

        // GET: Merks/MerkDelete/5
        public async Task<IActionResult> MerkDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var merk = await _context.Merks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (merk == null)
            {
                return NotFound();
            }

            return View(merk);
        }

        // POST: Merks/MerkDelete/5
        [HttpPost, ActionName("MerkDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> MerkDeleteConfirmed(int id)
        {
            var merk = await _context.Merks.FindAsync(id);
            _context.Merks.Remove(merk);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Merk));
        }

        private bool MerkExists(int id)
        {
            return _context.Merks.Any(e => e.Id == id);
        }
    }
}
