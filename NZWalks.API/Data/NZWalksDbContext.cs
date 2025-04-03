using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext(DbContextOptions dbContextOptions): base(dbContextOptions)
        {
            
        }

        //DbSet propertiese represent collections in database
        public DbSet<Difficulty> difficulties { get; set; }
        public DbSet<Region> regions { get; set; }  
        public DbSet<Walk> walks { get; set; }

    }
}
