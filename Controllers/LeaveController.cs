using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task<IActionResult> CreateLeave([FromBody] InputLeaveDto createLeaveDto)
        {
            if(!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            var leave = mapper.Map<InputLeaveDto, Leave>(createLeaveDto);
            leave.LastUpdated = DateTime.Now; 
            context.Leaves.Add(leave);
               
            await context.SaveChangesAsync();
            var result = mapper.Map<Leave, InputLeaveDto>(leave);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLeave(int id, [FromBody] InputLeaveDto createLeaveDto) {
            if(!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            var leave = await context.Leaves.Include(x => x.EmployeeLeaves).SingleOrDefaultAsync(x => x.Id == id);
            leave.LastUpdated = DateTime.Now;
            mapper.Map<InputLeaveDto, Leave>(createLeaveDto, leave);

            await context.SaveChangesAsync();
            var result  = mapper.Map<Leave, InputLeaveDto>(leave);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLeave(int id) {
            var leave = await context.Leaves.FindAsync(id);

            if(leave == null) return NotFound("Id not found");
            
            context.Leaves.Remove(leave);
            
            await context.SaveChangesAsync();
            var result = mapper.Map<Leave, InputLeaveDto>(leave);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IEnumerable<OutputLeaveDto>> GetLeave() {

            var leave = await context.Leaves
            .Include(x => x.Employee)
            .Include(x => x.EmployeeLeaves)
            .Include("EmployeeLeaves.Type").ToListAsync();

            return mapper.Map<List<Leave>,List<OutputLeaveDto>>(leave);
        } 
    }
}