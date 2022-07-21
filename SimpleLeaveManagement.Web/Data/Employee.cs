using Microsoft.AspNetCore.Identity;

namespace SimpleLeaveManagement.Web.Data;

public class Employee : IdentityUser
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string TaxId { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public DateOnly DateJoined { get; set; }
}