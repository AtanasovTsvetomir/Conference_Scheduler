using ConferenceScheduler.Services.Conference;
using ConferenceScheduler.ViewModels.Conference;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceScheduler.Controllers.ConferenceController
{
    public class ConferenceController : Controller
    {
        private readonly IConferenceService conferenceService;

        public ConferenceController(IConferenceService conferenceService)
        {
            this.conferenceService = conferenceService;
        }

        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(ConferenceCreateInputModel input)
        {
            this.conferenceService.Create(input);

            return this.Redirect("/Home");
        }

        public IActionResult All()
        {
            var conference = this.conferenceService.GetAll();

            return this.View(conference); 
        }
    }
}
