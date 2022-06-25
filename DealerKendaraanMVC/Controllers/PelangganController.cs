using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DealerKendaraanMVC.Data;
using DealerKendaraanMVC.Models;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace DealerKendaraanMVC.Controllers
{
    public class PelangganController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PelangganController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Pelanggan
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Produks.OrderByDescending(i => i.Gambar)
                                               .Take(3)  
                                               .Include(p => p.Merk).Include(p => p.Pemasok);
            return View(await applicationDbContext.ToListAsync());
        }
        // GET: Pelanggan/Create
        public IActionResult Create()
        {
            ViewData["MerkId"] = new SelectList(_context.Merks, "Id", "Nama");
            ViewData["PemasokId"] = new SelectList(_context.Pemasoks, "Id", "Alamat");
            return View();
        }

        // POST: Pelanggan/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IFormFile image, [Bind("Id,Nama,Warna,HargaSatuan,StokBarang,Gambar,MerkId,PemasokId")] Produk produk)
        {
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
                _context.Add(produk);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MerkId"] = new SelectList(_context.Merks, "Id", "Nama", produk.MerkId);
            ViewData["PemasokId"] = new SelectList(_context.Pemasoks, "Id", "Alamat", produk.PemasokId);
            return View(produk);
        }

        private bool ProdukExists(int id)
        {
            return _context.Produks.Any(e => e.Id == id);
        }
        public IActionResult Cari()
        {
            ViewData["MerkId"] = new SelectList(_context.Merks, "Id", "Nama");
            ViewData["PemasokId"] = new SelectList(_context.Pemasoks, "Id", "Alamat");
            return View();
        }


        // GET: Produks
        public async Task<IActionResult> Search([Bind("MerkId")] Produk produk)
        {
            var applicationDbContext = _context.Produks.Where(db => db.StokBarang > 0);
            if (produk.MerkId > 0)
            {
                applicationDbContext = applicationDbContext.Where(db => db.MerkId == produk.MerkId);
            }
            
            return View(await applicationDbContext.Include(p => p.Merk).ToListAsync());
        }


        // GET: Produks/MerkDetails/5
        public async Task<IActionResult> Details(int? id)
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

    }
}
