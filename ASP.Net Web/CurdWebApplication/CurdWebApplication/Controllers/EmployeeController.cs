using CurdWebApplication.Models;
using CurdWebApplication.Service;
using CurdWebApplication.EmpDTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using CurdWebApplication.Exception;


namespace CurdWebApplication.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class EmployeeController : ControllerBase
    {

        //public EmployeeController():base() { }

          public readonly ILogger<EmployeeController> _logger;

        private readonly IEmployeeService employeeService;

        public EmployeeController(IEmployeeService employeeService, ILogger<EmployeeController> logger)
        {
            this.employeeService = employeeService;
            _logger = logger;
        }

        [HttpGet("/index")]
        public string Index()
        {
            _logger.LogInformation("in Index Get Methode");
                

            return ("In Index");
        }


        [HttpGet("/getall")]
        //[Authorize(Roles ="admin")]
        [Authorize]
        public ActionResult<List<Employee>> getAll()
        {
            return Ok(employeeService.GetAll());
        }

        [HttpPost("/add")]
        public ActionResult addEmp([FromBody] Employee emp)
        {
            if (emp == null) {
                return BadRequest("data is Null /........");
            }
            employeeService.add(emp);
            Console.WriteLine("Added Done....");
            return Ok();
        }


        [HttpPut("update/{id}")]
        public ActionResult updateEmp(int id, [FromBody] EmployeeUpdateDto dto) {

            if (id != 0)
            {
                int i = (int)id;
                employeeService.update(i, dto);
                Console.WriteLine("Update Done");
                return Ok();
            }
            return BadRequest("Id InCorrect");
        }



        [HttpDelete("/delete/{id}")]
        public ActionResult delete(int id)
        {
            if (id <= 0)
                return BadRequest("Invalid ID");
            int i = (int)id;
            employeeService.delete(i);
            Console.WriteLine("Delete Done");
            return Ok("Delete Done");
        }


        [HttpGet("/sortByName")]
        public ActionResult<List<Employee>> SortByName()
        {
            var employees = employeeService.sort();

            if (employees == null)
                return NotFound("No employees found");

            return Ok(employees);
        }




        //[HttpGet("/getByID/{id}")]
        //public Employee getByID(int id)
        //{
        //    return employeeService.GetById(id);

        //}


        [HttpGet("/getByID/{id}")]
        public ActionResult<Employee> GetByID(int id)
        {
            if (id != 0)
            {
                var employee = employeeService.GetById(id);

                if (employee == null)
                    return NotFound();

                return Ok(employee);
            }
            //_logger.LogError(new EmployeeException());
            return BadRequest("Invalid ID");
        }

        [HttpPatch("updateNameById/{id}/{name}")]
        public ActionResult<EmployeeUpdateDto> updateEmpName(int id, string name)
        {

            if (id != 0 && name != null)
            {
                int i = (int)id;
                return Ok(employeeService.updateName(id, name));


                //using (var context = new CollectionContext()) {
                //    var employee = employeeService.GetById(id);
                //    if (employee != null) {
                //        employee.Name = name;
                //        context.SaveChanges();  
                //    }
                Console.WriteLine("Name Update Done");
                return Ok();
            }
        
            return BadRequest("Id InCorrect");
    }

    }

    
}
