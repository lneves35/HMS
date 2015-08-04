using System.Data.Entity;
using PandyIT.HMS.Data.Model.Entities;

namespace PandyIT.HMS.Data.Model
{
    public class HmsContext: DbContext
    {
        public HmsContext(string connectionString, IDatabaseInitializer<HmsContext> initializer)
            : base(connectionString)
        {
            Database.SetInitializer(initializer);       
        }

        protected HmsContext(string connectionString)
            : base(connectionString)
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
        }

        public DbSet<User> Users { get; set; }

        public DbSet<UserType> UserTypes { get; set; }
    }
}
