namespace aspnetwebFormsWithMvc3App.Service
{
    /// <summary>
    /// The Interface of the AccountService.
    /// </summary>
    public interface IAccountService
    {
        /// <summary>
        /// This method should return the total user count in the system.
        /// </summary>
        /// <returns>Long value representing the user cont.</returns>
        long UserCount();
    }
}