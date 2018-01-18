using System;

namespace Khres.Controllers.Resources
{
    public class LeaveDetailDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float Duration { get; set; }
        public string Description { get; set; }        
    }
}