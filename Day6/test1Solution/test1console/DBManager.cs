using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace test1console
{

    internal class DBManager : IDBManager
    {

        private readonly CollectionContext context;

        public DBManager()
        {
            context = new CollectionContext();
        }


        void IDBManager.AddDepartment(department dept)
        {
            context.Add(dept);
           context.SaveChanges();      
        }



        void IDBManager.DeleteDepartment(int id)
        {
            var dept = context.Departments.FirstOrDefault(d => 1==id);

            context.Departments.Remove(dept);

        }

        List<department> IDBManager.GetAllDepartments()
        {
          return   context.Departments.ToList();

        }

        department IDBManager.GetDepartment(int id)
        {

            return context.Departments.FirstOrDefault(id);  
        }

        void IDBManager.UpdateDepartment(department dept)
        {
            var dep = context.Departments.FirstOrDefault(dept);

        }
    }
}
