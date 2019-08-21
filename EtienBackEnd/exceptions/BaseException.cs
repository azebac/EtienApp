using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptions
{
    public class BaseException: ApplicationException
    {
        public virtual string ErrorCode { get; }
        public virtual string InnerMessage { get; }
        public virtual Exception Exception { get; }

        public BaseException(string errorCode, string innerMessage, Exception exception)
        {
            ErrorCode = errorCode;
            InnerMessage = innerMessage;
            Exception = exception;
        }
    }
}
