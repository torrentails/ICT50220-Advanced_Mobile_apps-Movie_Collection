using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MovieCollection_AlexS
{

    internal class MovieOwner
    {
        public String name;
        public int age;
        public String email;
        public List<Movie> movies;

        public MovieOwner(String name, int age, String email)
        {
            this.name = name;
            this.age = age;
            this.email = email;
            this.movies = new List<Movie>();
        }

        public float AverageRating(bool ignoreUnrated = true)
        {
            float rating = 0f;
            int numMovies = 0;

            foreach (Movie movie in movies)
            {
                if (!ignoreUnrated || movie.hasBeenRated)
                {
                    rating += movie.getRating();
                    numMovies++;
                }
            }

            return rating / numMovies;
        }
    }
}
