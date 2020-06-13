using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfoAPI.Controllers
{
    [ApiController] //atribut
    [Route("api/cities")]

    public class CitiesController : ControllerBase
    {
        [HttpGet]

        public IActionResult GetCities()
        {
            return Ok(CitiesDataStore.Current.Cities);
            //return new JsonResult(
            //    new List<object>()
            //    {
            //        new {id=1, Name="Imotski"},
            //        new {id=2, Name="Zagreb"}
            //    });
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            //finf city
            var cityToReturn = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);
            if(cityToReturn == null)
            {
                return NotFound();
            }

            return Ok(cityToReturn);

            //return new JsonResult(CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id));
        }
    }
}
