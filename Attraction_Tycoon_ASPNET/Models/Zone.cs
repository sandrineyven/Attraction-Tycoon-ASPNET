using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Attraction_Tycoon_ASPNET.Models
{
    public class Zone
    {
        [Key]
        public int id { get; set; }

        [Required]
        [Display(Name = "Nom")]
        public String name { get; set; }


        //public List<Shop> shopList { get; set; }

       // public List<Carousel> carouselList { get; set; }
    }
}
