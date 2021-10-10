using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Models
{
    // Class for Identity User 
    public class ApplicationUser: IdentityUser
    {
        //First Name of the user
        [Required,Display(Name = "First Name")]
        public string FirstName { get; set; }
        //Last Name of the user
        [Required, Display(Name = "Last Name")]
        public string LastName { get; set; }
        //Email Name of the user
        [Required, Display(Name ="Email")]
        public override string  Email { get; set; }
        [Display(Name = "Phone Number")]
        //Phone Number of the user
        public override string PhoneNumber { get; set; }
        //Birth Date of the user
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? BirthDate { get; set; }
    }
}
