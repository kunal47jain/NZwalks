using Crudoperation.Model;
using Microsoft.AspNetCore.Mvc;

namespace Crudoperation.Controllers
{
    internal class _dbcontext
    {
        public static object Brands { get; internal set; }

        internal static Task<ActionResult<Brand>> c(int id)
        {
            throw new NotImplementedException();
        }

        internal static object Entry(Brand brand)
        {
            throw new NotImplementedException();
        }

        internal static Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}