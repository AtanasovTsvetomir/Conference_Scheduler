namespace ConferenceScheduler.Services.Conference
{
    using ConferenceScheduler.ViewModels.Conference;
    using System.Collections.Generic;
    using ConferenceScheduler.Data.Models;
    using Microsoft.AspNetCore.Identity;

    public interface IConferenceService
    {
         void Create(ConferenceCreateInputModel model, string currentId);

        IEnumerable<Conference> GetAll();

        IEnumerable<Conference> Own(string id);
    }
}
