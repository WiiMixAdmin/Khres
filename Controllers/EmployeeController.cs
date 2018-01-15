using System.Collections.Generic;
using System.Threading.Tasks;
using Khres.Controllers.Resources;
using Khres.Models;
using Khres.Persistent;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace Khres.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly KhresDbContext context;
        private readonly IMapper mapper;

        public EmployeeController(KhresDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet("/api/employees")]
        public async Task<IEnumerable<EmployeeResource>> GetEmployees()
        {
            var employees = await context.Employees.Include(e => e.Position).ToListAsync();
            return mapper.Map<List<Employee>, List<EmployeeResource>>(employees);
        }
    }
}