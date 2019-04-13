using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Attraction_Tycoon_ASPNET.Models;
using System.Data.Entity.Infrastructure;

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
        public async Task<IActionResult> Index(string searchString)
        {

             var shops = from s in _context.Shop
                        select s;
            var car = from c in _context.Carousel
                        select c;
            var staffs = from s in _context.Staff
                        select s;


            if (!String.IsNullOrEmpty(searchString))
            {
                car = car.Where(c => c.name.Contains(searchString));
                shops = shops.Where(c => c.name.Contains(searchString));
                staffs = staffs.Where(c => c.name.Contains(searchString));
            }

            var vm = new Search
            {
                carousels = await car.ToListAsync(),
                shops = await shops.ToListAsync(),
                staffs = await staffs.ToListAsync()
            };
            
            
            return View(vm);
        }

    }

}
