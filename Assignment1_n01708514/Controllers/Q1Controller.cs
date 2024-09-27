using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1_n01708514.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Q1Controller : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP GET request and provides a response message.
        /// </summary>
        /// <returns>An HTTP response with a body indicating the usage.</returns>
        /// <example>
        /// GET api/q1/Welcome -> Welcome to 5125!
        /// </example>
        [HttpGet(template:"Welcome")]
        public string Welcome()
        {
            return "Welcome to 5125!";
        }
    }
}