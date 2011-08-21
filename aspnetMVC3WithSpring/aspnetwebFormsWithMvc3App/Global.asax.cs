using Spring.Web.Mvc;

namespace aspnetwebFormsWithMvc3App
{
    /// <summary>
    /// Inheriting the Global class from SpringMvcApplicaiton instead of System.Web.HttpApplication.  
    /// This is required so that Spring registers the controller factory to instantiate the Controllers when the request comes.
    /// This is done so that Spring gets an opportunity to dependency inject the controllers.
    /// </summary>
    public class Global : SpringMvcApplication
    {
    }
}
