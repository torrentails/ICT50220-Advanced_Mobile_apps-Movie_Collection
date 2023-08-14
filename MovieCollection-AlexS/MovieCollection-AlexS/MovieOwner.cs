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

        public List<Movie> MoviesOfContentRating(ContentRating contentRating)
        {
            List<Movie> moviesToReturn = new List<Movie>();

            foreach (Movie movie in movies)
            {
                if (movie.contentRating == contentRating)
                {
                    moviesToReturn.Add(movie);
                }
            }

            return moviesToReturn;
        }

        public List<Movie> UnratedMovies()
        {
            List<Movie> moviesToReturn = new List<Movie>();

            foreach (Movie movie in movies)
            {
                if (!movie.hasBeenRated)
                {
                    moviesToReturn.Add(movie);
                }
            }

            return moviesToReturn;
        }

        public List<Movie> MoviesGreaterThanRating(float rating, bool ignoreUnrated = true)
        {
            List<Movie> moviesToReturn = new List<Movie>();

            foreach (Movie movie in movies)
            {
                if ((!ignoreUnrated || movie.hasBeenRated)
                    && movie.getRating() >= rating)
                {
                    moviesToReturn.Add(movie);
                }
            }

            return moviesToReturn;
        }

        public List<Movie> MoviesLessThanRating(float rating, bool ignoreUnrated = true)
        {
            List<Movie> moviesToReturn = new List<Movie>();

            foreach (Movie movie in movies)
            {
                if ((!ignoreUnrated || movie.hasBeenRated)
                    && movie.getRating() <= rating)
                {
                    moviesToReturn.Add(movie);
                }
            }

            return moviesToReturn;
        }

        public float AverageDuration()
        {
            float duration = 0f;
            foreach (Movie movie in movies)
            {
                duration += movie.duration;
            }

            return duration / movies.Count;
        }
    }
}
