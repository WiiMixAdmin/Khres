using System;

namespace Khres.Controllers.Resources
{
    public class CreateLeaveDto
    {        
        public bool IsUrgent { get; set; }
        public LeaveDetailDto Detail { get; set; }
    }
}