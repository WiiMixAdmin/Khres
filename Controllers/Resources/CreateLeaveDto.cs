using System;
using System.ComponentModel.DataAnnotations;

namespace Khres.Controllers.Resources
{
    public class CreateLeaveDto
    {        
        [Required]
        public int EmployeeId { get; set; }
        public bool IsUrgent { get; set; }
        public LeaveDetailDto Detail { get; set; }
        [Required]
        public int[] LeaveTypeIds { get; set; }
    }
}