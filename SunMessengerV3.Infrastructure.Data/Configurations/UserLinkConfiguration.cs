using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SunMessengerV3.Infrastructure.Core.Chats.ValueObjects;
using SunMessengerV3.Infrastructure.Core.Users.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunMessengerV3.Infrastructure.Data.Configurations
{
    class UserLinkConfiguration : IEntityTypeConfiguration<UserLink>
    {
        public void Configure(EntityTypeBuilder<UserLink> builder)
        {
            builder.HasOne<User>()
                .WithMany()
                .HasForeignKey(e => e.UserId);
        }
    }
}
