using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Attraction_Tycoon_ASPNET.Models
{
    public class Search
    {
        [Key]
        public int id { get; set; }

        public List<Shop> shops { get; set; }

        public List<Carousel> carousels { get; set; }

        public List<Staff> staffs { get; set; }


    }
}
