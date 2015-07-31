using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PandyIT.HMS.Data.Entities.Entities;

namespace PandyIT.HMS.Data.Entities
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
