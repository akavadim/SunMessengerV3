using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SunMessengerV3.Infrastructure.Core.Chats.Objects;
using SunMessengerV3.Infrastructure.Core.Messages.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunMessengerV3.Infrastructure.Data.Configurations
{
    class ChatLinkConfiguration : IEntityTypeConfiguration<ChatLink>
    {
        public void Configure(EntityTypeBuilder<ChatLink> builder)
        {
            builder.HasOne<Chat>()
                .WithMany()
                .HasForeignKey(e => e.ChatId);
        }
    }
}
