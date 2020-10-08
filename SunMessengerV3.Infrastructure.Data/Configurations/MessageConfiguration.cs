using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SunMessengerV3.Infrastructure.Core.Messages.Objects;
using SunMessengerV3.Infrastructure.Core.Users.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunMessengerV3.Infrastructure.Data.Configurations
{
    class MessageConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasOne<User>()
                .WithMany()
                .HasForeignKey(e => e.SenderId);
            builder.HasMany(e => e.Chats);
            
        }
    }
}
