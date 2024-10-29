using MeetingAppDotNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingAppDotNet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            // ViewBag.Selamlama = saat > 12 ? "İyi Günler" : "Günaydın";
            // ViewBag.Userame = "Berkay";

            //viewdata ya key value şeklinde değer veriyoruz
            ViewData["Selamlama"] = saat > 12 ? "İyi Günler" : "Günaydın";
            // ViewData["UserName"] = "Berkay";

            int UserCount = Repository.Users.Where(info => info.WillAttend == true).Count();


            MeetingInfo meetingInfo1 = new MeetingInfo()
            {
                Id = 1,
                Location = "İstanbul ABC Kongre Merkezi",
                Date = new DateTime(2024, 01, 20, 20, 0, 0),
                NumberOfPeople = UserCount
            };
            return View(meetingInfo1);
        }
    }
}