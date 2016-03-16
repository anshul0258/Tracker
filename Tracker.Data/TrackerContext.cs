using System.Data.Entity;
using Tracker.Business.Entities;
using System.Data.Entity.ModelConfiguration.Conventions;
using Core.Common.Contracts;
using System.Runtime.Serialization;

namespace Tracker.Data
{
    public class TrackerContext : DbContext
    {
        public TrackerContext() : base("name=Tracker")
        {
            Database.SetInitializer<TrackerContext>(null);
        }
        
        public DbSet<Client> ClientSet { get; set; }
        public DbSet<Project> ProjectSet { get; set; }
        public DbSet<Tasks> TasksSet { get; set; }
        public DbSet<Person> PersonSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Ignore<IIdentifiableEntity>();
            modelBuilder.Ignore<ExtensionDataObject>();

            modelBuilder.Entity<Client>().HasKey(e => e.ClientID).Ignore(e => e.EntityId);
            modelBuilder.Entity<Project>().HasKey(e => e.ProjectId).Ignore(e => e.EntityId);
            modelBuilder.Entity<Tasks>().HasKey(e => e.TaskId).Ignore(e => e.EntityId);
            modelBuilder.Entity<Person>().HasKey(e => e.PersonId).Ignore(e => e.EntityId);           
        }
    }
}
