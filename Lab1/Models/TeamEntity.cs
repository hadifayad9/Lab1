using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Models
{
    //Class representation of a team
    public class TeamEntity
    {
        //ID for the teams
        [Key]
        public int Id { get; set; }
        //Team names
        [Required, Display(Name = "Team Name")]
        public string TeamName { get; set; }
        //Team emails
        [Required, Display(Name = "Team Email")]
        public string Email { get; set; }
        //Team Date
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? EstablishedDate { get; set; }
    }
}   
