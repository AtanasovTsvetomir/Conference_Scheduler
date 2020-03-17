namespace ConferenceScheduler.Services.Venue
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using ConferenceScheduler.Data;
    using ConferenceScheduler.ViewModels.Venue;

    public class VenueService : IVenueService
    {
        private readonly ApplicationDbContext context;

        public VenueService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<VenueViewModel> AddAsync(VenueCreateInputModel model)
        {
            // TODO : restyle the venue service!!!!


            //if (model.Name == null || model.Address == null)
            //{
            //    throw new Exception("Invalid data!");
            //}

            //var venue = new Data.Models.Venue
            //{
            //    Name = model.Name,
            //    Address = model.Address,
            //    Halls = model.Halls,
            //};

            //await this.context.Venues.AddAsync(venue);
            //await this.context.SaveChangesAsync();

            //var viewModel = new VenueViewModel
            //{
            //    Name = model.Name,
            //    Address = model.Address,
            //};

            return null;
        }
    }
}
