using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Khres.Models
{
    public class Leave
    {
        public int Id { get; set; }
        public bool IsUrgent { get; set; }
        public DateTime LastUpdated { get; set; }
        public LeaveDetail Detail { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public ICollection<EmployeeLeave> EmployeeLeaves { get; set; }

        public Leave()
        {
            EmployeeLeaves = new Collection<EmployeeLeave>();
        }        
    }
}