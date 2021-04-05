using Microsoft.EntityFrameworkCore;
using QuoteApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteApp.DataContext
{
    public class QuoteDbContext : DbContext
    {
        public QuoteDbContext(DbContextOptions options) : base(options)
        {
        }

        protected QuoteDbContext()
        {
        }
        public DbSet<Quote> Quotes{ get; set; }
    }
}
