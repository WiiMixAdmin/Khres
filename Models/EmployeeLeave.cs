namespace Khres.Models
{
    public class EmployeeLeave
    {
        public int LeaveId { get; set; }
        public Leave Leave { get; set; }
        public int LeaveTypeId { get; set; }
        public LeaveType Type { get; set; }        
    }
}