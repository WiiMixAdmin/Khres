using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Khres.Models
{
    public class Position
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        public ICollection<Employee> Employees { get; set; }
        public Position()
        {
            Employees = new Collection<Employee>();
        }      
    }
}