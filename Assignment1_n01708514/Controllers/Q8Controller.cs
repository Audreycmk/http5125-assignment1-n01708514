using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1_n01708514.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Q8Controller : ControllerBase
    {
        /// <summary>
        /// Receives an HTTP POST request with a form-encoded body containing two parameters.
        /// </summary>
        /// <returns>An HTTP response with a body echoing the request body parameters.</returns>
        /// <example>
        /// POST api/q8/squashfellows
        /// HEADERS: Content-Type: application/x-www-form-urlencoded
        /// FORM DATA: "Small=1&Large=1"
        /// -> 1 Small @ $25.50 = $25.50; 1 Large @ $40.50 = $40.50; Subtotal = $66.00; Tax = $8.58 HST; Total = $74.58
        /// FORM DATA: "Small=2&Large=1"
        /// -> 2 Small @ $25.50 = $51.00; 1 Large @ $40.50 = $40.50; Subtotal = $91.50; Tax = $11.90 HST; Total = $103.40
        /// FORM DATA: "Small=100&Large=100"
        /// -> 100 Small @ $25.50 = $2550.00; 100 Large @ $40.50 = $4050.00; Subtotal = $6600.00; Tax = $858.00 HST; Total = $7458.00
        /// </example>
        [HttpPost(template: "SquashFellows")]
        [Consumes("application/x-www-form-urlencoded")]
        public string SquashFellows([FromForm]int small, [FromForm]int large)
        {

            double totalSmall = Math.Round(small * 25.5, 2);
            double totalLarge = Math.Round(large * 40.5, 2);
            double subTotal = Math.Round(totalSmall + totalLarge, 2);
            double tax = Math.Round(subTotal * 0.13, 2);
            double total = Math.Round(subTotal + tax, 2);

            return $"{small} Small @ $25.50 = ${totalSmall:F2}; " +
           $"{large} Large @ $40.50 = ${totalLarge:F2}; " +
           $"Subtotal = ${subTotal:F2}; " +
           $"Tax = ${tax:F2} HST; " +
           $"Total = ${total:F2}";
        }
    }
}