using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Khres.Controllers.Resources
{
    public class OutputLeaveDto
    {        
        public int EmployeeId { get; set; }
        public EmployeeDto Employee { get; set; }
        public bool IsUrgent { get; set; }
        public DateTime LastUpdated { get; set; }
        public LeaveDetailDto Detail { get; set; }        
        public ICollection<LeaveTypeDto> LeaveTypes { get; set; }
    }
}