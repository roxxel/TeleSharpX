using System;
using System.Runtime.Serialization;

namespace TeleSharpX
{
    public class ApiException : Exception
    {
        public int ErrorCode { get; }

        public ApiException()
        {
        }

        protected ApiException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public ApiException(string message, int errorCode) : base(message)
        {
            ErrorCode = errorCode;
        }

        public ApiException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}