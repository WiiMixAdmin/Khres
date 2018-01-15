using AutoMapper;
using Khres.Controllers.Resources;
using Khres.Models;

namespace Khres.Mapping
{
    public class KhresMappingProfile : Profile
    {
        public KhresMappingProfile()
        {
            CreateMap<Employee, EmployeeResource>();
            CreateMap<Position, PositionResource>()
            .ForMember(dest => dest.Employees, opt => opt.Ignore());
        }        
    }
}