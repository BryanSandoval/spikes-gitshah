namespace aspnetwebFormsWithMvc3App.Context
{
    /// <summary>
    /// The UserContext interface which has two simple methods to set and get the UserName.
    /// </summary>
    public interface IUserContext
    {
        /// <summary>
        /// The method that will set the userName into the UserName property.
        /// </summary>
        /// <param name="userName">The user name to set.</param>
        void SetUserName(string userName);

        /// <summary>
        /// The readonly property to get the UserName held by the UserContext.
        /// </summary>
        string UserName { get; }
    }

    /// <summary>
    /// The implementation of the UserContext interface.
    /// </summary>
    public class UserContext : IUserContext
    {
        /// <summary>
        /// This method does nothing just sets the UserName property with the value passed in.
        /// Although we could have exposed the UserName properties setter as a public setter but
        /// I preffer to expose it as a method.  In real life this method will set more properties than just the UserName
        /// </summary>
        /// <param name="userName">The User name to set.</param>
        public void SetUserName(string userName)
        {
            UserName = userName;
        }

        /// <summary>
        /// The auto property for the UserName.  Exposing the getter only.
        /// </summary>
        public string UserName { get; private set; }
    }
}