using System.ComponentModel.DataAnnotations;

namespace SimpleLeaveManagement.Web.Models;

public class LeaveAllocationVM
{
    [Microsoft.Build.Framework.Required]
    public int Id { get; set; }

    [Display(Name = "Number Of Days")]
    [Microsoft.Build.Framework.Required]
    [Range(1, 50, ErrorMessage = "Invalid Number Entered")]
    public int NumberOfDays { get; set; }

    [Microsoft.Build.Framework.Required]
    [Display(Name = "Allocation Period")]
    public int Period { get; set; }

    public LeaveTypeVM? LeaveType { get; set; }
}