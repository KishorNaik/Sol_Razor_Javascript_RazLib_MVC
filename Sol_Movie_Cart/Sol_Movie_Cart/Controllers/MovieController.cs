using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Sol_Movie_Cart.Models;
using Sol_Movie_Cart.Repository;
using Sol_Movie_Cart.ViewModels;

namespace Sol_Movie_Cart.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieRepository movieRepository = null;

        public MovieController(IMovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
            this.MovieVM = new MovieViewModel();
        }

        [BindProperty]
        public MovieViewModel MovieVM { get; set; }

        [BindProperty(SupportsGet =true)]
        public int id { get; set; }

        public async  Task<IActionResult> Index()
        {
            this.MovieVM.MovieList = (await movieRepository?.GetListOfMoviesAsync()).ToList();

            this.MovieVM.MovieListJson = JsonConvert.SerializeObject(this.MovieVM.MovieList);

            return View(this.MovieVM);
        }

        [HttpGet]
        public async Task<IActionResult> OnView()
        {
            var movieData =
                   (await
                    movieRepository
                    ?.GetListOfMoviesAsync()
                   )
                   ?.AsEnumerable()
                   ?.FirstOrDefault((leMovieModel) => leMovieModel?.id == id);

            var movieDataJson = JsonConvert.SerializeObject(movieData);

            this.MovieVM.MovieJson = movieDataJson;

            return View(this.MovieVM);
        }
    }
}