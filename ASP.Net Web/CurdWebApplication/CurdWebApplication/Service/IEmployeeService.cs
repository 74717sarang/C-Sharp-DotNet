using Crud.Models;

namespace Crud.Service
{
    public interface IEmployeeService

    {
        List<Employee> GetAll();

        Employee GetById(int id);

        void add(Employee employee);

        List<Employee> sort();

        public void delete(int id);

        Employee update(int id, Employee employee);



    }
}
