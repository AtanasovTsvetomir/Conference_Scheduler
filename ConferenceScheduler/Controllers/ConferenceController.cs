namespace ConferenceScheduler.Controllers.ConferenceController
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Identity;

    using ConferenceScheduler.Data.Models;
    using ConferenceScheduler.Services.Conference;
    using ConferenceScheduler.ViewModels.Conference;

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
            this.conferenceService.Create(model, GetId());

            return this.Redirect("/Conference/Own");
        }

        public IActionResult All()
        {
            var conference = this.conferenceService.GetAll();

            return this.View(conference);
        }

        public IActionResult Own()
        {
            var ownConferences = this.conferenceService.Own(GetId());

            return this.View(ownConferences);
        }

        public IActionResult Details(int id)
        {
            var conference = this.conferenceService.Details(id);

            return this.View(conference);
        }

        public string GetId()
        {
            string currentId = userManager.GetUserId(HttpContext.User);

            return currentId;
        }
    }
}
