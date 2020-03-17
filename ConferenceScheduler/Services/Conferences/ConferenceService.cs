namespace ConferenceScheduler.Services.Conferences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

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

       
       
        public void Create(ConferenceCreateInputModel model)
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
        }

        public IEnumerable<Conference> GetAll()
                    => this.context.Conferences.Select(x => new Conference
                    {
                        Name = x.Name,
                        Description = x.Description,
                        StartTime = x.StartTime,
                        EndTime = x.EndTime,
                        Venue = x.Venue
                    })
                    .ToArray();
    }
}

//public IEnumerable<Conference> GetAll()
//            => this.context.Conferences.Select(x => new Conference
//            {
//                Name = x.Name,
//                Description = x.Name,
//                StartTime = x.StartTime,
//                EndTime = x.EndTime,
//                Venue = x.Venue
//            })
//            .ToArray();


//public async Task<ConferenceViewModel> AddAsync(ConferenceCreateInputModel model)
//{
//    if (model.Name == null || model.Description == null || model.StartTime == null || model.EndTime == null)
//    {
//        // Add other exception!
//        throw new Exception("Invalid data!");
//    }

//    var conference = new Conference
//    {
//        Name = model.Name,
//        Description = model.Description,
//        Venue = context.Venues.Find(model.VenueId),
//        StartTime = model.StartTime,
//        EndTime = model.EndTime,
//    };

//    await this.context.Conferences.AddAsync(conference);
//    await this.context.SaveChangesAsync();

//    var viewModel = new ConferenceViewModel
//    {
//        Name = conference.Name,
//        Description = conference.Description,
//        StartTime = conference.StartTime,
//        EndTime = conference.EndTime,
//        Venue = conference.Venue,
//    };

//    return viewModel;
//}
