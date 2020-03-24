namespace ConferenceScheduler.Services.Conferences
{
    using System.Linq;
    using System.Collections.Generic;

    using ConferenceScheduler.Data;
    using ConferenceScheduler.Data.Models;
    using ConferenceScheduler.Services.Conference;
    using ConferenceScheduler.ViewModels.Conference;

    public class ConferenceService : IConferenceService
    {
        private readonly ApplicationDbContext context;

        public ConferenceService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void Create(ConferenceCreateInputModel model, string currentId)
        {
            var conference = new Conference
            {
                Name = model.Name,
                Description = model.Description,
                Venue = context.Venues.Find(model.VenueId),
                StartTime = model.StartTime,
                EndTime = model.EndTime,
            };

            this.context.Conferences.Add(conference);
            this.context.SaveChanges();

            var usersConferences = new UsersConferences()
            {
                ApplicationUserId = currentId,
                ConferenceId = conference.Id
            };

            this.context.UsersConferences.Add(usersConferences);
            this.context.SaveChanges();
        }

        public IEnumerable<Conference> GetAll()
                    => this.context.Conferences
                        .Select(x => new Conference
                        {
                            Id = x.Id,
                            Name = x.Name,
                            Description = x.Description,
                            StartTime = x.StartTime,
                            EndTime = x.EndTime,
                            Venue = x.Venue,
                        })
                        .ToArray();

        public IEnumerable<Conference> Own(string id)
                => this.context
                     .UsersConferences
                     .Where(x => x.ApplicationUserId == id)
                     .Select(x => new Conference
                     {
                         Id = x.Conference.Id,
                         Name = x.Conference.Name,
                         Description = x.Conference.Description,
                         StartTime = x.Conference.StartTime,
                         EndTime = x.Conference.EndTime,
                         Venue = x.Conference.Venue,
                     })
                         .ToArray();

        public Conference Details(int id)
            => this.context
                .Conferences
                .Find(id);
    }
}
