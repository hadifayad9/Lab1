using Lab1.Controllers;
using Lab1.Data;
using Lab1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using Xunit;

namespace Assignment1Test
{
    public class UnitTest1
    {
        [Fact]
        public async void  TeamsController_List()
        {

            DbContextOptionsBuilder<ApplicationDbContext> optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SSD_Teams;Trusted_Connection=True;MultipleActiveResultSets=true");

            using (ApplicationDbContext context = new ApplicationDbContext(optionsBuilder.Options))
            {
                context.Add(new TeamEntity() { TeamName = "Hadi's Team", Email = "000397306@mohawkcollege.ca"});
                context.SaveChanges();
            }

            IActionResult result;
            using  (ApplicationDbContext context = new ApplicationDbContext(optionsBuilder.Options))
             {
             result =  await new TeamEntitiesController(context).Index();

            }

            var viewResult = Assert.IsType<ViewResult>(result);
            //Tried to get an object of the results but didnt know how to do it with a view since there isn't a response.
            //var teams = Assert.IsType<List<TeamEntity>>(viewResult.ViewData["teamname"]);
            //var team = Assert.Single(teams);
            Assert.Equal(viewResult, result);
        }
    }
}
