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

        [HttpGet]
        [Route("{Id}")]
        public ActionResult<List<Car>> Getcars(int id)
        {
            var cars = new List<Car>();
            var car1 = new Car
            {
                TeamName = "Team B",
                Speed = 100,
                MulfuctionChance = 0.2
            };

            return Ok(car1);
        }

        [HttpPost]
        public ActionResult<Car> CreateCar(Car car)
        {
            var newcar = new Car
            {
                Id = car.Id,
                TeamName = car.TeamName,
                Speed = car.Speed,
                MulfuctionChance = car.MulfuctionChance
            };

            return newcar;
        }
        
        [HttpPut]
        [Route("{id}")]
        public ActionResult<Car> UpdateCar(Car car)
        {
            var updateCar = new Car
            {
                Id = car.Id,
                TeamName = car.TeamName,
                Speed = car.Speed,
                MulfuctionChance = car.MulfuctionChance
            };

            return updateCar;
        }
        [HttpDelete]
        [Route("{id}")]

        public ActionResult deleteCar(int Id)
        {
            return Ok($"car with id {Id} is succcessully deleted");
        }
    }
}
