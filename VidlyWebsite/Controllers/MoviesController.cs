using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VidlyWebsite.Models;

namespace VidlyWebsite.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        private IEnumerable<Movies> GetMovies()
        {
            return new  List<Movies>
            {
                new Movies { Id = 10 ,Name="Gabbar"},
                new Movies { Id = 20 ,Name = "Sarabjit" }

            };
        }
    }
}
