namespace Khres.Controllers.Resources
{
    public class CreateEmployeeLeaveDto
    {
        public int EmployeeId { get; set; }
        public CreateLeaveDto Leave { get; set; }
        public int[] LeaveTypeIds { get; set; }        
    }   
}