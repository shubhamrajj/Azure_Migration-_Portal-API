using ctrlspec.Models;
using Microsoft.EntityFrameworkCore;

namespace ctrlspec.Data
{
    public class CtrlSpecDbContext:DbContext
    {
        public CtrlSpecDbContext(DbContextOptions<CtrlSpecDbContext>options):base(options)
        {

        }

      

        public DbSet<Login> login { get; set; }
         public DbSet<ServerList> ServerLists { get; set; }
         public DbSet<ApplicationList> ApplicationLists { get; set; }
        public DbSet<Application> Applications { get; set; }

        public DbSet<EmailModel> emailModel { get; set; }

         protected override void OnModelCreating(ModelBuilder modelBuilder)

    {

        // Configure the relationship between Login and Applications

        modelBuilder.Entity<Login>()

            .HasOne(l => l.Application)

            .WithOne(a => a.login)

            .HasForeignKey<Application>(a => a.C_Id);

    }
        internal Task GetById()
        {
            throw new NotImplementedException();
        }
    }
}
