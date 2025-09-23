using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebStarter6DBApp.DTO;
using WebStarter6DBApp.Models;
using WebStarter6DBApp.Services;

namespace WebStarter6DBApp.Pages.Students
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public StudentInsertDTO StudentInsertDTO { get; set; } = new();

        public List<Error> ErrorArray { get; set; } = [];

        private readonly IStudentService _studentService;

        public CreateModel(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public void OnGet()
        {
            // return Page();
        }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }

            try
            {
                StudentReadOnlyDTO? studentReadOnlyDTO = _studentService.InsertStudent(StudentInsertDTO);
                Response.Redirect("/Students/getall");
                //return RedirectToPage("/Students/getall");
            }
            catch (Exception ex)
            {
                ErrorArray.Add(new Error("", ex.Message, ""));
                return;
            }
        }
    }
}
