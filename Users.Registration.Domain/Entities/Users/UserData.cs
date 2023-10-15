namespace Users.Registration.Domain.Entities.Users
{
    public class UserData
    {
        public virtual long Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string MiddleName { get; set; }
        public virtual byte Age { get; set; }
    }
}