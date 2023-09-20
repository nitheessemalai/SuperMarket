using MarketLibrary.MarketModels;
using Microsoft.EntityFrameworkCore;
using System;

namespace MarketLibrary
{
    public class Marketcontext : DbContext
    {

        public Marketcontext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Market> SuperMarket { get; set; }
        public DbSet<dropdown> Dropdowns { get; set; }

    }
}
  

