using FluentNHibernate.Mapping;

namespace aspnetwebFormsWithMvc3App.NHibernate.Mappings
{
    /// <summary>
    /// The class that will hold the mappings for the Users table.  
    /// </summary>
    public class UserMap : ClassMap<User>
    {
        /// <summary>
        /// The Default constructor that will hold the fluent NHibernate mappings.  We have to specify the table name used to map the User class
        /// And we have to specify the Id column, in our case its the ID property which maps to the user_id column in the database.
        /// </summary>
        public UserMap()
        {
            Table("inetuser");
            Id(x => x.ID, "user_pkey");
        }
    }
}