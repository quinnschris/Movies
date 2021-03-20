﻿using System;
using Microsoft.EntityFrameworkCore;

namespace Movies.Models
{
    public class MoviesDbContext : DbContext
    {
        public MoviesDbContext(DbContextOptions<MoviesDbContext> options) : base (options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
