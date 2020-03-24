namespace ConferenceScheduler.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using ConferenceScheduler.Services.Halls;
    using ConferenceScheduler.ViewModels.Hall;

    public class HallController : Controller
    {
        private readonly IHallService hallService;

        public HallController(IHallService hallService)
        {
            this.hallService = hallService;
        }

        public IActionResult Add()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Add(int id, HallAddInputModel model)
        {
            this.hallService.Add(id, model);

            return this.Redirect("/Conference/Own");
        }
    }
}