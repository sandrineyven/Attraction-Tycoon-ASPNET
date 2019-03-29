using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Attraction_Tycoon_ASPNET.Models;

namespace Attraction_Tycoon_ASPNET.Models
{
    public class Attraction_Tycoon_ASPNETContext : DbContext
    {
        public Attraction_Tycoon_ASPNETContext (DbContextOptions<Attraction_Tycoon_ASPNETContext> options)
            : base(options)
        {
        }

        public DbSet<Attraction_Tycoon_ASPNET.Models.Carousel> Carousel { get; set; }

        public DbSet<Attraction_Tycoon_ASPNET.Models.Staff> Staff { get; set; }

        public DbSet<Attraction_Tycoon_ASPNET.Models.Shop> Shop { get; set; }

        public DbSet<Attraction_Tycoon_ASPNET.Models.Zone> Zone { get; set; }
    }
}
