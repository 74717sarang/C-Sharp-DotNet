using CurdWebApplication.Models;
using CurdWebApplication.EmpDTO;

namespace CurdWebApplication.Connection
{
    public interface IDBManager
    {
        List<Employee> GetAll();

        Employee GetById(int id);

        void add(Employee employee);

        List<Employee> sort();

        public void delete(int id);

        Employee update(int id, EmployeeUpdateDto employee);

        Employee updateName(int id, string name);
    }
}
