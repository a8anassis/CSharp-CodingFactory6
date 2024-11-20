using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;

namespace WebApp6Starter.Pages
{
    public class IndexModel : PageModel
    {
        public string? CurrentDay { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            CurrentDay = DateTime.UtcNow.ToString("dddd", CultureInfo.InvariantCulture);
            // return Page();
        }
    }
}
