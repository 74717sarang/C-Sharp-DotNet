using CurdWebApplication.Connection;
using CurdWebApplication.Models;
using CurdWebApplication.EmpDTO;

namespace CurdWebApplication.Service
{
    public class EmployeeService : IEmployeeService
    {
        //IDBManager dBManager = new DBManager();

        private readonly IDBManager dBManager;

        public EmployeeService(IDBManager _dBManager)
        {
            dBManager = _dBManager;
        }
        public Employee updateName(int id, string name)
        {
           return  dBManager .updateName(id, name); 
        }

        void IEmployeeService.add(Employee employee)
        {
            dBManager.add(employee);
        }

        void IEmployeeService.delete(int id)
        {

            dBManager.delete(id);
        }

        List<Employee> IEmployeeService.GetAll()
        {
           return  dBManager.GetAll();
        }

        Employee IEmployeeService.GetById(int id)
        {
            return dBManager.GetById(id);   
        }

        List<Employee> IEmployeeService.sort()
        {
            return dBManager.sort();
        }

        Employee IEmployeeService.update(int id, EmployeeUpdateDto employee)
        {
             return dBManager.update(id,employee);
        }
    }
}
