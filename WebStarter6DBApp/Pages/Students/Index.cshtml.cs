using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebStarter6DBApp.DTO;
using WebStarter6DBApp.Models;
using WebStarter6DBApp.Services;

namespace WebStarter6DBApp.Pages.Students
{
    public class IndexModel : PageModel
    {
        public List<StudentReadOnlyDTO> StudentsReadOnlyDTO { get; set; } = [];
        public Error ErrorObj { get; set; } = new();

        private readonly IStudentService _studentService;

        public IndexModel(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public IActionResult OnGet()
        {
            try
            {
                ErrorObj = new();
                StudentsReadOnlyDTO = _studentService.GetAllStudents();
            }
            catch (Exception ex)
            {
                ErrorObj = new Error("",ex.Message, "");
            }
            return Page();
        }
    }
}
