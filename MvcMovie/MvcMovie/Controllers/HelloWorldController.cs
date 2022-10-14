using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;

        /*
         * Okay, so the way it seems to work is that it associates the Controller name with the View name. Since this action in the controller
         * is labeled as Welcome, when the code compiles, it searches for the associated View within /Views/ or /Views/HelloWorld.
         * This controller is named HelloWorldController, which is required for it to link to its folder in Views. The naming conventions are important
         * and standardized.
         */

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello, " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
