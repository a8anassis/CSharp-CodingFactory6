using WebStarter6DBApp.DTO;

namespace WebStarter6DBApp.Services
{
    public interface IStudentService
    {
        StudentReadOnlyDTO? InsertStudent(StudentInsertDTO studentInsertDTO);
        void UpdateStudent(StudentUpdateDTO studentUpdateDTO);
        void DeleteStudent(int id);
        StudentReadOnlyDTO GetStudent(int id);
        List<StudentReadOnlyDTO> GetAllStudents();
    }
}
