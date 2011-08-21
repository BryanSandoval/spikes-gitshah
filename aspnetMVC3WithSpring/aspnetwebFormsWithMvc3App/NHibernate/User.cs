namespace aspnetwebFormsWithMvc3App.NHibernate
{
    /// <summary>
    /// The user class that will map to the Users table.  We are only mapping the ID which is the primary key in the database.
    /// We are not mapping any other properties since right now we dont need them.
    /// </summary>
    public class User
    {
        public virtual long ID { get; set; }
    }
}