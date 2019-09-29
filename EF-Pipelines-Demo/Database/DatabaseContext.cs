using EF_Pipelines_Demo.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Pipelines_Demo.Database
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            
        }

        public DbSet<Game> Game { get; set; }
        public DbSet<Player> Player { get; set; }
        public DbSet<Item> Item { get; set; }
    }
}
