using Microsoft.AspNetCore.Mvc;
namespace Portfolio_Project
{
    public class HomeController : Controller
    {
        // Request
        // localhost:5000/
        [HttpGet("")]

        public string IndexFromController()
        {
            return "This is my Index!";
        }

        // localhost:5000/projects
        [HttpGet("projects")]

        public string ProjectsFromController()
        {
            return "These are my projects!";
        }

        // localhost:5000/contact
        [HttpGet("contact")]

        public string ContactFromController()
        {
            return "This is my Contact!";
        }
    }

}