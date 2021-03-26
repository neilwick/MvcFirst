using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcFirst.Models
{
    public class StoreGameContext : DbContext
    {
        public StoreGameContext(DbContextOptions<StoreGameContext> options)
            : base(options)
        {
        }

        public DbSet<Game> Game { get; set; }
    }
}