using System;
using System.Collections.Generic;
using System.Text;

namespace Mockbuster
{
    //User class
   public class User 
    {
        public User(string movieName, string mainActor, Genre movieCategory, string director)
        {

        }

        //method that filters by genre and returns a list of movies of only those genres
        public string SearchByGenre(List<Movie> Movies, Genre movieType)
        {
            string output = "";
            for(int i = 0; i < Movies.Count; i++)
            {
                Movie m = Movies[i];
                if(m.MovieCategory == movieType)
                {
                    output += m.MovieCategory.ToString(); //in here, had to add the ToString() because the m.MovieCategory is an enum and it needs to be string in order to add it to output
                }
            }
            return output;
        }

        //method that filters by movie name and returns a list of movies of only those names
        public string SearchByMovieName(List<Movie> Movies, string movieName)
        {
            string output = "";
            for(int i = 0; i< Movies.Count; i++)
            {
                Movie m = Movies[i];
                if(m.MovieName == movieName)
                {
                    output += m.MovieName;
                }
            }
            return output;
        }

        //method that filters by the main actors and returns a list of movies of only those main actors
        public string SearchByMainActor(List<Movie> Movies, string mainActor)
        {
            string output = "";
            for (int i = 0; i < Movies.Count; i++)
            {
                Movie m = Movies[i];
                if (m.MainActor == mainActor)
                {
                    output += m.MainActor;
                }
            }
            return output;
        }

        //method to filter by director and returns a list of only those directors
        public string SearchByDirector(List<Movie> Movies, string director)
        {
            string output = "";
            for (int i = 0; i < Movies.Count; i++)
            {
                Movie m = Movies[i];
                if (m.Director == director)
                {
                    output += m.Director;
                }
            }
            return output;
        }

    }
}
