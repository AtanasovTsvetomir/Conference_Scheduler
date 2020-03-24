using ConferenceScheduler.ViewModels.Session;

namespace ConferenceScheduler.Services.Sessions
{
    public interface ISessionService
    {
        void Add(SessionAddInputModel model);
    }
}
