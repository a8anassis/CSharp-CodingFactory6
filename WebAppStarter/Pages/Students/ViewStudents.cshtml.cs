using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppStarter.DTO;
using WebAppStarter.Models;

namespace WebAppStarter.Pages.Students
{
    public class ViewStudentsModel : PageModel
    {
        public List<StudentReadOnlyDTO> StudentsReadOnlyDTOs { get; set; } = [
            MapStudentToDTO(new Student { Id = 1, Firstname = "Anna", Lastname = "Giannou" }),
            MapStudentToDTO(new Student { Id = 1, Firstname = "Costas", Lastname = "Androutsos" }),
            MapStudentToDTO(new Student { Id = 1, Firstname = "Tasos", Lastname = "Fragos" })
        ]; 

        public void OnGet()
        {

        }

        private static StudentReadOnlyDTO MapStudentToDTO(Student student)
        {
            return new StudentReadOnlyDTO
            {
                Id = student.Id,
                Firstname = student.Firstname,
                Lastname = student.Lastname
            };
        }
    }
}
