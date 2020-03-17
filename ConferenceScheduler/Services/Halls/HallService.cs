namespace ConferenceScheduler.Services.Hall
{
    using System;
    using System.Threading.Tasks;

    using ConferenceScheduler.Data;
    using ConferenceScheduler.Data.Models;
    using ConferenceScheduler.ViewModels.Hall;

    public class HallService : IHallService
    {
        private readonly ApplicationDbContext context;

        public HallService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<HallViewModel> AddAsync(HallCreateInputModel model)
        {
            if (model.Name == null || model.Capacity <= 0)
            {
                //Add more exceptions
                throw new Exception("Invalid data!");
            }

            var hall = new Hall
            {
                Name = model.Name,
                Capacity = model.Capacity,
                // parse the enum.
                //VenueId = Enum.Parse<VenueEnum>(model.Venue),
            };

            await this.context.Halls.AddAsync(hall);
            await this.context.SaveChangesAsync();

            var viewModel = new HallViewModel
            {
                Name = model.Name,
                Capacity = model.Capacity,
            };

            return viewModel;
        }
    }
}
