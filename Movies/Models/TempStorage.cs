﻿using System;
using System.Collections.Generic;

namespace Movies.Models
{
    public static class TempStorage
    {
        private static List<AddMovie> movies = new List<AddMovie>();

        public static IEnumerable<AddMovie> Movies => movies;

        public static void AddFilm(AddMovie films)
        {
            movies.Add(films);
        }
    }
}
