using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleLeaveManagement.Web.Constants;

namespace SimpleLeaveManagement.Web.Configurations.Entities;

public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        builder.HasData(
            new IdentityRole
            {
                Id = "038bc907-bfb7-4374-8166-02c54e82a2f0",
                Name = Roles.Administrator,
                NormalizedName = Roles.Administrator.ToUpper()
            },
            new IdentityRole
            {
                Id = "67f1b1bb-4c4a-4407-9aca-d962316403e6",
                Name = Roles.User,
                NormalizedName = Roles.User.ToUpper()
            }
        );
    }
}