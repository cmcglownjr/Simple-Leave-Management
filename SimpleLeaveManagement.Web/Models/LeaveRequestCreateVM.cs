using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SimpleLeaveManagement.Web.Models;

public class LeaveRequestCreateVM : IValidatableObject
{
    [Required]
    [Display(Name ="Start Date")]
    public DateTime? StartDate { get; set; }

    [Required]
    [Display(Name = "End Date")]
    public DateTime? EndDate { get; set; }

    [Required]
    [Display(Name = "Leave Type")]
    public int LeaveTypeId { get; set; }
    public SelectList? LeaveTypes { get; set; }

    [Display(Name = "Request Comments")]
    public string? RequestComments { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if(StartDate > EndDate)
        {
            yield return new ValidationResult("The Start Date Must Be Before End Date", new[] { nameof(StartDate), nameof(EndDate) });
        }

        if(RequestComments?.Length > 250)
        {
            yield return new ValidationResult("Comments are too long", new[] { nameof(RequestComments) });
        }
    }
}