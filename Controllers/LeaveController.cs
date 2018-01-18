using Khres.Controllers.Resources;
using Khres.Models;
using Khres.Persistent;
using Microsoft.AspNetCore.Mvc;

namespace Khres.Controllers
{
    [Route("/api/leaves")]
    public class LeaveController : Controller
    {
        private readonly KhresDbContext context;
        public LeaveController(KhresDbContext context)
        {
            this.context = context;

        }
        [HttpPost]
        public IActionResult CreateLeave([FromBody]CreateEmployeeLeaveDto createEmployeeLeaveDto) {
            return Ok(createEmployeeLeaveDto);
        }
    }
}