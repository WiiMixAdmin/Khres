using System;
using System.Threading.Tasks;
using AutoMapper;
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
        private readonly IMapper mapper;
        public LeaveController(KhresDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }
        [HttpPost]
        public async Task<IActionResult> CreateLeave([FromBody]CreateEmployeeLeaveDto createEmployeeLeaveDto)
        {
            if(!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            var employeeLeave = mapper.Map<CreateEmployeeLeaveDto, EmployeeLeave>(createEmployeeLeaveDto); 
            employeeLeave.Leave.LastUpdated = DateTime.Now;
            foreach(var typeId in createEmployeeLeaveDto.LeaveTypeIds) {
                context.Add(new EmployeeLeave() {
                    EmployeeId = employeeLeave.EmployeeId,
                    LeaveTypeId = typeId,
                    Leave = employeeLeave.Leave
                });
            }            
            await context.SaveChangesAsync();
            return Ok(createEmployeeLeaveDto);
        }
    }
}