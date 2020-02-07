using Microsoft.AspNetCore.Mvc;
namespace Razor.Controllers     //be sure to use your own project's namespace!
{
    public class RazorController : Controller   //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet("")]       //type of request
                            //associated route string (exclude the leading /)
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet("users/{username}")]
        public string HelloUser(string username, string food)
        {
            if (food == "Clams Casino") ;
            return $"Hello {username}";
        }

    }
}