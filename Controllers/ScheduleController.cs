using app.Services;
using app.Data;
using app.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace app.Controllers
{
    [ApiController]
    [Route("api/schedule")]
    public class ScheduleController : ControllerBase
    {
        private readonly IScheduleService _serviсe;
        public ScheduleController(IScheduleService service, AppDbContext db)
        {
            _serviсe = service;
        }
        
        [HttpGet("group/{groupName}")]
        public async Task <IActionResult> GetSchedule(string groupName, DateTime start, DateTime end)
        {
            var result = await _serviсe.GetScheduleForGroup(groupName, start.Date, end.Date);
            return Ok(result);
        }
    } 
}
