using AutoMapper;
using SimpleLeaveManagement.Web.Data;
using SimpleLeaveManagement.Web.Models;

namespace SimpleLeaveManagement.Web.Configurations;

public class MapperConfig : Profile
{
    public MapperConfig()
    {
        CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
    }
}