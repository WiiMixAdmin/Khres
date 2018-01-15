using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Khres.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }

        public ICollection<Position> Positions { get; set; }

        public Employee()
        {
            Positions = new Collection<Position>();
        }
    }
}