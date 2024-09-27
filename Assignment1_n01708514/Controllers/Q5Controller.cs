using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1_n01708514.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Q5Controller : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP POST request with a body and provides a response message.
        /// </summary>
        /// <returns>An HTTP response with a body echoing the request body.</returns>
        /// <example>
        /// POST api/q5/secret
        /// HEADERS: Content-Type: application/json
        /// FORM DATA: "5"
        /// -> Shh.. the secret is 5
        /// POST api/q5/secret
        /// HEADERS: Content-Type: application/json
        /// FORM DATA: "-200"
        /// -> Shh.. the secret is -200
        /// </example>
        [HttpPost(template: "Secret")]
        public string Secret([FromBody] int port)
        {
            return $"Shh.. the secret is {port}";
        }
    }
}