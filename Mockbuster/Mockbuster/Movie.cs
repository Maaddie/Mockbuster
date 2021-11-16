using System;
using System.Collections.Generic;
using System.Text;

namespace Mockbuster
{
    //Movie class that contains the below properties
   public class Movie
    {
        //Initializing properties
        public string MovieName { get; set; }
        public string MainActor { get; set; }
        public Genre MovieCategory { get; set; }
        public string Director { get; set; }

        //Initializing constructor with the above properties
        public Movie(string movieName, string mainActor, Genre movieCategory, string director)
        {
            MovieName = movieName;
            MainActor = mainActor;
            MovieCategory = movieCategory;
            Director = director;
        }

        //This is the override ToString() that returns a formatted string that contains all of the properties
        public override string ToString()
        {
            string output = $"Movie Name: {MovieName}\n";
            output += $"Main Actor: {MainActor}\n";
            output += $"Movie Category: {MovieCategory}\n";
            output += $"Director: {Director}\n";
            return output;
        }
    }

    //Enum that holds the genres of movies
    public enum Genre
    {
        Action,
        Animation,
        Comedy,
        Drama,
        Romance
        
    }
}
