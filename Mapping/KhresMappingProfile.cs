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
            CreateMap<CreateLeaveDto, Leave>()
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
            /*
            .ForMember(dest => dest.EmployeeLeaves, opt => opt.MapFrom(s => s.LeaveTypeIds.Select(x => new EmployeeLeave() {
                LeaveTypeId = x
            }))); */

            CreateMap<Leave, CreateLeaveDto>()
            .ForMember(dest => dest.LeaveTypeIds, opt => opt.MapFrom(s => s.EmployeeLeaves.Select(x => x.LeaveTypeId)));
        }        
    }
}