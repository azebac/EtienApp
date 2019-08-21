using System;

namespace exceptions
{
    public class UsernameNotFoundException:BaseException
    {
        public UsernameNotFoundException(string errorCode, string innerMessage, Exception exception) : base(errorCode, innerMessage, exception)
        {
        }
    }
}