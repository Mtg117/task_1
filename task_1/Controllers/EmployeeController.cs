using Microsoft.AspNetCore.Mvc;
using task_1.Data;

namespace task_1.Controllers
{
    public class EmployeeController : Controller
    {
        ApplicationDbContext Context=new ApplicationDbContext();
        public IActionResult Index()
        {
            var employees=Context.employees.ToList();
            return View("Index", employees);
        }
    }
}
