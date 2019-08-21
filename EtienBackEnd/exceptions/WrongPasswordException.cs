using System;

namespace exceptions
{
    public class WrongPasswordException:BaseException
    {
        public WrongPasswordException(string errorCode, string innerMessage, Exception exception) : base(errorCode, innerMessage, exception)
        {
        }
    }
}