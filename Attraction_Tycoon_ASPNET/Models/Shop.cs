using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Attraction_Tycoon_ASPNET.Models
{
    public class Shop
    {
        [Key]
        public int id { get; set; }

        [Required]
        [Display(Name = "Nom")]
        public String name { get; set; }

        [Required]
        [Display(Name = "Type")]
        public String type { get; set; }

        [Required]
        [Display(Name = "zone")]
        public int zone { get; set; }

        public List<Staff> staffs { get; set; }
}
}
