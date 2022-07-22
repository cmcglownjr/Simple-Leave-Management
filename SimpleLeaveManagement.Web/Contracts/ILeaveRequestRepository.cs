using SimpleLeaveManagement.Web.Data;
using SimpleLeaveManagement.Web.Models;

namespace SimpleLeaveManagement.Web.Contracts;

public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
{
    Task<bool> CreateLeaveRequest(LeaveRequestCreateVM model);
    Task<EmployeeLeaveRequestViewVM> GetMyLeaveDetails();
    Task<LeaveRequestVM?> GetLeaveRequestAsync(int? id);
    Task<List<LeaveRequest>> GetAllAsync(string employeeId);
    Task ChangeApprovalStatus(int leaveRequestId, bool approved);
    Task CancelLeaveRequest(int leaveRequestId);
    Task<AdminLeaveRequestViewVM> GetAdminLeaveRequestList();
}