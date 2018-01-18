using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Khres.Controllers.Resources
{
    public class PositionDto
    {
        public int Id { get; set; }
       
        public string Title { get; set; }

        public ICollection<EmployeeDto> Employees { get; set; }

        public PositionDto()
        {
            Employees = new Collection<EmployeeDto>();            
        }
    }
}