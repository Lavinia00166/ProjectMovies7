using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectMovies7.Models;

namespace ProjectMovies7.Data
{
    public class ProjectMovies7Context : DbContext
    {
        public ProjectMovies7Context (DbContextOptions<ProjectMovies7Context> options)
            : base(options)
        {
        }

        public DbSet<ProjectMovies7.Models.Movie> Movie { get; set; }
    }
}
