namespace DotaAutoChecker.Exceptions
{
    public static class ExceptionTypeConverter
    {
        private const string Unknown = "Unhandled exception";
        private const string EmptyFile = "";
        private const string NoMatches = "Nobody home!";
        private const string UnexpectedValue = "Unexpected index value! Repeat parameter!";

        public static string TypeToMessage(ExceptionType exceptionType)
        {
            switch (exceptionType)
            {
                case ExceptionType.EmptyFileException:
                    return EmptyFile;
                case ExceptionType.NoMatchesException:
                    return NoMatches;
                case ExceptionType.UnexpectedValueException:
                    return UnexpectedValue;
            }

            return Unknown;
        }
    }
}
