using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NZwalks.Model.Domains;
namespace NZwalks.Data
{
    public class NZwalksDbcontext:DbContext
    {
        //to create a constructor use ctor
        public NZwalksDbcontext(DbContextOptions<NZwalksDbcontext> options): base(options)

        {
            
        }
        public DbSet<Regions> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<Walkdifficulty> Walkdifficultie { get; set; }

    }
}
