using HelpDeskManagement.Models;
using HelpDeskManagement.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace HelpDeskManagement.Controllers
{
    public class LoginController : Controller
    {

        private readonly HelpDeskDBContext _context;

        public LoginController(HelpDeskDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }


        //[HttpPost]

        //public async Task<ActionResult<UserMst>> validateUser([FromBody] UserMst obj)
        //{
        //    Response res = new Response();
        //    var user = await _context.UserMsts.FindAsync(obj.Email);
        //    if (user == null)
        //    {
        //        return BadRequest("user not exist");
        //    }

        //    if (user.Passwrod != obj.Passwrod)
        //    {
        //        return BadRequest("Password is wrong");
        //    }

        //    return Ok("you are logged in");
        //}

        [HttpPost]

        public ActionResult validateUser([FromBody] UserMst obj)
        {
            Response res = new Response();
            //var user = _context.UserMsts.Find(obj.Email);
            var user = _context.UserMsts.SingleOrDefault(a => a.Email == obj.Email);
            if (user == null)
            {
                res.status = false;
                res.message = "user not found";
                return Ok(res);
            }

            if (user.Passwrod != obj.Passwrod)
            {
                res.status = false;
                res.message = "password in wrong";
                return Ok(res);
            }

            res.status = true;
            res.message = "success";
            return Ok(res);
        }
    }
}
