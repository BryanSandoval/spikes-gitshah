using System.Web.Mvc;
using aspnetwebFormsWithMvc3App.Context;

namespace aspnetwebFormsWithMvc3App.Controllers
{
    /// <summary>
    /// The Login controller will have simple methods to set the UserName in the UserContext and then show the UserInfo on the page.
    /// </summary>
    public class LoginController : Controller
    {
        /// <summary>
        /// The UserContext Reference this object is a spring object which will be singleton across one user session.  This means
        /// each user session will have a different instance of UserContext injected in them.
        /// </summary>
        public IUserContext UserContext { get; set; }

        /// <summary>
        /// This Action method will set the User name as Git Shah with a sessionID added to it.  
        /// This is done to show that when, requests are sent via two different threads i.e. two different browser windows unique session ids would be generated
        /// and unique UserNames will be set in UserContext object.
        /// </summary>
        /// <returns>Redirects the user to UserInfo action.</returns>
        public ActionResult Login()
        {
            UserContext.SetUserName("Git Shah With SessionID: " + Session.SessionID);
            return RedirectToAction("UserInfo");
        }

        /// <summary>
        /// This guy does simply gets the UserName property from the UserContext and sets it in the ViewBag.  
        /// It then renders the RazorIndex view.
        /// </summary>
        /// <returns>View called RazorIndex.  Which will show the user name on the page.</returns>
        public ActionResult UserInfo()
        {
            ViewBag.UserName = UserContext.UserName;
            return View("RazorIndex");
        }
    }
}