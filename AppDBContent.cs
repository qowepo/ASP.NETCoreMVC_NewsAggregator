using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewsAggregator.Models;

namespace NewsAggregator.Data
{
    public class AppDBContent: DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options): base(options)
        {

        }

        public DbSet<NewsPost> Sport { get; set; }

        public DbSet<NewsPost> Russia { get; set; }

        public DbSet<NewsPost> Business { get; set; }

        public DbSet<NewsPost> General { get; set; }

    
    }
}
