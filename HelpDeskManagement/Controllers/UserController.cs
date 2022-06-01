using HelpDeskManagement.Models;
using HelpDeskManagement.ViewModel;
using Microsoft.AspNetCore.Mvc;


namespace HelpDeskManagement.Controllers
{
    public class UserController : Controller
    {
        private readonly HelpDeskDBContext _context;

        public UserController(HelpDeskDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult saveUser(UserMst model)
        {
            Response res = new Response();
            _context.UserMsts.Add(model);
            _context.SaveChanges();
            res.status = true;
            res.message = "success";
            return Ok(res) ;
        }

    }
}
