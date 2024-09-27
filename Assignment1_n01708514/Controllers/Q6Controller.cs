using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1_n01708514.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Q6Controller : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP GET request with one query parameter and provides a response message.
        /// </summary>
        /// <returns>
        /// The result of the value of square root times the base to power of exponent. </returns>
        /// <example>
        /// GET api/q6/hexagon?side=1 -> 2.598076211353316
        /// GET api/q6/hexagon?side=1.5 -> 5.845671475544961
        /// GET api/q6/hexagon?side=20 -> 1039.2304845413264
        /// </example>
        [HttpGet(template:"Hexagon")]
        public double Hexagon(double side)
        { 
       double Area = (Math.Sqrt(3) * 3 / 2) * Math.Pow(side, 2);
       return Area;
       }
    }
}