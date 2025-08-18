using Crud.Models;
using Crud.Service;
using Microsoft.AspNetCore.Mvc;

namespace CurdWebApplication.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class EmployeeController:ControllerBase
    {

        private readonly IEmployeeService employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        [HttpGet("/index")]
        public string Index()
        {
            return ("In Index");
        }


        [HttpGet("/getall")]
        public List<Employee> getAll()
        {
            return employeeService.GetAll();

        }

        [HttpPost("/add")]
        public void addEmp([FromBody] Employee emp)
        {
            employeeService.add(emp);
            Console.WriteLine("Added Done....");
        }


        [HttpPut("update/{id}")]
        public void updateEmp(int id,[FromBody] Employee emp) {


            int i = (int)id;
            employeeService.update(i,emp);
            Console.WriteLine("Update Done");  
        
        }



        [HttpDelete("{id}")]
        public void delete(int id)
        {
            int i = (int)id;
            employeeService.delete(i);
            Console.WriteLine("Delete Done");
        }


        [HttpGet("/sortByName")]
        public List<Employee> sortByName()
        {
            return employeeService.sort();

        }


    }
}
