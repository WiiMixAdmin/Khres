using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Khres.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(255)]
        public string LastName { get; set; }
        [RegularExpression("^(?:m|M|male|Male|f|F|female|Female)$")]
        public string Gender { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public int PositionId { get; set; }
        public Position Position { get; set; }        
    }
}