using WebStarter6DBApp.Models;

namespace WebStarter6DBApp.DAO
{
    public interface IStudentDAO
    {
        Student? Insert(Student student);
        void Update(Student student);
        void Delete(int id);
        Student? GetById(int id);
        List<Student> GetAll();
    }
}
