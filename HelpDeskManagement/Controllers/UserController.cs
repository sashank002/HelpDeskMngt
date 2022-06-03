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
        
        public IActionResult saveUser([FromBody]UserMst model)
        {
                Response res = new Response();
                _context.UserMsts.Add(model);
                _context.SaveChanges();
                res.status = true;
                res.message = "success";
                return Ok(res);
            
            
        }

        [HttpPost]

        public async Task<ActionResult<UserMst>> validateUser([FromBody]UserMst obj)
        {
            Response res = new Response();
            var user = await _context.UserMsts.FindAsync(obj.Email);
            if(user == null)
            {
                return BadRequest("user not exist");
            }

            if(user.Passwrod != obj.Passwrod)
            {
                return BadRequest("Password is wrong");
            }

            return Ok("you are logged in");
        }



    }
}
