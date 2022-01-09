using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entity;

namespace WebUI.Features.Cars
{
    [Route("api/Motorbikes")]
    [ApiController]
    public class MotorbikeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Motorbikes>> GetMotorbikes()
        {
            var Motorbike = new List<Motorbikes>();
            var Motorbikes1 = new Motorbikes
            {
                TeamName="Team B",
                 Speed = 210,
                 MulfuctionChance = 2.0
            };
            var Motorbikes2 = new Motorbikes
            {
                TeamName = "Team A",
                Speed = 80,
                MulfuctionChance = 2.5
            };
            Motorbike.Add(Motorbikes1);
            Motorbike.Add(Motorbikes2);
            
            return Ok(Motorbike);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<List<Motorbikes>> GetMotorbikes(int id)
        {
            var Motorbike = new List<Motorbikes>();
            var Motorbikes1 = new Motorbikes
            {
                TeamName = "Team B",
                Speed = 210,
                MulfuctionChance = 2.0
            };

            return Ok(Motorbikes1);
        }

        [HttpPost]
        public ActionResult<Motorbikes> CreateMotorbikes(Motorbikes Motorbike)
        {
            var NewMotorbikes = new Motorbikes
            {
                TeamName = Motorbike.TeamName,
                Speed = Motorbike.Speed,
                MulfuctionChance = Motorbike.MulfuctionChance
            };
            return NewMotorbikes;
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult<Motorbikes> UpdateMotorbikes(Motorbikes motorbike)
        {
            var UpdateMotorbikes = new Motorbikes
            {
                TeamName = motorbike.TeamName,
                Speed = motorbike.Speed,
                MulfuctionChance = motorbike.MulfuctionChance
            };

            return UpdateMotorbikes;
        }

        [HttpDelete]
        [Route("{id}")]

        public ActionResult deleteMotorbikes(int Id)
        {
            return Ok($"car with id {Id} is succcessully deleted");
        }

    }
}
