using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace myWebApp.Controllers
{
    [ApiController]
    public class CoordinateController : ControllerBase
    {
        [HttpGet("coordinates")]
        public ActionResult<IEnumerable<Coordinates>> GetCoordinates() {
            return new []
            {
                new Coordinates{ Lat = 22.1234, Lng = -46.1234 },
                new Coordinates{ Lat = 23.2345, Lng = -47.3456 },
                new Coordinates{ Lat = 24.4568, Lng = -48.9812 },
                new Coordinates{ Lat = 25.2453, Lng = -49.1293 }
            };
        }

        [HttpPost("coordinates")]
        public ActionResult<Coordinates> PostCoordinates([FromBody] Coordinates coords) {
            
            return new Coordinates{ Lat = coords.Lat * 1.05, Lng = coords.Lng * 1.08 };
        }
    }
}

public class Coordinates
{
    public double Lat { get; set; }
    public double Lng { get; set; }
}