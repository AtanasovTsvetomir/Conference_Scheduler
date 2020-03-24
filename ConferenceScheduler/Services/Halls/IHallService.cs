namespace ConferenceScheduler.Services.Halls
{
    using ConferenceScheduler.ViewModels.Hall;

    public interface IHallService 
    {
        void Add(int id, HallAddInputModel model);
    }
}
