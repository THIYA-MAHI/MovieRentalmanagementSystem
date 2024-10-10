using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalmanagement
{
    public class MovieManager
    {
        public List<Movie> MovieList = new List<Movie>();

        public void createMovie(int movieId, string title, string director, decimal rentalPrice)
        {
            Movie movie = new Movie(movieId, title, director, rentalPrice);
            MovieList.Add(movie);
        }
        public void ReadMovies()
        {

        }
    }
}
