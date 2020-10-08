using Microsoft.EntityFrameworkCore;
using SunMessengerV3.Domain.Core.Chats.ValueObjects;
using SunMessengerV3.Infrastructure.Core.Chats.Objects;
using SunMessengerV3.Infrastructure.Core.Chats.ValueObjects;
using SunMessengerV3.Infrastructure.Core.Messages.Objects;
using SunMessengerV3.Infrastructure.Core.Messages.ValueObjects;
using SunMessengerV3.Infrastructure.Core.Users.Objects;
using SunMessengerV3.Infrastructure.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SunMessengerV3.InfrastructureChats.Data
{
    public class MessengerContext:DbContext
    {
        public DbSet<User> Users { get; }
        public DbSet<Chat> Chats { get; }
        public DbSet<DirectChat> DirectChats { get; }
        public DbSet<GroupChat> GroupChats { get; }
        public DbSet<Message> Messages { get; }

        public DbSet<ChatLink> ChatLinks { get; }
        public DbSet<UserLink> UserLinks { get; }
        public DbSet<UserHistory> UsersHistory { get; }

        public MessengerContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ChatConfiguration());
            modelBuilder.ApplyConfiguration(new ChatLinkConfiguration());
            modelBuilder.ApplyConfiguration(new DirectChatConfiguration());
            modelBuilder.ApplyConfiguration(new GroupChatConfiguration());
            modelBuilder.ApplyConfiguration(new MessageConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserHistoryConfiguration());
            modelBuilder.ApplyConfiguration(new UserLinkConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
