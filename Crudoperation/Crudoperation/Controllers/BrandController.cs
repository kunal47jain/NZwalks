using Crudoperation.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Crudoperation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly Brandcontext _dbcontext;


        public BrandController(Brandcontext dbcontext)
        {
            _dbcontext = dbcontext;


        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Brand>>> GetBrands()
        {
            if (_dbcontext.Brands == null)
            {
                return NotFound();
            }
            return await _dbcontext.Brands.ToListAsync();

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Brand>> GetBrand(int id)
        {
            if (_dbcontext.Brands == null)
            {
                return NotFound();

            }
            var brand = await _dbcontext.Brands.FindAsync(id);
            if (brand == null)
            {
                return NotFound();
            }
            return brand;





        }
        [HttpPost]
        public async Task<ActionResult<Brand>> PostBrand(Brand brand)
        {
            _dbcontext.Brands.Add(brand);
            await _dbcontext.SaveChangesAsync();
            return CreatedAtAction(nameof(GetBrand), new { id = brand.Id }, brand);
        }

    



        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBrand(int id, Brand brand)
        {
            if (_dbcontext.Brands == null)
            {
               NotFound();


            }

            Brand? brand1 = await _dbcontext.Brands.FindAsync(id);
            if (id == null) { 
                return NotFound();
            }
             _dbcontext.Brands.Remove(brand1);
            await _dbcontext.SaveChangesAsync();

            return Ok();



        }

        private DbSet<Brand> Remove(Brand brand)
        {
            throw new NotImplementedException();
        }
    }

}



   