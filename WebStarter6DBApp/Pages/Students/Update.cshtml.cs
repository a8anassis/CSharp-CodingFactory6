using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebStarter6DBApp.DTO;
using WebStarter6DBApp.Models;
using WebStarter6DBApp.Services;

namespace WebStarter6DBApp.Pages.Students
{
    public class UpdateModel : PageModel
    {
        [BindProperty]
        public StudentUpdateDTO StudentUpdateDTO { get; set; } = new();

        public List<Error> ErrorArray { get; set; } = [];

        private readonly IStudentService _studentService;

        public UpdateModel(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public IActionResult OnGet(int id)
        {
            try
            {
                StudentReadOnlyDTO? studentReadOnlyDTO = _studentService.GetStudent(id);
                StudentUpdateDTO = new StudentUpdateDTO()
                {
                    Id = studentReadOnlyDTO.Id,
                    Firstname = studentReadOnlyDTO.Firstname,
                    Lastname = studentReadOnlyDTO.Lastname,
                };
            }
            catch (Exception ex)
            {
                ErrorArray.Add(new Error("", ex.Message, ""));
            }
            return Page();

        }

        public void OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            try
            {
                StudentUpdateDTO.Id = id;
                _studentService.UpdateStudent(StudentUpdateDTO);
                Response.Redirect("/Students/getall");
            }
            catch (Exception e)
            {
                ErrorArray.Add(new Error("", e.Message, ""));
            }
        }
    }
}
