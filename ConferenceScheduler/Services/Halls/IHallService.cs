namespace ConferenceScheduler.Services.Hall
{
    using System.Threading.Tasks;

    using ConferenceScheduler.ViewModels.Hall;

    public interface IHallService
    {
        Task<HallViewModel> AddAsync(HallCreateInputModel model);
    }
}
