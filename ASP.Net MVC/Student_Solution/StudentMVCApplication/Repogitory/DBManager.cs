using StudentMVCApplication.Models;

namespace StudentMVCApplication.Repogitory
{
    public class DBManager : IDBManager
    {
        void IDBManager.add(Student student)
        {

            
        }

        void IDBManager.delete(int id)
        {
            throw new NotImplementedException();
        }

        List<Student> IDBManager.GetAll()
        {
            //using (var context = new CollectionContext()) {
            //    var list = from s in context.

            //return list.T
            //    }
            using (var context = new CollectionContext())
            {

                var student = from S in context.students select S;
                return student.ToList();

            }
        }

        Student IDBManager.GetById(int id)
        {
            throw new NotImplementedException();
        }

        List<Student> IDBManager.sort()
        {
            throw new NotImplementedException();
        }

        Student IDBManager.update(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
