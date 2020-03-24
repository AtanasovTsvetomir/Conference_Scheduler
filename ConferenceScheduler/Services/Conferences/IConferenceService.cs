namespace ConferenceScheduler.Services.Conference
{
    using System.Collections.Generic;

    using ConferenceScheduler.Data.Models;
    using ConferenceScheduler.ViewModels.Conference;

    public interface IConferenceService
    {
         void Create(ConferenceCreateInputModel model, string currentId);

        IEnumerable<Conference> GetAll();

        IEnumerable<Conference> Own(string id);

        Conference Details(int id);
    }
}
