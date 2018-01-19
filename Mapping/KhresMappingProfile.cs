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
                var removedLeaveTypes = new List<EmployeeLeave>();
                foreach(var s in src.LeaveTypeIds) {
                    var itemExisted = dest.EmployeeLeaves.Any(x => x.LeaveTypeId == s);
                    if(!itemExisted) dest.EmployeeLeaves.Add(new EmployeeLeave() {LeaveTypeId = s});
                }

                foreach(var d in dest.EmployeeLeaves) {
                    var itemExisted = src.LeaveTypeIds.Contains(d.LeaveTypeId);
                    if(!itemExisted) {
                        removedLeaveTypes.Add(d);
                    }    
                }

                removedLeaveTypes.ForEach(el => {
                    dest.EmployeeLeaves.Remove(el);
                });                
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