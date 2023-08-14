using System;
using System.Collections.Generic;
using System.Text;

namespace MovieCollection_AlexS
{
    internal class Movie
    {
    public String name;
    public int duration;
    public int year;
    public String star;
    public enum contentRating
    {
        G = 0,
        PG = 1,
        M = 2,
        MA = 3,
        R = 4,
        X = 5,
        CTC = 6
    }
    }
}
