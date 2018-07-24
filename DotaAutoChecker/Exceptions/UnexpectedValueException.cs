namespace DotaAutoChecker.Exceptions
{
    public class UnexpectedValueException : ExtendException
    {
        public UnexpectedValueException() : base(ExceptionType.UnexpectedValueException) { }
    }
}
