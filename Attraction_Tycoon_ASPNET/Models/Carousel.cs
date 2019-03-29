using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Attraction_Tycoon_ASPNET.Models
{
    public class Carousel
    {
        [Key]
        public int id { get; set; }

        [Required]
        [Display(Name = "Nom")]
        public String name { get; set; }

        [Required]
        [Display(Name = "Type")]
        public String type { get; set; }

        public bool is_open { get; set; }

        public int duration { get; set; }

        public int waiting_time { get; set; }

        public String state { get; set; }

        public int capacity { get; set; }

        [Required]
        [Display(Name = "zone")]
        public int zone { get; set; }

    }
}
