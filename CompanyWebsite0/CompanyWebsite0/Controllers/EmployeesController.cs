using Microsoft.AspNetCore.Mvc;

namespace CompanyWebsite0.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
