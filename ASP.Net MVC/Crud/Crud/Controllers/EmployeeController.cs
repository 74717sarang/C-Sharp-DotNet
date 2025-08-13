using Crud.Models;
using Crud.Service;
using Microsoft.AspNetCore.Mvc;
namespace Crud.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;


        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }


        public IActionResult add()
        {

            return View();
        }
        // add emp

        [HttpPost]
        public IActionResult add(int ID, string name, string designation, string role)
        {
            _employeeService.add(new Employee(ID, name, designation, role));

            return View();
        }



        [HttpGet]
        public IActionResult GetAll()
        {
            List<Employee> employees = _employeeService.GetAll();
            ViewData["getall"] = employees;
            Console.WriteLine(employees.Count);
            foreach (Employee employee in employees)
            {
                Console.WriteLine("ID: " + employee.Id + " " + "Name: " + employee.Name);
            }
            return View();
        }

        public IActionResult Delete()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            int a = (int)id;
            _employeeService.delete(a);
            return RedirectToAction("GetAll", "Employee");

        }


        public IActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Update(Employee employee)
        {
            
            _employeeService.update(employee);
            return RedirectToAction("GetAll");

        }
    }
}
