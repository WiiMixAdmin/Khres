using System.ComponentModel.DataAnnotations;

namespace Khres.Models
{
    public class Position
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }        
    }
}