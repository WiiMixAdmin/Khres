using System.Collections.Generic;
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
            CreateMap<InputLeaveDto, Leave>()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .AfterMap((src, dest) => { 

                var addItems = src.LeaveTypeIds.Where(x => dest.EmployeeLeaves.Any(t => t.LeaveTypeId != x))
                .Select(tId => new EmployeeLeave() {LeaveTypeId = tId});
                foreach(var i in addItems) 
                    dest.EmployeeLeaves.Add(i);
                
                var deleteItems = dest.EmployeeLeaves.Where(x => !src.LeaveTypeIds.Contains(x.LeaveTypeId));
                foreach(var i in deleteItems)
                    dest.EmployeeLeaves.Remove(i);            
            });

            CreateMap<Leave, InputLeaveDto>()
            .ForMember(dest => dest.LeaveTypeIds, opt => opt.MapFrom(s => s.EmployeeLeaves.Select(x => x.LeaveTypeId)));

            CreateMap<Leave, OutputLeaveDto>()
            .ForMember(dest => dest.LeaveTypes, opt => opt.MapFrom(s => s.EmployeeLeaves.Select(x => 
                new LeaveTypeDto() { Id = x.Type.Id, Label = x.Type.Label }
            )));
        }        
    }
}