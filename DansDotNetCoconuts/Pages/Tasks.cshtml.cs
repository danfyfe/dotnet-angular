using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class TasksModel : PageModel
    {
        private readonly ILogger<TasksModel> _logger;
        // public Tasks tasks;
        // public TaskList Tasks { get; set; }
        public TasksModel(ILogger<TasksModel> logger)
        {
            // additional services can be added here, since it is the constructor
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
