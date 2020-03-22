using ConferenceScheduler.Data;
using ConferenceScheduler.Data.Models;
using ConferenceScheduler.Services.Conference;
using ConferenceScheduler.ViewModels.Conference;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ConferenceScheduler.Controllers.ConferenceController
{
    public class ConferenceController : Controller
    {
        private readonly IConferenceService conferenceService;
        private readonly UserManager<ApplicationUser> userManager;

        public ConferenceController(IConferenceService conferenceService, UserManager<ApplicationUser> userManager)
        {
            this.conferenceService = conferenceService;
            this.userManager = userManager;
        }

        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(ConferenceCreateInputModel model)
        {
            string currentId = userManager.GetUserId(HttpContext.User);

            this.conferenceService.Create(model, currentId);

            return this.Redirect("/Home");
        }

        public IActionResult All()
        {
            var conference = this.conferenceService.GetAll();

            return this.View(conference);
        }

        public IActionResult Own()
        {
            string currentId = userManager.GetUserId(HttpContext.User);

            var ownConferences = this.conferenceService.Own(currentId);

            return this.View(ownConferences);
        }
    }
}
