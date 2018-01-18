using AutoMapper;
using Khres.Controllers.Resources;
using Khres.Models;

namespace Khres.Mapping
{
    public class KhresMappingProfile : Profile
    {
        public KhresMappingProfile()
        {
            CreateMap<Employee, EmployeeDto>();
            CreateMap<Position, PositionDto>()
            .ForMember(dest => dest.Employees, opt => opt.Ignore());
        }        
    }
}