namespace Users.Registration.Domain.Entities.Frameworks
{
    public class Result
    {
        public virtual ResultCodes Code { get; set; }
        public virtual string Message { get; set; }
    }

    public class Result<T> : Result
    {
        public virtual T Entity { get; set; }
    }
}