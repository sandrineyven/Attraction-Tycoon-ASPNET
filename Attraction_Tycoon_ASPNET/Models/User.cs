using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Attraction_Tycoon_ASPNET.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }

        [Required]
        [Display(Name = "Login")]
        public String login { get; set; }

        [Required]
        [Display(Name = "Password")]
        public String password { get; set; }

        public String email { get; set; }

    }
}
