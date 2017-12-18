using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ShoeMarket.Models
{
    public class ShoeMarketContext : DbContext
    {
        public ShoeMarketContext (DbContextOptions<ShoeMarketContext> options)
            : base(options)
        {
        }

        public DbSet<ShoeMarket.Models.Movie> Movie { get; set; }
    }
}
