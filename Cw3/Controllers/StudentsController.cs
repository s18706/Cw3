using Microsoft.AspNetCore.Mvc;

namespace Cw3.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}