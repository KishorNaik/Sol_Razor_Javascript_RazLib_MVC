using Sol_Movie_Cart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Movie_Cart.ViewModels
{
    public class MovieViewModel
    {
        public List<MovieModel> MovieList { get; set; }

        public String MovieListJson { get; set; }

        public String MovieJson { get; set; }
    }
}
