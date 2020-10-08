using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SunMessengerV3.Infrastructure.Core.Chats.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunMessengerV3.Infrastructure.Data.Configurations
{
    class DirectChatConfiguration : IEntityTypeConfiguration<DirectChat>
    {
        public void Configure(EntityTypeBuilder<DirectChat> builder)
        {
            
        }
    }
}
