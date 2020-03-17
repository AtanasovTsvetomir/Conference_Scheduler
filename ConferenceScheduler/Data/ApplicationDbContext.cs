namespace ConferenceScheduler.Data
{
    using Microsoft.EntityFrameworkCore;

    using ConferenceScheduler.Data.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using System.Collections.Generic;

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Conference> Conferences { get; set; }

        public DbSet<Hall> Halls { get; set; }

        public DbSet<Session> Sessions { get; set; }

        public DbSet<Speaker> Speakers { get; set; }

        public DbSet<Venue> Venues { get; set; }

        public DbSet<UsersConferences> UsersConferences { get; set; }

        public DbSet<SpeakersConferences> SpeakersConferences { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<UsersConferences>()
                .HasKey(uc => new { uc.ConferenceId, uc.ApplicationUserId });

            builder
                .Entity<SpeakersConferences>()
                .HasKey(sc => new { sc.SpeakerId, sc.ConferenceId });

            builder.Entity<Hall>()
                .HasOne(h => h.Venue)
                .WithMany(v => v.Halls)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Venue>().HasData(new Venue
            {
                Id = 1,
                Name = "Inter Expo Center",
                Address = "Sofia",
            });

            builder.Entity<Venue>().HasData(new Venue
            {
                Id = 2,
                Name = "Sofia Center",
                Address = "Sofia",
            });

            builder.Entity<Venue>().HasData(new Venue
            {
                Id = 3,
                Name = "Caneff Center",
                Address = "Rousse",
            });

            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(@"Server=DESKTOP-M8SK6SD\SQLEXPRESS01;Database=Conference_Scheduler;Trusted_Connection=True;Integrated Security=True;");
            }
        }
    }
}
