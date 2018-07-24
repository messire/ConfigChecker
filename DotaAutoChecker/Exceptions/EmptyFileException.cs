namespace DotaAutoChecker.Exceptions
{
    public class EmptyFileException : ExtendException
    {
        public EmptyFileException() : base(ExceptionType.EmptyFileException) { }
    }
}
