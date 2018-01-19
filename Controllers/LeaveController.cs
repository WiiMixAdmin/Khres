using System;
using System.Threading.Tasks;
using AutoMapper;
using Khres.Controllers.Resources;
using Khres.Models;
using Khres.Persistent;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public async Task<IActionResult> CreateLeave([FromBody] CreateLeaveDto createLeaveDto)
        {
            if(!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            var leave = mapper.Map<CreateLeaveDto, Leave>(createLeaveDto);
            leave.LastUpdated = DateTime.Now; 
            context.Leaves.Add(leave);
               
            await context.SaveChangesAsync();
            var result = mapper.Map<Leave, CreateLeaveDto>(leave);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLeave(int id, [FromBody] CreateLeaveDto createLeaveDto) {
            if(!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            var leave = await context.Leaves.Include(x => x.EmployeeLeaves).SingleOrDefaultAsync(x => x.Id == id);
            mapper.Map<CreateLeaveDto, Leave>(createLeaveDto, leave);

            await context.SaveChangesAsync();
            var result  = mapper.Map<Leave, CreateLeaveDto>(leave);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLeave(int id) {
            
            if(!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            var leave = await context.Leaves.FindAsync(id);
            context.Leaves.Remove(leave);
            
            await context.SaveChangesAsync();
            var result = mapper.Map<Leave, CreateLeaveDto>(leave);
            return Ok(result);
        }
    }
}