using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Attraction_Tycoon_ASPNET.Models;

namespace Attraction_Tycoon_ASPNET.Controllers
{
    public class CarouselsController : Controller
    {
        private readonly Attraction_Tycoon_ASPNETContext _context;

        public CarouselsController(Attraction_Tycoon_ASPNETContext context)
        {
            _context = context;
        }

        // GET: Carousels
        public async Task<IActionResult> Index(string searchString)
        {
            var carousels = from c in _context.Carousel
                        select c;

            if (!String.IsNullOrEmpty(searchString))
            {
                carousels = carousels.Where(c => c.name.Contains(searchString));
            }

            return View(await carousels.ToListAsync());
        }

        // GET: Carousels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carousel = await _context.Carousel
                .FirstOrDefaultAsync(m => m.id == id);
            if (carousel == null)
            {
                return NotFound();
            }

            return View(carousel);
        }

        // GET: Carousels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Carousels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,name,type,is_open,duration,waiting_time,state,capacity,zone")] Carousel carousel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carousel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(carousel);
        }

        // GET: Carousels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carousel = await _context.Carousel.FindAsync(id);
            if (carousel == null)
            {
                return NotFound();
            }
            return View(carousel);
        }

        // POST: Carousels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,name,type,is_open,duration,waiting_time,state,capacity,zone")] Carousel carousel)
        {
            if (id != carousel.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carousel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarouselExists(carousel.id))
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
            return View(carousel);
        }

        // GET: Carousels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carousel = await _context.Carousel
                .FirstOrDefaultAsync(m => m.id == id);
            if (carousel == null)
            {
                return NotFound();
            }

            return View(carousel);
        }

        // POST: Carousels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var carousel = await _context.Carousel.FindAsync(id);
            _context.Carousel.Remove(carousel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarouselExists(int id)
        {
            return _context.Carousel.Any(e => e.id == id);
        }
    }
}
