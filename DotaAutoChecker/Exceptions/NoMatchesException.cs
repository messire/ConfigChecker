namespace DotaAutoChecker.Exceptions
{
    public class NoMatchesException : ExtendException
    {
        public NoMatchesException() : base(ExceptionType.NoMatchesException) { }
    }
}
