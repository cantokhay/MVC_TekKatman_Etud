using Microsoft.EntityFrameworkCore;
using MvcTekKatman.Entities;

namespace MvcTekKatman.Context
{
    public class MvcContext : DbContext
    {
        public MvcContext(DbContextOptions<MvcContext> options) : base(options)
        {

        }

        public DbSet<User> Users  { get; set; }

        public DbSet<School> Schools { get; set; }

        public DbSet<Class> Classes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User {Id = 1, FirstName = "Muhammed", LastName= "Güler", Role = Enums.Role.Admin, CreateDate = DateTime.Now}
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
