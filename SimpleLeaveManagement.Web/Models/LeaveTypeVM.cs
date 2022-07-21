using System.ComponentModel.DataAnnotations;

namespace SimpleLeaveManagement.Web.Models;

public class LeaveTypeVM
{
    public int Id { get; set; }
    [Required]
    [Display(Name = "Leave Type Name")]
    public string Name { get; set; }
    [Required]
    [Display(Name = "Default Number Of Days")]
    [Range(1, 25, ErrorMessage = "Please Enter A Valid Number")]
    public int DefaultDays { get; set; }
}