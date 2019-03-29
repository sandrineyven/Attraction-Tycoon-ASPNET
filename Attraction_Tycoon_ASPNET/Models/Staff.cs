using System;
using System.ComponentModel.DataAnnotations;

namespace Attraction_Tycoon_ASPNET.Models
{
    public class Staff
    {
        [Key]
        public int id { get; set; }

        public int id_user { get; set; }


        [Required]
        [Display(Name = "Nom")]
        public String name { get; set; }


        [Required]
        [Display(Name = "Type")]
        public String type { get; set; }

        public double salary { get; set; }

        public int hours { get; set; }

        public String status { get; set; }

        public Shop shop { get; set; }

    }
}