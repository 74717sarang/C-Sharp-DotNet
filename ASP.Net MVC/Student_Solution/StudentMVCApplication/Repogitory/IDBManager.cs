using StudentMVCApplication.Models;

namespace StudentMVCApplication.Repogitory
{
    public interface IDBManager
    {
        List<Student> GetAll();

        Student GetById(int id);

        void add(Student student);

        List<Student> sort();

        public void delete(int id);

        Student update(Student student);
    }
}
