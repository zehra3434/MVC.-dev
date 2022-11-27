using Microsoft.AspNetCore.Mvc;
using MVC.SQLite3.EF.DAL.Abstract;

namespace MVC.SQLite3.EF.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeDal _employeeDal;

        public EmployeeController(IEmployeeDal employeeDal)
        {
            this._employeeDal = new EfEmployee();
        }

        public IActionResult Index()
        {
            var model = _employeeDal.GetAll();
            return View(model
        );
        }
    }
}
