using System;
using System.Collections.Generic;
using System.Text;

namespace Mockbuster
{
    //Admin Class
    //User here is used as base class 
    class Admin : User
    {
        public Admin(string movieName, string mainActor, Genre movieCategory, string director) : base(movieName, mainActor, movieCategory, director)
        {

        }

        //method that takes in the movie object as an argument and adds it to the movie repo
        public void addMovie(Movie movie, MovieRepository movieRepository)
        {
            movieRepository.movieList.Add(movie);

        }

         public string EditMovie()
        {

        }

       
    }
}
