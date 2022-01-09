using Microsoft.AspNetCore.Mvc;

namespace TheLifeOrganize_Inator.API.Areas.Agenda.Controllers
{
    public class AgendaHomeController : Controller
    {
        [Area("agenda")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
