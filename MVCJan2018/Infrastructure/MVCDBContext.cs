using MVCJan2018.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MVCJan2018.Infrastructure
{
   public class MVCDBContext : DbContext
   {
      public MVCDBContext() : base("MVCClassConnection")
      {
         Database.SetInitializer<MVCDBContext>(null);
      }
      protected override void OnModelCreating(DbModelBuilder modelBuilder)
      {
         modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
      }

      public DbSet<Student> Student { get; set; }
      public DbSet<Users> User { get; set; }
   }
}