using Domain.Entity;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace WebUI.Features.Cars
{
    [Route("api/cars")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ApplicaitonDbContext _Context;

        public CarController(ApplicaitonDbContext context)
        {
            _Context = context;
        }

        [HttpGet]
        public ActionResult<List<Car>> Getcars()
        {
            var cars = _Context.Cars.ToList();
            return Ok(cars);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Car> Getcars(int id)
        {
            var Car = _Context.Cars.FirstOrDefault(x => x.Id == id);

            if (Car == null)
                return BadRequest($"Car with Id : {id} hasn't been found");
            else
                return Ok(Car);
        }

        [HttpPost]
        public ActionResult<Car> CreateCar(Car car)
        {
            _Context.Add(car);
            _Context.SaveChanges();
            //var newcar = new Car
            //{
            //    Id = car.Id,
            //    TeamName = car.TeamName,
            //    Speed = car.Speed,
            //    MulfuctionChance = car.MulfuctionChance
            //};

            return car;
        }
        
        [HttpPut]
        [Route("{id}")]
        public ActionResult<Car> UpdateCar(Car car)
        {
            var dbCar = _Context.Cars.FirstOrDefault(x => x.Id == car.Id);

            if (dbCar == null)
                return BadRequest($"Car with Id : {car.Id} hasn't been found");

            dbCar.TeamName = car.TeamName;
            dbCar.Speed = car.Speed;
            dbCar.MulfuctionChance = car.MulfuctionChance;
            _Context.SaveChanges();

            return dbCar;
        }
        [HttpDelete]
        [Route("{id}")]

        public ActionResult deleteCar(int id)
        {
            var dbCar = _Context.Cars.FirstOrDefault(x => x.Id == id);

            if (dbCar == null)
                return BadRequest($"Car with Id : {id} hasn't been found");

            _Context.Remove(dbCar);
            _Context.SaveChanges();
            return Ok($"car with id {id} is succcessully deleted");
        }
    }
}
