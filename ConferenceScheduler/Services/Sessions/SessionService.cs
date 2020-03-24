using ConferenceScheduler.Data;
using ConferenceScheduler.Data.Models;
using ConferenceScheduler.ViewModels.Session;

namespace ConferenceScheduler.Services.Sessions
{
    public class SessionService : ISessionService
    {
        private readonly ApplicationDbContext context;

        public SessionService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void Add(SessionAddInputModel model)
        {
            var session = new Session
            {
                Name = model.Name,
                Description = model.Description,
                SessionStart = model.StartTime,
                SessionEnd = model.EndTime,
            };
        }
    }
}
