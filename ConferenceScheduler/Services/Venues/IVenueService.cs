namespace ConferenceScheduler.Services.Venue
{
    using ConferenceScheduler.ViewModels.Venue;
    using System.Threading.Tasks;

    public interface IVenueService
    {
        Task<VenueViewModel> AddAsync(VenueCreateInputModel model);
    }
}
