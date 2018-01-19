using System.Linq;
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
            
            CreateMap<LeaveDetailDto, LeaveDetail>().ReverseMap();
            CreateMap<CreateLeaveDto, Leave>()
            .ForMember(dest => dest.EmployeeLeaves, opt => opt.MapFrom(s => s.LeaveTypeIds.Select(x => new EmployeeLeave() {
                LeaveTypeId = x
            })));

            CreateMap<Leave, CreateLeaveDto>()
            .ForMember(dest => dest.LeaveTypeIds, opt => opt.MapFrom(s => s.EmployeeLeaves.Select(x => x.LeaveTypeId)));
        }        
    }
}