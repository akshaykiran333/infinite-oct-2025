using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CC8_CodeFirst.Models
{
    public class MoviesDbContext : DbContext
    {
        public MoviesDbContext() : base("connectstr") { }
        public DbSet<Movie> Movies { get; set; }
    }
}