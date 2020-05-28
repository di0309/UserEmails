using System.Data.Entity;
using UserEmails.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace UserEmails.DAL
{
    public class UserEmailsContext : DbContext
    {
        public UserEmailsContext() : base("UE")
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Email> Emails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // мне больше нравится использовать существительные в ед. числе для названия сущностей в БД
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<User>().Property(c => c.Name).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Email>().Property(c => c.Mail).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Email>().Property(c => c.UserID).IsRequired();
        }
    }
}