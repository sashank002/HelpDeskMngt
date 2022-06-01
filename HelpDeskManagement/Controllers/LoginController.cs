using Microsoft.AspNetCore.Mvc;

namespace HelpDeskManagement.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
