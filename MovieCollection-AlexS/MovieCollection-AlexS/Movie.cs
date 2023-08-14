﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MovieCollection_AlexS
{
    public enum ContentRating
    {
        G = 0,
        PG = 1,
        M = 2,
        MA = 3,
        R = 4,
        X = 5,
        CTC = 6
    }

    internal class Movie
    {
        public String name;
        public int duration;
        public int year;
        public String movieStar;
        public ContentRating contentRating;
        public bool hasBeenRated = false;

        float rating = 0;

        public Movie(string name, int duration, int year, string movieStar, float starRating, ContentRating rating)
        {
            this.name = name;
            this.duration = duration;
            this.year = year;
            this.movieStar = movieStar;
            this.contentRating = rating;
            this.setRating(starRating);
        }

        public float getRating()
        {
            return this.rating;
        }

        public void setRating(float rating)
        {
            if (rating < 0 || rating > 5)
            {
                throw new ArgumentOutOfRangeException("Rating out of bounds, must be between 0 and 5 (inclusively)");
            }

            if (rating % 0.5 != 0)
            {
                throw new ArgumentException("Rating not a multiple of 0.5");
            }

            this.rating = rating;
            this.hasBeenRated = true;
        }
    }
}