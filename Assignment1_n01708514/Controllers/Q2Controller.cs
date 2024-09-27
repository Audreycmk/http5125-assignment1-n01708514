using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1_n01708514.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Q2Controller : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP GET request with one query parameter and provides a response message.
        /// </summary>
        /// <returns>
        /// An HTTP response with a body indicating the usage, echoing the value of name.</returns>
        /// <example>
        /// GET api/q2/greeting?name=Gary -> Hi Gary!
        /// GET api/q2/greeting?name=Ren%C3%A9e -> Hi Renée!
        /// </example>
        [HttpGet(template:"Greeting")]
        public string Greeting(string name)
        {
            string message =$"Hi {name}!";
            return message;
        }
    }
}