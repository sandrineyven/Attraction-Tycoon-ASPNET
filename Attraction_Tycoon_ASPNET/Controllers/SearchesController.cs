using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Attraction_Tycoon_ASPNET.Models;
using System.Data.Entity.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;

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
        public async Task<IActionResult> Index(string searchString, int zone, int cat)
        {
            IQueryable<Shop> shops = new List<Shop>().AsQueryable();
            IQueryable<Carousel> car = new List<Carousel>().AsQueryable();
            IQueryable<Staff> staffs = new List<Staff>().AsQueryable();
           
                shops = from s in _context.Shop
                        select s;
          
                car = from c in _context.Carousel
                      select c;
           
                staffs = from s in _context.Staff
                         select s;
           

           

            if (!String.IsNullOrEmpty(searchString))
            {
                if (shops.Count() > 0)
                {
                    shops = shops.Where(c => c.name.Contains(searchString));
                }
                if (car.Count() > 0)
                {
                    car = car.Where(c => c.name.Contains(searchString));
                }
                if (staffs.Count() > 0)
                {
                    staffs = staffs.Where(c => c.name.Contains(searchString));
                }
            }

            if (zone != 0) {
                if (car.Count() != 0)
                {
                    car = car.Where(c => c.zone == zone);
                }
                if (shops.Count() != 0)
                {
                    shops = shops.Where(c => c.zone == zone);
                }
            }

            if (cat != 0) {
                if (cat == 1)
                {
                    car = car.Where(c => c.zone == 0);
                    staffs = staffs.Where(c => c.status.Equals("StatusInexistant"));
                }
                else if (cat == 2)
                {
                    car = car.Where(c => c.zone == 0);
                    shops = shops.Where(c => c.zone == 0);
                }
                else if (cat == 3)
                {
                    staffs = staffs.Where(c => c.status.Equals("StatusInexistant"));
                    shops = shops.Where(c => c.zone == 0);
                }

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
