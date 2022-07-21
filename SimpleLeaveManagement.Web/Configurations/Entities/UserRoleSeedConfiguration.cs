using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SimpleLeaveManagement.Web.Configurations.Entities;

public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
{
    public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
    {
        builder.HasData(
            new IdentityUserRole<string>
            {
                RoleId = "038bc907-bfb7-4374-8166-02c54e82a2f0",
                UserId = "ecd519f0-a89c-4303-a487-9660982e62ec"
            },
            new IdentityUserRole<string>
            {
                RoleId = "67f1b1bb-4c4a-4407-9aca-d962316403e6",
                UserId = "5fa69211-43ed-43c3-9c88-3098a1b16cdc"
            }
        );
    }
}