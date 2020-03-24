namespace ConferenceScheduler.Data
{
    using Microsoft.EntityFrameworkCore;

    using ConferenceScheduler.Data.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

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

        public DbSet<HallsConferences> HallsConferences { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<UsersConferences>()
                .HasKey(uc => new { uc.ConferenceId, uc.ApplicationUserId });

            builder
                .Entity<SpeakersConferences>()
                .HasKey(sc => new { sc.SpeakerId, sc.ConferenceId });

            builder
                .Entity<HallsConferences>()
                .HasKey(hc => new { hc.HallId, hc.ConferenceId });

            builder.Entity<Hall>()
                .HasOne(h => h.Venue)
                .WithMany(v => v.Halls)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Hall>()
                .HasData(new Hall
                {
                    Id = 1,
                    Name = "First hall",
                    Capacity = 50,
                    VenueId = 1
                });

            builder.Entity<Hall>()
                .HasData(new Hall
                {
                    Id = 2,
                    Name = "Second hall",
                    Capacity = 50,
                    VenueId = 1
                });

            builder.Entity<Hall>()
                .HasData(new Hall
                {
                    Id = 3,
                    Name = "First hall",
                    Capacity = 50,
                    VenueId = 2
                });

            builder.Entity<Hall>()
                .HasData(new Hall
                {
                    Id = 4,
                    Name = "Second hall",
                    Capacity = 50,
                    VenueId = 2
                });

            builder.Entity<Hall>()
                .HasData(new Hall
                {
                    Id = 5,
                    Name = "First hall",
                    Capacity = 50,
                    VenueId = 3
                });

                builder.Entity<Hall>()
                .HasData(new Hall
                {
                    Id = 6,
                    Name = "Second hall",
                    Capacity = 50,
                    VenueId = 3
                });

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
                //Halls = new List<Hall>
                //{
                //    new Hall()
                //    {
                //        Id = 1,
                //        Name = "First hall",
                //        Capacity = 50,
                //        VenueId = 2
                //    },
                //    new Hall()
                //    {
                //        Id = 2,
                //        Name = "Second hall",
                //        Capacity = 100,
                //        VenueId = 2
                //    },
                //    new Hall()
                //    {
                //        Id = 3,
                //        Name = "Third hall",
                //        Capacity = 80,
                //        VenueId = 2
                //    }
                //}
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
