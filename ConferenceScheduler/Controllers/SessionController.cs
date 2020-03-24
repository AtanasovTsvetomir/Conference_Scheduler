namespace ConferenceScheduler.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class SessionController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }
    }
}