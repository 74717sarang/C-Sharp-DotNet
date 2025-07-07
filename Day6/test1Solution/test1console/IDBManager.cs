using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1console
{
    internal interface IDBManager
    {
        void AddDepartment(department dept);
        department GetDepartment(int id);
        List<department> GetAllDepartments();
        void UpdateDepartment(department dept);
        void DeleteDepartment(int id);
    }
}
