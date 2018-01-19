using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Khres.Models
{
    public class LeaveType
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Label { get; set; }
        public ICollection<EmployeeLeave> EmployeeLeaves { get; set; }
        public LeaveType()
        {
            EmployeeLeaves = new Collection<EmployeeLeave>();
        }        
    }
}