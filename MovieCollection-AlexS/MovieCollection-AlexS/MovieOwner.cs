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
    }
}
