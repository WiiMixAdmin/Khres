using System;

namespace Khres.Models
{
    public class LeaveDetail
    {        
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float Duration { get; set; }
        public string Description { get; set; }
    }
}