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
    public class SearchesController : Controller
    {
        private readonly Attraction_Tycoon_ASPNETContext _context;

        public SearchesController(Attraction_Tycoon_ASPNETContext context)
        {
            _context = context;
        }

        // GET: Searches
        public async Task<IActionResult> Index()
        {
            return View(await _context.Search.ToListAsync());
        }

        // GET: Searches/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var search = await _context.Search
                .FirstOrDefaultAsync(m => m.id == id);
            if (search == null)
            {
                return NotFound();
            }

            return View(search);
        }
    }
}
