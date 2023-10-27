using Microsoft.EntityFrameworkCore;

namespace Crudoperation.Model
{
    public class Brandcontext:DbContext

    {
        public Brandcontext(DbContextOptions<Brandcontext>options):base(options)
        {

        }

        public DbSet<Brand> Brands { get; set; }


    }
}
