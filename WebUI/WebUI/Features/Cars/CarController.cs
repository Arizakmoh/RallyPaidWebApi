using Domain.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebUI.Features.Cars
{
    [Route("api/cars")]
    [ApiController]
    public class CarController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Car>> Getcars()
        {
            var cars = new List<Car>();
            
            var car1 = new Car
            {
                TeamName = "Mohamed",
                Speed = 200,
                MulfuctionChance = 0.2
            };
            var car2 = new Car
            {
                TeamName = "Ashraf",
                Speed = 90,
                MulfuctionChance = 0.3
            };

            cars.Add(car1);
            cars.Add(car2);

            return Ok(cars);

        }
    }
}
