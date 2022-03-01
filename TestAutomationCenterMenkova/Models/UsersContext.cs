using Microsoft.EntityFrameworkCore;

namespace TestAutomationCenterMenkova.Models
{
    public class UsersContext : DbContext
    {
            public DbSet<User> Users { get; set; }
            public DbSet<Chat> Chats { get; set; }

        public UsersContext(DbContextOptions<UsersContext> options)
                : base(options)
            {
                Database.EnsureCreated();
            }
    }
}