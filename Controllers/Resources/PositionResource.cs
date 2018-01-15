using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Khres.Controllers.Resources
{
    public class PositionResource
    {
        public int Id { get; set; }
       
        public string Title { get; set; }

        public ICollection<EmployeeResource> Employees { get; set; }

        public PositionResource()
        {
            Employees = new Collection<EmployeeResource>();            
        }
    }
}