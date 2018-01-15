namespace Khres.Controllers.Resources
{
    public class EmployeeResource
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }

        public int PositionId { get; set; }
        public PositionResource Position { get; set; }  
    }
}