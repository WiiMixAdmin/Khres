using System.ComponentModel.DataAnnotations;

namespace Khres.Models
{
    public class LeaveType
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Label { get; set; }        
    }
}