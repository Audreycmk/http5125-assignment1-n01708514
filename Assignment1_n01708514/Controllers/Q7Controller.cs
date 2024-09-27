using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1_n01708514.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Q7Controller : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP GET request with one query parameter and provides a new date by adding a specified number of days to January 1, 2000.
        /// </summary>
        /// <returns>A string representing the new date in "yyyy-MM-dd" format.</returns>
        /// <example>
        /// GET api/q7/timemachine?days=1 -> 2000-01-02
        /// GET api/q7/timemachine?days=-1 -> 1999-12-31
        /// </example>
        [HttpGet("TimeMachine")]
        public string TimeMachine(int days)
        {
            DateTime originalDate = new DateTime(2000, 1, 1);
            DateTime newDate = originalDate.AddDays(days);
    
            return newDate.ToString("yyyy-MM-dd");
        }
    }
}