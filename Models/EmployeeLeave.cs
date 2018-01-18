namespace Khres.Models
{
    public class EmployeeLeave
    {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int LeaveId { get; set; }
        public Leave Leave { get; set; }
        public int LeaveTypeId { get; set; }
        public LeaveType Type { get; set; }        
    }
}