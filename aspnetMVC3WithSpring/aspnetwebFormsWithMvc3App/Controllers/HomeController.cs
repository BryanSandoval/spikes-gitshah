using System.Web.Mvc;
using AnotherProject;
using aspnetwebFormsWithMvc3App.Context;
using Spring.Transaction;
using Spring.Transaction.Interceptor;
using aspnetwebFormsWithMvc3App.Service;

namespace aspnetwebFormsWithMvc3App.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Reference of the Account service.  This will be injected by the Dependency Injection framework, in our case Spring.NET.
        /// Notice that nowhere we are creating an instance of AccountService.  Before the request is processed by the Action method
        /// This Object will be injected by Spring.NET for us.
        /// </summary>
        public IAccountService AccountService { get; set; }

        /// <summary>
        /// The UserContext Reference this object is a spring object which will be singleton across one user session.  This means
        /// each user session will have a different instance of UserContext injected in them.
        /// </summary>
        public IUserContext UserContext { get; set; }

        /// <summary>
        /// The method is used to render the aspx view called Index.aspx.
        /// This method also sets the UserName property in the ViewBag.
        /// </summary>
        /// <returns>ActionResult instance to render the aspx view</returns>
        public ActionResult Index()
        {
            ViewBag.UserName = "Git Shah";
            return View();
        }

        /// <summary>
        /// The method that is used to render the Razor view called RazorIndex.cshtml.
        /// This method also sets the UserName property in the ViewBag.
        /// </summary>
        /// <returns>ActionResult instance to render the razor view</returns>
        public ActionResult RazorIndex()
        {
            ViewBag.UserName = "Git Shah";
            return View();
        }

        /// <summary>
        /// This method interacted with the Dependency AccountService and populates the UserCount in the ViewBag.  This will eventually be shown on the UI.
        /// </summary>
        /// <returns>The ActionResult instance to render the SpringIndex.cshtml view.</returns>
        public ActionResult SpringIndex()
        {
            ViewBag.TotalUsers = AccountService.UserCount();
            return View();
        }        

        public ActionResult UserInfo1()
        {
            ViewBag.UserName = UserContext.UserName;
            return View("RazorIndex");           
        }

        public ActionResult UserInfo2()
        {
            ViewBag.UserName = UserContext.UserName;
            return View("RazorIndex");           
        }

        public ActionResult Login(FormCollection formCollection)
        {
            Session["UserName"] = formCollection["UserName"];
            return View();
        }

        public ActionResult UpdateUser(string userName)
        {
            Session["UserName"] = userName;
            return View();            
        }
    }
}