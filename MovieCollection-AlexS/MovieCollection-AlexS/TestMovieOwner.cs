using System.Collections.Generic;
using System.Diagnostics;

namespace MovieCollection_AlexS
{
    internal class TestMovieOwner
    {
        MovieOwner owner;

        public TestMovieOwner()
        {
            owner = new MovieOwner("Alex", int.MaxValue, "20113355@tafe.wa.edu.au");
            owner.movies.Add(new Movie("The Godfather", 175, 1972, "Marlon Brando", ContentRating.R));
            owner.movies.Add(new Movie("The Shawshank Redemption", 142, 1994, "Tim Robbins", ContentRating.MA, 5f));
            owner.movies.Add(new Movie("Schindler's List", 195, 1993, "Liam Neeson", ContentRating.M));
            owner.movies.Add(new Movie("The Sound of Music", 172, 1965, "Julie Andrews", ContentRating.G, 4.5f));
            owner.movies.Add(new Movie("A Clockwork Orange", 136, 1971, "Malcolm McDowell", ContentRating.R, 2f));
        }

        void PrintList(List<Movie> list)
        {
            Debug.WriteLine("[");
            foreach (Movie movie in list)
            {
                Debug.WriteLine(movie.name);
            }
            Debug.WriteLine("]");
        }

        public void RunTests()
        {
            Debug.WriteLine(owner.AverageRating()); // 3.833333
            Debug.WriteLine(owner.AverageRating(false)); // 2.3

            // [The Godfather, A Clockwork Orange]
            PrintList(owner.MoviesOfContentRating(ContentRating.R));

            // [The Godfather, Schindler's List]
            PrintList(owner.UnratedMovies());

            // [The Shawshank Redemption, The Sound of Music]
            PrintList(owner.MoviesGreaterThanRating(4.0f));

            // [The Shawshank Redemption, The Sound of Music]
            PrintList(owner.MoviesGreaterThanRating(4.0f, false));

            // [A Clockwork Orange]
            PrintList(owner.MoviesLessThanRating(3.0f));

            // [The Godfather, Schindler's List, A Clockwork Orange]
            PrintList(owner.MoviesLessThanRating(3.0f, false));

            Debug.WriteLine(owner.AverageDuration()); // 164.0

            (Movie longestMovie, int longestMovieDuration) = owner.GetLongestMovie();
            Debug.WriteLine(longestMovie.name); // Schindler's List
            Debug.WriteLine(longestMovieDuration); // 195

            (Movie shortestMovie, int shortestMovieDuration) = owner.GetShortestMovie();
            Debug.WriteLine(shortestMovie.name); // A Clockwork Orange
            Debug.WriteLine(shortestMovieDuration); // 136
        }
    }
}
