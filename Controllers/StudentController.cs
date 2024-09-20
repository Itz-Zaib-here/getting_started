using Microsoft.AspNetCore.Mvc;

namespace getting_started.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudentBio()
        {
            return View();
        }
    }
}
