using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1_n01708514.Controllers
{
    [ApiController]     
    [Route("api/[controller]")]
    public class Q4Controller : ControllerBase
    {
    /// <summary>
    /// Receives an HTTP POST request with an empty body and provides a response message.
    /// </summary>
    /// <returns>An HTTP response with a body indicating the usage.</returns>
    /// <example>
    /// POST api/q4/knockknock
    /// FORM DATA: (empty)
    /// -> Who’s there?
    /// </example>
    [HttpPost(template:"Knockknock")]
    public string Knockknock()
    {
        return "Who's there?";
    }   
    }
}