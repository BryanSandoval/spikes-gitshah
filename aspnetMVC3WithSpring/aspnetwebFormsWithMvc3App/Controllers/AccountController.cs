using System.Web.Mvc;

namespace aspnetwebFormsWithMvc3App.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}