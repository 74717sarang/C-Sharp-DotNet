using Crud.Models;
using Microsoft.AspNetCore.Connections;

namespace Crud.Connection
{
    public class DBManager : IDBManager
    {
        void IDBManager.add(Employee employee)
        {
            using (var context = new CollectionContext())
            {

                context.Employees.Add(employee);
                context.SaveChanges();

            }
        }

        void IDBManager.delete(int id)
        {
           
            using (var context = new CollectionContext())
            {
                context.Employees.Remove(context.Employees.Find(id));
                context.SaveChanges() ; 

            }

        }

        List<Employee> IDBManager.GetAll()
        {
            using (var context = new CollectionContext())
            {

                var student = from S in context.Employees select S;
                return student.ToList();

            }
        }

        Employee IDBManager.GetById(int id)
        {
            using (var context = new CollectionContext())
            {

                var e = context.Employees.Find(id);
                return e;

            }
        }

        List<Employee> IDBManager.sort()
        {
            throw new NotImplementedException();
        }

        Employee IDBManager.update(Employee employee)
        {
      
            using (var context = new CollectionContext())
            {
                //var employees = context.Employees.Find(employee.Id);
                var employees = context.Employees.FirstOrDefault(e => e.Id == employee.Id);

                if (employees == null)
                {
                    // Handle missing record
                    throw new Exception($"Employee with ID {employee.Id} not found.");
                }

                employees.Name = employee.Name;
                employees.Role = employee.Role;
                employees.Designation = employee.Designation;
                context.SaveChanges();
                return employees;

            }
        }
    }
}
