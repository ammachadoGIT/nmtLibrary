using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace nmtLibrary.Controllers
{
    [Authorize]
    public class WritersController : Controller
    {
        // GET: Writers
        public ActionResult Index()
        {
            return View();
        }
    }
}
