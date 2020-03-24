namespace ConferenceScheduler.Services.Halls
{
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

        public void Add(int id, HallAddInputModel model)
        {
            var hallsConferences = new HallsConferences
            {
                ConferenceId = id,
                HallId = model.HallId
            };

            this.context.HallsConferences.Add(hallsConferences);
            this.context.SaveChanges();
        }
    }
}
