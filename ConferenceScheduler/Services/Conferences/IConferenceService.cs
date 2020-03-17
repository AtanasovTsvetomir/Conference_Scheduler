namespace ConferenceScheduler.Services.Conference
{
    using ConferenceScheduler.ViewModels.Conference;
    using System.Collections.Generic;
    using ConferenceScheduler.Data.Models;

    public interface IConferenceService
    {
         void Create(ConferenceCreateInputModel model);

        IEnumerable<Conference> GetAll();
    }
}
