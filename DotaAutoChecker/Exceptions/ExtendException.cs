using System;

namespace DotaAutoChecker.Exceptions
{
    public class ExtendException: Exception
    {
        protected ExtendException(ExceptionType exceptionType) : base(ExceptionTypeConverter.TypeToMessage(exceptionType)) { }
    }
}
