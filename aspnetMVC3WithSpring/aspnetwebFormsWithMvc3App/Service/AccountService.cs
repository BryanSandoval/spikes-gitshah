using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction;
using Spring.Transaction.Interceptor;
using aspnetwebFormsWithMvc3App.NHibernate;

namespace aspnetwebFormsWithMvc3App.Service
{
    /// <summary>
    /// The AccountService implementation.
    /// </summary>
    public class AccountService : IAccountService
    {
        /// <summary>
        /// The Session factory reference that will be injected by spring.net
        /// </summary>
        public ISessionFactory SessionFactory { get; set; }

        /// <summary>
        /// From the SessionFactory we are now getting the CurrentSession and adding the criteria over the User class.  
        /// We are projecting the row count this will return us the total number of rows in the user table.
        /// </summary>
        /// <returns>The long value representing the user count.</returns>
        [Transaction(TransactionPropagation.Required)]
        public long UserCount()
        {
            return SessionFactory
                .GetCurrentSession()
                .CreateCriteria<User>()
                .SetProjection(Projections.RowCountInt64())
                .UniqueResult<long>();
        }
    }
}