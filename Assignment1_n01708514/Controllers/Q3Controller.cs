using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1_n01708514.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Q3Controller : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP GET request with one query parameter and provides a response message.
        /// </summary>
        /// <returns>
        /// The result of base to power of exponent. </returns>
        /// <example>
        /// GET api/q3/cube/4 -> 64
        /// GET api/q3/cube/-4 -> -64
        /// GET api/q3/cube/10 -> 1000
        /// </example>
         [HttpGet(template:"Cube/{Base}")]
        public double Cube(int Base)
        {
        double CubeNumber = Math.Pow(Base,3);
            return CubeNumber;
        }
    }
}