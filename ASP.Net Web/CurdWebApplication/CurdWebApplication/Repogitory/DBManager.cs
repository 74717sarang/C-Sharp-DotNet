using CurdWebApplication.Connection;
using CurdWebApplication.EmpDTO;
using CurdWebApplication.Exception;
using CurdWebApplication.Models;
using Microsoft.AspNetCore.Connections;
using Microsoft.EntityFrameworkCore;

namespace CurdWebApplication.Connection
{
    public class DBManager : IDBManager
    {


        private readonly CollectionContext _context;

        //public DBManager()
        //{
        //}

        public DBManager(CollectionContext context)
        {
            _context = context;
        }
        void IDBManager.add(Employee employee)
        {
            

                _context.Employees.Add(employee);
                _context.SaveChanges();

            
        }

        void IDBManager.delete(int id)
        {
            if (id == 0) { 
            throw new EmployeeException("Id can not be Zero .....");
}

            //var emp = _context.Employees.Where(e => e.Id == id);
            var emp = _context.Employees.FirstOrDefault(x => x.Id == id);   
            //var emp= _context.Employees.Find( id);

            if (emp == null) {
                throw new EmployeeException($"Employee with Id {id} not found.");
            }
            _context.Employees.Remove(_context.Employees.Find(id));

            _context.SaveChanges() ;             

        }

        List<Employee> IDBManager.GetAll()
        {
          
                var student = from S in _context.Employees select S;
            if (student == null)
            {
                throw new EmployeeException("Employees not found in Table.");
            }

            return student.ToList();

            
        }

        Employee IDBManager.GetById(int id)
        {
                //int i=(int)id;

                if(id==0) throw new  EmployeeException ("id can not be Zero");

                var e = _context.Employees.Find(id);
            if (e == null)
            {
                throw new EmployeeException($"Employee with Id {id} not found.");
            }
            return e;

            
        }

        List<Employee> IDBManager.sort()
        {
                var student = from S in _context.Employees
                              orderby S.Name
                              select S;
                if (student.Count() == 0) {
                    throw new EmployeeException("Empty list ........");
                }
                return student.ToList();
        }



        Employee IDBManager.update(int id, EmployeeUpdateDto employee)
        {
            
                var existingEmployee = _context.Employees.FirstOrDefault(e => e.Id == id);

                if (existingEmployee == null)
                    throw new EmployeeException($"Employee with ID {id} not found.");

                existingEmployee.Name = employee.Name ?? existingEmployee.Name;
                existingEmployee.Role = employee.Role ?? existingEmployee.Role;
                existingEmployee.Designation = employee.Designation ?? existingEmployee.Designation;

                _context.SaveChanges();
                return existingEmployee;
            
        }

        Employee IDBManager.updateName(int id, string  name)
        {

              var employee = _context.Employees.Find(id);
                //var employees = context.Employees.FirstOrDefault(e => e.id == id);

                if (employee == null)
                {
                    // Handle missing record
                    throw new EmployeeException($"Employee with ID {id} not found.");
                }

                employee.Name = name;

                _context.SaveChanges();
                return employee;

            
        }
    }
}
