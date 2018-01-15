namespace Khres.Models
{
    public class Position
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }        
    }
}