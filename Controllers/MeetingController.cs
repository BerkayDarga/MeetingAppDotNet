using MeetingAppDotNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingAppDotNet.Controllers
{
    public class MeetingController : Controller
    {
        // [HttpGet]
        // public IActionResult Index()
        // {
        //     return View();
        // }
        [HttpGet]

        public IActionResult Apply()
        {
            return View();
        }
        [HttpPost]
        // public IActionResult Apply(string Name, string Phone, string Email, bool WillAttend)
        public IActionResult Apply(UserInfo model)

        {
            Repository.CreateUser(model);
            ViewBag.UserCount = Repository.Users.Where(info => info.WillAttend == true).Count();
            return View("Thanks", model);
            // Console.WriteLine(Name);
            // Console.WriteLine(Phone);

        }
        [HttpGet]

        public IActionResult List()
        {
            return View(Repository.Users);
        }
    }
}