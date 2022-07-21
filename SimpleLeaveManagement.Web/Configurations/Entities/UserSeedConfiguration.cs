using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleLeaveManagement.Web.Data;

namespace SimpleLeaveManagement.Web.Configurations.Entities;

public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        var hasher = new PasswordHasher<Employee>();
        builder.HasData(
            new Employee
            {
                Id = "ecd519f0-a89c-4303-a487-9660982e62ec",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                UserName = "admin@localhost.com",
                Firstname = "System",
                Lastname = "Admin",
                PasswordHash = hasher.HashPassword(null, "!QA2ws#ED"),
                EmailConfirmed = true
            },
            new Employee
            {
                Id = "5fa69211-43ed-43c3-9c88-3098a1b16cdc",
                Email = "user@localhost.com",
                NormalizedEmail = "USER@LOCALHOST.COM",
                NormalizedUserName = "USER@LOCALHOST.COM",
                UserName = "user@localhost.com",
                Firstname = "System",
                Lastname = "User",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true
            }
        );
    }
}