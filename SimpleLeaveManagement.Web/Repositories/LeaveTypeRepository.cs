using SimpleLeaveManagement.Web.Contracts;
using SimpleLeaveManagement.Web.Data;

namespace SimpleLeaveManagement.Web.Repositories;

public class LeaveTypeRepository: GenericRepository<LeaveType>, ILeaveTypeRepository
{
    public LeaveTypeRepository(ApplicationDbContext context) : base(context)
    {
        
    }
}