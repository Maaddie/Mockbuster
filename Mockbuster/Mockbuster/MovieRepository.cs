using System;
using System.Collections.Generic;
using System.Text;

namespace Mockbuster
{
    //Movie Repo class
   public class MovieRepository
    {
        //Static method that returns a list of movie objects
        public static List<Movie> GetMovies()
        {
            List<Movie> Movies = new List<Movie>();
            Movies.Add(new Movie("Aladdin", "Naomi Scott", Genre.Action, "Guy Ritchie"));
            Movies.Add(new Movie("House of Gucci", "Lady Gaga", Genre.Drama, "Ridley Scott"));
            Movies.Add(new Movie("American Sniper", "Bradley Cooper", Genre.Drama, "Clint Eastwood"));
            Movies.Add(new Movie("Frozen", "Idina Menzel", Genre.Animation, "Jennifer Lee"));
            Movies.Add(new Movie("Jumanji", "Dwayne Johnson", Genre.Comedy, "Jake Kasdan"));

            //returning list of 5 movies objects
            return Movies;
        }

        //list i am using for admin to add movies to the list
       public List<Movie> movieList = new List<Movie>();


    }
}
