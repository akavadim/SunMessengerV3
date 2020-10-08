using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SunMessengerV3.Infrastructure.Core.Chats.Objects;
using SunMessengerV3.Infrastructure.Core.Users.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunMessengerV3.Infrastructure.Data.Configurations
{
    class GroupChatConfiguration : IEntityTypeConfiguration<GroupChat>
    {
        public void Configure(EntityTypeBuilder<GroupChat> builder)
        {
            builder.Property(e => e.Name)
                .IsRequired();

            builder.HasOne<User>()
                .WithMany()
                .HasForeignKey(e => e.CreatorId);
        }
    }
}
