using Microsoft.AspNetCore.Mvc;
using NZwalks.Model.Domains;
using NZwalks.Repositries;

namespace NZwalks.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionsController : Controller
       

    {
        private readonly IRegionRepositries regionRepositries;

        public RegionsController(IRegionRepositries regionRepositries)
        {
            this.regionRepositries = regionRepositries;
        }
        [HttpGet]
        public IActionResult GetAllRegions(object? regions)
        {
            var value = new List<Regions>();
            {
                new Regions()
                {
                    Id = Guid.NewGuid(),
                    Name = "Wellington",
                    Code = "WlG",
                    Area = 224455,
                    Lat = 1.333,
                    Long = 2.554,
                    Population = 764647

                };

                new Regions()
                {
                    Id = Guid.NewGuid(),
                    Name = "Auckland",
                    Code = "AUCK",
                    Area = 22555,
                    Lat = 3.333,
                    Long = 2.054,
                    Population = 4647

                };


             };  
        
            
            return Ok(regions);
        }

    }
}


    

