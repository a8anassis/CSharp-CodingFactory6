using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebStarter6DBApp.Models;
using WebStarter6DBApp.Services;

namespace WebStarter6DBApp.Pages.Students
{
    public class DeleteModel : PageModel
    {
        public List<Error> ErrorArray { get; set; } = [];
        private readonly IStudentService _studentService;

        public DeleteModel(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public void OnGet(int id)
        {
            try
            {
                _studentService.DeleteStudent(id);
                Response.Redirect("/Students/getall");
            }
            catch (Exception ex)
            {
                ErrorArray.Add(new Error("", ex.Message, ""));
            }
        }
    }
}
