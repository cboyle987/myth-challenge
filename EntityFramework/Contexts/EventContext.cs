using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Contexts
{
    public class EventContext : DbContext
    {
        public DbSet<EventData> Events { get; set; }
        public DbSet<ParentChildRelation> ParentRelations { get; set; }
        public DbSet<RelatedSportsEvents> Relations { get; set; }

        public EventContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable("MYTH_DB_CONNECTION_STRING"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ParentChildRelation>()
                .HasKey(x => new { x.ParentId, x.ChildId });

            modelBuilder.Entity<SportsOrganization>()
                .HasKey(org => new {org.SportsOrganizationId, org.EventDataId});

            modelBuilder.Entity<EventData>()
                .HasMany(e => e.ChildSportEvents)
                .WithOne(e => e.Parent)
                .HasForeignKey(e => e.ParentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<EventData>()
                .HasMany(e => e.ParentSportEvents)
                .WithOne(e => e.Child)
                .HasForeignKey(e => e.ChildId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RelatedSportsEvents>()
                .HasKey(x => new {x.RelatedEventId, x.EventId});

            modelBuilder.Entity<RelatedSportsEvents>()
                .HasOne(e => e.RelatedEvent)
                .WithMany()
                .HasForeignKey(e => e.RelatedEventId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RelatedSportsEvents>()
                .HasOne(e => e.Event)
                .WithMany(e => e.RelatedSportsEvents)
                .HasForeignKey(e => e.EventId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
