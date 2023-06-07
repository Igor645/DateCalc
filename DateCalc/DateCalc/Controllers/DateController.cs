using Microsoft.AspNetCore.Mvc;

namespace DateCalc.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DateController : Controller
    {
        [HttpGet("datedifference", Name = "GetDateDifference")]
        public IActionResult GetDateDifference(DateTime inputDate)
        {
            DateTime currentDate = DateTime.Now;
            TimeSpan difference = inputDate - currentDate;
            string formattedDuration = $"{(int)difference.TotalDays}d {difference.Hours.ToString("00")}h {difference.Minutes.ToString("00")}min";

            var responseObj = new { Duration = formattedDuration };
            return Ok(responseObj);
        }
    }
}
