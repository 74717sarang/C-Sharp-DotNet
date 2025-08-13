using Crud.Connection;
using Crud.Models;

namespace Crud.Service
{
    public class EmployeeService : IEmployeeService
    {
        IDBManager dBManager = new DBManager();
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

        Employee IEmployeeService.update(int id,Employee employee)
        {
             return dBManager.update(id,employee);
        }
    }
}
